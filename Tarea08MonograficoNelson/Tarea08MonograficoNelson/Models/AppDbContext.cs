using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea08MonograficoNelson.Models;

namespace Tarea08MonograficoNelson.Models
{
    public class AppDbContext : IdentityDbContext
    {
        // public DbSet<Persona> personas { get; set; }
        //  public DbSet<Marca> Marcas { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Modelo> Modelo { get; set; }

        public AppDbContext()
        {   }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Tarea08MonograficoNelson.Models.Estudiantes> Estudiantes { get; set; }

        public DbSet<Tarea08MonograficoNelson.Models.Empleado> Empleado { get; set; }

        public DbSet<Tarea08MonograficoNelson.Models.Profesor> Profesor { get; set; }

        public DbSet<Tarea08MonograficoNelson.Models.Persona> Persona { get; set; }

    }
}
