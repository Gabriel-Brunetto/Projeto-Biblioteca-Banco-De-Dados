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
    public partial class adicionarLivro : Form
    {
        public adicionarLivro()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
    }
}
