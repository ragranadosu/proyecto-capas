using Proyecto.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Presentacion
{
    public partial class FrmMantenimientoLibros : Form
    {
        public FrmMantenimientoLibros()
        {
            InitializeComponent();
        }

        private void ListarLibros()
        {
            try
            {
                DgvLibros.DataSource = NLibro.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgvLibros.Columns[0].Visible = false;
            TxtId.Visible = false;
        }

        private void FrmMantenimientoLibros_Load(object sender, EventArgs e)
        {
            this.Formato();
            this.ListarLibros();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DgvLibros.DataSource = NLibro.Buscar(TxtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                NLibro.Insertar(
                    TxtCodigo.Text.Trim(),
                    TxtTitulo.Text.Trim(),
                    false,
                    Convert.ToInt32(TxtNumEjemplares.Text),
                    TxtIsbn.Text.Trim(),
                    TxtAutor.Text.Trim(),
                    TxtEditorial.Text.Trim(),
                    TxtAnioEdicion.Text.Trim(),
                    Convert.ToInt32(TxtNumEdicion.Text),
                    TxtPais.Text.Trim(),
                    TxtIdioma.Text.Trim(),
                    TxtMateria.Text.Trim(),
                    Convert.ToInt32(TxtNumPaginas.Text),
                    TxtUbicacion.Text.Trim(),
                    TxtDescripcion.Text.Trim(),
                    true
                    );

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
