using System.Data;

namespace SocietyCare.Contracts
{
    public class Address
    {
        public string locationId { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string streetNo { get; set; }
        public string mobileNumber { get; set; }
        public Documents documents { get; set; }

        public static Address Fill(IDataRecord dataRecord)
        {
            Address address = new Address();
            return address;
        }
    }
}
