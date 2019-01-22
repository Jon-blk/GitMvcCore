using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GitMvcCore.Models
{
    public class GitMvcCoreContext : DbContext
    {
        public GitMvcCoreContext (DbContextOptions<GitMvcCoreContext> options)
            : base(options)
        {
        }

        public DbSet<GitMvcCore.Models.Car> Car { get; set; }
    }
}
