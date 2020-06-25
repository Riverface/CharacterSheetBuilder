using Microsoft.EntityFrameworkCore;

namespace Viewer.Models
{
    public class ViewerContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }

        public ViewerContext(DbContextOptions<ViewerContext> options) : base(options)
        {

        }
        
    }
}