using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace demomvc.Data
{
    public class ApplicationDbGame:IdentityDbContext
    {
       public ApplicationDbGame(DbContextOptions<ApplicationDbGame> options)
            : base(options)
        {

        }
        public DbSet<demomvc.Models.Games> Dataalumnos { get; set; }
        
 
    }
}