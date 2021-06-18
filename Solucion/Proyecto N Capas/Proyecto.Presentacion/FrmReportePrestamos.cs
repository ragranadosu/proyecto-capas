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
    public partial class FrmReportePrestamos : Form
    {
        private int total = 0;
        public FrmReportePrestamos()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DgvPrestamos.DataSource = NPrestamo.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmReportePrestamos_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.total = DgvPrestamos.Rows.Count;
            LblTotal.Text = "Total: " + Convert.ToString(this.total);

        }
    }
}
