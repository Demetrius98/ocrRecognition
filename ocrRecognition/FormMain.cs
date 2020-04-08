using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ocrRecognition
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        //Counstructor of Form   
        public FormMain()
        {
            InitializeComponent();

            //Initialization ComboBoxs
            DatasetElementsMethods.InitializeComboBox(comboBoxTrainCharater);
            DatasetElementsMethods.InitializeComboBox(comboBoxTestCharater);
        }

        //Path for saving Train Dataset
        private String saveTrainDatasetFilename;
        //Path for saving Test Dataset
        private String saveTestDatasetFilename;
        //Main Dataset
        private HashSet<DatasetElements> imageDataset = new HashSet<DatasetElements>();
        //Train and Test Datasets
        private HashSet<DatasetImageElements> imageDatasetTrain = new HashSet<DatasetImageElements>();
        private HashSet<DatasetImageElements> imageDatasetTest = new HashSet<DatasetImageElements>();

        private void buttonOpen_Click(object sender, EventArgs e) {
            OpenFileDialog openDialog = new OpenFileDialog(); //create OpenDialog
            openDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //Make imageFilter
            openDialog.Multiselect = true;

            //Show OpenDialog and adding files
            if (openDialog.ShowDialog() == DialogResult.OK) {

                StringBuilder imageSizeErr = new StringBuilder ();
                StringBuilder imageOtherErr = new StringBuilder ();
                //Making list of files path
                foreach (String fileName in openDialog.FileNames) {
                    
                    //if this fileimage doesn't have errors
                    if (DatasetElementsMethods.isImageNoErrors(fileName))
                    {
                        //Size of image checking
                        if (DatasetElementsMethods.isImageSizeOk(fileName))
                        {
                            DatasetElements imageElement = new DatasetElements(fileName);
                            imageDataset.Add(imageElement);
                        }
                        else
                        {
                            //Making list of size error files
                            imageSizeErr.Append(fileName + Environment.NewLine);
                        }
                    }
                    else
                    {
                        //Making list of other errors files
                        imageOtherErr.Append(fileName + Environment.NewLine);
                    }
                        
                }

                if (imageSizeErr.Length != 0)
                {
                    MessageBox.Show("These images are not " + DatasetImageElements.ImageWidthConst + "x" + DatasetImageElements.ImageHeightConst
                        + " pixels and were ignored:" + Environment.NewLine + imageSizeErr.ToString(), "Error: Incorrect size",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (imageOtherErr.Length != 0)
                {
                    MessageBox.Show("These images have errors:" + Environment.NewLine + imageOtherErr.ToString(), "Errors in files",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DatasetElementsMethods.updateListBoxMain (listBoxImages, imageDataset, labelStatusPre);

            }

        }

        //Open SaveDialogs and setting train test dataset's filenames
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            DatasetElementsMethods.configSaveDialog(saveFileDialog);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveTrainDatasetFilename = saveFileDialog.FileName;
                labelPathSaveTrainDataset.Text = "Path: " + Environment.NewLine + saveTrainDatasetFilename;
            }
        }

        private void buttonSaveTestDataset_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            DatasetElementsMethods.configSaveDialog(saveFileDialog);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveTestDatasetFilename = saveFileDialog.FileName;
                labelPathSaveTestDataset.Text = "Path: " + Environment.NewLine + saveTestDatasetFilename;
            }
        }

        private void buttonDeleteImages_Click(object sender, EventArgs e)
        {
            if (listBoxImages.Items.Count > 0 && listBoxImages.SelectedIndex >= 0)
            {
                //Remove item from imageDataset
                imageDataset.RemoveWhere(item => listBoxImages.SelectedItem.ToString().Equals(item.GetFilename()));

                DatasetElementsMethods.updateListBoxMain(listBoxImages, imageDataset, labelStatusPre);
            }
            
        }


        private void buttonAsTrain_Click(object sender, EventArgs e)
        {
            //making new HashSet of TrainDataset
            int selectedItemIndex = listBoxImages.SelectedIndex;
            if (selectedItemIndex >= 0)
            {
                String selectedItemFilename = listBoxImages.SelectedItem.ToString();
                if (DatasetElementsMethods.setTrainTestElements(selectedItemFilename, imageDataset, imageDatasetTrain, DatasetImageElements.TypeDataset.training))
                {
                    //updating (deleting) from listboxImage
                    DatasetElementsMethods.updateListBoxMain(listBoxImages, imageDataset, labelStatusPre);
                    //updating ListBoxTrain
                    DatasetElementsMethods.updateListBoxTrainTest(listBoxTrainDataset, imageDatasetTrain, labelTrainCountElements);

                    //If Counting Elements in ListBox is Successful -> displaying
                    if (DatasetElementsMethods.countCharaters(imageDatasetTrain, labelTrainCount)) { }
                }
            }
        }


        private void buttonAsTest_Click(object sender, EventArgs e)
        {
            //making new HashSet of TestDataset
            int selectedItemIndex = listBoxImages.SelectedIndex;
            if (selectedItemIndex >= 0)
            {
                String selectedItemFilename = listBoxImages.SelectedItem.ToString();
                if (DatasetElementsMethods.setTrainTestElements(selectedItemFilename, imageDataset, imageDatasetTest, DatasetImageElements.TypeDataset.testing))
                {
                    //updating (deleting) from listboxImage
                    DatasetElementsMethods.updateListBoxMain(listBoxImages, imageDataset, labelStatusPre);
                    //updating listBoxTest
                    DatasetElementsMethods.updateListBoxTrainTest(listBoxTestDataset, imageDatasetTest, labelTestCountElements);

                    //If Counting is Successful -> displaying
                    if (DatasetElementsMethods.countCharaters(imageDatasetTest, labelTestCount)) { }
                }
            }
        }

        private void buttonDelTrainDatasetElem_Click(object sender, EventArgs e)
        {
            //If item in listBox Selected
            int selectedItem = listBoxTrainDataset.SelectedIndex;
            if (selectedItem >= 0) 
            {
                //delete elements from Train Dataset
                if (DatasetElementsMethods.delTrainTestElements(selectedItem, imageDataset, imageDatasetTrain))
                {
                    //Updating listboxs
                    DatasetElementsMethods.updateListBoxMain(listBoxImages, imageDataset, labelStatusPre);
                    DatasetElementsMethods.updateListBoxTrainTest(listBoxTrainDataset, imageDatasetTrain, labelTrainCountElements);

                    //Clearing pictureBox
                    DatasetElementsMethods.clearPictureBox(pictureBoxPreTrain);

                    //If Counting is Successful -> displaying
                    if (DatasetElementsMethods.countCharaters(imageDatasetTrain, labelTrainCount)) { }
                }

            }
        }

        private void buttonDelTestDatasetElem_Click(object sender, EventArgs e)
        {
            //If item in listBox Selected
            int selectedItem = listBoxTestDataset.SelectedIndex;
            if (selectedItem >= 0)
            {
                //delete elements from Train Dataset
                if (DatasetElementsMethods.delTrainTestElements(selectedItem, imageDataset, imageDatasetTest))
                {
                    //Updating listboxs
                    DatasetElementsMethods.updateListBoxMain(listBoxImages, imageDataset, labelStatusPre);
                    DatasetElementsMethods.updateListBoxTrainTest(listBoxTestDataset, imageDatasetTest, labelTestCountElements);

                    //Clearing pictureBox
                    DatasetElementsMethods.clearPictureBox(pictureBoxPreTest);

                    //If Counting is Successful -> displaying
                    if (DatasetElementsMethods.countCharaters(imageDatasetTest, labelTestCount)) { }
                }

            }
        }

        //If ComboBox Train Selected
        private void comboBoxTrainCharater_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexItem = listBoxTrainDataset.SelectedIndex;
            if (selectedIndexItem >= 0)
            {
                //Parsing of Elmenent in ComboBox
                DatasetImageElements.Charater selectedCharater = (DatasetImageElements.Charater)Enum.Parse(typeof(DatasetImageElements.Charater), comboBoxTrainCharater.SelectedValue.ToString());

                //Updating in Train Test HashSet
                if (DatasetElementsMethods.setCharaterInTrainTestDataset(selectedIndexItem, selectedCharater, imageDatasetTrain))
                {
                    DatasetElementsMethods.updateListBoxTrainTest(listBoxTrainDataset, imageDatasetTrain, labelTrainCountElements);

                    //If Counting is Successful -> displaying
                    if (DatasetElementsMethods.countCharaters(imageDatasetTrain, labelTrainCount)) { }

                    //Selected item in Train listBox
                    listBoxTrainDataset.SelectedIndex = selectedIndexItem;
                }
            }
        }

        //if ListBoxTrain selected
        private void listBoxTrainDataset_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedItemIndex = listBoxTrainDataset.SelectedIndex;
            if (selectedItemIndex >= 0) 
            {
                //getting charater of selectedItem
                DatasetImageElements.Charater selectedCharater = imageDatasetTrain.ElementAt(selectedItemIndex).GetCharater();

                comboBoxTrainCharater.SelectedValue = selectedCharater.ToString();

                //Loading image in PictureBox
                DatasetElementsMethods.loadImageInPictureBox(imageDatasetTrain.ElementAt(selectedItemIndex).GetFilename(), pictureBoxPreTrain);

                listBoxTrainDataset.SelectedIndex = selectedItemIndex;
            }
            
        }

        //If listBox Test Selected
        private void listBoxTestDataset_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedItemIndex = listBoxTestDataset.SelectedIndex;
            if (selectedItemIndex >= 0)
            {
                //getting charater of selectedItem
                DatasetImageElements.Charater selectedCharater = imageDatasetTest.ElementAt(selectedItemIndex).GetCharater();

                comboBoxTestCharater.SelectedValue = selectedCharater.ToString();

                //Loading image in PictureBox
                DatasetElementsMethods.loadImageInPictureBox(imageDatasetTest.ElementAt(selectedItemIndex).GetFilename(), pictureBoxPreTest);


                listBoxTestDataset.SelectedIndex = selectedItemIndex;
            }
        }

        //If ComboBox Test Selected
        private void comboBoxTestCharater_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexItem = listBoxTestDataset.SelectedIndex;
            if (selectedIndexItem >= 0)
            {
                //Parsing of Elmenent in ComboBox
                DatasetImageElements.Charater selectedCharater = (DatasetImageElements.Charater)Enum.Parse(typeof(DatasetImageElements.Charater), comboBoxTestCharater.SelectedValue.ToString());

                //Updating in Train Test HashSet
                if (DatasetElementsMethods.setCharaterInTrainTestDataset(selectedIndexItem, selectedCharater, imageDatasetTest))
                {
                    DatasetElementsMethods.updateListBoxTrainTest(listBoxTestDataset, imageDatasetTest, labelTestCountElements);

                    //If Counting is Successful -> displaying
                    if (DatasetElementsMethods.countCharaters(imageDatasetTest, labelTestCount)) { }

                    listBoxTestDataset.SelectedIndex = selectedIndexItem;
                }
            }
        }

        private void comboBoxTrainCharater_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            listBoxTrainDataset.Focus();
        }

        private void comboBoxTrainCharater_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            listBoxTrainDataset.Focus();
        }

        private void comboBoxTestCharater_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            listBoxTestDataset.Focus();
        }

        private void comboBoxTestCharater_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            listBoxTestDataset.Focus();
        }

        private void buttonMakeTask1_Click(object sender, EventArgs e)
        {
            if (!DatasetElementsMethods.isUnsetElements(imageDatasetTrain) && !DatasetElementsMethods.isUnsetElements(imageDatasetTest))
            {
                if (DatasetElementsMethods.isCountCharaterOk(imageDatasetTrain, imageDatasetTest))
                {
                    if (saveTrainDatasetFilename != null && saveTestDatasetFilename != null)
                    {
                        //Method for making datalists
                        if (DatasetElementsMethods.makeTextDatasetList(imageDatasetTrain, saveTrainDatasetFilename))
                        {
                            if (DatasetElementsMethods.makeTextDatasetList(imageDatasetTest, saveTestDatasetFilename))
                            {
                                MessageBox.Show("Datasets have been maked!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("There are some errors!" + Environment.NewLine + "Test dataset has not been maked!",
                                "Error: Test Dataset", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        } 
                        else
                        {
                            MessageBox.Show("There are some errors!" + Environment.NewLine + "Train dataset has not been maked!",
                                "Error: Train Dataset", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Choose path for saving datasets!", "Error: Choose path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect count of charaters!" + Environment.NewLine +
                        "Train count of charater's type must be equal to Test count of charater's type", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else 
            {
                MessageBox.Show("Unset elements were detected!", "Error: unset elements", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
