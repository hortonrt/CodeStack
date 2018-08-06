using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace CodeStack.Data.Models {
    public class CodeStackContext : DbContext {
        public CodeStackContext(DbContextOptions<CodeStackContext> options) : base(options) { }

        public static readonly LoggerFactory MyLoggerFactory = new LoggerFactory(new [] { new ConsoleLoggerProvider((_, __) => true, true) });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder
            .UseLoggerFactory(MyLoggerFactory);

        public DbSet<Models.Navigation.Route> Route { get; set; }
    }
}