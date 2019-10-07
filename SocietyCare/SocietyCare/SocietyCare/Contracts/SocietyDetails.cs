using System.Collections.Generic;

namespace SocietyCare.Contracts
{
    public class SocietyDetails
    {
        public string societyId { get;set;}
        public string managerId { get; set; }
        public string societyName { get; set; }
        public Address address { get; set; }
        public List<Flat> flats { get; set; }
        public List<string> societyImages { get; set; }
        public Documents societyDocuments { get; set; }
        public bool isAffliated { get; set; }
        public bool globallyAllowed { get; set; }

    }
}
