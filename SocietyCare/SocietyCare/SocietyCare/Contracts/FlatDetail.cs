using SocietyCare.Enums;

namespace SocietyCare.Contracts
{
    public class FlatDetail
    {
        public string flatId { get; set; }
        public double rent { get; set; }
        public double securityDeposit { get; set; }
        public string flatArea { get; set; }
        public string buildingAge { get; set; }

        public string facing { get; set; }

        public string floor { get; set; }

        public int balcony { get; set; }

        public Amenties amenties { get; set; }

        public string flatDescription { get; set; }


    }
}
