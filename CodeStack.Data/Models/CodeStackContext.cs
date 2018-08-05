using Microsoft.EntityFrameworkCore;

namespace CodeStack.Data.Models {
    public class CodeStackContext : DbContext {
        public CodeStackContext(DbContextOptions<CodeStackContext> options) : base(options) { }

        public DbSet<Models.Navigation.Route> Route { get; set; }
    }
}