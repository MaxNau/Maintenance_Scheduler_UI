namespace Maintenance_Scheduler_DAL.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LogsDb : DbContext
    {
        public LogsDb()
            : base("name=LogsDb")
        {
        }

        public virtual DbSet<log> logs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<log>()
                .Property(e => e.log_thread)
                .IsUnicode(false);

            modelBuilder.Entity<log>()
                .Property(e => e.log_level)
                .IsUnicode(false);

            modelBuilder.Entity<log>()
                .Property(e => e.log_logger)
                .IsUnicode(false);

            modelBuilder.Entity<log>()
                .Property(e => e.log_message)
                .IsUnicode(false);

            modelBuilder.Entity<log>()
                .Property(e => e.log_exception)
                .IsUnicode(false);
        }
    }
}
