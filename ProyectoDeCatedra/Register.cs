using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDeCatedra
{
    public partial class Register : Form
    {
        ProyectoDataContext obj = new ProyectoDataContext();
        
        public Register()
        {
            InitializeComponent();
        }

        private void btnSiCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Login = new Login();
            Login.Show(this);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int id = 1;
        obj.RegistrarUsuario(id ,txtNombre.Text, txtNacionalidad.Text, txtCorreo.Text, dFechaNacimiento.Value, txtTelefono.Text, txtGenero.Text, txtPassword.Text, rdbEmpleador.Text);

            
            id++;
        }
    }
}
