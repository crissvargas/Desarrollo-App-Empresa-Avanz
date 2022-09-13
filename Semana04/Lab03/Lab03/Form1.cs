﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab03
{
    public partial class Form1 : Form
    {
            SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    MessageBox.Show("Conexión Cerrada Satisfactoriamente!");
                }
                else
                    MessageBox.Show("La conexion ya esta cerrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cerrar la conexion: \n"+
                    ex.ToString());
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            String servidor = txtServidor.Text;
            String bd = txtBaseDatos.Text;
            String user = txtUsuario.Text;
            String pwd = txtPassword.Text;

            String str = "Server=" + servidor + ";DataBase=" + bd + ";";

            if (chkAutenticacion.Checked)
                str += "Integrated Security=true";
            else
                str += "UserId" + user + ";Password=" + pwd + ";";

            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Conectado Satisfactoriamente!");
                btnDesconectar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar el servidor: \n" + ex.ToString());
            }
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    MessageBox.Show("Estado del Servidor: " + conn.State +
                        "\nVersión del Servidor: " + conn.ServerVersion +
                        "\nBase de datos: " + conn.Database);
                else
                {
                    MessageBox.Show("Estado del servidor: " + conn.State);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible determinar el estado del servidor: \n"+
                    ex.ToString());
            }
        }

        private void chkAutenticacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutenticacion.Checked)
            {
                txtUsuario.Enabled=false;
                txtPassword.Enabled=false;
            }
            else
            {
                txtUsuario.Enabled=true;
                txtPassword.Enabled=true;
            }
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(conn);
            persona.Show();

        }
    }
}
