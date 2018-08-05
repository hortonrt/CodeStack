using Microsoft.EntityFrameworkCore;

namespace codestack.Models {
    public class CodeStackContext : DbContext {
        public CodeStackContext (DbContextOptions<CodeStackContext> options) : base (options) { }

        public DbSet<Models.Navigation.Route> Route { get; set; }
    }
}