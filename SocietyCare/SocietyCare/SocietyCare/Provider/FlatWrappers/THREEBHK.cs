using SocietyCare.Contracts;
using SocietyCare.Enums;
using SocietyCare.Interfaces;
using System;
using System.Collections.Generic;

namespace SocietyCare.Provider.FlatWrappers
{
    public class THREEBHK : IFlatAvailability
    {
        public List<Flat> GetFlatDetails(FlatStatus flatStatus)
        {
            throw new NotImplementedException();
        }

        public List<Flat> GetFlatDetails(Rating flatRating)
        {
            throw new NotImplementedException();
        }
    }
}