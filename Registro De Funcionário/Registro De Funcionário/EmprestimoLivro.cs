using System;
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
    public partial class EmprestimoLivro : Form
    {
        public EmprestimoLivro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void EmprestimoLivro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.Empréstimo'. Você pode movê-la ou removê-la conforme necessário.
            this.empréstimoTableAdapter.Fill(this.bibliotecaDataSet.Empréstimo);
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet11.Livro'. Você pode movê-la ou removê-la conforme necessário.
            this.livroTableAdapter1.Fill(this.bibliotecaDataSet11.Livro);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new EmprestimoADD().Show();
            this.Hide();
        }
    }
}
