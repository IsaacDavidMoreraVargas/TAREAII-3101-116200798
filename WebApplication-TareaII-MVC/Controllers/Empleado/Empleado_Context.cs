using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication_TareaII_MVC.Controllers.Empleado
{
    public partial class Empleado_Context : DbContext
    {
        public Empleado_Context() { }
        public Empleado_Context(DbContextOptions<Empleado_Context> options) : base(options) { }
        public virtual DbSet<WebApplication_TareaII_MVC.Models.Empleado.registro_empleados> Registros_Empleados { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-RVLLMUB;Database=TareaII;Trusted_Connection=True;Encrypt=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WebApplication_TareaII_MVC.Models.Empleado.registro_empleados>(entity =>
            {
                entity.ToTable("registroEmpleados");
                entity.Property(e => e.nombreEmpleado)
                    .HasMaxLength(60)
                    .IsUnicode(false);
                entity.Property(e => e.cedulaEmpleado)
                    //.HasMaxLength(8)
                    .IsUnicode(false);
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}
