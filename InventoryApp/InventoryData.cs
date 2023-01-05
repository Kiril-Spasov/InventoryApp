using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    internal class InventoryData
    {
        private string[] partNumbers = new string[100];
        private string[] partSize = new string[100];
        private int[,] quantity = new int[100, 100];
        private int[] totals = new int[100];
        private int parts;
        private int sizes;

        public string[] PartNumbers
        {
            get { return partNumbers; }
        }
        public string[] PartSize
        {
            get { return partSize; }
        }
        public int[,] Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int[] Totals
        {
            get { return totals; }
        }
        public int PartsCount
        {
            get { return parts; }
        }
        public int SizesCount
        {
            get { return sizes; }
        }

        public void LoadDataFromFile(string path, int partsCount, int sizesCount)
        {
            StreamReader streamReader = new StreamReader(path);

            try
            {
                for (int i = 1; i <= partsCount; i++)
                {
                    for (int j = 1; j <= sizesCount; j++)
                    {
                        quantity[i, j] = Convert.ToInt32(streamReader.ReadLine());
                        totals[i] += quantity[i, j];
                    }
                }

                for (int i = 1; i <= partsCount; i++)
                {
                    partNumbers[i] = streamReader.ReadLine();
                }

                for (int i = 1; i <= sizesCount; i++)
                {
                    partSize[i] = streamReader.ReadLine();
                }

                parts = partsCount;
                sizes = sizesCount;

                streamReader.Close();

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error has occured. Check if file is in correct format. " + ex.Message);
            }           
        }

        public void WriteDataToFile(string path)
        {
            StreamWriter streamWriter = new StreamWriter(path);

            for (int i = 1; i <= parts; i++)
            {
                for (int j = 1; j <= sizes; j++)
                {
                    streamWriter.WriteLine(quantity[i, j]);
                }
            }

            for (int i = 1; i <= parts; i++)
            {
                streamWriter.WriteLine(partNumbers[i]);
            }

            for (int i = 1; i <= sizes; i++)
            {
                streamWriter.WriteLine(partSize[i]);
            }

            streamWriter.Close();
        }
    }
}
