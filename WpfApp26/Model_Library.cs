namespace WpfApp26
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model_Library : DbContext
    {
        public Model_Library()
            : base("name=Model_Library")
        {
        }

        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<InstanceOfBooks> InstanceOfBooks { get; set; }
        public virtual DbSet<Readers> Readers { get; set; }
        public virtual DbSet<SignUpData> SignUpData { get; set; }
        public virtual DbSet<SystemCatalogOfBook> SystemCatalogOfBook { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>()
                .Property(e => e.ISBN)
                .IsFixedLength();

            modelBuilder.Entity<Books>()
                .Property(e => e.AutorOfBook)
                .IsUnicode(false);

            modelBuilder.Entity<Books>()
                .HasMany(e => e.SystemCatalogOfBook)
                .WithMany(e => e.Books)
                .Map(m => m.ToTable("CatalogOfBooks").MapLeftKey("ISBN").MapRightKey("CodeSpaceOfKnowledge"));

            modelBuilder.Entity<InstanceOfBooks>()
                .Property(e => e.AvailabilityInLibrary)
                .IsFixedLength();

            modelBuilder.Entity<InstanceOfBooks>()
                .Property(e => e.ISBN)
                .IsFixedLength();

            modelBuilder.Entity<Readers>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Readers>()
                .Property(e => e.Gender)
                .IsFixedLength();
        }
    }
}
