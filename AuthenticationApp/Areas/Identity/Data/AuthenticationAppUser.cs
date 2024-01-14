using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AuthenticationApp.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AuthenticationAppUser class
public class AuthenticationAppUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName = "varchar(100)")]
    public string FirstName { get; set; }

    [PersonalData]
    [Column(TypeName = "varchar(100)")]
    public string LastName { get; set; }

}

