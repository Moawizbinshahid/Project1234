using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project1234.Shared;

namespace Project1234.Server.Data
{
    public class Project1234ServerContext : DbContext
    {
        public Project1234ServerContext (DbContextOptions<Project1234ServerContext> options)
            : base(options)
        {
        }

        public DbSet<Project1234.Shared.Student> Student { get; set; } = default!;
    }
}
