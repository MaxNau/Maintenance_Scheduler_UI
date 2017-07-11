namespace Maintenance_Scheduler_DAL.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MaintenanceSchedulerContext : DbContext
    {
        public MaintenanceSchedulerContext()
            : base("MaintenanceSchedulerContext")
        {
        }

        public virtual DbSet<qrtz_blob_triggers> qrtz_blob_triggers { get; set; }
        public virtual DbSet<qrtz_calendars> qrtz_calendars { get; set; }
        public virtual DbSet<qrtz_cron_triggers> qrtz_cron_triggers { get; set; }
        public virtual DbSet<qrtz_fired_triggers> qrtz_fired_triggers { get; set; }
        public virtual DbSet<qrtz_job_details> qrtz_job_details { get; set; }
        public virtual DbSet<qrtz_locks> qrtz_locks { get; set; }
        public virtual DbSet<qrtz_paused_trigger_grps> qrtz_paused_trigger_grps { get; set; }
        public virtual DbSet<qrtz_scheduler_state> qrtz_scheduler_state { get; set; }
        public virtual DbSet<qrtz_simple_triggers> qrtz_simple_triggers { get; set; }
        public virtual DbSet<qrtz_simprop_triggers> qrtz_simprop_triggers { get; set; }
        public virtual DbSet<qrtz_triggers> qrtz_triggers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<qrtz_blob_triggers>()
                .Property(e => e.SCHED_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_blob_triggers>()
                .Property(e => e.TRIGGER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_blob_triggers>()
                .Property(e => e.TRIGGER_GROUP)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_calendars>()
                .Property(e => e.SCHED_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_calendars>()
                .Property(e => e.CALENDAR_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_cron_triggers>()
                .Property(e => e.SCHED_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_cron_triggers>()
                .Property(e => e.TRIGGER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_cron_triggers>()
                .Property(e => e.TRIGGER_GROUP)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_cron_triggers>()
                .Property(e => e.CRON_EXPRESSION)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_cron_triggers>()
                .Property(e => e.TIME_ZONE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_fired_triggers>()
                .Property(e => e.SCHED_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_fired_triggers>()
                .Property(e => e.ENTRY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_fired_triggers>()
                .Property(e => e.TRIGGER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_fired_triggers>()
                .Property(e => e.TRIGGER_GROUP)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_fired_triggers>()
                .Property(e => e.INSTANCE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_fired_triggers>()
                .Property(e => e.STATE)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_fired_triggers>()
                .Property(e => e.JOB_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_fired_triggers>()
                .Property(e => e.JOB_GROUP)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_job_details>()
                .Property(e => e.SCHED_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_job_details>()
                .Property(e => e.JOB_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_job_details>()
                .Property(e => e.JOB_GROUP)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_job_details>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_job_details>()
                .Property(e => e.JOB_CLASS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_job_details>()
                .HasMany(e => e.qrtz_triggers)
                .WithRequired(e => e.qrtz_job_details)
                .HasForeignKey(e => new { e.SCHED_NAME, e.JOB_NAME, e.JOB_GROUP })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<qrtz_locks>()
                .Property(e => e.SCHED_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_locks>()
                .Property(e => e.LOCK_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_paused_trigger_grps>()
                .Property(e => e.SCHED_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_paused_trigger_grps>()
                .Property(e => e.TRIGGER_GROUP)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_scheduler_state>()
                .Property(e => e.SCHED_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_scheduler_state>()
                .Property(e => e.INSTANCE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_simple_triggers>()
                .Property(e => e.SCHED_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_simple_triggers>()
                .Property(e => e.TRIGGER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_simple_triggers>()
                .Property(e => e.TRIGGER_GROUP)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_simprop_triggers>()
                .Property(e => e.SCHED_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_simprop_triggers>()
                .Property(e => e.TRIGGER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_simprop_triggers>()
                .Property(e => e.TRIGGER_GROUP)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_simprop_triggers>()
                .Property(e => e.STR_PROP_1)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_simprop_triggers>()
                .Property(e => e.STR_PROP_2)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_simprop_triggers>()
                .Property(e => e.STR_PROP_3)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_triggers>()
                .Property(e => e.SCHED_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_triggers>()
                .Property(e => e.TRIGGER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_triggers>()
                .Property(e => e.TRIGGER_GROUP)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_triggers>()
                .Property(e => e.JOB_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_triggers>()
                .Property(e => e.JOB_GROUP)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_triggers>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_triggers>()
                .Property(e => e.TRIGGER_STATE)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_triggers>()
                .Property(e => e.TRIGGER_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_triggers>()
                .Property(e => e.CALENDAR_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<qrtz_triggers>()
                .HasOptional(e => e.qrtz_blob_triggers)
                .WithRequired(e => e.qrtz_triggers);

            modelBuilder.Entity<qrtz_triggers>()
                .HasOptional(e => e.qrtz_cron_triggers)
                .WithRequired(e => e.qrtz_triggers);

            modelBuilder.Entity<qrtz_triggers>()
                .HasOptional(e => e.qrtz_simple_triggers)
                .WithRequired(e => e.qrtz_triggers);

            modelBuilder.Entity<qrtz_triggers>()
                .HasOptional(e => e.qrtz_simprop_triggers)
                .WithRequired(e => e.qrtz_triggers);
        }
    }
}
