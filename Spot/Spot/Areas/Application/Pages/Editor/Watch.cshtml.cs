using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Spot.Data;
using Spot.Data.Interfaces;
using Spot.Data.Models;

namespace Spot.Areas.Application.Pages.Editor
{
    public class Watch : PageModel
    {
        private ApplicationDbContext _applicationDbContext;
        private ISocialObjectManager _socialObjectManager;
        public UserManager<User> _userManager;
        public Watch(ApplicationDbContext applicationDbContext,UserManager<User> userManager, ISocialObjectManager socialObjectManager)
        {
            _userManager = userManager;
            _socialObjectManager = socialObjectManager;
            _applicationDbContext = applicationDbContext;
        }
        public SocialObject SocialObject;
        public User Presenter;
        public async void OnGet(string socialObjectId)
        {
            SocialObject = _socialObjectManager.All
                .FirstOrDefault(x => x.Id == Convert.ToInt32(socialObjectId));
            Presenter = _userManager.FindByIdAsync(SocialObject.PresenterId).Result;
        }
    }
}