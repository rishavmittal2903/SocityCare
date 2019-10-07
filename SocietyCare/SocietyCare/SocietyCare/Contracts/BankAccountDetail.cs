using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocietyCare.Contracts
{
    public class BankAccountDetail
    {
        public string accountNumber { get; set; }

        public string IFSCCode { get; set; }

        public string expiryMonth { get; set; }

        public string expiryYear { get; set; }

        public string NameOnCard { get; set; }
    }
}
