using System.Globalization;
using System.Text;

namespace AulaInterfaces.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Basic payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}");
            stringBuilder.AppendLine($"Tax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}");
            stringBuilder.AppendLine($"Total payment: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}");
            return stringBuilder.ToString();
        }
    }
}
