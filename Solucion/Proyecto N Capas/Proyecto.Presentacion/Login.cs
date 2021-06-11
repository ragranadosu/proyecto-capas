using Proyecto.Entidades;
using Proyecto.Negocio;
using System;
using System.Windows.Forms;

namespace Proyecto.Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Usuario U = NUsuario.BuscarPorEmail(TxtEmail.Text);

            if (U != null)
            {
                Console.WriteLine(U.Contrasena);
                if (TxtContrasena.Text.Equals(U.Contrasena))
                {
                    Inicio inicio = new Inicio();
                    inicio.Show();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas", "Error");
                }
            }
            else
            {
                MessageBox.Show("usuario no encontrado", "Error");
            }
        }
    }
}
