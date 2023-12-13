
using Microsoft.EntityFrameworkCore;
using testDataGrid.Models;

namespace testDataGrid.Context
{
    public class TestDataGridDbContext : DbContext
    {
        public TestDataGridDbContext(DbContextOptions<TestDataGridDbContext> options) : base(options)
        {

        }

        public DbSet<Pays> Pays { get; set; }
        public DbSet<Ville> Villes { get; set; }
    }
}