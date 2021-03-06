﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using kl753916MIS4200.Models;

namespace kl753916MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            // add the SetInitializer statement here
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, kl753916MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        public DbSet<customer> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet <OrderDetail> OrderDetails { get; set; }

        //These are for the SD2
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }


        // add this method - it will be used later
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }

}