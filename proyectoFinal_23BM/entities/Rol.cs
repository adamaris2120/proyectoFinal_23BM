using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinal_23BM.entities
{
    public class Rol
    {
        [Key]
        public int PkRol { get; set; }
        public string Nombro { get; set; }
        
    }
}
