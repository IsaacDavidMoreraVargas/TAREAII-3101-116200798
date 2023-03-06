using Microsoft.EntityFrameworkCore;
using WebApplication_TareaII_MVC.Controllers.Empleado;

namespace WebApplication_TareaII_MVC.Controllers.Grados
{
    public partial class Grado_Context : DbContext
    {

        public Grado_Context() { }
        public Grado_Context(DbContextOptions<Empleado_Context> options) : base(options) { }
        public virtual DbSet<WebApplication_TareaII_MVC.Models.Grados.registro_grado> Registros_Grados { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-RVLLMUB;Database=TareaII;Trusted_Connection=True;Encrypt=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WebApplication_TareaII_MVC.Models.Grados.registro_grado>(entity =>
            {
                entity.ToTable("gradosAcademicosDisponibles");
                entity.Property(e => e.gradoAcademicoDisponible)
                    .HasMaxLength(20)
                    .IsUnicode(false);
                entity.Property(e => e.idGradoAcademicoDisponible)
                    //.HasMaxLength(8)
                    .IsUnicode(false);
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
