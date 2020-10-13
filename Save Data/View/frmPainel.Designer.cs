namespace Save_Data {
    partial class frmPainel {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPainel));
            this.dtvDados = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anotações = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Criptografar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Descriptografar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSite = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCelular = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAnotacoes = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAdicionar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCarregarNovamente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDeletarDados = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btAtualizarlinha = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtSenhaAES = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvDados
            // 
            this.dtvDados.AllowUserToAddRows = false;
            this.dtvDados.AllowUserToDeleteRows = false;
            this.dtvDados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Email,
            this.Senha,
            this.Site,
            this.Celular,
            this.Anotações,
            this.Criptografar,
            this.Descriptografar});
            this.dtvDados.EnableHeadersVisualStyles = false;
            this.dtvDados.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtvDados.Location = new System.Drawing.Point(12, 108);
            this.dtvDados.Name = "dtvDados";
            this.dtvDados.ReadOnly = true;
            this.dtvDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvDados.Size = new System.Drawing.Size(1228, 270);
            this.dtvDados.TabIndex = 0;
            this.dtvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvDados_CellClick);
            this.dtvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvDados_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // Senha
            // 
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            // 
            // Site
            // 
            this.Site.HeaderText = "Site";
            this.Site.Name = "Site";
            this.Site.ReadOnly = true;
            this.Site.Width = 150;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 150;
            // 
            // Anotações
            // 
            this.Anotações.HeaderText = "Anotações";
            this.Anotações.Name = "Anotações";
            this.Anotações.ReadOnly = true;
            this.Anotações.Width = 335;
            // 
            // Criptografar
            // 
            this.Criptografar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Criptografar.HeaderText = "";
            this.Criptografar.Name = "Criptografar";
            this.Criptografar.ReadOnly = true;
            this.Criptografar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Criptografar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Criptografar.Text = "Criptografar";
            this.Criptografar.ToolTipText = "Criptografar";
            this.Criptografar.UseColumnTextForButtonValue = true;
            // 
            // Descriptografar
            // 
            this.Descriptografar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Descriptografar.HeaderText = "";
            this.Descriptografar.Name = "Descriptografar";
            this.Descriptografar.ReadOnly = true;
            this.Descriptografar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Descriptografar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Descriptografar.Text = "Descriptografar";
            this.Descriptografar.UseColumnTextForButtonValue = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Usuário Logado:";
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.Location = new System.Drawing.Point(128, 83);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(20, 16);
            this.lblUsuarioLogado.TabIndex = 17;
            this.lblUsuarioLogado.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(310, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Email:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(355, 83);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(20, 16);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(580, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(629, 83);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(20, 16);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(961, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Senha Criptografia:";
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Hint = " teste@email.com";
            this.txtEmail.Location = new System.Drawing.Point(12, 387);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(240, 23);
            this.txtEmail.TabIndex = 24;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Depth = 0;
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Hint = "******************";
            this.txtSenha.Location = new System.Drawing.Point(258, 387);
            this.txtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(240, 23);
            this.txtSenha.TabIndex = 25;
            this.txtSenha.UseSystemPasswordChar = false;
            // 
            // txtSite
            // 
            this.txtSite.Depth = 0;
            this.txtSite.ForeColor = System.Drawing.Color.Black;
            this.txtSite.Hint = " www.siteteste.com.br";
            this.txtSite.Location = new System.Drawing.Point(504, 387);
            this.txtSite.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSite.Name = "txtSite";
            this.txtSite.PasswordChar = '\0';
            this.txtSite.SelectedText = "";
            this.txtSite.SelectionLength = 0;
            this.txtSite.SelectionStart = 0;
            this.txtSite.Size = new System.Drawing.Size(240, 23);
            this.txtSite.TabIndex = 26;
            this.txtSite.UseSystemPasswordChar = false;
            // 
            // txtCelular
            // 
            this.txtCelular.Depth = 0;
            this.txtCelular.ForeColor = System.Drawing.Color.Black;
            this.txtCelular.Hint = " (##) #### - ####";
            this.txtCelular.Location = new System.Drawing.Point(750, 387);
            this.txtCelular.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.PasswordChar = '\0';
            this.txtCelular.SelectedText = "";
            this.txtCelular.SelectionLength = 0;
            this.txtCelular.SelectionStart = 0;
            this.txtCelular.Size = new System.Drawing.Size(240, 23);
            this.txtCelular.TabIndex = 27;
            this.txtCelular.UseSystemPasswordChar = false;
            // 
            // txtAnotacoes
            // 
            this.txtAnotacoes.Depth = 0;
            this.txtAnotacoes.ForeColor = System.Drawing.Color.Black;
            this.txtAnotacoes.Hint = " Algo para se lembrar";
            this.txtAnotacoes.Location = new System.Drawing.Point(996, 387);
            this.txtAnotacoes.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAnotacoes.Name = "txtAnotacoes";
            this.txtAnotacoes.PasswordChar = '\0';
            this.txtAnotacoes.SelectedText = "";
            this.txtAnotacoes.SelectionLength = 0;
            this.txtAnotacoes.SelectionStart = 0;
            this.txtAnotacoes.Size = new System.Drawing.Size(244, 23);
            this.txtAnotacoes.TabIndex = 28;
            this.txtAnotacoes.UseSystemPasswordChar = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Depth = 0;
            this.btnAdicionar.Location = new System.Drawing.Point(12, 425);
            this.btnAdicionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Primary = true;
            this.btnAdicionar.Size = new System.Drawing.Size(300, 46);
            this.btnAdicionar.TabIndex = 29;
            this.btnAdicionar.Text = "ADICIONAR DADOS";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnCarregarNovamente
            // 
            this.btnCarregarNovamente.Depth = 0;
            this.btnCarregarNovamente.Location = new System.Drawing.Point(318, 425);
            this.btnCarregarNovamente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCarregarNovamente.Name = "btnCarregarNovamente";
            this.btnCarregarNovamente.Primary = true;
            this.btnCarregarNovamente.Size = new System.Drawing.Size(300, 46);
            this.btnCarregarNovamente.TabIndex = 30;
            this.btnCarregarNovamente.Text = "CARREGAR LINHAS NOVAMENTE";
            this.btnCarregarNovamente.UseVisualStyleBackColor = true;
            this.btnCarregarNovamente.Click += new System.EventHandler(this.btnCarregarNovamente_Click_1);
            // 
            // btnDeletarDados
            // 
            this.btnDeletarDados.Depth = 0;
            this.btnDeletarDados.Location = new System.Drawing.Point(624, 425);
            this.btnDeletarDados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeletarDados.Name = "btnDeletarDados";
            this.btnDeletarDados.Primary = true;
            this.btnDeletarDados.Size = new System.Drawing.Size(300, 46);
            this.btnDeletarDados.TabIndex = 31;
            this.btnDeletarDados.Text = "DELETAR LINHA";
            this.btnDeletarDados.UseVisualStyleBackColor = true;
            this.btnDeletarDados.Click += new System.EventHandler(this.btnDeletarDados_Click_1);
            // 
            // btAtualizarlinha
            // 
            this.btAtualizarlinha.Depth = 0;
            this.btAtualizarlinha.Location = new System.Drawing.Point(930, 425);
            this.btAtualizarlinha.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAtualizarlinha.Name = "btAtualizarlinha";
            this.btAtualizarlinha.Primary = true;
            this.btAtualizarlinha.Size = new System.Drawing.Size(310, 46);
            this.btAtualizarlinha.TabIndex = 32;
            this.btAtualizarlinha.Text = "ATUALIZAR LINHA";
            this.btAtualizarlinha.UseVisualStyleBackColor = true;
            this.btAtualizarlinha.Click += new System.EventHandler(this.btAtualizarlinha_Click);
            // 
            // txtSenhaAES
            // 
            this.txtSenhaAES.Depth = 0;
            this.txtSenhaAES.ForeColor = System.Drawing.Color.Black;
            this.txtSenhaAES.Hint = " **************";
            this.txtSenhaAES.Location = new System.Drawing.Point(1108, 79);
            this.txtSenhaAES.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenhaAES.Name = "txtSenhaAES";
            this.txtSenhaAES.PasswordChar = '*';
            this.txtSenhaAES.SelectedText = "";
            this.txtSenhaAES.SelectionLength = 0;
            this.txtSenhaAES.SelectionStart = 0;
            this.txtSenhaAES.Size = new System.Drawing.Size(132, 23);
            this.txtSenhaAES.TabIndex = 33;
            this.txtSenhaAES.UseSystemPasswordChar = false;
            // 
            // frmPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1252, 488);
            this.Controls.Add(this.txtSenhaAES);
            this.Controls.Add(this.btAtualizarlinha);
            this.Controls.Add(this.btnDeletarDados);
            this.Controls.Add(this.btnCarregarNovamente);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtAnotacoes);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtvDados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPainel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de Usuário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPainel_FormClosed);
            this.Load += new System.EventHandler(this.frmPainel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvDados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Site;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anotações;
        private System.Windows.Forms.DataGridViewButtonColumn Criptografar;
        private System.Windows.Forms.DataGridViewButtonColumn Descriptografar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenha;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSite;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCelular;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAnotacoes;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdicionar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCarregarNovamente;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeletarDados;
        private MaterialSkin.Controls.MaterialRaisedButton btAtualizarlinha;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenhaAES;
    }
}