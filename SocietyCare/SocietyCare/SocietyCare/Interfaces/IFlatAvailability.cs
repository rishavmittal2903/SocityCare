
using SocietyCare.Contracts;
using SocietyCare.Enums;
using System.Collections.Generic;

namespace SocietyCare.Interfaces
{
   public interface IFlatAvailability
    {
        List<Flat> GetFlatDetails(FlatStatus flatStatus);
        List<Flat> GetFlatDetails(Rating flatRating);

    }
}
