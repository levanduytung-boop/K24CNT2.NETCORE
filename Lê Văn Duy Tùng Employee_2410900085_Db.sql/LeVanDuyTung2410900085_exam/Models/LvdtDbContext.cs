using Microsoft.EntityFrameworkCore;

namespace LeVanDuyTung2410900085_exam.Models
{
    public class LvdtDbContext : DbContext
    {
        public LvdtDbContext(DbContextOptions<LvdtDbContext> options) : base(options)
        {
        }

        public DbSet<LvdtEmployee> LvdtEmployees { get; set; } = null!;
        public DbSet<LvdtStudent> LvdtStudents { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LvdtEmployee>(entity =>
            {
                entity.ToTable("LvdtEmployee");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.LvdtName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.LvdtEmail).HasMaxLength(100);
                entity.Property(e => e.LvdtPhone).HasMaxLength(20);
                entity.Property(e => e.LvdtActive).HasDefaultValue(true);
            });

            modelBuilder.Entity<LvdtStudent>(entity =>
            {
                entity.ToTable("LvdtStudent");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.LvdtName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.LvdtEmail).HasMaxLength(100);
                entity.Property(e => e.LvdtPhone).HasMaxLength(20);
                entity.Property(e => e.LvdtActive).HasDefaultValue(true);
            });
        }
    }
}
