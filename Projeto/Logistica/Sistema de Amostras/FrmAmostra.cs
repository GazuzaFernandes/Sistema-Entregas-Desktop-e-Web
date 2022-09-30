using DALLogistica.Entities;
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

namespace Projeto.Logistica.Sistema_de_Amostras
{
    public partial class FrmAmostra : Form
    {
        internal Amostra _amostracliente;
        public FrmAmostra()
        {
            InitializeComponent();
        }

        private void FrmAmostra_Load(object sender, EventArgs e)
        {
            try
            {               
                if (_amostracliente == null)
                    _amostracliente = new Amostra();
                if (_amostracliente.AmostraId > 0)
                {                   
                    _amostracliente = new DLAmostra().ConsultarPorId(_amostracliente.AmostraId);
                    txtAmostraId.Text = _amostracliente.AmostraId.ToString();
                    dtpDataEntrega.Value = _amostracliente.DataEntrega;
                    rtbComentario.Text = _amostracliente.Material;
                    txtConstrutora.Text = _amostracliente.Construtora;
                    txtObra.Text = _amostracliente.Obra;
                    switch (_amostracliente.StatusobraId)//escolha
                    {
                        case 2:
                            {
                                rbPendente.Checked = true;
                            }
                            break;
                        case 3:
                            {
                                rbFinalizado.Checked = true;
                            }
                            break;
                        case 4:
                            {
                                rbCancelado.Checked = true;
                            }
                            break;
                    }                    
                }
                else
                {
                    rbPendente.Checked = true;
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
                    int.TryParse(txtAmostraId.Text, out id);
                    if (id > 0)
                    {
                        var atualizar = new DLAmostra().ConsultarPorId(id);
                        atualizar.DataEntrega = dtpDataEntrega.Value;
                        atualizar.Construtora = txtConstrutora.Text;
                        atualizar.Obra = txtObra.Text;
                        atualizar.Material = rtbComentario.Text;
                        if (rbPendente.Checked == true)
                            atualizar.StatusobraId = 2;
                        else if (rbFinalizado.Checked == true)
                            atualizar.StatusobraId = 3;
                        else if (rbCancelado.Checked == true)
                            atualizar.StatusobraId = 4;
                        new DLAmostra().Atualizar(atualizar);
                        MessageBox.Show("Amostra Atualizada com Sucesso!");
                        LimparAmostra();
                    }
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
                var pergunta = "Deseja Realmente excluir essa Amostra ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtAmostraId.Text, out id);
                    if (id > 0)
                    {
                        new DLAmostra().Excluir(new Amostra { AmostraId = id });
                        MessageBox.Show("Amostra excluída com sucesso!");
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

        #region Apenas Metodos

        private bool ValidarCampos()
        {
            if (txtConstrutora.Text == "")
            {
                throw new Exception("Informe o Cliente");
            }
            else if (rtbComentario.Text == "")
            {
                throw new Exception("Informe o material");
            }
            return true;
        }
        private void LimparAmostra()
        {
            dtpDataEntrega.Value = DateTime.Now;
            txtConstrutora.Text = Convert.ToString(null);
            txtObra.Text = Convert.ToString(null);
        }
        #endregion

    }
}
