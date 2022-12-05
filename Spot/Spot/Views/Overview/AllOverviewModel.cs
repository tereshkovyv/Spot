using System.Collections.Generic;
using Spot.Data.Models;

namespace Spot.Views.Overview
{
    public class AllOverviewModel
    {
        public IEnumerable<SocialObject> socialObjects { get; set; }
    }
}