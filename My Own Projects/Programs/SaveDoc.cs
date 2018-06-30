using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AneAlekPrograma
{
    [Serializable]
    public class SaveDoc
    {
        public List<Product> products { get; set; }
        public List<Category> categories { get; set; }
        public Category category;
        public Product Product;

        public SaveDoc()
        {
            products = new List<Product>();
            categories = new List<Category>();
        }

        public void AddProduct(string name, int quantity)
        {
            Product product = new Product(name, quantity);
            products.Add(product);
        }

        public void AddCategory(string name, int number)
        {
            Category category = new Category(name, number);
            categories.Add(category);
        }
    }
}
