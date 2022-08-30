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
    public partial class manUsuario : Form
    {
        public manUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            string telefono = txtTelefono.Text;
            string direcion = txtDireccion.Text;
            string email = txtEmail.Text;
            string fechaNac = datePickerFechaNac.Text;
            dgvUsuarios.Rows.Add("", dni, nombre, apellidos, direcion, telefono, email, fechaNac);
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
