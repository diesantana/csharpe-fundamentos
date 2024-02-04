using AulaInterfaces.Entities;

namespace AulaInterfaces.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        // Injetando o service, podendo ser qualquer classe que implementa a interface
        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
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

            double taxAmount = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, taxAmount);

        }
    }
}
