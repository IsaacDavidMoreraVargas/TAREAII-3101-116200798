using Microsoft.EntityFrameworkCore;
using WebApplication_TareaII_MVC.Controllers.Edificio;

namespace WebApplication_TareaII_MVC.Controllers.Asociar
{
    public partial class Asociar_Context : DbContext 
    {

        public Asociar_Context() { }
        public Asociar_Context(DbContextOptions<Asociar_Context> options) : base(options) { }
        public virtual DbSet<WebApplication_TareaII_MVC.Models.Asociar.asociar_registro> Registros_registros { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-RVLLMUB;Database=TareaII;Trusted_Connection=True;Encrypt=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WebApplication_TareaII_MVC.Models.Asociar.asociar_registro>(entity =>
            {
                entity.ToTable("registroAsociacion");
                entity.Property(e => e.fechaRegistro)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }

}
