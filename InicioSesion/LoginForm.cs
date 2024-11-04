using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InicioSesion.Servicio;
using InicioSesion.MOdels;

namespace InicioSesion
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(TbUser.Text.Trim()== "" || TbPassword.Text.Trim() == "")
            {
                MetroMessageBox.Show(this, "No se pueden dejar espacios en blanco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User usuario = new User()
            {
                Users = TbUser.Text,
                Password = TbPassword.Text
            };

            ServicioUsuario servicioUsuario = new ServicioUsuario();

            if(servicioUsuario.ValidateUser(usuario.Users, usuario.Password))
            {
                MetroMessageBox.Show(this, "Bienvenido", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroMessageBox.Show(this, "Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
