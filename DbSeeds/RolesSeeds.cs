using System;
using Microsoft.EntityFrameworkCore;
using Reach_Home.Data;
using Reach_Home.Models;

namespace Reach_Home.DbSeeds
{
    public static class RolesSeeds
    {
         public static void SeedData(ApplicationDbContext dbContext)
        {
            // Verifica si los datos ya existen antes de agregarlos
            if (!dbContext.Roles.Any(r => r.rol_descripcion == "Administrador"))
            {
                dbContext.Roles.Add(new Rol { rol_descripcion = "Administrador" });
            }
            
            if (!dbContext.Roles.Any(r => r.rol_descripcion == "Agente"))
            {
                dbContext.Roles.Add(new Rol { rol_descripcion = "Agente" });
            }

             if (!dbContext.Roles.Any(r => r.rol_descripcion == "Usuario"))
            {
                dbContext.Roles.Add(new Rol { rol_descripcion = "Usuario" });
            }
            
            dbContext.SaveChanges();
        }
        
    }
}