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
    public partial class AddNewCategory : Form
    {
        public Category Category { get; set; }
        public AddNewCategory()
        {
            InitializeComponent();
        }
        
        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if(tbName.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbName, "Мора да внесете име на категорија");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Category = new Category(tbName.Text.Trim(), (int)nudNumber.Value);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
