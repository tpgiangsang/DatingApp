using DatingApp.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Api.Data
{
    // class kế thừa DbContext
    // DbContext là tập hợp nhiều DbSet
    // DbSet là tập hợp nhiều Entity
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Value> Values { get; set; }

    }
}