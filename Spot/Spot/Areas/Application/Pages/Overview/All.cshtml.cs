using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Spot.Data.Interfaces;
using Spot.Data.Models;

namespace Spot.Areas.Application.Pages.Overview
{
    public class All : PageModel
    {
        public ISocialObjectManager _socialObjectManager { get; }

        public All(ISocialObjectManager socialObjectManager)
        {
            _socialObjectManager = socialObjectManager;
        }
        public IEnumerable<SocialObject> socialObjects { get; set; }
        public void OnGet()
        {
            socialObjects = _socialObjectManager.All;
        }
}
}