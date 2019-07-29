using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bocian.Pages
{
    public class IndexModel : PageModel
    {

        private readonly UserManager<IdentityUser> UserManager;

        public IndexModel(UserManager<IdentityUser> UserManager)
        {
           this.UserManager = UserManager;
        }
        public void OnGet()
        {
           create();


        }
        private async void create()
        {
            System.Diagnostics.Debug.WriteLine("create");
            var result = await UserManager.CreateAsync(new IdentityUser("R3kurencja"), "kapp#Ferefsdfs3t3dddDd");
            System.Diagnostics.Debug.WriteLine(result + "XD" + result.Errors);

        }
    }
}
