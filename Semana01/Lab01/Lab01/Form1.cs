using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String dni = txtDni.Text;
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String direccion = txtDireccion.Text;
            String telefono = txtTelefono.Text;
            String email = txtEmail.Text;
            String fechaNac = txtFechaNac.Text;
            String departamento = txtDepartamento.Text;
            dgvUsuarios.Rows.Add("", dni, nombre, apellido,direccion,telefono,email,fechaNac,departamento);
        }
    }
}
