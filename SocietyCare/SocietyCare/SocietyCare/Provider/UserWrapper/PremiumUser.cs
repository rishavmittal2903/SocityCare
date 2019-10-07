using SocietyCare.Contracts;
using SocietyCare.Enums;
using SocietyCare.Interfaces;
using System.Collections.Generic;

namespace SocietyCare.Provider.UserWrapper
{
    public class PremiumUser : IUserAction
    {
        IFlatAvailability _IFlatAvailability;
        AccountType _accountType;
        public PremiumUser(IFlatAvailability flatAvailability)
        {
            _IFlatAvailability = flatAvailability;
            _accountType = AccountType.PREMIUM;
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
        
        public bool UpdateAppointment(string flatId)
        {
            throw new System.NotImplementedException();
        }

        public List<UserDetails> GetOwnerNumber(string flatId)
        {
            throw new System.NotImplementedException();
        }


    }
}
