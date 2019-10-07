using SocietyCare.Interfaces;

namespace SocietyCare.Provider.PaymentWrapper
{
    public class PaymentGateway : IPayment
    {
        public bool PayMoney()
        {
            throw new System.NotImplementedException();
        }

        public bool RefundMoney()
        {
            throw new System.NotImplementedException();
        }
    }
}
