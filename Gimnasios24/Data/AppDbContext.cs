using Microsoft.EntityFrameworkCore;
using Gimnasios24.Model.Domain;


namespace Gimnasios24.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Member> Members { get; set; }
        public DbSet<Machine> Machines {  get; set; }
        public DbSet<GymLocation> GymLocations { get; set; }
        public DbSet<Manager> Employees { get; set; }


    }
}
