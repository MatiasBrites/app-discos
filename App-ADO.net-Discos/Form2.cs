using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace App_ADO.net_Discos
{
    public partial class FrmAltaDisco : Form
    {
        private Disco disco = null; 
        public FrmAltaDisco()
        {
            InitializeComponent();
            Text = "Agregar Disco";
        }

        public FrmAltaDisco(Disco disco)
        {
            InitializeComponent();
            this.disco = disco;
            Text = "Modificar Disco";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar() 
        {
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                if (disco == null)
                {
                    disco = new Disco();
                    disco.Titulo = txtTitulo.Text;
                    disco.CantidadCanciones = int.Parse(txtCantCanciones.Text);
                    disco.UrlImagen = txtUrlImagen.Text;
                    disco.Edicion = (Edicion)cboEdicion.SelectedItem;
                    disco.Estilo = (Estilo)cboEstilo.SelectedItem;

                }
                    if (disco.Id != 0)
                    {
                        negocio.modificar(disco);
                        MessageBox.Show("Modificado correctamente");
                    }

                    else
                    {
                        negocio.agregar(disco);
                        MessageBox.Show("Agregado correctamente");
                    }

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAltaDisco_Load(object sender, EventArgs e)
        {
            EdicionNegocio edicionNegocio = new EdicionNegocio();
            EstiloNegocio  estiloNegocio = new EstiloNegocio(); 

            try
            {
                cboEdicion.DataSource = edicionNegocio.listar();
                cboEdicion.ValueMember = "Id";
                cboEdicion.DisplayMember = "Descripcion";
                cboEstilo.DataSource = estiloNegocio.listar();
                cboEstilo.ValueMember = "Id";
                cboEstilo.DisplayMember = "Descripcion";


                if (disco != null)
                {
                    txtTitulo.Text = disco.Titulo;
                    txtCantCanciones.Text = disco.CantidadCanciones.ToString();
                    txtUrlImagen.Text = disco.UrlImagen;
                    Cargarimagen(disco.UrlImagen);
                    cboEdicion.SelectedValue = disco.Edicion.Id;
                    cboEstilo.SelectedValue = disco.Estilo.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            Cargarimagen(txtUrlImagen.Text);
        }

        private void Cargarimagen(string imagen)
        {

            try
            {
                PbImagenTapa.Load(imagen);
            }
            catch (Exception ex)
            {

                PbImagenTapa.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");

            }
        }
    }
}
