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
    public partial class livros : Form
    {
        public livros()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=GABRIEL-BRUNETT\SQLEXPRESS;integrated security=SSPI; initial Catalog=Biblioteca");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new adicionarLivro().Show();
            this.Hide();
        }

        private void livros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.Livro'. Você pode movê-la ou removê-la conforme necessário.
            this.livroTableAdapter.Fill(this.bibliotecaDataSet.Livro);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void livroBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
