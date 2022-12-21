using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Spot.DataLayer.Models
{
    public class User : IdentityUser
    {
        public string OrganisationName { get; set; }
        public string OrganisationType { get; set; }
        public string ContactPersonName { get; set; }
        public string OtherContacts { get; set; }
        public string OtherInformation { get; set; }
        public List<SocialObject> FavoriteObjects { get; set; } = new List<SocialObject>();
        public List<SocialObject> OwnObjects { get; set; } = new List<SocialObject>();

    }
}