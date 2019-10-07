using System.Collections.Generic;
using SocietyCare.Contracts;
using SocietyCare.Enums;
using SocietyCare.Interfaces;

namespace SocietyCare.Provider.UserWrapper
{
    public class Tenants : IDetails
    {
        IPayment _payment;
        IFindWorker _findWorker;
        public Tenants(IPayment payment,IFindWorker findWorker)
        {
            _payment = payment;
            _findWorker = findWorker;
        }
       

        public SocietyDetails GetSocietyDetail(string flatIDORName)
        {
            throw new System.NotImplementedException();
        }
        
       public List<Flat> GetFlatDetails(string id)
        {
            throw new System.NotImplementedException();
        }

       public List<UserDetails> GetOwnerDetail(string id)
        {
            throw new System.NotImplementedException();
        }
       public List<UserDetails> GetUserDetails(string societyId, string flatId, string userId, UserType userType)
        {
            throw new System.NotImplementedException();
        }
    }
}
