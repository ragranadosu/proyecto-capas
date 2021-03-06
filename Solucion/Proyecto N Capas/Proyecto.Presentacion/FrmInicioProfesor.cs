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
    public partial class FrmInicioProfesor : Form
    {
        public FrmInicioProfesor()
        {
            InitializeComponent();
        }

        private void formato()
        {
            DgvListado.Columns[0].HeaderText = "Id del libro";
            DgvListado.Columns[4].HeaderText = "Numero ejemplares";
            DgvListado.Columns[5].HeaderText = "Acrónimo ISBN";
            DgvListado.Columns[8].HeaderText = "Año Edición";
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NLibro.Listar();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DgvListado.DataSource = NLibro.Buscar(TxtBuscar.Text);
        }

        private void FrmInicioProfesor_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.formato();
        }
    }
}
