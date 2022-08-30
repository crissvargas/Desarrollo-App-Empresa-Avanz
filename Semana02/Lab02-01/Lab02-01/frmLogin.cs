using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
         
            String[] usuario = {"cvargas","rvargas","mvargas" };
            String[] contraseña = { "Tecsup123","Tecsup123","Tecsup123" };

            if (usuario.Contains(txtUsuario.Text) && contraseña.Contains(txtPassword.Text))
            {
                PrincipalMDI principal = new PrincipalMDI();
                principal.Show();
                this.Hide();
                txtUsuario.Text = "";
                txtPassword.Text = "";
            }
            else
            { 
                Mensaje mensaje = new Mensaje();
                mensaje.Show();
                this.Hide();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
