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

        }

        private void BtnDevolver_Click(object sender, EventArgs e)
        {

        }

        private void DgvProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.profesor = Convert.ToInt32(DgvProfesores.CurrentRow.Cells["IdUsuario"].Value);
            this.ListarPrestamos();
        }

        private void DgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmDevoluciones_Load(object sender, EventArgs e)
        {
            this.ListarProfesores();
        }
    }
}
