using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class ModelsContext : IdentityDbContext
    {
        public ModelsContext(DbContextOptions<ModelsContext> options)
            : base(options)
        {
        }
    }
}
