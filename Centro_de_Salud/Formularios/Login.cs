using CapaLogica;
using CapaModelo;
using interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {


                string user = txtUsuario.Text.Trim();
                string pass = txtContraseña.Text.Trim();

                UsuarioLN servicio = new UsuarioLN();
                Usuario objetoUsuario = servicio.ValidarLogin(user, pass);
                

                if (objetoUsuario != null)
                {
                    MessageBox.Show($"Bienvenido {objetoUsuario.usuario}", "Éxito");

                    Sesion.UsuarioLogueado = objetoUsuario;

                    // ABRIR FORMULARIO PRINCIPAL
                    // Le pasamos el objetoUsuario al constructor para que el Main sepa quién entró
                    this.Hide();
                    Menu menu = new Menu(objetoUsuario);
                    menu.ShowDialog();
                    limpiar();
                    this.Show();



                }
                else
                {
                    MessageBox.Show("Usuario Inactivo o credenciales incorrectos.");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void limpiar()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        

        private void btnVerContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.PasswordChar == '*')
            {
                txtContraseña.PasswordChar = '\0'; // Muestra la contraseña real
            }
            else
            {
                // Si no hay máscara, volvemos a poner el asterisco
                txtContraseña.PasswordChar = '*';
            }
        }

       
    }
}
