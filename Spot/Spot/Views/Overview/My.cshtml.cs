using System.Collections.Generic;
using Spot.Data.Models;

namespace Spot.Views.Overview
{
    public class MyOverviewModel
    {
        public IEnumerable<SocialObject> socialObjects { get; set; }
    }
}