using Microsoft.EntityFrameworkCore;

namespace DBFirstLibrary
{
    public partial class MyLocalLibraryContext : DbContext
    {
        public MyLocalLibraryContext()
        {
        }

        public MyLocalLibraryContext(DbContextOptions<MyLocalLibraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Books> Books { get; set; }
              

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Books>(entity =>
            {
                entity.HasIndex(e => e.AuthorId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
