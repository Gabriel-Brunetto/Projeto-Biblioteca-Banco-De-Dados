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
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "D:\\Gabriel Brunetto\\Programação De Banco De Dados\\RegistroDeFuncionario\\Registro De Funcionário\\Registro De Funcionário\\BibliotecaDataSet.xsd";
            //SqlCommand cmd = new SqlCommand(); 
            //cmd.Connection = con;
            //con.Open();
            
            new Menu().Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
