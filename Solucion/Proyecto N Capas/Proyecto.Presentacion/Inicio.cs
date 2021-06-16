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
    public partial class Inicio : Form
    {
        private int childFormNumber = 0;
        private int profesor;
        private int libro;
        private string fecha;

        public Inicio()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
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

        private void ListarProfesores()
        {
            try
            {
                DgvProfesores.DataSource = NUsuario.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void ListarPrestamos()
        {
            try
            {
                if (this.profesor != 0)
                {
                    DgvPrestamos.DataSource = NPrestamo.BuscarPorProfesor(this.profesor);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnBuscarLibro_Click(object sender, EventArgs e)
        {
            DgvLibros.DataSource = NLibro.Buscar(TxtBuscarLibro.Text);  
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.ListarLibros();
            this.ListarProfesores();
            this.ListarPrestamos();
        }

        private void matenimientoLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dateTimePicker.Text);
            FrmMantenimientoLibros frmMantenimientoLibros = new FrmMantenimientoLibros();
            frmMantenimientoLibros.Show();
        }

        private void BtnBuscarProfesor_Click(object sender, EventArgs e)
        {
            DgvProfesores.DataSource = NUsuario.Buscar(TxtBuscarProfesor.Text);
        }

        private void DgvProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.profesor = Convert.ToInt32(DgvProfesores.CurrentRow.Cells["IdUsuario"].Value);
            this.ListarPrestamos();
        }

        private void DgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.libro = Convert.ToInt32(DgvLibros.CurrentRow.Cells["IdLibro"].Value);
        }

        private void BtnPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.profesor != 0 & this.libro != 0)
                {
                    if (!Convert.ToBoolean(DgvLibros.CurrentRow.Cells["Prestado"].Value))
                    {
                        NPrestamo.Insertar(this.libro, this.profesor, dateTimePicker.Value, dateTimePicker.Value);

                        this.ListarPrestamos();
                        this.ListarLibros();
                    }
                    else
                    {
                        MessageBox.Show("El libro se encuentra prestado");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un profesor y un libro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnDevoluciones_Click(object sender, EventArgs e)
        {
            FrmDevoluciones frmDevoluciones = new FrmDevoluciones();
            frmDevoluciones.Show();
        }
    }
}
