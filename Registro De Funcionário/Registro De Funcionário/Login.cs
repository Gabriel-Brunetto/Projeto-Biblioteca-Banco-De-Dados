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

namespace Registro_De_Funcionário
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CadastroUsu().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=GABRIEL-BRUNETT\SQLEXPRESS;integrated security=SSPI; initial Catalog=Biblioteca";
            SqlCommand cmd = new SqlCommand(); 
            cmd.Connection = con;
            con.Open();
            string login = "SELECT*FROM usuario where usuario='" +userText.Text+ "'and senha='" + passText.Text + "'";
            cmd = new SqlCommand(login,con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read() == true)
            {
                new Menu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario Invalido", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
