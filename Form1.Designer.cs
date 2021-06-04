
namespace Cadastro_de_Clientes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DadosPessoais = new System.Windows.Forms.GroupBox();
            this.limparImg = new System.Windows.Forms.Button();
            this.carregarImg = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.PictureBox();
            this.sexo = new System.Windows.Forms.GroupBox();
            this.feminino = new System.Windows.Forms.RadioButton();
            this.masculino = new System.Windows.Forms.RadioButton();
            this.cpfCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telCliente = new System.Windows.Forms.TextBox();
            this.rgCliente = new System.Windows.Forms.TextBox();
            this.nmCliente = new System.Windows.Forms.TextBox();
            this.cdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.Label();
            this.endereco = new System.Windows.Forms.GroupBox();
            this.cidade = new System.Windows.Forms.TextBox();
            this.logradouro = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.TextBox();
            this.cep = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dadosExtra = new System.Windows.Forms.GroupBox();
            this.checkTwitter = new System.Windows.Forms.CheckBox();
            this.checkFacebook = new System.Windows.Forms.CheckBox();
            this.checkEmail = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.twitter = new System.Windows.Forms.TextBox();
            this.facebook = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Incluir = new System.Windows.Forms.Button();
            this.Alterar = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.Exibir = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bairro = new System.Windows.Forms.TextBox();
            this.bairroCliente = new System.Windows.Forms.TextBox();
            this.DadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.sexo.SuspendLayout();
            this.endereco.SuspendLayout();
            this.dadosExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // DadosPessoais
            // 
            this.DadosPessoais.Controls.Add(this.limparImg);
            this.DadosPessoais.Controls.Add(this.carregarImg);
            this.DadosPessoais.Controls.Add(this.img);
            this.DadosPessoais.Controls.Add(this.sexo);
            this.DadosPessoais.Controls.Add(this.cpfCliente);
            this.DadosPessoais.Controls.Add(this.label3);
            this.DadosPessoais.Controls.Add(this.telCliente);
            this.DadosPessoais.Controls.Add(this.rgCliente);
            this.DadosPessoais.Controls.Add(this.nmCliente);
            this.DadosPessoais.Controls.Add(this.cdCliente);
            this.DadosPessoais.Controls.Add(this.label2);
            this.DadosPessoais.Controls.Add(this.label1);
            this.DadosPessoais.Controls.Add(this.nome);
            this.DadosPessoais.Controls.Add(this.codigo);
            this.DadosPessoais.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DadosPessoais.Location = new System.Drawing.Point(12, 54);
            this.DadosPessoais.Name = "DadosPessoais";
            this.DadosPessoais.Size = new System.Drawing.Size(1075, 218);
            this.DadosPessoais.TabIndex = 0;
            this.DadosPessoais.TabStop = false;
            this.DadosPessoais.Text = "Dados Pessoais";
            // 
            // limparImg
            // 
            this.limparImg.Location = new System.Drawing.Point(903, 125);
            this.limparImg.Name = "limparImg";
            this.limparImg.Size = new System.Drawing.Size(162, 82);
            this.limparImg.TabIndex = 13;
            this.limparImg.Text = "Limpar Imagem";
            this.limparImg.UseVisualStyleBackColor = true;
            this.limparImg.Click += new System.EventHandler(this.limparImg_Click);
            // 
            // carregarImg
            // 
            this.carregarImg.Location = new System.Drawing.Point(903, 24);
            this.carregarImg.Name = "carregarImg";
            this.carregarImg.Size = new System.Drawing.Size(162, 84);
            this.carregarImg.TabIndex = 12;
            this.carregarImg.Text = "Carregar Imagem";
            this.carregarImg.UseVisualStyleBackColor = true;
            this.carregarImg.Click += new System.EventHandler(this.carregarImg_Click);
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(686, 24);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(211, 183);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 11;
            this.img.TabStop = false;
            // 
            // sexo
            // 
            this.sexo.Controls.Add(this.feminino);
            this.sexo.Controls.Add(this.masculino);
            this.sexo.Location = new System.Drawing.Point(11, 142);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(210, 65);
            this.sexo.TabIndex = 10;
            this.sexo.TabStop = false;
            this.sexo.Text = "Sexo";
            // 
            // feminino
            // 
            this.feminino.AutoSize = true;
            this.feminino.Location = new System.Drawing.Point(116, 27);
            this.feminino.Name = "feminino";
            this.feminino.Size = new System.Drawing.Size(86, 23);
            this.feminino.TabIndex = 1;
            this.feminino.TabStop = true;
            this.feminino.Text = "Feminino";
            this.feminino.UseVisualStyleBackColor = true;
            // 
            // masculino
            // 
            this.masculino.AutoSize = true;
            this.masculino.Location = new System.Drawing.Point(7, 27);
            this.masculino.Name = "masculino";
            this.masculino.Size = new System.Drawing.Size(94, 23);
            this.masculino.TabIndex = 0;
            this.masculino.TabStop = true;
            this.masculino.Text = "Masculino";
            this.masculino.UseVisualStyleBackColor = true;
            // 
            // cpfCliente
            // 
            this.cpfCliente.Location = new System.Drawing.Point(398, 81);
            this.cpfCliente.Name = "cpfCliente";
            this.cpfCliente.Size = new System.Drawing.Size(282, 27);
            this.cpfCliente.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPF:";
            // 
            // telCliente
            // 
            this.telCliente.Location = new System.Drawing.Point(127, 112);
            this.telCliente.Name = "telCliente";
            this.telCliente.Size = new System.Drawing.Size(265, 27);
            this.telCliente.TabIndex = 7;
            // 
            // rgCliente
            // 
            this.rgCliente.Location = new System.Drawing.Point(71, 81);
            this.rgCliente.Name = "rgCliente";
            this.rgCliente.Size = new System.Drawing.Size(278, 27);
            this.rgCliente.TabIndex = 6;
            // 
            // nmCliente
            // 
            this.nmCliente.Location = new System.Drawing.Point(71, 52);
            this.nmCliente.Name = "nmCliente";
            this.nmCliente.Size = new System.Drawing.Size(609, 27);
            this.nmCliente.TabIndex = 5;
            // 
            // cdCliente
            // 
            this.cdCliente.Location = new System.Drawing.Point(71, 24);
            this.cdCliente.Name = "cdCliente";
            this.cdCliente.Size = new System.Drawing.Size(609, 27);
            this.cdCliente.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tel. Residencial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "RG:";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(14, 55);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(51, 19);
            this.nome.TabIndex = 1;
            this.nome.Text = "Nome:";
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(7, 27);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(58, 19);
            this.codigo.TabIndex = 0;
            this.codigo.Text = "Código:";
            // 
            // endereco
            // 
            this.endereco.Controls.Add(this.cidade);
            this.endereco.Controls.Add(this.bairroCliente);
            this.endereco.Controls.Add(this.logradouro);
            this.endereco.Controls.Add(this.numero);
            this.endereco.Controls.Add(this.cep);
            this.endereco.Controls.Add(this.label8);
            this.endereco.Controls.Add(this.label7);
            this.endereco.Controls.Add(this.label6);
            this.endereco.Controls.Add(this.label5);
            this.endereco.Controls.Add(this.label4);
            this.endereco.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereco.Location = new System.Drawing.Point(12, 279);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(1075, 90);
            this.endereco.TabIndex = 1;
            this.endereco.TabStop = false;
            this.endereco.Text = "Endereço";
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(744, 54);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(321, 27);
            this.cidade.TabIndex = 9;
            // 
            // logradouro
            // 
            this.logradouro.Location = new System.Drawing.Point(355, 24);
            this.logradouro.Name = "logradouro";
            this.logradouro.Size = new System.Drawing.Size(710, 27);
            this.logradouro.TabIndex = 7;
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(71, 54);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(186, 27);
            this.numero.TabIndex = 6;
            // 
            // cep
            // 
            this.cep.Location = new System.Drawing.Point(71, 24);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(186, 27);
            this.cep.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(682, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Bairro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Logradouro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "CEP:";
            // 
            // dadosExtra
            // 
            this.dadosExtra.Controls.Add(this.checkTwitter);
            this.dadosExtra.Controls.Add(this.checkFacebook);
            this.dadosExtra.Controls.Add(this.checkEmail);
            this.dadosExtra.Controls.Add(this.label11);
            this.dadosExtra.Controls.Add(this.label10);
            this.dadosExtra.Controls.Add(this.twitter);
            this.dadosExtra.Controls.Add(this.facebook);
            this.dadosExtra.Controls.Add(this.email);
            this.dadosExtra.Controls.Add(this.label9);
            this.dadosExtra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadosExtra.Location = new System.Drawing.Point(12, 376);
            this.dadosExtra.Name = "dadosExtra";
            this.dadosExtra.Size = new System.Drawing.Size(1075, 130);
            this.dadosExtra.TabIndex = 2;
            this.dadosExtra.TabStop = false;
            this.dadosExtra.Text = "Dados Extras";
            // 
            // checkTwitter
            // 
            this.checkTwitter.AutoSize = true;
            this.checkTwitter.Location = new System.Drawing.Point(942, 86);
            this.checkTwitter.Name = "checkTwitter";
            this.checkTwitter.Size = new System.Drawing.Size(73, 23);
            this.checkTwitter.TabIndex = 8;
            this.checkTwitter.Text = "Twitter";
            this.checkTwitter.UseVisualStyleBackColor = true;
            this.checkTwitter.CheckedChanged += new System.EventHandler(this.checkTwitter_CheckedChanged);
            // 
            // checkFacebook
            // 
            this.checkFacebook.AutoSize = true;
            this.checkFacebook.Location = new System.Drawing.Point(942, 55);
            this.checkFacebook.Name = "checkFacebook";
            this.checkFacebook.Size = new System.Drawing.Size(89, 23);
            this.checkFacebook.TabIndex = 7;
            this.checkFacebook.Text = "Facebook";
            this.checkFacebook.UseVisualStyleBackColor = true;
            this.checkFacebook.CheckedChanged += new System.EventHandler(this.checkFacebook_CheckedChanged);
            // 
            // checkEmail
            // 
            this.checkEmail.AutoSize = true;
            this.checkEmail.Location = new System.Drawing.Point(942, 22);
            this.checkEmail.Name = "checkEmail";
            this.checkEmail.Size = new System.Drawing.Size(64, 23);
            this.checkEmail.TabIndex = 6;
            this.checkEmail.Text = "Email";
            this.checkEmail.UseVisualStyleBackColor = true;
            this.checkEmail.CheckedChanged += new System.EventHandler(this.checkEmail_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 19);
            this.label11.TabIndex = 5;
            this.label11.Text = "Twitter:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "Facebook:";
            // 
            // twitter
            // 
            this.twitter.Location = new System.Drawing.Point(86, 86);
            this.twitter.Name = "twitter";
            this.twitter.ReadOnly = true;
            this.twitter.Size = new System.Drawing.Size(850, 27);
            this.twitter.TabIndex = 3;
            // 
            // facebook
            // 
            this.facebook.Location = new System.Drawing.Point(86, 53);
            this.facebook.Name = "facebook";
            this.facebook.ReadOnly = true;
            this.facebook.Size = new System.Drawing.Size(850, 27);
            this.facebook.TabIndex = 2;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(86, 20);
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Size = new System.Drawing.Size(850, 27);
            this.email.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Email:";
            // 
            // Incluir
            // 
            this.Incluir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Incluir.Location = new System.Drawing.Point(12, 513);
            this.Incluir.Name = "Incluir";
            this.Incluir.Size = new System.Drawing.Size(174, 62);
            this.Incluir.TabIndex = 3;
            this.Incluir.Text = "Incluir";
            this.Incluir.UseVisualStyleBackColor = true;
            this.Incluir.Click += new System.EventHandler(this.Incluir_Click);
            // 
            // Alterar
            // 
            this.Alterar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alterar.Location = new System.Drawing.Point(192, 513);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(174, 62);
            this.Alterar.TabIndex = 4;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = true;
            // 
            // Consultar
            // 
            this.Consultar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultar.Location = new System.Drawing.Point(372, 513);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(174, 62);
            this.Consultar.TabIndex = 5;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Exibir
            // 
            this.Exibir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exibir.Location = new System.Drawing.Point(552, 513);
            this.Exibir.Name = "Exibir";
            this.Exibir.Size = new System.Drawing.Size(174, 62);
            this.Exibir.TabIndex = 6;
            this.Exibir.Text = "Exibir";
            this.Exibir.UseVisualStyleBackColor = true;
            // 
            // Limpar
            // 
            this.Limpar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar.Location = new System.Drawing.Point(732, 513);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(174, 62);
            this.Limpar.TabIndex = 7;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Sair
            // 
            this.Sair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.Location = new System.Drawing.Point(912, 513);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(174, 62);
            this.Sair.TabIndex = 8;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkOrange;
            this.label12.Location = new System.Drawing.Point(400, -8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(404, 59);
            this.label12.TabIndex = 9;
            this.label12.Text = "Cadastro de Cliente";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(355, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(321, 20);
            this.textBox2.TabIndex = 8;
            // 
            // bairro
            // 
            this.bairro.Location = new System.Drawing.Point(355, 54);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(321, 20);
            this.bairro.TabIndex = 8;
            // 
            // bairroCliente
            // 
            this.bairroCliente.Location = new System.Drawing.Point(355, 54);
            this.bairroCliente.Name = "bairroCliente";
            this.bairroCliente.Size = new System.Drawing.Size(321, 27);
            this.bairroCliente.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 587);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Exibir);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.Incluir);
            this.Controls.Add(this.dadosExtra);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.DadosPessoais);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DadosPessoais.ResumeLayout(false);
            this.DadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.sexo.ResumeLayout(false);
            this.sexo.PerformLayout();
            this.endereco.ResumeLayout(false);
            this.endereco.PerformLayout();
            this.dadosExtra.ResumeLayout(false);
            this.dadosExtra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DadosPessoais;
        private System.Windows.Forms.Button limparImg;
        private System.Windows.Forms.Button carregarImg;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.GroupBox sexo;
        private System.Windows.Forms.RadioButton feminino;
        private System.Windows.Forms.RadioButton masculino;
        private System.Windows.Forms.TextBox cpfCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telCliente;
        private System.Windows.Forms.TextBox rgCliente;
        private System.Windows.Forms.TextBox nmCliente;
        private System.Windows.Forms.TextBox cdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.GroupBox endereco;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.TextBox logradouro;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.TextBox cep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox dadosExtra;
        private System.Windows.Forms.CheckBox checkTwitter;
        private System.Windows.Forms.CheckBox checkFacebook;
        private System.Windows.Forms.CheckBox checkEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox twitter;
        private System.Windows.Forms.TextBox facebook;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Incluir;
        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button Exibir;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox bairro;
        private System.Windows.Forms.TextBox bairroCliente;
    }
}

