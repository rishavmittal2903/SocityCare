using SocietyCare.Contracts;
using SocietyCare.Enums;
using System.Collections.Generic;

namespace SocietyCare.Interfaces
{
   public interface IDetails
    {
        SocietyDetails GetSocietyDetail(string id);
        List<Flat> GetFlatDetails(string id);

        List<UserDetails> GetOwnerDetail(string id);

        List<UserDetails> GetUserDetails(string societyId,string flatId,string userId,UserType userType);
    }
}
