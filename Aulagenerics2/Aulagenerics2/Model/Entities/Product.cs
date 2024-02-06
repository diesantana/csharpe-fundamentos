using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulagenerics2.Model.Entities
{
    internal class Product(string name, double price) : IComparable<Product>
    {
        public string Name { get; set; } = name;
        public double Price { get; set; } = price;

        public int CompareTo(Product other)
        {
            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
 
 