using SocietyCare.Contracts;
using SocietyCare.Interfaces;
using System;
using System.Collections.Generic;

namespace SocietyCare.Provider.WorkerWrappers
{
    public class HouseHelper:IFindWorker
    {
        public UserDetails GetWorkerDetail(string userId)
        {
            throw new NotImplementedException();
        }

        public List<UserDetails> GetWorkerStatus(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
