using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.MvcWebUI.Entities
{
    public class CustomIdentityDbContext:IdentityDbContext<CustomIdentityUser,CustomIdentityRole,string>
    {
        public CustomIdentityDbContext(DbContextOptions <CustomIdentityDbContext> options):base(options)
        {

        }
    }
}
