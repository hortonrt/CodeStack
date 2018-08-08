using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace CodeStack.WebAPI.Data {
    public class CodeStackContext : DbContext {
        public CodeStackContext(DbContextOptions<CodeStackContext> options) : base(options) { }

        public static readonly LoggerFactory MyLoggerFactory = new LoggerFactory(new [] { new ConsoleLoggerProvider((_, __) => true, true) });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder
            .UseLoggerFactory(MyLoggerFactory);

        public DbSet<Entities.Contact> Contact { get; set; }
    }
}