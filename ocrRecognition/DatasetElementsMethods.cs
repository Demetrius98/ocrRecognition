using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace ocrRecognition
{
    abstract class DatasetElementsMethods
    {
        //Count charater elements for displaying in one string
        public const byte countCharaterElementsInOneString = 4;

        //Initialization of ComboBoxs
        public static void InitializeComboBox(ComboBox comboBoxObj)
        {
            comboBoxObj.DataSource = Enum.GetValues(typeof(DatasetImageElements.Charater))
                                                  .Cast<DatasetImageElements.Charater>()
                                                  .Select(p => new { Name = Enum.GetName(typeof(DatasetImageElements.Charater), p), Value = (int)p })
                                                  .ToList();
            comboBoxObj.DisplayMember = "Name";
            comboBoxObj.ValueMember = "Name";
            comboBoxObj.SelectedValue = DatasetImageElements.Charater.unset.ToString();
        }

        // Method for updating ListboxMain after adding and deleting files
        public static void updateListBoxMain(ListBox listBoxObj, HashSet<DatasetElements> hashSetObj, Label labelObj)
        {

            int selectedListboxItem = listBoxObj.SelectedIndex;

            listBoxObj.Items.Clear();
            foreach (var item in hashSetObj)
            {
                //If Item in ListBoxImage are unset now
                if (item.GetTypeset().Equals(DatasetElements.TypeDataset.unset))
                {
                    listBoxObj.Items.Add(item.GetFilename());
                }
            }

            //Selecting of item in listBoxImages
            if (listBoxObj.Items.Count > 0)
            {
                if (selectedListboxItem > 0)
                {
                    selectedListboxItem = selectedListboxItem - 1;
                }
                else
                {
                    selectedListboxItem = 0;
                }
                listBoxObj.SetSelected(selectedListboxItem, true);
            }

            labelObj.Text = "You have added " + hashSetObj.Count + " files";

        }

        //Method for updating Train or Test ListBox
        public static void updateListBoxTrainTest(ListBox listBoxObj, HashSet<DatasetImageElements> hashSetobj, Label labelObj)
        {

            int selectedListboxItem = listBoxObj.SelectedIndex;

            listBoxObj.Items.Clear();
            foreach (var item in hashSetobj)
            {
                listBoxObj.Items.Add(item.GetShortFilename());
            }

            //Selecting of item in listBoxImages
            if (listBoxObj.Items.Count > 0 && selectedListboxItem < 0)
            {
                selectedListboxItem = 0;
                listBoxObj.SetSelected(selectedListboxItem, true);
            }

            //Updating information (count of elements) in Label
            labelObj.Text = hashSetobj.Count() + " elements";
        }

        public static Boolean setTrainTestElements(String selectedItem, HashSet<DatasetElements> mainDataset, HashSet<DatasetImageElements> trainTestDataset, DatasetElements.TypeDataset typeset)
        {
            //Trying to access at element and updating HashSets
            try
            {
                var itemBase = mainDataset.Single(x => x.GetFilename().Equals(selectedItem));

                DatasetImageElements item = new DatasetImageElements(itemBase);
                item.SetTypeset(typeset);
                //setting charater
                item.SetCharater(DatasetImageElements.Charater.unset);
                //setting Image vector of pixel code
                

                //Updating information in imageDataset HashSet
                mainDataset.Remove(itemBase);
                itemBase.SetTypeset(typeset);
                mainDataset.Add(itemBase);

                //Adding element in train dataset of images
                trainTestDataset.Add(item);
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public static Boolean delTrainTestElements(int selectedItem, HashSet<DatasetElements> mainDataset, HashSet<DatasetImageElements> trainTestDataset)
        {
            //trying to access at element and updating item in HashSets
            try
            {
                //Accsess to train test HashSet at element
                var item = trainTestDataset.ElementAt(selectedItem);

                //Remove from trainTest dataset
                trainTestDataset.Remove(item);

                //try search in mainDataset
                var itemBase = mainDataset.Single(x => x.GetFilename().Equals(item.GetFilename()));

                //Remove and Delete from mainDataset
                mainDataset.Remove(itemBase);
                itemBase.SetTypeset(DatasetElements.TypeDataset.unset);
                mainDataset.Add(itemBase);
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        //Setting Charater in train test dataset
        public static Boolean setCharaterInTrainTestDataset(int selectedIndexItem, DatasetImageElements.Charater selectedCharater, HashSet<DatasetImageElements> hashSetObj)
        {
            //Updating in Train Test HashSet
            try
            {
                var selectedItem = hashSetObj.ElementAt(selectedIndexItem);
                hashSetObj.Remove(selectedItem);
                selectedItem.SetCharater(selectedCharater);
                hashSetObj.Add(selectedItem);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        
        //setting configuration of SaveDialog
        public static void configSaveDialog(SaveFileDialog saveFileDialogObj) 
        {
            saveFileDialogObj.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //saveFileDialogObj.FilterIndex = 2;
            saveFileDialogObj.RestoreDirectory = true;
        }

        //Counting the charaters and adding information at label component
        public static Boolean countCharaters(HashSet<DatasetImageElements> datasetTrainTest, Label labelObj) 
        {
            try
            {
                //Grouping items by Charaters 
                var groupByCharaters = datasetTrainTest.GroupBy(x => x.GetCharater()).OrderBy(x => x.Key);
                labelObj.Text = "Count: ";
                int i = 0;
                foreach (var groupItem in groupByCharaters)
                {
                    if (i % countCharaterElementsInOneString == 0 && i != 0)
                    {
                        labelObj.Text += Environment.NewLine;
                    }
                    labelObj.Text += groupItem.Key.ToString() + ": " + groupItem.Count() + ",  ";
                    i++;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            
            return true;
        }

        public static Boolean isImageSizeOk (String filename) 
        {
            try
            {
                Image loadedImage = Image.FromFile(filename);
                if ((loadedImage.Height == DatasetImageElements.ImageHeightConst) &&
                                (loadedImage.Width == DatasetImageElements.ImageWidthConst))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static Boolean isImageNoErrors(String filename) 
        {
            try
            {
                Image loadedImage = Image.FromFile(filename);
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public static Boolean loadImageInPictureBox(String filename, PictureBox pictureBoxObj) 
        {
            pictureBoxObj.Image?.Dispose();
            try
            {
                Image loadedImage = Image.FromFile(filename);
                Size sizeImage = new Size(DatasetImageElements.ImageWidthConst * DatasetImageElements.ImageZoomConst,
                    DatasetImageElements.ImageHeightConst * DatasetImageElements.ImageZoomConst);
                pictureBoxObj.Image = new Bitmap(loadedImage, sizeImage);
                loadedImage?.Dispose();
            }
            catch (Exception e)
            {
                return false; 
            }

            return true;
        }

        //Clearing PictureBox
        public static void clearPictureBox(PictureBox pictureBoxObj)
        {
            pictureBoxObj.Image?.Dispose();
            pictureBoxObj.Image = null;
        }

        //Check correct count of charaters for making datasets  
        public static Boolean isCountCharaterOk(HashSet<DatasetImageElements> hashSetTrain, HashSet<DatasetImageElements> hashSetTest) 
        {
            var selectedTrainCharater = hashSetTrain.GroupBy(item => item.GetCharater()).OrderBy(x => x.Key);
            var selectedTestCharater = hashSetTest.GroupBy(item => item.GetCharater()).OrderBy(x => x.Key);

            if (selectedTrainCharater.Count() == selectedTestCharater.Count())
            {
                int countOfItems = selectedTrainCharater.Count();
                for (int i = 0; i < countOfItems; i++ )
                {
                    if (!selectedTrainCharater.ElementAt(i).Key.Equals(selectedTestCharater.ElementAt(i).Key)) 
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        //Checking: are there unset elements in Hashset
        public static Boolean isUnsetElements(HashSet<DatasetImageElements> hashSetObj) 
        {
            int countOfUnsetElements = hashSetObj.Where(item => item.GetCharater().Equals(DatasetImageElements.Charater.unset)).Count();
            if (countOfUnsetElements == 0) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Making Dataset and saving in txt file
        public static Boolean makeTextDatasetList(HashSet<DatasetImageElements> hashSetObj, String saveFilename)
        {
            StringBuilder str = new StringBuilder();
            //contain bytecode of image
            StringBuilder pictureCodeVector = new StringBuilder();
            var groupByCharaters = hashSetObj.GroupBy(x => x.GetCharater()).OrderBy(x => x.Key);
            int countOfKeys = groupByCharaters.Count();

            int countOfPixels = DatasetImageElements.ImageHeightConst * DatasetImageElements.ImageWidthConst;
            for (int i = 0; i < countOfPixels; i++)
            {
                str.Append("pix_");
                str.Append(i + 1);
                str.Append("\t");
            }

            foreach (var groupItem in groupByCharaters)
            {
                str.Append("\t");
                str.Append(groupItem.Key);
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(saveFilename, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(str);
                    
                    foreach (var hashSetElement in hashSetObj)
                    {
                        str.Clear();
                        pictureCodeVector.Clear();
                        pictureCodeVector.Append(hashSetElement.GetPictureStringFormat());

                        int numOfPixels = pictureCodeVector.Length;
                        for (int i = 0; i < numOfPixels; i++)
                        {
                            str.Append(pictureCodeVector[i]);
                            str.Append("\t");
                        }

                        foreach (var groupItem in groupByCharaters)
                        {
                            if (hashSetElement.GetCharater().Equals(groupItem.Key))
                            {
                                str.Append("1");
                                str.Append("\t");
                            }
                            else
                            {
                                str.Append("0");
                                str.Append("\t");
                            }
                        }
                        sw.WriteLine(str);
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally {
            }

            return true;
        }
    
    
    }

}
