using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                MessageBox.Show("ingresar Usuario");
                return;
                txtUsuario.Focus();
            }
            if (txtClave.Text == "")
            {
                MessageBox.Show("ingresar Clave");
                return;
                txtClave.Focus();
            }
            MessageBox.Show("ingreso al sistema ");
            this.Close();   
        }
    }
}
