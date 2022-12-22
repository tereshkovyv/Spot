using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Spot.Data;
using Spot.Data.Models;
using Spot.DataLayer;
using Spot.DataLayer.Interfaces;
using Spot.DataLayer.Models;

namespace Spot.Areas.Application.Pages.Editor
{
    public class Create : PageModel
    {
        private IAddable<SocialObject> SocialObjectRepository { get; }
        private UserManager<User> UserManager { get; }

        public Create(ApplicationDbContext applicationDbContext, UserManager<User> userManager,
            IAddable<SocialObject> socialObjectRepository)
        {
            UserManager = userManager;
            SocialObjectRepository = socialObjectRepository;
        }

        [BindProperty]
        public InputModel Input { get; set; }
        public SocialObject SocialObject { get; set; }

        public class InputModel
        {
            public int Id { get; set; }
            [Required]
            [Display(Name = "Название")]
            public string Name { get; set; }
            [Display(Name = "Место проведения")] public string Place { get; set; }
            [Display(Name = "Дата")] public DateTime Date { get; set; }
            [Display(Name = "Время")] public DateTime Time { get; set; }
            [Display(Name = "Короткое описание")] public string ShirtDescription { get; set; }
            [Display(Name = "Полное описание")] public string FullDescription { get; set; }
        }
        
        public async Task<IActionResult> OnPostAsync()
        {
            SocialObject = new SocialObject
            {
                Name = Input.Name,
                Place = Input.Place,
                Date = new DateTime(Input.Date.Year, Input.Date.Month, Input.Date.Day, Input.Time.Hour, Input.Time.Minute, Input.Time.Second),
                ShirtDescription = Input.ShirtDescription,
                FullDescription = Input.FullDescription
            };
            var user = UserManager.GetUserAsync(User).Result;
            SocialObject.PresenterId = user.Id;
            
            user.OwnObjects.Add(SocialObject);
            SocialObjectRepository.Add(SocialObject);
            return RedirectToPage();
        }
    }
}