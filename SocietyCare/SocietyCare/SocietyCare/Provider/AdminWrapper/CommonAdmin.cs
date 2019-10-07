using System.Collections.Generic;
using SocietyCare.Contracts;
using SocietyCare.Enums;
using SocietyCare.Interfaces;

namespace SocietyCare.Provider.AdminWrapper
{
    public class CommonAdmin : IAdminAction, IDetails
    {
        public bool AddDetail<T>(IList<T> flatDetail)
        {
            throw new System.NotImplementedException();
        }
        public bool RemoveDetail<T>(string id)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateDetail<T>(IList<T> societyDetail)
        {
            throw new System.NotImplementedException();
        }

        public bool UploadDocument<T>(IList<T> documents)
        {
            throw new System.NotImplementedException();
        }

        public IList<T> ViewDocuments<T>(string id)
        {
            throw new System.NotImplementedException();
        }

        public bool RemoveDocument<T>(IList<T> documents)
        {
            throw new System.NotImplementedException();
        }
        #region ADD/REMOVE AND UPDATE DETAILS

        #endregion

        #region GET FLAT/OWNER/PERSON DETAILS
        List<Flat> IDetails.GetFlatDetails(string id)
        {
            throw new System.NotImplementedException();
        }

        List<UserDetails> IDetails.GetOwnerDetail(string id)
        {
            throw new System.NotImplementedException();
        }

        List<UserDetails> IDetails.GetUserDetails(string societyId, string flatId, string userId, UserType userType)
        {
            throw new System.NotImplementedException();
        }


        public SocietyDetails GetSocietyDetail(string flatIDORName)
        {
            throw new System.NotImplementedException();
        }
        #endregion

    }
}
