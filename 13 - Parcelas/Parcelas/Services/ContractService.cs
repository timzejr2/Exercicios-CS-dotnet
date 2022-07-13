using System;
using Parcelas.Entities;

namespace Parcelas.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessesContract(Contract contract, int months)
        {
            double basicValue = contract.TotalValue / months;
            for(int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedValue = basicValue + _onlinePaymentService.Interest(basicValue, i);
                double fullValue = updatedValue + _onlinePaymentService.PaymentFee(updatedValue);
                contract.addInstallment(new Installment(date, fullValue));
            }
        }
    }
}
