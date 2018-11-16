using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using actividades_complementaria.Models;

namespace actividades_complementaria.Models
{
    public class actividades_complementariaContext : DbContext
    {
        public actividades_complementariaContext (DbContextOptions<actividades_complementariaContext> options)
            : base(options)
        {
        }

        public DbSet<actividades_complementaria.Models.Carrera> carrera { get; set; }

        public DbSet<actividades_complementaria.Models.Organigrama> Organigrama { get; set; }
    }
}
