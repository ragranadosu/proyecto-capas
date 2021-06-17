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
            BtnActualizar.Visible = false;
            CboxActivo.Visible = false;
            LblActivo.Visible = false;
        }

        private void Limpiar()
        {
            TxtCodigo.Clear();
            TxtTitulo.Clear();
            TxtNumEjemplares.Clear();
            TxtIsbn.Clear();
            TxtAutor.Clear();
            TxtEditorial.Clear();
            TxtAnioEdicion.Clear();
            TxtNumEdicion.Clear();
            TxtPais.Clear();
            TxtIdioma.Clear();
            TxtMateria.Clear();
            TxtNumPaginas.Clear();
            TxtUbicacion.Clear();
            TxtDescripcion.Clear();
            TxtId.Clear();

            CboxActivo.Visible = false;
            LblActivo.Visible = false;
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

                this.Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TxtId.Visible = false;
            BtnActualizar.Visible = false;
            TabGeneral.SelectedIndex = 0;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                NLibro.Actualizar(
                    Convert.ToInt32(TxtId.Text),
                    TxtCodigo.Text.Trim(),
                    TxtTitulo.Text.Trim(),
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
                    Convert.ToBoolean(CboxActivo.SelectedItem)
                    );

                this.Limpiar();
                this.ListarLibros();
                TabGeneral.SelectedIndex = 0;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Visible = true;
            BtnActualizar.Visible = true;
            TabGeneral.SelectedIndex = 1;
            CboxActivo.Visible = true;
            LblActivo.Visible = true;

            TxtId.Text = Convert.ToString(DgvLibros.CurrentRow.Cells["IdLibro"].Value);
            TxtCodigo.Text = Convert.ToString(DgvLibros.CurrentRow.Cells["Codigo"].Value);
            TxtTitulo.Text = Convert.ToString(DgvLibros.CurrentRow.Cells["Titulo"].Value);
            TxtNumEjemplares.Text = Convert.ToString(DgvLibros.CurrentRow.Cells["NumEjemplares"].Value);
            TxtIsbn.Text = Convert.ToString(DgvLibros.CurrentRow.Cells["Isbn"].Value);
            TxtAutor.Text = Convert.ToString(DgvLibros.CurrentRow.Cells["Autor"].Value);
            TxtEditorial.Text = Convert.ToString(DgvLibros.CurrentRow.Cells["Editorial"].Value);
            TxtAnioEdicion.Text = Convert.ToString(DgvLibros.CurrentRow.Cells["AnioEdicion"].Value);
            CboxActivo.SelectedItem = Convert.ToString(DgvLibros.CurrentRow.Cells["Activo"].Value);
            TxtNumEdicion.Text = Convert.ToString(DgvLibros.CurrentRow.Cells["NumEdicion"].Value);
            TxtPais.Text = Convert.ToString(DgvLibros.CurrentRow.Cells["Pais"].Value);
            TxtIdioma.Text = Convert.ToString(DgvLibros.CurrentRow.Cells["Idioma"].Value);
            TxtMateria.Text = Convert.ToString(DgvLibros.CurrentRow.Cells["Materia"].Value);
            TxtNumPaginas.Text = Convert.ToString(DgvLibros.CurrentRow.Cells["NumPaginas"].Value);
            TxtUbicacion.Text = Convert.ToString(DgvLibros.CurrentRow.Cells["Ubicacion"].Value);
            TxtDescripcion.Text = Convert.ToString(DgvLibros.CurrentRow.Cells["Descripcion"].Value);
        }
    }
}
