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
        private IAllSocialObjects _allSocialObjects;
        public UserManager<User> _userManager;
        public Watch(ApplicationDbContext applicationDbContext, IAllSocialObjects allSocialObjects, UserManager<User> userManager)
        {
            _userManager = userManager;
            _allSocialObjects = allSocialObjects;
            _applicationDbContext = applicationDbContext;
        }
        public SocialObject SocialObject;
        public User Presenter;
        public async void OnGet(string socialObjectId)
        {
            SocialObject = _allSocialObjects.GetAllObjectsObjects
                .FirstOrDefault(x => x.Id == Convert.ToInt32(socialObjectId));
            Presenter = _userManager.FindByIdAsync(SocialObject.PresenterId).Result;
        }
    }
}