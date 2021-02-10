using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Context
{
    public class ProjectContext : IdentityDbContext<AppUser>
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }

        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<AppUser> AppUsers { get; set; }
    }
}
