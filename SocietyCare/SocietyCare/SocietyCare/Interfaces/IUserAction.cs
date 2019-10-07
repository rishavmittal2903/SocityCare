using SocietyCare.Contracts;
using System.Collections.Generic;

namespace SocietyCare.Interfaces
{
    public interface IUserAction
    {
        bool BookFlat(string flatId);

        bool BookAppointment(string flatId);

        bool CancelAppointment(string flatId);

        bool UpdateAppointment(string flatId);

        List<UserDetails> GetOwnerNumber(string flatId);


    }
}
