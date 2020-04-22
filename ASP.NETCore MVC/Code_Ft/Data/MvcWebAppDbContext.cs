using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Code_Ft.Models;

namespace Code_Ft.Data
{
    public class MvcWebAppDbContext : DbContext
    {
        public MvcWebAppDbContext(DbContextOptions<MvcWebAppDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Product> Products { get; set;}
    }
}