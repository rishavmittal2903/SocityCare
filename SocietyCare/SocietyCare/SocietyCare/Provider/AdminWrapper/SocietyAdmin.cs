using System.Collections.Generic;
using SocietyCare.Contracts;
using SocietyCare.Enums;
using SocietyCare.Interfaces;

namespace SocietyCare.Provider.AdminWrapper
{
    public class SocietyAdmin: IAdminAction, IDetails
    {
        #region ADD/REMOVE AND UPDATE DETAILS

        public bool AddDetail<T>(IList<T> flatDetail)
        {
            throw new System.NotImplementedException();
        }
        

        public bool UpdateDetail<T>(IList<T> societyDetail)
        {
            throw new System.NotImplementedException();
        }
        public IList<T> ViewDocuments<T>(string id)
        {
            throw new System.NotImplementedException();
        }

        public bool UploadDocument<T>(IList<T> documents)
        {
            throw new System.NotImplementedException();
        }
        public bool RemoveDetail<T>(string id)
        {
            throw new System.NotImplementedException();
        }
        public bool RemoveDocument<T>(IList<T> documents)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region GET FLAT/OWNER/PERSON DETAILS
        public List<Flat> GetFlatDetails(string id)
    {
        throw new System.NotImplementedException();
    }

    public List<UserDetails> GetOwnerDetail(string id)
    {
        throw new System.NotImplementedException();
    }

    public SocietyDetails GetSocietyDetail(string id)
    {
        throw new System.NotImplementedException();
    }

    public List<UserDetails> GetUserDetails(string societyId, string flatId, string userId, UserType userType)
    {
        throw new System.NotImplementedException();
    }

        #endregion

    }
}
