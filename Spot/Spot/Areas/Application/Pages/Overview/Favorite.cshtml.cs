using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Spot.DataLayer.Interfaces;
using Spot.DataLayer.Models;

namespace Spot.Areas.Application.Pages.Overview
{
    public class Favorite : PageModel
    {
        public IGettable<SocialObject> SocialObjectRepository { get; }
        public UserManager<User> _userManager;
        
        public Favorite(IGettable<SocialObject> socialObjectRepository, UserManager<User> userManager)
        {
            _userManager = userManager;
            SocialObjectRepository = socialObjectRepository;
        }
        public IEnumerable<SocialObject> socialObjects { get; set; }
        public void OnGet()
        {
            socialObjects = (_userManager.GetUserAsync(User).Result).FavoriteObjects;
        }
}
}