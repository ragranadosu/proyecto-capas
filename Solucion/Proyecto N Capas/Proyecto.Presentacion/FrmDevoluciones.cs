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
    public partial class FrmDevoluciones : Form
    {
        private int profesor;
        private int prestamo;
        private int libro;
        
        public FrmDevoluciones()
        {
            InitializeComponent();
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

        private void BtnBuscarProfesor_Click(object sender, EventArgs e)
        {
            DgvProfesores.DataSource = NUsuario.Buscar(TxtBuscarProfesor.Text);
        }

        private void BtnDevolver_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.profesor != 0 & this.prestamo != 0)
                {
                    NPrestamo.Devolver(this.prestamo, this.libro);

                    this.prestamo = 0;
                    this.libro = 0;

                    this.ListarPrestamos();
                }
                else
                {
                    MessageBox.Show("Se debe seleccionar un profesor y un prestamo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DgvProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.profesor = Convert.ToInt32(DgvProfesores.CurrentRow.Cells["IdUsuario"].Value);
            this.ListarPrestamos();
        }

        private void DgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.prestamo = Convert.ToInt32(DgvPrestamos.CurrentRow.Cells["IdPrestamo"].Value);
            this.libro = Convert.ToInt32(DgvPrestamos.CurrentRow.Cells["Libro"].Value);
        }

        private void FrmDevoluciones_Load(object sender, EventArgs e)
        {
            this.ListarProfesores();
        }
    }
}
