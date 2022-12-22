using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Spot.Data.Models;
using Spot.DataLayer.Interfaces;
using Spot.DataLayer.Models;

namespace Spot.Areas.Application.Pages.Overview
{
    public class Own : PageModel
    {
        public readonly UserManager<User> UserManager;
        
        public Own(UserManager<User> userManager)
        {
            UserManager = userManager;
        }
        public IEnumerable<SocialObject> socialObjects { get; set; }
        public void OnGet()
        {
            socialObjects = (UserManager.GetUserAsync(User).Result).OwnObjects;
        }
}
}