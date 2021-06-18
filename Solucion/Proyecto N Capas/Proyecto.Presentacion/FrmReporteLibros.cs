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
    public partial class FrmReporteLibros : Form
    {
        private int total = 0;
        public FrmReporteLibros()
        {
            InitializeComponent();
        }

        private void Listar()
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

        private void FrmReporteLibros_Load(object sender, EventArgs e)
        {
            this.Listar();
            total = DgvLibros.Rows.Count;
            LblTotal.Text = "Total: " + Convert.ToString(total);
        }
    }
}
