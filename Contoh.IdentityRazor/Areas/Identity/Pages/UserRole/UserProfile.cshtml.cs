using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

using Contoh.IdentityRazor.Data;
using Contoh.IdentityRazor.ServiceApplication;
using System.Threading;
using Microsoft.AspNetCore.Authorization;

namespace Contoh.IdentityRazor.Areas.Identity.Pages.UserRole
{
    public class UserProfileModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ITestService _testService;
        public UserProfileModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, ITestService testService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _testService = testService;
        }

        [BindProperty]
        public UserProfile profile { get; set; }

        private async Task LoadAsync(IdentityUser user, CancellationToken cancellationToken)
        {
           // var userName = await _userManager.GetUserNameAsync(user);
           // var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            var UsrProfile = await _testService.GetUserProfileAsync(user.Id, cancellationToken); //Context.UserProfile.SingleOrDefault(x => x.ApplicationUserId.Equals(Model.Id));

            profile = new UserProfile
            {
                ApplicationUserId= UsrProfile.ApplicationUserId,
                ConfirmPassword = UsrProfile.ConfirmPassword,
                Email = UsrProfile.Email,
                FirstName = UsrProfile.FirstName,
                LastName = UsrProfile.LastName,
                OldPassword = UsrProfile.OldPassword,
                Password = UsrProfile.Password,
                ProfilePicture = UsrProfile.ProfilePicture,
                UserProfileId = UsrProfile.UserProfileId

            };
        }


        public async Task<IActionResult> OnGetAsync(CancellationToken cancellationToken)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user, cancellationToken);
            return Page();
        }


    }
}
