using Microsoft.EntityFrameworkCore;

namespace TAREA_MODULO.AppMVCCodeFirst.Models
{
    public class TareaDbContext: DbContext
    {
        public TareaDbContext(DbContextOptions<TareaDbContext> options) : base(options) { }
        public DbSet<Empleado> Empleados { get; set; }

        public DbSet<Alumno> Alumnos { get; set; }
    }

}
