using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class FormInventory : Form
    {
        public FormInventory()
        {
            InitializeComponent();
        }


        InventoryData inventoryData = new InventoryData();
        string path = Application.StartupPath + @"\inventory.txt";

        private void FormInventory_Load(object sender, EventArgs e)
        {
            inventoryData.LoadDataFromFile(path, 10, 3);
        }

        private void displayTotalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayTotals();
        }
        private void DisplayTotals()
        {
            FormDisplayTotals formDisplayTotals = new FormDisplayTotals();

            string message = "";

            message += "PART NUMBER \t";

            for (int i = 1; i <= 3; i++)
            {
                message += inventoryData.PartSize[i].ToUpper() + "\t";
            }

            message += "TOTAL" + Environment.NewLine;

            for (int i = 1; i <= 10; i++)
            {
                message += inventoryData.PartNumbers[i] + "\t \t";

                for (int j = 1; j <= 3; j++)
                {
                    message += inventoryData.Quantity[i, j] + "\t";
                }

                message += inventoryData.Totals[i] + Environment.NewLine;
            }

            formDisplayTotals.DisplayText = message;
            formDisplayTotals.ShowDialog();
            
        }

        private void receivePartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataEntry dataEntry = new DataEntry();

            if (dataEntry.ShowDialog() == DialogResult.OK && dataEntry.Validate() == true )
            {
                int selectedPartSize = 0;
                int selectedPartNumber;

                string partNumber = dataEntry.PartNumber;
                int quantity = Convert.ToInt32(dataEntry.Quantity);
                string partSize = "";

                if ( dataEntry.Small == true)
                {
                    partSize = "small";
                }
                else if ( dataEntry.Medium == true)
                {
                    partSize = "medium";
                }
                else if (dataEntry.Large == true)
                {
                    partSize = "large";
                }


                selectedPartNumber = Searching.LinearSearch(inventoryData.PartNumbers, partNumber, inventoryData.PartsCount);

                if (partSize != "")
                {
                    selectedPartSize = Searching.LinearSearch(inventoryData.PartSize, partSize, inventoryData.SizesCount);
                }
                else
                {
                    MessageBox.Show("You must select part size.");
                }     


                if (selectedPartNumber != -1 && selectedPartSize != -1)
                {
                    inventoryData.Quantity[selectedPartNumber, selectedPartSize] += quantity;
                    inventoryData.Totals[selectedPartNumber] += quantity;
                }
                else
                {
                    MessageBox.Show("Item not found.");
                }
            }
        }

        private void issuePartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataEntry dataEntry = new DataEntry();

            if (dataEntry.ShowDialog() == DialogResult.OK && dataEntry.Validate() == true )
            {
                int selectedPartSize = 0;
                int selectedPartNumber;

                string partNumber = dataEntry.PartNumber;
                int quantity = Convert.ToInt32(dataEntry.Quantity);
                string partSize = "";

                if (dataEntry.Small == true)
                {
                    partSize = "small";
                }
                else if (dataEntry.Medium == true)
                {
                    partSize = "medium";
                }
                else if (dataEntry.Large == true)
                {
                    partSize = "large";
                }

                selectedPartNumber = Searching.LinearSearch(inventoryData.PartNumbers, partNumber, inventoryData.PartsCount);

                if (partSize != "")
                {
                    selectedPartSize = Searching.LinearSearch(inventoryData.PartSize, partSize, inventoryData.SizesCount);
                }
                else
                {
                    MessageBox.Show("You must select part size.");
                }

                if (selectedPartNumber != -1 && selectedPartSize != -1)
                {
                    inventoryData.Quantity[selectedPartNumber, selectedPartSize] -= quantity;
                    inventoryData.Totals[selectedPartNumber] -= quantity;
                }
                else
                {
                    MessageBox.Show("Item not found.");
                }
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventoryData.WriteDataToFile(path);
            this.Close();
        }
    }
}
