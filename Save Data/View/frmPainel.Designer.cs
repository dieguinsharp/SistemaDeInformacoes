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
            this.components = new System.ComponentModel.Container();
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.txtSenha = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCelular = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.txtAnotacoes = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSite = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.btnCarregarNovamente = new System.Windows.Forms.Button();
            this.btnAtualizarlinha = new System.Windows.Forms.Button();
            this.btnAdicionarDados = new System.Windows.Forms.Button();
            this.btnDeletarDados = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSenhaAES = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.dtvDados.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtvDados.Location = new System.Drawing.Point(12, 64);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(66, 343);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 22);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.WaterMark = "emailteste@gmail.com";
            this.txtEmail.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.WaterMarkForeColor = System.Drawing.Color.Gray;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(311, 343);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(172, 22);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.WaterMark = "***************";
            this.txtSenha.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txtSenha.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.WaterMarkForeColor = System.Drawing.Color.Gray;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha:";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(796, 343);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(168, 22);
            this.txtCelular.TabIndex = 8;
            this.txtCelular.WaterMark = "(##) ####-####";
            this.txtCelular.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txtCelular.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.WaterMarkForeColor = System.Drawing.Color.Gray;
            // 
            // txtAnotacoes
            // 
            this.txtAnotacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnotacoes.Location = new System.Drawing.Point(1059, 343);
            this.txtAnotacoes.Name = "txtAnotacoes";
            this.txtAnotacoes.Size = new System.Drawing.Size(180, 22);
            this.txtAnotacoes.TabIndex = 9;
            this.txtAnotacoes.WaterMark = "Algo para você se lembrar";
            this.txtAnotacoes.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txtAnotacoes.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnotacoes.WaterMarkForeColor = System.Drawing.Color.Gray;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(970, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Anotações:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(489, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Site:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(729, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Celular:";
            // 
            // txtSite
            // 
            this.txtSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSite.Location = new System.Drawing.Point(534, 343);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(189, 22);
            this.txtSite.TabIndex = 5;
            this.txtSite.WaterMark = "www.siteteste.com.br";
            this.txtSite.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txtSite.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSite.WaterMarkForeColor = System.Drawing.Color.Gray;
            // 
            // btnCarregarNovamente
            // 
            this.btnCarregarNovamente.BackColor = System.Drawing.Color.Gray;
            this.btnCarregarNovamente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarregarNovamente.FlatAppearance.BorderSize = 2;
            this.btnCarregarNovamente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarNovamente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarNovamente.Location = new System.Drawing.Point(304, 26);
            this.btnCarregarNovamente.Name = "btnCarregarNovamente";
            this.btnCarregarNovamente.Size = new System.Drawing.Size(304, 46);
            this.btnCarregarNovamente.TabIndex = 11;
            this.btnCarregarNovamente.Text = "CARREGAR LINHAS NOVAMENTE";
            this.btnCarregarNovamente.UseVisualStyleBackColor = false;
            this.btnCarregarNovamente.Click += new System.EventHandler(this.btnCarregarNovamente_Click);
            // 
            // btnAtualizarlinha
            // 
            this.btnAtualizarlinha.BackColor = System.Drawing.Color.Gray;
            this.btnAtualizarlinha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizarlinha.FlatAppearance.BorderSize = 2;
            this.btnAtualizarlinha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarlinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarlinha.Location = new System.Drawing.Point(923, 26);
            this.btnAtualizarlinha.Name = "btnAtualizarlinha";
            this.btnAtualizarlinha.Size = new System.Drawing.Size(295, 46);
            this.btnAtualizarlinha.TabIndex = 12;
            this.btnAtualizarlinha.Text = "ATUALIZAR LINHA";
            this.btnAtualizarlinha.UseVisualStyleBackColor = false;
            this.btnAtualizarlinha.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdicionarDados
            // 
            this.btnAdicionarDados.BackColor = System.Drawing.Color.Gray;
            this.btnAdicionarDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarDados.FlatAppearance.BorderSize = 2;
            this.btnAdicionarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarDados.Location = new System.Drawing.Point(6, 26);
            this.btnAdicionarDados.Name = "btnAdicionarDados";
            this.btnAdicionarDados.Size = new System.Drawing.Size(292, 46);
            this.btnAdicionarDados.TabIndex = 13;
            this.btnAdicionarDados.Text = "ADICIONAR LINHA";
            this.btnAdicionarDados.UseVisualStyleBackColor = false;
            this.btnAdicionarDados.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDeletarDados
            // 
            this.btnDeletarDados.BackColor = System.Drawing.Color.Gray;
            this.btnDeletarDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletarDados.FlatAppearance.BorderSize = 2;
            this.btnDeletarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarDados.Location = new System.Drawing.Point(618, 26);
            this.btnDeletarDados.Name = "btnDeletarDados";
            this.btnDeletarDados.Size = new System.Drawing.Size(299, 46);
            this.btnDeletarDados.TabIndex = 14;
            this.btnDeletarDados.Text = "DELETAR LINHA";
            this.btnDeletarDados.UseVisualStyleBackColor = false;
            this.btnDeletarDados.Click += new System.EventHandler(this.btnDeletarDados_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Usuário Logado:";
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.Location = new System.Drawing.Point(128, 39);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(20, 16);
            this.lblUsuarioLogado.TabIndex = 17;
            this.lblUsuarioLogado.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(310, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Email:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(355, 39);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(20, 16);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(580, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(629, 39);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(20, 16);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(961, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Senha Criptografia:";
            // 
            // txtSenhaAES
            // 
            this.txtSenhaAES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAES.Location = new System.Drawing.Point(1108, 36);
            this.txtSenhaAES.Name = "txtSenhaAES";
            this.txtSenhaAES.PasswordChar = '*';
            this.txtSenhaAES.Size = new System.Drawing.Size(131, 22);
            this.txtSenhaAES.TabIndex = 23;
            this.txtSenhaAES.WaterMark = "Senha AES";
            this.txtSenhaAES.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txtSenhaAES.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAES.WaterMarkForeColor = System.Drawing.Color.Gray;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(-9, 474);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1267, 11);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(1244, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(14, 530);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(-9, 23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(14, 530);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Location = new System.Drawing.Point(-4, 21);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1267, 10);
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdicionarDados);
            this.groupBox1.Controls.Add(this.btnCarregarNovamente);
            this.groupBox1.Controls.Add(this.btnDeletarDados);
            this.groupBox1.Controls.Add(this.btnAtualizarlinha);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 381);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1224, 87);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MODIFICAR LINHAS";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1252, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.criadorToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Trocar de Conta";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // criadorToolStripMenuItem
            // 
            this.criadorToolStripMenuItem.Name = "criadorToolStripMenuItem";
            this.criadorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.criadorToolStripMenuItem.Text = "Criador";
            this.criadorToolStripMenuItem.Click += new System.EventHandler(this.criadorToolStripMenuItem_Click);
            // 
            // frmPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1252, 482);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtSenhaAES);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAnotacoes);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtvDados);
            this.Controls.Add(this.pictureBox5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPainel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de Usuário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPainel_FormClosed);
            this.Load += new System.EventHandler(this.frmPainel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvDados;
        private System.Windows.Forms.Label label1;
        private ChreneLib.Controls.TextBoxes.CTextBox txtEmail;
        private ChreneLib.Controls.TextBoxes.CTextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private ChreneLib.Controls.TextBoxes.CTextBox txtCelular;
        private ChreneLib.Controls.TextBoxes.CTextBox txtAnotacoes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ChreneLib.Controls.TextBoxes.CTextBox txtSite;
        private System.Windows.Forms.Button btnCarregarNovamente;
        private System.Windows.Forms.Button btnAtualizarlinha;
        private System.Windows.Forms.Button btnAdicionarDados;
        private System.Windows.Forms.Button btnDeletarDados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label8;
        private ChreneLib.Controls.TextBoxes.CTextBox txtSenhaAES;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Site;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anotações;
        private System.Windows.Forms.DataGridViewButtonColumn Criptografar;
        private System.Windows.Forms.DataGridViewButtonColumn Descriptografar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criadorToolStripMenuItem;
    }
}