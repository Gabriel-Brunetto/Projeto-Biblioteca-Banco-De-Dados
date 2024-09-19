using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Registro_De_Funcionário
{
    public partial class EmprestimoADD : Form
    {
        public EmprestimoADD()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=GABRIEL-BRUNETT\SQLEXPRESS;integrated security=SSPI; initial Catalog=Biblioteca");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string EMPRESTIMO = "INSERT INTO Empréstimo (Data_Empréstimo, Data_Devolução) VALUES ('" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "')";
            SqlCommand cmd = new SqlCommand(EMPRESTIMO, con);
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Livro adicionado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new EmprestimoLivro().Show();
            this.Hide();
        }

        private void EmprestimoADD_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.Livro'. Você pode movê-la ou removê-la conforme necessário.
            this.livroTableAdapter.Fill(this.bibliotecaDataSet.Livro);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new EmprestimoLivro().Show();
            this.Hide();
        }
    }
}
