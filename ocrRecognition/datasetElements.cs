using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ocrRecognition
{
    public class DatasetElements
    {

        private String filename;
        private String shortFilename;

        public enum TypeDataset
        {
            training,
            testing,
            unset
        }
        
        private TypeDataset typeDataset;

        //constructor
        public DatasetElements()
        {}

        public DatasetElements(String filename)
        {
            this.filename = filename;
            this.typeDataset = TypeDataset.unset;
            this.shortFilename = Path.GetFileName(filename);
            this.typeDataset = TypeDataset.unset;
        }

        public DatasetElements(String filename, String shortFilename)
        {
            this.filename = filename;
            this.typeDataset = TypeDataset.unset;
            this.shortFilename = shortFilename;
        }

        //Getters and Setters Methods
        public String GetFilename()
        {
            return filename;
        }
        public void SetFilename(String filename)
        {
            this.filename = filename;
        }

        public String GetShortFilename()
        {
            return shortFilename;
        }
        public void SetShortFilename(String shortFilename)
        {
            this.shortFilename = shortFilename;
        }

        public TypeDataset GetTypeset()
        {
            return typeDataset;
        }

        public void SetTypeset(TypeDataset typeDataset)
        {
            this.typeDataset = typeDataset;
        }

        //overriding HashCode and Equals Methods
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + filename.GetHashCode();
                return (filename != null ? hash : 0);
            }
        }

        public override bool Equals(object obj)
        {
            DatasetElements DatasetElementsObj = obj as DatasetElements;
            if (DatasetElementsObj == null)
                return false;
            else
                return filename.Equals(DatasetElementsObj.filename);
        }


    }
}
