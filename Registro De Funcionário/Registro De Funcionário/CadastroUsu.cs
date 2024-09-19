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

namespace Registro_De_Funcionário
{
    public partial class CadastroUsu : Form
    {
        public CadastroUsu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=GABRIEL-BRUNETT\SQLEXPRESS;integrated security=SSPI; initial Catalog=Biblioteca");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" && textBox2.Text == "")
            {
                MessageBox.Show("Usuario Invalido", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(textBox2.Text == textBox3.Text)
            {
                con.Open();
                string REGISTRO = "insert into usuario values('"+textBox1.Text+"','"+textBox2.Text+"')";
                cmd = new SqlCommand(REGISTRO,con);
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Usuario criado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("As senhas são diferentes", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
