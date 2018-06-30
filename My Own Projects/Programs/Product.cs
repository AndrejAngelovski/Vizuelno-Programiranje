using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AneAlekPrograma
{
    [Serializable]
    public class Product
    {
        public string Name { get; set; }
        //public string Data { get; set; }
        public int Quantity { get; set; }

        public Product(string name, int quantity)
        {
            Name = name;
            //Data = data;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return string.Format("{0} - Залиха: {1}", Name, Quantity);
        }

        // ( ) MALI ZAGRADI
        // [ ] SREDNI ZAGRADI
        // { } GOLEMI ZAGRADI
    }
}
