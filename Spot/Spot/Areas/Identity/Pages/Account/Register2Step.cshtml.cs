﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Humanizer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Spot.Data.Models;

namespace Spot.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class Register2StepModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public Register2StepModel(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }
        
        public string ReturnUrl { get; set; }

        public class InputModel
        {

            public User user { get; set; }

            [Required]
            [Display(Name = "Название организации")]
            public string OrganisationName { get; set; }

            [Required]
            [Display(Name = "Тип организации")]
            public string OrganisationType { get; set; }
            
            [Required]
            [Display(Name = "Фамилия Имя представителя")]
            public string ContactPersonName { get; set; }
            
            [Display(Name = "Телефон")]
            public string Phone { get; set; }
            
            [Display(Name = "Другие контакты")]
            public string OtherContacts { get; set; }
            
            [Display(Name = "Другая информация")]
            public string OtherInformation { get; set; }
        }

        public async Task OnGetAsync(string returnUrl)
        {
            var user = await _userManager.GetUserAsync(User);
            Console.WriteLine("OnGet");
            Console.WriteLine($"Сейчас : {user.Email}");
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl)
        {
            var user = await _userManager.GetUserAsync(User);
            Console.WriteLine("OnPost");
            Console.WriteLine($"Сайчас юзер: {user.Email}");
            returnUrl ??= Url.Content("~/");
            //_user = _userManager.FindByIdAsync(userId).Result;
            //inf = _user.Email;
            if (ModelState.IsValid)
            {
                user.OrganisationName = Input.OrganisationName;
                user.OrganisationType = Input.OrganisationType;
                user.ContactPersonName = Input.ContactPersonName;
                user.OtherContacts = Input.OtherContacts;
                user.OtherInformation = Input.OtherInformation;
                await _userManager.UpdateAsync(user);
                return LocalRedirect(returnUrl);
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
