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
            var dev = true;

            Usuario U = NUsuario.BuscarPorEmail(TxtEmail.Text);

            if (!dev)
            {
                if (U != null)
                {
                    if (TxtContrasena.Text.Equals(U.Contrasena))
                    {
                        if (U.Rol.Equals("profesor"))
                        {
                            FrmInicioProfesor FrmInicioProfesor = new FrmInicioProfesor();
                            FrmInicioProfesor.Show();
                        }
                        else
                        {

                            Inicio inicio = new Inicio();
                            inicio.Show();
                        }
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
            else
            {
                Inicio inicio = new Inicio();
                inicio.Show();
            }
        }
    }
}
