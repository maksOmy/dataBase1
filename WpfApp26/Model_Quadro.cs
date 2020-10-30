namespace WpfApp26
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model_Quadro : DbContext
    {
        public Model_Quadro()
            : base("name=Model_Quadro")
        {
        }

        public virtual DbSet<Customer_Inform> Customer_Inform { get; set; }
        public virtual DbSet<project_info> project_info { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<user_info> user_info { get; set; }
        public virtual DbSet<worker_info> worker_info { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer_Inform>()
                .Property(e => e.Customer)
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Inform>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Customer_Inform>()
                .Property(e => e.Bank)
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Inform>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Inform>()
                .Property(e => e.AdressCust)
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Inform>()
                .Property(e => e.FioWorker)
                .IsUnicode(false);

            modelBuilder.Entity<project_info>()
                .Property(e => e.ProjectName)
                .IsUnicode(false);

            modelBuilder.Entity<project_info>()
                .Property(e => e.Chief)
                .IsUnicode(false);

            modelBuilder.Entity<project_info>()
                .Property(e => e.Customer)
                .IsUnicode(false);

            modelBuilder.Entity<project_info>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<project_info>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<project_info>()
                .Property(e => e.Bank)
                .IsUnicode(false);

            modelBuilder.Entity<project_info>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<project_info>()
                .Property(e => e.INN)
                .IsUnicode(false);

            modelBuilder.Entity<project_info>()
                .Property(e => e.AddressCust)
                .IsUnicode(false);

            modelBuilder.Entity<project_info>()
                .Property(e => e.FioWorker)
                .IsUnicode(false);

            modelBuilder.Entity<project_info>()
                .Property(e => e.PhoneWorker)
                .IsUnicode(false);

            modelBuilder.Entity<project_info>()
                .HasMany(e => e.worker_info1)
                .WithOptional(e => e.project_info1)
                .HasForeignKey(e => e.ProjectID);

            modelBuilder.Entity<worker_info>()
                .Property(e => e.EmpolyeeName)
                .IsUnicode(false);

            modelBuilder.Entity<worker_info>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<worker_info>()
                .Property(e => e.District)
                .IsUnicode(false);

            modelBuilder.Entity<worker_info>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<worker_info>()
                .Property(e => e.Base)
                .IsUnicode(false);

            modelBuilder.Entity<worker_info>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<worker_info>()
                .Property(e => e.Salary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<worker_info>()
                .Property(e => e.Bonus)
                .HasPrecision(19, 4);

            modelBuilder.Entity<worker_info>()
                .Property(e => e.GrossSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<worker_info>()
                .Property(e => e.Exempt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<worker_info>()
                .Property(e => e.Picture)
                .IsFixedLength();

            modelBuilder.Entity<worker_info>()
                .HasMany(e => e.project_info)
                .WithOptional(e => e.worker_info)
                .HasForeignKey(e => e.WorkerID);
        }
    }
}
