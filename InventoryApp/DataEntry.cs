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
    public partial class DataEntry : Form
    {
        public DataEntry()
        {
            InitializeComponent();
        }

        public string PartNumber
        {
            get { return CboPartNumber.Text; }
        }
        public bool Small
        {
            get { return RdoBtnSmall.Checked; }
        }
        public bool Medium
        {
            get { return RdoBtnMedium.Checked; }
        }
        public bool Large
        {
            get { return RdoBtnLarge.Checked; }
        }
        public string Quantity
        {
            get { return TxtQuantity.Text; }
        }

        //8 is backspace in the ascii table.
        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void CboPartNumber_Validating(object sender, CancelEventArgs e)
        {
            if (CboPartNumber.Text == "" || CboPartNumber.Text == null)
            {
                e.Cancel = true;
                MessageBox.Show("You must select part number.");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void TxtQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (TxtQuantity.Text == "" || TxtQuantity.Text == null)
            {
                e.Cancel = true;
                MessageBox.Show("You must enter quantity.");
            }
            else
            {
                e.Cancel = false;
            }
        }

    }
}
