using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UnitedBanking.Models;

namespace UnitedBanking.Context
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextoptions)
            : base(contextoptions)
        {

        }
        
        public DbSet<Employees> Employees { get; set; }
    
    }
        
}
