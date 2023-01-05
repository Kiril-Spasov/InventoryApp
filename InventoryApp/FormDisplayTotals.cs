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
    public partial class FormDisplayTotals : Form
    {
        public FormDisplayTotals()
        {
            InitializeComponent();
        }

        public string DisplayText
        {
            set { TxtDisplay.Text = value; }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
