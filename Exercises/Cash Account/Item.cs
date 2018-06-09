using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CashAccount
{
    class Item
    {
        public Product Produkt { get; set; }
        public int Kolicina { get; set; }

        public Item(Product produkt, int kolicina)
        {
            Produkt = produkt;
            Kolicina = kolicina;
        }

        public override string ToString()
        {
            return string.Format("{0} {1:0.00} X {2} = {3:0.00", Produkt.Ime, Produkt.Cena, Kolicina, Produkt.Cena * Kolicina);
        }

        public float Price()
        {
            return Produkt.Cena * Kolicina;
        }
    }
}
