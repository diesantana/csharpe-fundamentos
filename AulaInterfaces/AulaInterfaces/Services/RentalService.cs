using AulaInterfaces.Entities;

namespace AulaInterfaces.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        // Injetando o service que calcula a taxa na classe, como um atributo
        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            double basicPayment = 0.0;
            // duração
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double hours = duration.TotalHours;
            if (hours <= 12.00)
            {
                basicPayment = PricePerHour * Math.Ceiling(hours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double taxAmount = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, taxAmount);

        }
    }
}
