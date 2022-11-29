using System.Collections.Generic;
using Spot.Data.Models;

namespace Spot.Data.Interfaces
{
    public interface IAllSocialObjects
    {
        IEnumerable<SocialObject> SocialObjects { get; }
        
        IEnumerable<SocialObject> GetFavorite { set; get; }
    }
}