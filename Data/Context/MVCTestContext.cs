using Microsoft.EntityFrameworkCore;
using MVCTest.Models;

namespace MVCTest.Data.Context
{
    public class MVCTestContext : DbContext
    {
        private readonly IConfiguration _configStr;

        public DbSet<Person> Person {get; set;}
        public MVCTestContext(IConfiguration config)
        {
            _configStr = config;
        }
        public MVCTestContext(){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectStr = _configStr.GetConnectionString("MvcStr");

            optionsBuilder.UseNpgsql(connectStr);
        }
    }
}