using SocietyCare.Contracts;
using SocietyCare.Interfaces;
using System;
using System.Collections.Generic;

namespace SocietyCare.Provider.UserWrapper
{
    public class Owner : IAdminAction,IOwnerAction
    {
        public bool AddDetail<T>(IList<T> flatDetail)
        {
            throw new NotImplementedException();
        }
        public bool RemoveDetail<T>(string id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveDocument<T>(IList<T> documents)
        {
            throw new NotImplementedException();
        }

        public bool UpdateDetail<T>(IList<T> societyDetail)
        {
            throw new NotImplementedException();
        }

        public bool UploadDocument<T>(IList<T> documents)
        {
            throw new NotImplementedException();
        }

        public IList<T> ViewDocuments<T>(string id)
        {
            throw new NotImplementedException();
        }
        public bool CallPendingRentReminder(string flatId)
        {
            throw new NotImplementedException();
        }

        public bool RefundMoney(BankAccountDetail bankAccountDetail)
        {
            throw new NotImplementedException();
        }


    }
}
