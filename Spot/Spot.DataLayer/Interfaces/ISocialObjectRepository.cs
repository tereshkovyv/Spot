using System.Collections.Generic;
using Spot.Data.Models;
using Spot.DataLayer.Models;

namespace Spot.DataLayer.Interfaces
{
    public interface ISocialObjectRepository : IAddable<SocialObject>, IGettable<SocialObject>, IChangeable<SocialObject>
    {
    }
}