namespace ExercicioInterfaces.Services
{
    internal class PayPalService : IOnlinePaymentService
    {
        public double Interest(double amount, int months)
        {
            // 1% a cada parcela  + 
            return amount * 0.01 * months;
        }

        public double PaymentFee(double amount)
        {
            // 2% em cima do valor com juros
            return amount * 0.02;
        }
    }
}
