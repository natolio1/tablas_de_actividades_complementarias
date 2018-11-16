using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using actividades_complementaria.Models;

namespace actividades_complementaria.Data
{
    public class DbInitializer
    {
        public static void Initializer(actividades_complementariaContext context)
        {
            context.Database.EnsureCreated();
            if (context.carrera.Any())
            {
                return;
            }
            var carrera = new Carrera[]
            {
                //
            };
            foreach (Carrera a in carrera)
            {
                context.carrera.Add(a);
            }
            context.SaveChanges();
        }
    }
}
