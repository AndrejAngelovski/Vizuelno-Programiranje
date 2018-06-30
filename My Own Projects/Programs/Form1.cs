using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace AneAlekPrograma
{
    public partial class Form1 : Form
    {
        private SaveDoc SaveDoc;
        private string FileName;
        public Form1()
        {
            InitializeComponent();
            SaveDoc = new SaveDoc();
            Category category = new Category("Алат", 1);
            category.AddProduct(new Product("Клешта", 10));
            lbKategorii.Items.Add(category);
            Category category2 = new Category("Електричен алат", 2);
            category2.AddProduct(new Product("Бруска", 15));
            lbKategorii.Items.Add(category2);
            loadCategory();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddNewCategory addNew = new AddNewCategory();
            if(addNew.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbKategorii.Items.Add(addNew.Category);
            }
        }
        
        private void lbKategorii_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteCategory.Enabled = lbKategorii.SelectedIndex != -1;
            btnDeleteCategory.Enabled = lbKategorii.SelectedIndex != -1;
            loadCategory();            
        }

        /*private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            AddProduct form = new AddProduct();
            if(form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Category category = lbKategorii.SelectedItem as Category;
                category.AddProduct(form.Product);
            }
        }*/

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека сакате да ја избришете категоријата? ", "Избриши категорија", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                lbKategorii.Items.RemoveAt(lbKategorii.SelectedIndex);
                loadCategory();
            }
        }


        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека сакате да го избришете продуктот?" , "Избриши продукт", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Category category = lbKategorii.SelectedItem as Category;
                category.Products.RemoveAt(lbProdukti.SelectedIndex);
                lbProdukti.Items.RemoveAt(lbProdukti.SelectedIndex);
                
            }
        }

        private void btnAddNewProduct_Click_1(object sender, EventArgs e)
        {
            AddProduct form = new AddProduct();
            if(lbKategorii.SelectedIndex != -1)
            { 
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Category category = lbKategorii.SelectedItem as Category;
                    category.AddProduct(form.Product);
                    lbProdukti.Items.Add(form.Product);
                    //loadCategory();
                }
            }
        }

        void loadCategory()
        {
            lbProdukti.Items.Clear();
            Category category = lbKategorii.SelectedItem as Category;
            if (category != null && category.Products.Count > 0)
            {
                foreach (Product product in category.Products)
                {
                  lbProdukti.Items.Add(product);
                }
            }
        }

        private void saveFile()
        {
            if(FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Програма за артикли (*.atk)|*.atk";
                saveFileDialog.Title = "Зачувај ја програмата";
                saveFileDialog.FileName = FileName;
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if(FileName != null)
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, SaveDoc);
                }
            }
        }

        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Програма за артикли (*.atk)|*.atk";
            openFileDialog.Title = "Отвори ја програмата";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        SaveDoc = (SaveDoc)formater.Deserialize(fileStream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDoc = new SaveDoc();
            Invalidate(true);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            SaveDoc = new SaveDoc();
            Invalidate(true);
        }
    }
}
