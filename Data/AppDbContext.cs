using Microsoft.EntityFrameworkCore;
using MiAp.Models;

namespace MiAp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<TaskItem> Tasks => Set<TaskItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed some initial demo tasks for the Kanban board
        modelBuilder.Entity<TaskItem>().HasData(
            new TaskItem
            {
                Id = Guid.Parse("f91ba5a9-dc96-419b-a010-8b1e16f731c2"),
                Title = "Diseñar base de datos de tareas",
                Description = "Crear la estructura del modelo TaskItem y configurar EF Core con SQLite.",
                Status = "in-progress",
                Priority = "high",
                CreatedAt = DateTime.UtcNow
            },
            new TaskItem
            {
                Id = Guid.Parse("e24b45ef-2ef0-4824-be21-1779ba31c8ad"),
                Title = "Implementar manejo global de errores",
                Description = "Añadir IExceptionHandler para formatear errores con RFC 7807.",
                Status = "done",
                Priority = "high",
                CreatedAt = DateTime.UtcNow.AddHours(-2)
            },
            new TaskItem
            {
                Id = Guid.Parse("15c1e5ba-1941-477d-9bfb-93ff9ad32ea5"),
                Title = "Agregar logging estructurado con Serilog",
                Description = "Configurar Serilog para guardar trazas en consola y archivos.",
                Status = "todo",
                Priority = "low",
                CreatedAt = DateTime.UtcNow
            }
        );
    }
}
