using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Spot.DataLayer;
using Spot.DataLayer.Interfaces;
using Spot.DataLayer.Models;

namespace Spot.Areas.Application.Pages.Overview
{
    public class All : PageModel
    {
        [BindProperty]
        public int Input { get; }
        public ISocialObjectRepository SocialObjectRepository { get; }
        public UserManager<User> UserManager { get; }
        public ApplicationDbContext ApplicationDbContext { get; }

        public All(ISocialObjectRepository socialObjectRepository, UserManager<User> userManager, ApplicationDbContext applicationDbContext)
        {
            ApplicationDbContext = applicationDbContext;
            UserManager = userManager;
            SocialObjectRepository = socialObjectRepository;
        }
        public IEnumerable<SocialObject> socialObjects { get; set; }
        public void OnGet()
        {
            socialObjects = SocialObjectRepository.All;
        }

        public void OnPost(int id)
        {
            var user = UserManager.GetUserAsync(User).Result;
            user.FavoriteObjects.Add(SocialObjectRepository.GetByIdOrNull(id));
            ApplicationDbContext.Users.Update(user);
            ApplicationDbContext.SaveChanges();
            
            OnGet();
        }
}
}