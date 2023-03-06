using Microsoft.EntityFrameworkCore;
using WebApplication_TareaII_MVC.Controllers.Empleado;

namespace WebApplication_TareaII_MVC.Controllers.Edificio
{
    public partial class Edificio_Context : DbContext
    {
        public Edificio_Context() { }
        public Edificio_Context(DbContextOptions<Edificio_Context> options) : base(options) { }
        public virtual DbSet<WebApplication_TareaII_MVC.Models.Edificio.registro_edificios> Registros_Edificios { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-RVLLMUB;Database=TareaII;Trusted_Connection=True;Encrypt=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WebApplication_TareaII_MVC.Models.Edificio.registro_edificios>(entity =>
            {
                entity.ToTable("edificiosDisponibles");
                entity.Property(e => e.nombreEdificioDisponible)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
