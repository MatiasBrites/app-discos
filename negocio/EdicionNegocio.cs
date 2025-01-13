using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class EdicionNegocio
    {
        public List<Edicion> listar()
        {


            List<Edicion> lista = new List<Edicion>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetConsulta("select Id,Descripcion from TIPOSEDICION");
                datos.EjecutarLectura();



                while (datos.Lector.Read())
                {
                    Edicion aux = new Edicion();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }



                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                datos.CerrarConexion();
            }

        }
    }
}
