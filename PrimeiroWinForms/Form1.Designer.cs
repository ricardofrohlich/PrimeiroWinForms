namespace PrimeiroWinForms
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
            this.BTOk = new System.Windows.Forms.Button();
            this.BTCancel = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.lblend = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.lblbairro = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblMSG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTOk
            // 
            this.BTOk.Location = new System.Drawing.Point(66, 186);
            this.BTOk.Name = "BTOk";
            this.BTOk.Size = new System.Drawing.Size(162, 63);
            this.BTOk.TabIndex = 6;
            this.BTOk.Text = "Cadastrar";
            this.BTOk.UseVisualStyleBackColor = true;
            this.BTOk.Click += new System.EventHandler(this.BTOk_Click);
            // 
            // BTCancel
            // 
            this.BTCancel.Location = new System.Drawing.Point(234, 186);
            this.BTCancel.Name = "BTCancel";
            this.BTCancel.Size = new System.Drawing.Size(152, 63);
            this.BTCancel.TabIndex = 7;
            this.BTCancel.Text = "Cancelar";
            this.BTCancel.UseVisualStyleBackColor = true;
            this.BTCancel.Click += new System.EventHandler(this.BTCancel_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(66, 12);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(320, 20);
            this.tbNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 41);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "e-mail:";
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(66, 38);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(320, 20);
            this.tbemail.TabIndex = 1;
            // 
            // tbEnd
            // 
            this.tbEnd.Location = new System.Drawing.Point(66, 64);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(320, 20);
            this.tbEnd.TabIndex = 2;
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Location = new System.Drawing.Point(8, 68);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(59, 13);
            this.lblend.TabIndex = 6;
            this.lblend.Text = "Endereço: ";
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(66, 90);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(320, 20);
            this.tbBairro.TabIndex = 3;
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Location = new System.Drawing.Point(9, 93);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(40, 13);
            this.lblbairro.TabIndex = 8;
            this.lblbairro.Text = "Bairro: ";
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(66, 116);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(320, 20);
            this.tbCidade.TabIndex = 4;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(9, 119);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(46, 13);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidade: ";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(66, 142);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(320, 20);
            this.tbTelefone.TabIndex = 5;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(9, 145);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(55, 13);
            this.lblTelefone.TabIndex = 12;
            this.lblTelefone.Text = "Telefone: ";
            // 
            // lblMSG
            // 
            this.lblMSG.AutoSize = true;
            this.lblMSG.Location = new System.Drawing.Point(137, 256);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(0, 13);
            this.lblMSG.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 274);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.tbEnd);
            this.Controls.Add(this.lblend);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.BTCancel);
            this.Controls.Add(this.BTOk);
            this.Name = "Form1";
            this.Text = "Formulário da minha primeira aplicação";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTOk;
        private System.Windows.Forms.Button BTCancel;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblMSG;
    }
}

