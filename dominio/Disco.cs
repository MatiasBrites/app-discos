using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
      public class Disco
    {                   
        public int Id { get; set; }

        [DisplayName("Título")]
        public string Titulo { get; set; }
        [DisplayName("Cantidad Canciones")]
        public int CantidadCanciones { get; set; }

        public string UrlImagen  { get; set; }
       
        public Estilo Estilo { get; set; }
        
        [DisplayName("Edición")]
        public Edicion Edicion { get; set; }
    }
 }
