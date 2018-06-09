using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Narachki
{
    public partial class AddOrder : Form
    {
        public ProductItem Item { get; set; }

        public AddOrder()
        {
            InitializeComponent();
            var product = new Product("Кафе", 60);
            cbProducts.Items.Add(product);
            product = new Product("Вода", 40);
            cbProducts.Items.Add(product);
            product = new Product ("Пиво", 100 );
            cbProducts.Items.Add(product);
            product = new Product ("Сладолед", 80);
            cbProducts.Items.Add(product);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Item = new ProductItem
            {
                Product = cbProducts.SelectedItem as Product,
                Quantity = (int)nudQuantity.Value,
                Note = tbNote.Text
            };
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = cbProducts.SelectedIndex != -1;
        }
    }
}
