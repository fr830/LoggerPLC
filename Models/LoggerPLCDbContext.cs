using Microsoft.EntityFrameworkCore;

namespace LoggerPLC.Models
{
    public class LoggerPLCDbContext : DbContext
    {

        public LoggerPLCDbContext(DbContextOptions<LoggerPLCDbContext> options) : base(options) { }

        public DbSet<Data> Datas { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Error> Errors {get;set;}
    }
}