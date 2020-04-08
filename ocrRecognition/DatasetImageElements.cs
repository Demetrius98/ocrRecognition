using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ocrRecognition
{
    //Extanding of class DatasetElements
    public class DatasetImageElements : DatasetElements
    {
        //Constants for Height and Width in pixels
        public const int ImageHeightConst = 8;
        public const int ImageWidthConst = 8;
        public const int ImageZoomConst = 4;

        //pictureStringFormat
        private String pictureStringFormat;

        public enum Charater : short
        {
            unset, A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, S, R, T, U, V, W, X, Y, Z,
            a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, s, r, t, u, v, w, x, y, z
        }

        private Charater charater;

        //calling the constructor of base class
        public DatasetImageElements() { }

        public DatasetImageElements(String filename) : base (filename) 
        { 
        }

        //new constructor
        public DatasetImageElements(DatasetElements datasetElementsObj) : 
            base (datasetElementsObj.GetFilename(), datasetElementsObj.GetShortFilename()) 
        {
            this.charater = DatasetImageElements.Charater.unset;
            //Setting code vector of image 
            this.pictureStringFormat = SetPictureStringFormat(datasetElementsObj.GetFilename());
        }

        public Charater GetCharater()
        {
            return charater;
        }

        public void SetCharater(Charater charater)
        {
            this.charater = charater;
        }

        public String GetPictureStringFormat()
        {
            return pictureStringFormat;
        }

        public String SetPictureStringFormat(String filename)
        {
            StringBuilder strImg = new StringBuilder();
            try
            {
                Bitmap img = (Bitmap)Image.FromFile(filename);
                for (int i = 0; i < img.Height; i++)
                {
                    for (int j = 0; j < img.Width; j++)
                    {
                        if (img.GetPixel(j, i) == Color.FromArgb(255, 0,0,0))
                        {
                            strImg.Append("1");
                        }
                        else
                        {
                            strImg.Append("0");
                        }
                    }
                }
            }
            catch
            {
                return null;
            }

            return strImg.ToString();
        }

         
        
        }
    }

