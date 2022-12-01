using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "User_Name" && txtSenha.Text == "1234")
            {
                MessageBox.Show("Bem vindo!");
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha inválidos");
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtSenha.Clear();
        }
    }
}
