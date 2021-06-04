using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Clientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void carregarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg|jpeg|*jpeg|png|*png|gif|*.gif";
            if (file.ShowDialog() == DialogResult.OK)
            {
                img.ImageLocation = file.FileName;
            }
        }

        private void limparImg_Click(object sender, EventArgs e)
        {
            img.Image = null;
        }
        private void limparTextBoxes(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = null;
                }
            }
        }
        private void Limpar_Click(object sender, EventArgs e)
        {
            limparTextBoxes(DadosPessoais.Controls);
            limparTextBoxes(endereco.Controls);
            limparTextBoxes(dadosExtra.Controls);
            img.Image = null;
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkEmail_CheckedChanged(object sender, EventArgs e)
        {
            email.ReadOnly = false;
        }

        private void checkFacebook_CheckedChanged(object sender, EventArgs e)
        {
            facebook.ReadOnly = false;
        }

        private void checkTwitter_CheckedChanged(object sender, EventArgs e)
        {
            twitter.ReadOnly = false;
        }

        private void Incluir_Click(object sender, EventArgs e)
        {
            cdCliente.Text = "1234";
            nmCliente.Text = "Pedro Augusto do Nascimento";
            rgCliente.Text = "40.616.040-5";
            cpfCliente.Text = "998.091.370-36";
            telCliente.Text = "98812-1415";
            masculino.Checked = true;
            cep.Text = "11750-000";
            numero.Text = "54";
            logradouro.Text = "Rua João Cordeiro";
            bairroCliente.Text = "Guaraú";
            cidade.Text = "Peruíbe";
            email.Text = "pedrorcpla@gmail.com";
            facebook.Text = "Face do Pedro";
            twitter.Text = "Twitter do Pedro";
            checkEmail.Checked = true;
            checkFacebook.Checked = true;
            checkTwitter.Checked = true;
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            if (cdCliente.Text == "") { cdCliente.Text = "Não cadastrado"; }
            if (nmCliente.Text == "") { nmCliente.Text = "Não cadastrado"; }
            if (rgCliente.Text == "") { rgCliente.Text = "Não cadastrado"; }
            if (cpfCliente.Text == "") { cpfCliente.Text = "Não cadastrado"; }
            if (telCliente.Text == "") { telCliente.Text = "Não cadastrado"; }
            string sexo = "Não cadastrado";
            if (masculino.Checked == true) { sexo = "Masculino"; }
            if (feminino.Checked == true) { sexo = "Feminino"; }
            if (cep.Text == "") { cep.Text = "Não cadastrado"; }
            if (numero.Text == "") { numero.Text = "Não cadastrado"; }
            if (logradouro.Text == "") { logradouro.Text = "Não cadastrado"; }
            if (bairroCliente.Text == "") { bairroCliente.Text = "Não cadastrado"; }
            if (cidade.Text == "") { cidade.Text = "Não cadastrado"; }
            if (email.Text == "") { email.Text = "Não cadastrado"; }
            if (facebook.Text == "") { facebook.Text = "Não cadastrado"; }
            if (twitter.Text == "") { twitter.Text = "Não cadastrado"; }

            MessageBox.Show("Código: "+ cdCliente.Text + "; \nNome: " + nmCliente.Text + "; \nRG: " + rgCliente.Text + "; \nCPF: " + cpfCliente.Text + "; \nTelefone: " + telCliente.Text + "; \nSexo: " + sexo + "; \nCEP: " + cep.Text + "; \nNúmero: " + numero.Text + "; \nLogradouro: " + logradouro.Text + "; \nBairro: " + bairroCliente.Text + "; \nCidade: " + cidade.Text + "; \nEmail: " + email.Text + "; \nFacebook: " + facebook.Text + "; \nTwitter: " + twitter.Text + ".", "Consultar Dados", MessageBoxButtons.OK);
        }
    }
}
