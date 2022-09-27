using DALLogistica.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Logistica.Sistema_de_Logistica
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
        }
        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean temUsuario = false;
                var listaUsuarios = new DLUsuario().Listar();
                for (int i = 0; i < listaUsuarios.Count; i++)
                {
                    if (listaUsuarios[i].Senha == txtSenha.Text)
                    {
                        temUsuario = true;
                    }
                }
                if (temUsuario == true)
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Senha inválida!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario cancelou a solicitação!");
            Close();
        }
    }
}
