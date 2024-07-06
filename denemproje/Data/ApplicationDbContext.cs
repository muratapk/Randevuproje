﻿using denemproje.Models;
using Microsoft.EntityFrameworkCore;

namespace denemproje.Data
{
    public class ApplicationDbContext : DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        }
        public DbSet<Randevu>? Randevus{ get; set; }
        public DbSet<Admin>? Admins { get; set; }

    }
}
