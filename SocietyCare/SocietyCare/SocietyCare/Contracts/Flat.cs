using SocietyCare.Enums;
using System.Collections.Generic;

namespace SocietyCare.Contracts
{
    public class Flat
    {
        public string flatId { get; set; }

        public string ownerId { get; set; }
        public List<UserDetails> users { get; set; }
        public FlatType flatType { get; set; }
        public string flatName { get; set; }
        public FlatStatus flatStatus { get; set; }
        public Rating flatRating { get; set; }
        public FlatDetail flatDetails { get; set; }
        public FlatPreferable preferable { get; set; }
        public FurnishStatus furnishStatus { get; set; }
        public TenantType tenantType { get; set; }
        public Documents flatDocuments { get; set; }
        public string locationId { get; set; }

        public List<string> flatImages { get; set; }

    }
}
