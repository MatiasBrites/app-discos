using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Estilo

         
    {
        public override string ToString()
        {
            return Descripcion;
        }
        public int Id { get; set; }

        public string Descripcion { get; set; }
    }
}
