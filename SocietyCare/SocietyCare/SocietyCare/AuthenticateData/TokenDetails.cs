using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocietyCare.AuthenticateData
{
    public class TokenDetails
    {
      public string access_token { get; set; }
        public int access_token_expires_in { get; set; }
        public string refresh_token { get; set; }
        public int refresh_token_expires_in { get; set; }
    }
}
