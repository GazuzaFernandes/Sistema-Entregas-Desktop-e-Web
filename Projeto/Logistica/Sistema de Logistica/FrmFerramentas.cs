
using DAL.Entities.Logistica;
using DAL.Repository.Logistica;
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
    public partial class FrmFerramentas : Form
    {
        internal Ferramentas _ferramentas;
        public FrmFerramentas()
        {
            InitializeComponent();
        }

        private void FrmFerramentas_Load(object sender, EventArgs e)
        {
            try
            {

                if (_ferramentas == null)
                    _ferramentas = new Ferramentas();
                if (_ferramentas.FerramentaId > 0)
                {
                    _ferramentas = new DLFerramentas().ConsultarPorId(_ferramentas.FerramentaId);
                    txtFerramentaId.Text = _ferramentas.FerramentaId.ToString();
                    dtpRetirada.Value = _ferramentas.Retirada;
                    dtpDevolucao.Value = _ferramentas.Devolucao;
                    txtNome.Text = _ferramentas.Funcionario;
                    rtbEquipamento.Text = _ferramentas.Material;
                    switch (cbSelecionar.Text)//escolha
                    {
                        case "Pendente":
                            {
                                cbSelecionar.Sorted = true;
                            }
                            break;
                        case "Devolvido":
                            {
                                cbSelecionar.Sorted = true;
                            }
                            break;
                    }
                }
                else
                {
                    cbSelecionar.Sorted = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = ValidarCampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtFerramentaId.Text, out id);
                    if (id > 0)
                    {
                        var atualizar = new DLFerramentas().ConsultarPorId(id);
                        atualizar.Devolucao = dtpDevolucao.Value;
                        atualizar.Retirada = dtpRetirada.Value;
                        atualizar.Funcionario = txtNome.Text;
                        atualizar.Material = rtbEquipamento.Text;
                        switch (cbSelecionar.Text)//escolha
                        {
                            case "Pendente":
                                {
                                    cbSelecionar.Sorted = true;
                                }
                                break;
                            case "Devolvido":
                                {
                                    cbSelecionar.Sorted = true;
                                }
                                break;
                        }
                        atualizar.StatusobraId = 3;
                        new DLFerramentas().Atualizar(atualizar);
                        MessageBox.Show("Material devolvido com Sucesso!");
                    }
                    else
                    {
                        var novo = new Ferramentas();
                        novo.Devolucao = dtpDevolucao.Value;
                        novo.Retirada = dtpRetirada.Value;
                        novo.Funcionario = txtNome.Text;
                        novo.Material = rtbEquipamento.Text;
                        switch (cbSelecionar.Text)//escolha
                        {
                            case "Pendente":
                                {
                                    cbSelecionar.Sorted = true;
                                }
                                break;
                            case "Devolvido":
                                {
                                    cbSelecionar.Sorted = true;
                                }
                                break;
                        }
                        var idferramentas = new DLFerramentas().Inserir(novo);
                        MessageBox.Show(" Material " + idferramentas + " Retirado com Sucesso! ");
                    }
                    LimparCampos();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja realmente deletar o material que o funcionario retirou ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtFerramentaId.Text, out id);
                    if (id > 0)
                    {
                        new DLFerramentas().Excluir(new Ferramentas { FerramentaId = id });
                        MessageBox.Show("Ferramenta excluída com sucesso!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("id Invalido");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void dgvFerramentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var ferramenta = dgvFerramentas.Rows[e.RowIndex].DataBoundItem as Ferramentas;
            if(ferramenta != null)
            {
                txtFerramentaId.Text = ferramenta.FerramentaId.ToString();
                txtNome.Text = ferramenta.Funcionario;
                rtbEquipamento.Text = ferramenta.Material;
                dtpRetirada.Value = ferramenta.Retirada;
                dtpDevolucao.Value = ferramenta.Devolucao;
                switch (cbSelecionar.Text)//escolha
                {
                    case "Pendente":
                        {
                            cbSelecionar.Sorted = true;
                        }
                        break;
                    case "Devolvido":
                        {
                            cbSelecionar.Sorted = true;
                        }
                        break;
                }
            }
        }

        #region Campo de Metodos
        private void LimparCampos()
        {
            dtpRetirada.Value = DateTime.Now;
            dtpDevolucao.Value = DateTime.Now;
            txtNome.Text = Convert.ToString(null);
            rtbEquipamento.Text = Convert.ToString(null);
        }
        private bool ValidarCampos()
        {
            if (txtNome.Text == "")
            {
                throw new Exception(" Informe quem Retirou ");
            }
            return true;
        }

        #endregion

    }
}
