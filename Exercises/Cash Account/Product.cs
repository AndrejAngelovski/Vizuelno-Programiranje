using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CashAccount
{
    public class Product
    {
        public int Kod { get; set; }
        public string Ime { get; set; }
        public float Cena { get; set; }

        public Product(int kod, string ime, float cena)
        {
            Kod = kod;
            Ime = ime;
            Cena = cena;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1} {2:0.00}", Kod, Ime, Cena);
        }
    }
}
