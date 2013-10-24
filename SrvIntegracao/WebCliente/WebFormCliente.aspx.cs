using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCliente
{
    public partial class WebFormCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxCPF.Text))
            {
                LabelMensagem.Text = "CPF deve ser informado";
                return;
            }

            var _con = new ServicoIntegracao.ServicoIntegracaoClient();

            try
            {
                var _cliente = _con.Pesquisar(TextBoxCPF.Text);

                if (_cliente != null)
                {
                    TextBoxNome.Text = _cliente.nome;
                    TextBoxTelefoneResidencial.Text = _cliente.telefoneresidencial;
                    TextBoxEndereco.Text = _cliente.endereco;

                    if (_cliente.datanascimento.HasValue)
                        TextBoxDataNascimento.Text = _cliente.datanascimento.Value.ToString("dd/MM/yyyy");

                    TextBoxNumeroCelular.Text = _cliente.numerocelular;
                }
                else
                {
                    TextBoxNome.Text = "";
                    TextBoxTelefoneResidencial.Text = "";
                    TextBoxEndereco.Text = "";
                    TextBoxDataNascimento.Text = "";
                    TextBoxNumeroCelular.Text = "";
                    LabelMensagem.Text = "CPF não encontrado";
                }
            }
            catch (Exception Ex)
            {
                LabelMensagem.Text = "Ocorreu o seguinte erro: " + Ex.Message;
            }
        }

        protected void ButtonAtualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxCPF.Text))
            {
                LabelMensagem.Text = "CPF deve ser informado";
                return;
            }

            if (string.IsNullOrEmpty(TextBoxDataNascimento.Text))
            {
                LabelMensagem.Text = "Data de nascimento deve ser informada";
                return;
            }

            if (string.IsNullOrEmpty(TextBoxNumeroCelular.Text))
            {
                LabelMensagem.Text = "Numero do celular deve ser informado!";
                return;
            }

            var _con = new ServicoIntegracao.ServicoIntegracaoClient();
            var _cliente = new ServicoIntegracao.tbCliente()
            {
                cpf = TextBoxCPF.Text,
                datanascimento = Convert.ToDateTime(TextBoxDataNascimento.Text),
                numerocelular = TextBoxNumeroCelular.Text
            };

            try
            {
                _con.Atualizar(_cliente);
                LabelMensagem.Text = "Registro atualizado";
            }
            catch (Exception Ex)
            {
                LabelMensagem.Text = "Ocorreu o seguinte erro: " + Ex.Message;
            }
        }
    }
}