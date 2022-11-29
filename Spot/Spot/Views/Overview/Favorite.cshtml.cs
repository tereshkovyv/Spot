using System.Collections.Generic;
using Spot.Data.Models;

namespace Spot.Views.Overview
{
    public class FavoriteOverviewModel
    {
        public IEnumerable<SocialObject> socialObjects { get; set; }
    }
}