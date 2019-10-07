using System.Collections.Generic;
using SocietyCare.Contracts;
using SocietyCare.Enums;
using SocietyCare.Interfaces;

namespace SocietyCare.Provider.UserWrapper
{
    public class CommonUser : IUserAction
    {
        AccountType _accountType;
        IPayment _payment;
        public CommonUser(IPayment payment)
        {
            _accountType = AccountType.NORMAL;
            _payment = payment;
        }
        public bool BookAppointment(string flatId)
        {
            throw new System.NotImplementedException();
        }

        public bool BookFlat(string flatId)
        {
            throw new System.NotImplementedException();
        }

        public bool CancelAppointment(string flatId)
        {
            throw new System.NotImplementedException();
        }

        public List<UserDetails> GetOwnerNumber(string flatId)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateAppointment(string flatId)
        {
            throw new System.NotImplementedException();
        }
    }
}
