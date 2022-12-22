using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Spot.Data;
using Spot.Data.Models;
using Spot.DataLayer;
using Spot.DataLayer.Interfaces;
using Spot.DataLayer.Models;

namespace Spot.Areas.Application.Pages.Overview
{
    public class All : PageModel
    {
        private ISocialObjectRepository SocialObjectRepository { get; }
        
        public UserManager<User> UserManager { get; }

        public All(ISocialObjectRepository socialObjectRepository, UserManager<User> userManager)
        {
            UserManager = userManager;
            SocialObjectRepository = socialObjectRepository;
        }
        
        public IEnumerable<SocialObject> SocialObjects { get; set; }
        
        public void OnGet()
        {
            SocialObjects = SocialObjectRepository.All;
        }
    }
}