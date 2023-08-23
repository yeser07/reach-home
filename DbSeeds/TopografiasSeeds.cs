using Reach_Home.Data;
using Reach_Home.Models;

namespace Reach_Home.DbSeeds
{
    public static class TopografiasSeeds
    {
           public static void SeedData(ApplicationDbContext dbContext)
        {
            // Verifica si los datos ya existen antes de agregarlos
            if (!dbContext.Topografias.Any(t => t.topografia_descripcion == "Terreno plano"))
            {
                dbContext.Topografias.Add(new Topografia { topografia_descripcion = "Terreno plano", topografia_activo = true});
            }
            
            if (!dbContext.Topografias.Any(t => t.topografia_descripcion == "Terreno ondulado"))
            {
                dbContext.Topografias.Add(new Topografia { topografia_descripcion = "Terreno ondulado", topografia_activo = true });
            }

             if (!dbContext.Topografias.Any(t => t.topografia_descripcion == "Terreno montañoso"))
            {
                dbContext.Topografias.Add(new Topografia { topografia_descripcion = "Terreno montañoso", topografia_activo = true });
            }

             if (!dbContext.Topografias.Any(t => t.topografia_descripcion == "Terreno con humedales"))
            {
                dbContext.Topografias.Add(new Topografia { topografia_descripcion = "Terreno con humedales", topografia_activo = true });
            }

            if (!dbContext.Topografias.Any(t => t.topografia_descripcion == "Terreno con cuerpos de agua"))
            {
                dbContext.Topografias.Add(new Topografia { topografia_descripcion = "Terreno con cuerpos de agua", topografia_activo = true });
            }
            
            dbContext.SaveChanges();
        }
    }
}