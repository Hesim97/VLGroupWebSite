using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VLGroupWebSite.Models.Membership
{
    public class AppRole : IdentityRole<int>
    {
    }


    //public class  AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken
    public class AppUserLogin : IdentityUserLogin<int>
    {
    }

    public class AppUserRole : IdentityUserRole<int>
    {
    }

    public class AppUserClaim : IdentityUserClaim<int>
    {
    }

    public class AppRoleClaim : IdentityRoleClaim<int>
    {
    }

    public class AppUserToken : IdentityUserToken<int>
    {
    }
}
