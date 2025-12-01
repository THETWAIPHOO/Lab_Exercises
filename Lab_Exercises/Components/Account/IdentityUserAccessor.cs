using Lab_Exercises.Data;
using Microsoft.AspNetCore.Identity;

namespace Lab_Exercises.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<Lab_ExercisesUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<Lab_ExercisesUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
