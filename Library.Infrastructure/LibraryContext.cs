using Microsoft.EntityFrameworkCore;
using Library.Domain.Entities;

namespace Library.Infrastructure
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<User> Users { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Author>(entity =>
        //    {
        //        entity.HasKey(e => e.Id);
        //        entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
        //        entity.Property(e => e.Surname).HasMaxLength(100);
        //        entity.Property(e => e.Patronymic).HasMaxLength(100);

        //        entity.HasMany(e => e.Books)
        //              .WithOne(b => b.Author)
        //              .HasForeignKey(b => b.AuthorId);
        //    });

        //    modelBuilder.Entity<Book>(entity =>
        //    {
        //        entity.HasKey(e => e.Id);
        //        entity.Property(e => e.Name).IsRequired().HasMaxLength(200);
        //        entity.Property(e => e.Genre).HasMaxLength(50);
        //        entity.Property(e => e.PublicationYear).IsRequired();
        //        entity.Property(e => e.IsAvailable).IsRequired();

        //        entity.HasMany(e => e.Rentals)
        //              .WithOne(r => r.Book)
        //              .HasForeignKey(r => r.BookId);
        //    });

        //    modelBuilder.Entity<Rental>(entity =>
        //    {
        //        entity.HasKey(e => e.Id);
        //        entity.Property(e => e.StartDate).IsRequired();
        //        entity.Property(e => e.EndDate).IsRequired();
        //        entity.Property(e => e.Review).HasMaxLength(1000);

        //        entity.HasOne(e => e.Book)
        //              .WithMany(b => b.Rentals)
        //              .HasForeignKey(e => e.BookId);

        //        entity.HasOne(e => e.User)
        //              .WithMany(u => u.Rentals)
        //              .HasForeignKey(e => e.UserId);

        //        entity.HasOne(e => e.Status)
        //              .WithMany(s => s.Rentals)
        //              .HasForeignKey(e => e.StatusId);
        //    });

        //    modelBuilder.Entity<Status>(entity =>
        //    {
        //        entity.HasKey(e => e.Id);
        //        entity.Property(e => e.Name).IsRequired().HasMaxLength(50);

        //        entity.HasMany(e => e.Rentals)
        //              .WithOne(r => r.Status)
        //              .HasForeignKey(r => r.StatusId);
        //    });

        //    modelBuilder.Entity<User>(entity =>
        //    {
        //        entity.HasKey(e => e.Id);
        //        entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
        //        entity.Property(e => e.Surname).HasMaxLength(100);
        //        entity.Property(e => e.Patronymic).HasMaxLength(100);
        //        entity.Property(e => e.Address).HasMaxLength(200);
        //        entity.Property(e => e.ContactNumber).HasMaxLength(20);

        //        entity.HasMany(e => e.Rentals)
        //              .WithOne(r => r.User)
        //              .HasForeignKey(r => r.UserId);
        //    });
        //}
    }
}
