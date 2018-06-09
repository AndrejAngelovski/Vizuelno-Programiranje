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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodadiNov_Click(object sender, EventArgs e)
        {
            NewProduct np = new NewProduct();
            if(np.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach(object obj in lbProducts.Items)
                {
                    Product product = (Product)obj;
                    if(product.Kod == np.Product.Kod)
                    {
                        MessageBox.Show("Производ со овој код веќе постои!");
                        return;
                    }
                }
                lbProducts.Items.Add(np.Product);
            }
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDodadiVoSmetka.Enabled = lbProducts.SelectedIndex != -1;
            nudQuantity.Enabled = lbProducts.SelectedIndex != -1;
        }

        private void btnDodadiVoSmetka_Click(object sender, EventArgs e)
        {
            Product selected = (Product)lbProducts.SelectedItem;
            Item item = new Item(selected, (int)nudQuantity.Value);
            lbSmetka.Items.Add(item);
            calculateTotal();
        }

        private void calculateTotal()
        {
            float total = 0;
            foreach(object obj in lbSmetka.Items)
            {
                Item item = (Item)obj;
                total += item.Price();
            }
            tbVkupno.Text = string.Format("{0:0.00} ден", total);
            tbZaPlakanje.Text = string.Format("{0:0.00} ден", total * (float)(1 + nudDanok.Value / 100));
        }

        private void nudDanok_ValueChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void btnIzbrisiStavka_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Избриши ставка?", "Дали сте сигурни дека сакате да ја избришете ставката?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                lbSmetka.Items.RemoveAt(lbSmetka.SelectedIndex);
                calculateTotal();
            }
        }

        private void lbSmetka_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnIzbrisiStavka.Enabled = lbSmetka.SelectedIndex != -1;
        }
    }
}
