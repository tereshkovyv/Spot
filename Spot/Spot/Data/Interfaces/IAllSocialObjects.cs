using System.Collections.Generic;
using Spot.Data.Models;

namespace Spot.Data.Interfaces
{
    public interface IAllSocialObjects
    {
        IEnumerable<SocialObject> GetAllObjectsObjects { get; set; }
        
        IEnumerable<SocialObject> GetFavoriteObjects { get; }
        
        IEnumerable<SocialObject> GetMySocialObjects { get; }
    }
}