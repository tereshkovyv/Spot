using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Spot.DataLayer.Interfaces;
using Spot.DataLayer.Models;

namespace Spot.Areas.Application.Pages.Overview
{
    public class Own : PageModel
    {
        public IGettable<SocialObject> SocialObjectRepository { get; }
        public readonly UserManager<User> UserManager;
        
        public Own(IGettable<SocialObject> socialObjectRepository, UserManager<User> userManager)
        {
            UserManager = userManager;
            SocialObjectRepository = socialObjectRepository;
        }
        public IEnumerable<SocialObject> socialObjects { get; set; }
        public void OnGet()
        {
            socialObjects = (UserManager.GetUserAsync(User).Result).OwnObjects;
        }
}
}