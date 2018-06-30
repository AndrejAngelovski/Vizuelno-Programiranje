using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AneAlekPrograma
{
    [Serializable]
    public class Category
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public List<Product> Products { get; set; }

        public Category(string name, int number)
        {
            Name = name;
            Number = number;
            Products = new List<Product>();
        }
        
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public override string ToString()
        {
            return string.Format("{0}. {1}", Number, Name);
        }
    }
}
