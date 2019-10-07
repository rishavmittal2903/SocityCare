using System.Data;

namespace SocietyCare.Contracts
{
    public class Documents
    {
        public string UserId { get; set; }
        public string pancardNumber { get; set; }
        public string passportNumber { get; set; }
        public string aadharCardNumber { get; set; }

        public static Documents Fill(IDataRecord dataRecord)
        {
            Documents document = new Documents();
            return document;
        }
    }
}
