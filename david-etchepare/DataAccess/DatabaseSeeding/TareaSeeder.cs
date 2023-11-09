using Microsoft.EntityFrameworkCore; //hay que instalar
//Herramientas/Administrador de paquetes Nuget/Administrar paquetes Nuget para la solución
//buscamos EntityFramework e instalamos:
//Microsoft.EntityFrameworkCore >Seleccionar versión 6
//Microsoft.EntityFrameworkCore.SqlServer
//Microsoft.EntityFrameworkCore.Tools
//Microsoft.EntityFrameworkCore.Design
using david_etchepare.Entities;

namespace david_etchepare.DataAccess.DatabaseSeeding
{
    public class TareaSeeder : IEntitySeeder
    {
        public void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarea>().HasData(
                new Tarea
                {
                    Id = 1,
                    TareaTitle = "Tarea1",
                    TareaDescription = "Detalles de Tarea1",
                    IsCompleted = false,
                },
                new Tarea
                {
                    Id = 2,
                    TareaTitle = "Tarea2",
                    TareaDescription = "Detalles de Tarea2",
                    IsCompleted = false,
                }
                );
        }
    }
}
//completado el seeder probar si funciona con el migration
//abrimos la consola desde Herramientas/Administrador de paquetes nuget/Consola del administrador de paquetes
//utilizamos el comando add-migration Version1 (el nombre lo elegimos nosotros)
//luego Update-Database