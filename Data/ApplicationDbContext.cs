using BlazorCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
        }
        public DbSet<Post> Posts { get; set; }
    }
}