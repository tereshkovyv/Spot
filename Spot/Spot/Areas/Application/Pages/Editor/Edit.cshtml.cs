using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Spot.DataLayer;
using Spot.DataLayer.Interfaces;
using Spot.DataLayer.Models;

namespace Spot.Areas.Application.Pages.Editor
{
    public class Edit : PageModel
    {
        public IGettable<SocialObject> GettableSocialObjectRepository { get; set; }
        public IAddable<SocialObject> AddableSocialObjectRepository { get; }
        public UserManager<User> _userManager { get; set; }


        public Edit(ApplicationDbContext applicationDbContext, UserManager<User> userManager,
         IGettable<SocialObject> gettableSocialObjectRepository, IAddable<SocialObject> addableSocialObjectRepository)
        {
            GettableSocialObjectRepository = gettableSocialObjectRepository;
            AddableSocialObjectRepository = addableSocialObjectRepository;

            _userManager = userManager;
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

        public async Task OnGetAsync(string socialObjectId)
        {
            if (socialObjectId is null)
                SocialObject = new SocialObject();
            else
                SocialObject = GettableSocialObjectRepository.All
                    .FirstOrDefault(x => x.Id == Convert.ToInt32(socialObjectId));
        }
        public async Task<IActionResult> OnPostAsync()
        {
            SocialObject = GettableSocialObjectRepository.GetByIdOrNull(Input.Id);
            SocialObject.Name = Input.Name;
            SocialObject.Place = Input.Place;
            SocialObject.Date = Input.Date;
            //T0D0: ввод времени
            SocialObject.ShirtDescription = Input.ShirtDescription;
            SocialObject.FullDescription = Input.FullDescription;
            var user = _userManager.GetUserAsync(User).Result;
            SocialObject.PresenterId = user.Id;
            
            user.OwnObjects.Add(SocialObject);
            AddableSocialObjectRepository.Add(SocialObject);
            return RedirectToPage();
        }
    }
}