using Microsoft.EntityFrameworkCore;
using WebApplication_TareaII_MVC.Controllers.Empleado;

namespace WebApplication_TareaII_MVC.Controllers.Profesion
{
    public partial class Profesion_Context : DbContext
    {
        public Profesion_Context() { }
        public Profesion_Context(DbContextOptions<Profesion_Context> options) : base(options) { }
        public virtual DbSet<WebApplication_TareaII_MVC.Models.Profesion.registro_profesion> Registros_Profesiones { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-RVLLMUB;Database=TareaII;Trusted_Connection=True;Encrypt=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WebApplication_TareaII_MVC.Models.Profesion.registro_profesion>(entity =>
            {
                entity.ToTable("registroProfesion");
                entity.Property(e => e.nombreProfesion)
                    .HasMaxLength(60)
                    .IsUnicode(false);
                entity.Property(e => e.gradoAcademico)
                    //.HasMaxLength(8)
                    .IsUnicode(false);
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
