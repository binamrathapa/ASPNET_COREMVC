using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ECommerce_API.Models;

namespace ECommerce_API.Data
{
    public class ECommerce_APIContext : DbContext
    {
        public ECommerce_APIContext (DbContextOptions<ECommerce_APIContext> options)
            : base(options)
        {
        }

        public DbSet<ECommerce_API.Models.Category> Category { get; set; } = default!;
    }
}
