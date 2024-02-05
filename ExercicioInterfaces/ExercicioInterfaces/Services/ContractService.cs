using ExercicioInterfaces.Entities;

namespace ExercicioInterfaces.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int numberOfmonths)
        {
            // mes inicial
            DateTime initialMonth = contract.Date;
            // valor de cada parcela
            double freeInstallmentValue = contract.TotalValue / numberOfmonths;

            for (int i = 1; i <= numberOfmonths; i++)
            {
                // vencimento daquele mes (a cada iteração + 1 mês)
                DateTime dueDate = initialMonth.AddMonths(i);

                // juros com base na parcela
                double interestValue = _onlinePaymentService.Interest(freeInstallmentValue, i);

                // taxa de pagamento com base no valor com jutos
                double paymentFee = _onlinePaymentService.PaymentFee(interestValue + freeInstallmentValue);
                // valor final 
                double finalValue = freeInstallmentValue + interestValue + paymentFee;

                // instancia uma parcela e adiciona na lista, do contrato atual. 
                Installment installment = new Installment(dueDate, finalValue);

                contract.Installments.Add(installment);
            }

        }
    }
}
