﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_De_Funcionário
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new livros().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new EmprestimoLivro().Show();
            this.Hide();
        }
    }
}
