using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Registro_De_Funcionário
{
    public partial class adicionarLivro : Form
    {
        public adicionarLivro()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=GABRIEL-BRUNETT\SQLEXPRESS;integrated security=SSPI; initial Catalog=Biblioteca");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void button4_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Livro Inválido", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();
                string LIVRO = "INSERT INTO Livro (Título, Data_Publicação) VALUES ('" + textBox1.Text + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "')";
                SqlCommand cmd = new SqlCommand(LIVRO, con);
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Livro adicionado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void adicionarLivro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
