using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Spot.Data;
using Spot.Data.Models;

namespace Spot.Areas.Application.Pages.Overview
{
    public class All : PageModel
    {
        private ApplicationDbContext _applicationDbContext;
        public All(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IEnumerable<SocialObject> socialObjects { get; set; }
        public async void OnGetAsync()
        {
            socialObjects = _applicationDbContext.SocialObject;
        }
    }
}