using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Spot.Data.Models;
using Spot.DataLayer.Interfaces;
using Spot.DataLayer.Models;

namespace Spot.Areas.Application.Pages.Editor
{
    public class Watch : PageModel
    {
        private readonly IGettable<SocialObject> SocialObjectRepository;
        public readonly UserManager<User> UserManager;
        public Watch(UserManager<User> userManager, IGettable<SocialObject> socialObjectRepository)
        {
            UserManager = userManager;
            SocialObjectRepository = socialObjectRepository;
            
        }
        public SocialObject SocialObject;
        public User Presenter;
        public async void OnGet(string socialObjectId)
        {
            SocialObject = SocialObjectRepository.All
                .FirstOrDefault(x => x.Id == Convert.ToInt32(socialObjectId));
            Presenter = UserManager.FindByIdAsync(SocialObject.PresenterId).Result;
        }
    }
}