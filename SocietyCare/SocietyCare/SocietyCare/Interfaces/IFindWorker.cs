using SocietyCare.Contracts;
using SocietyCare.Enums;
using System.Collections.Generic;

namespace SocietyCare.Interfaces
{
   public interface IFindWorker
    {
        UserDetails GetWorkerDetail(string userId);

        List<UserDetails> GetWorkerStatus(string userId);

    }
}
