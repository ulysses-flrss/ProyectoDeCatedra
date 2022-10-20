using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDeCatedra
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnNoCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Register = new Register();
            Register.Show(this);
        }
    }
}
