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

        private void Formato()
        {
            DgvLibros.Columns[0].HeaderText = "Id del libro";
            DgvLibros.Columns[5].HeaderText = "ISBN";
            DgvLibros.Columns[8].HeaderText = "Año Edición";

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
            this.Formato();
            total = DgvLibros.Rows.Count;
            LblTotal.Text = "Total: " + Convert.ToString(total);
        }
    }
}
