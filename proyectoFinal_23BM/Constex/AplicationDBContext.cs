using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using proyectoFinal_23BM.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinal_23BM.Constex
{
    public class AplicationDBContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySQL("server= localhost; database= ProyectoDB23BM; user=root; password=arispato");

        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Rol>Roles { get; set; }
    }
}
