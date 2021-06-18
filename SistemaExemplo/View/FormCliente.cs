using SistemaExemplo.Controller;
using SistemaExemplo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaExemplo.View
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        public void limparDados()
        {
            textBoxNome.Text = string.Empty;
            textBoxCPF.Text = string.Empty;
            textBoxIdade.Text = string.Empty;
            textBoxLimiteDeCredito.Text = string.Empty;
            checkBoxAtivo.Checked = false;
            dateTimePickerDataNascimento.Value = DateTime.Now;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var Cliente = new Cliente()
                {
                    Nome = textBoxNome.Text,
                    Cpf = textBoxCPF.Text,
                    DataNascimento = dateTimePickerDataNascimento.Value,
                    Idade = textBoxIdade.Text != string.Empty ? int.Parse(textBoxIdade.Text) : null,
                    LimiteDeCredito = textBoxLimiteDeCredito.Text != string.Empty ? decimal.Parse(textBoxIdade.Text) : null,
                    Ativo = checkBoxAtivo.Checked
                };
                ClienteController.Inserir(Cliente);
                dataGridViewListaCliente.DataSource = ClienteController.GetClientes();
                MessageBox.Show("Cliente salvo com sucesso!");
                limparDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
