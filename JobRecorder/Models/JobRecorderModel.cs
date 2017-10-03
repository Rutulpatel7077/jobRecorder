namespace JobRecorder.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class JobRecorderModel : DbContext
    {
        public JobRecorderModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<job> jobs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<employee>()
                .Property(e => e.employee_name)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.employee_email)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.employee_phone)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .HasMany(e => e.jobs)
                .WithRequired(e => e.employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<job>()
                .Property(e => e.job_position)
                .IsUnicode(false);

            modelBuilder.Entity<job>()
                .Property(e => e.job_description)
                .IsUnicode(false);
        }
    }
}
