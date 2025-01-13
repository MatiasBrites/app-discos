using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using dominio;
using negocio;





namespace App_ADO.net_Discos
{
    public partial class frmmain : Form
    {
        private List<Disco> listaDiscos;
        public frmmain()
        {
            InitializeComponent();
            Text = "Disco";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();
            
        }

        private void Cargar() 
        {
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                listaDiscos = negocio.listar();
                dgvDiscos.DataSource = listaDiscos;
                dgvDiscos.Columns["UrlImagen"].Visible = false;
                dgvDiscos.Columns["Id"].Visible = false;
                Cargarimagen(listaDiscos[0].UrlImagen);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {        
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            Cargarimagen(seleccionado.UrlImagen);
            
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaDisco alta = new FrmAltaDisco();
            alta.ShowDialog();
            Cargar();
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Disco seleccionado;
            seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            FrmAltaDisco modificar = new FrmAltaDisco(seleccionado);
            modificar.ShowDialog();
            Cargar();
        }
    }
}
