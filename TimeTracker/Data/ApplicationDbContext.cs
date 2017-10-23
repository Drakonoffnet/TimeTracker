﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TimeTracker.Models;
using TimeTracker.Models.DAL;

namespace TimeTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Team> Teams { get; set; } 

        public DbSet<OutOfWork> OutOfWork { get; set; }

        public DbSet<Project> Projects { get; set; }
        public DbSet<StatusTask> StatusTask { get; set; }
        public DbSet<TaskWork> Tasks { get; set; }
        public DbSet<TaskDefaultValue> TaskDefaultValues { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }
        public DbSet<TimeExecute> TimeExecute { get; set; } 
    }
}
