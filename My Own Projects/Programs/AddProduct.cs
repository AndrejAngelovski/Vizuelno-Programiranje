using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AneAlekPrograma
{
    [Serializable]
    public partial class AddProduct : Form
    {
        public Product Product { get; set; }

        public AddProduct()
        {
            InitializeComponent();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if(tbName.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbName, "Мора да внесете име на продукт");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product = new Product(tbName.Text.Trim(), (int)nudQuantity.Value);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
