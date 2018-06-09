using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.CashAccount
{
    public partial class NewProduct : Form
    {
        public Product Product { get; set; }
        //public ErrorProvider errorProvider1 { get; private set; }
        private System.Windows.Forms.ErrorProvider errorProvider1;

        public NewProduct()
        {
            InitializeComponent();
        }

        private void btnVnesi_Click(object sender, EventArgs e)
        {
            Product = new Product((int)nudCode.Value, tbName.Text, (float)nudPrice.Value);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            //errorProvider1 = new ErrorProvider();
            if(tbName.Text.Trim().Length > 0)
            {
                e.Cancel = false;
                errorProvider1.SetError(tbName, null);
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Името на продуктот е задолжително");
            }
        }

        
    }
}
