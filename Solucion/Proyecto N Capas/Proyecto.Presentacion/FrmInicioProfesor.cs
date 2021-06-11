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

        private void Listar()
        {
            try
            {
                //DgvListado .DataSource = NLibro
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void FrmInicioProfesor_Load(object sender, EventArgs e)
        {

        }
    }
}
