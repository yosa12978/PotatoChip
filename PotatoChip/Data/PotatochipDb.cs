using Microsoft.EntityFrameworkCore;

namespace PotatoChip.Data
{
    public class PotatochipDb : DbContext
    {
        public PotatochipDb(DbContextOptions<PotatochipDb> options) : base(options) 
        {
        
        }
        protected override void OnModelCreating(ModelBuilder builder) 
        {
        
        }
    }
}
