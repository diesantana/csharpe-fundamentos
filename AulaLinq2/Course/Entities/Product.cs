using System.Globalization;
using System.Text;

namespace Course.Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Id);
            sb.Append(", ");
            sb.Append(Name);
            sb.Append(", ");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(", ");
            sb.Append(Category.Name);
            sb.Append(", ");
            sb.Append(Category.Tier);
            return sb.ToString();
        }


    }
}
