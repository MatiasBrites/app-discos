using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using dominio;
using System.Net;

namespace negocio
{
    public class DiscoNegocio
    {
        public List<Disco> listar()
        {


        List<Disco> lista = new List<Disco>();
        AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetConsulta("select D.Id, Titulo, CantidadCanciones, UrlImagenTapa, T.Descripcion Edicion, E.Descripcion Estilos,D.IdEstilo,D.IdTipoEdicion from DISCOS D, TIPOSEDICION T, ESTILOS E where D.IdEstilo = E.Id and D.IdTipoEdicion = T.Id");
                datos.EjecutarLectura();

               

                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    if (!(datos.Lector["UrlImagenTapa"] is DBNull ) )
                    {
                        aux.UrlImagen = (string)datos.Lector["UrlImagenTapa"];
                    }
                    aux.Edicion = new Edicion();
                    aux.Estilo = new Estilo();
                    aux.Edicion.Id = (int)datos.Lector["IdTipoEdicion"];
                    aux.Estilo.Id = (int)datos.Lector["IdEstilo"];
                    aux.Edicion.Descripcion = (string)datos.Lector["Edicion"];
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilos"];
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

        public void agregar(Disco nuevo) 
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetConsulta("insert into DISCOS(Titulo, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion)values('"+ nuevo.Titulo + "'," + nuevo.CantidadCanciones + ", @IdUrlImagen,@IdEstilo, @IdEdicion)");
                datos.SetearParametros("@IdEstilo", nuevo.Estilo.Id);
                datos.SetearParametros("@IdEdicion", nuevo.Edicion.Id);
                datos.SetearParametros("@IdUrlImagen", nuevo.UrlImagen);
                datos.EjecutarAccion();
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
        public void modificar(Disco modificar) 
        {
            AccesoDatos datos = new AccesoDatos();    
            try
            {
                datos.SetConsulta("update DISCOS set Titulo = @Titulo,CantidadCanciones = @CantCanciones,UrlImagenTapa = @UrlImagen,IdEstilo = @IdEstilo, IdTipoEdicion = @IdTipoEdicion where Id = @Id");

                datos.SetearParametros("@Titulo", modificar.Titulo);
                datos.SetearParametros("@CantCanciones", modificar.CantidadCanciones);
                datos.SetearParametros("@UrlImagen", modificar.UrlImagen);
                datos.SetearParametros("@IdEstilo", modificar.Estilo.Id);
                datos.SetearParametros("@IdTipoEdicion", modificar.Edicion.Id);
                datos.SetearParametros("@Id", modificar.Id);
                datos.EjecutarAccion();   


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
