using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Spot.Data;
using Spot.Data.Interfaces;
using Spot.Data.Models;

namespace Spot.Areas.Application.Pages.Editor
{
    public class Create : PageModel
    {
        public ISocialObjectManager _socialObjectManager { get; set; }
        public ApplicationDbContext _dbContext { get; set; }
        public UserManager<User> _userManager { get; set; }

        public Create(ApplicationDbContext applicationDbContext, UserManager<User> userManager,
           ISocialObjectManager socialObjectManager)
        {
            _socialObjectManager = socialObjectManager;
            _userManager = userManager;
            _dbContext = applicationDbContext;
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

            public InputModel()
            {
                Console.WriteLine("InputModelCreated");
            }
        }

        public async Task OnGetAsync()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            SocialObject = new SocialObject();
            SocialObject.Name = Input.Name;
            SocialObject.Place = Input.Place;
            SocialObject.Date = Input.Date;
            //T0D0: ввод времени
            SocialObject.ShirtDescription = Input.ShirtDescription;
            SocialObject.FullDescription = Input.FullDescription;
            var user = _userManager.GetUserAsync(User).Result;
            SocialObject.PresenterId = user.Id;
            
            user.OwnObjects.Add(SocialObject);
            _dbContext.Add(SocialObject);
            _dbContext.SaveChanges();
            return RedirectToPage();
        }
    }
}