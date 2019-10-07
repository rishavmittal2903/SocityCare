using SocietyCare.Contracts;
using System.Collections.Generic;

namespace SocietyCare.Interfaces
{
    public interface IOwnerAction
    {
        bool CallPendingRentReminder(string flatId);
        bool RefundMoney(BankAccountDetail bankAccountDetail);
    }
}
