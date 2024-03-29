﻿
namespace EstoquIN.View
{
    partial class Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupInfoCliente = new System.Windows.Forms.GroupBox();
            this.txtClienteEndereco = new System.Windows.Forms.TextBox();
            this.lblClienteEndereco = new System.Windows.Forms.Label();
            this.lblClienteObs = new System.Windows.Forms.Label();
            this.txtClienteObs = new System.Windows.Forms.RichTextBox();
            this.lblClienteCnpj = new System.Windows.Forms.Label();
            this.txtClienteRazao = new System.Windows.Forms.TextBox();
            this.txtClienteNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtClienteCnpj = new System.Windows.Forms.TextBox();
            this.lblClienteNomeFantasia = new System.Windows.Forms.Label();
            this.lblClienteRazao = new System.Windows.Forms.Label();
            this.txtClienteInscricao = new System.Windows.Forms.TextBox();
            this.lblClienteInscricao = new System.Windows.Forms.Label();
            this.btnClienteAdicionar = new FontAwesome.Sharp.IconButton();
            this.btnClienteEditar = new FontAwesome.Sharp.IconButton();
            this.dataClientes = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRazao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInscricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContatoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContatoEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContatoTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFreqCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClienteCancelar = new FontAwesome.Sharp.IconButton();
            this.groupContatoCliente = new System.Windows.Forms.GroupBox();
            this.lblClienteContatoTelefone = new System.Windows.Forms.Label();
            this.txtClienteContatoTelefone = new System.Windows.Forms.TextBox();
            this.lblClienteContatoEmail = new System.Windows.Forms.Label();
            this.lblClienteContatoNome = new System.Windows.Forms.Label();
            this.txtClienteContatoNome = new System.Windows.Forms.TextBox();
            this.txtClienteContatoEmail = new System.Windows.Forms.TextBox();
            this.btnClienteExcluir = new FontAwesome.Sharp.IconButton();
            this.groupInfoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).BeginInit();
            this.groupContatoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInfoCliente
            // 
            this.groupInfoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupInfoCliente.Controls.Add(this.txtClienteEndereco);
            this.groupInfoCliente.Controls.Add(this.lblClienteEndereco);
            this.groupInfoCliente.Controls.Add(this.lblClienteObs);
            this.groupInfoCliente.Controls.Add(this.txtClienteObs);
            this.groupInfoCliente.Controls.Add(this.lblClienteCnpj);
            this.groupInfoCliente.Controls.Add(this.txtClienteRazao);
            this.groupInfoCliente.Controls.Add(this.txtClienteNomeFantasia);
            this.groupInfoCliente.Controls.Add(this.txtClienteCnpj);
            this.groupInfoCliente.Controls.Add(this.lblClienteNomeFantasia);
            this.groupInfoCliente.Controls.Add(this.lblClienteRazao);
            this.groupInfoCliente.Controls.Add(this.txtClienteInscricao);
            this.groupInfoCliente.Controls.Add(this.lblClienteInscricao);
            this.groupInfoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupInfoCliente.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.groupInfoCliente.ForeColor = System.Drawing.Color.White;
            this.groupInfoCliente.Location = new System.Drawing.Point(11, 10);
            this.groupInfoCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupInfoCliente.Name = "groupInfoCliente";
            this.groupInfoCliente.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupInfoCliente.Size = new System.Drawing.Size(961, 442);
            this.groupInfoCliente.TabIndex = 21;
            this.groupInfoCliente.TabStop = false;
            this.groupInfoCliente.Text = "Informações empresariais";
            // 
            // txtClienteEndereco
            // 
            this.txtClienteEndereco.BackColor = System.Drawing.SystemColors.Menu;
            this.txtClienteEndereco.Location = new System.Drawing.Point(51, 273);
            this.txtClienteEndereco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteEndereco.MaxLength = 100;
            this.txtClienteEndereco.Name = "txtClienteEndereco";
            this.txtClienteEndereco.Size = new System.Drawing.Size(371, 34);
            this.txtClienteEndereco.TabIndex = 17;
            // 
            // lblClienteEndereco
            // 
            this.lblClienteEndereco.AutoSize = true;
            this.lblClienteEndereco.ForeColor = System.Drawing.Color.White;
            this.lblClienteEndereco.Location = new System.Drawing.Point(46, 242);
            this.lblClienteEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteEndereco.Name = "lblClienteEndereco";
            this.lblClienteEndereco.Size = new System.Drawing.Size(93, 28);
            this.lblClienteEndereco.TabIndex = 16;
            this.lblClienteEndereco.Text = "Endereço";
            // 
            // lblClienteObs
            // 
            this.lblClienteObs.AutoSize = true;
            this.lblClienteObs.ForeColor = System.Drawing.Color.White;
            this.lblClienteObs.Location = new System.Drawing.Point(483, 242);
            this.lblClienteObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteObs.Name = "lblClienteObs";
            this.lblClienteObs.Size = new System.Drawing.Size(123, 28);
            this.lblClienteObs.TabIndex = 11;
            this.lblClienteObs.Text = "Observações";
            // 
            // txtClienteObs
            // 
            this.txtClienteObs.BackColor = System.Drawing.SystemColors.Menu;
            this.txtClienteObs.Location = new System.Drawing.Point(488, 273);
            this.txtClienteObs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteObs.MaxLength = 65000;
            this.txtClienteObs.Name = "txtClienteObs";
            this.txtClienteObs.Size = new System.Drawing.Size(398, 128);
            this.txtClienteObs.TabIndex = 10;
            this.txtClienteObs.Text = "";
            // 
            // lblClienteCnpj
            // 
            this.lblClienteCnpj.AutoSize = true;
            this.lblClienteCnpj.ForeColor = System.Drawing.Color.White;
            this.lblClienteCnpj.Location = new System.Drawing.Point(46, 44);
            this.lblClienteCnpj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteCnpj.Name = "lblClienteCnpj";
            this.lblClienteCnpj.Size = new System.Drawing.Size(56, 28);
            this.lblClienteCnpj.TabIndex = 0;
            this.lblClienteCnpj.Text = "CNPJ";
            // 
            // txtClienteRazao
            // 
            this.txtClienteRazao.BackColor = System.Drawing.SystemColors.Menu;
            this.txtClienteRazao.Location = new System.Drawing.Point(488, 75);
            this.txtClienteRazao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteRazao.MaxLength = 80;
            this.txtClienteRazao.Name = "txtClienteRazao";
            this.txtClienteRazao.Size = new System.Drawing.Size(398, 34);
            this.txtClienteRazao.TabIndex = 3;
            // 
            // txtClienteNomeFantasia
            // 
            this.txtClienteNomeFantasia.BackColor = System.Drawing.SystemColors.Menu;
            this.txtClienteNomeFantasia.Location = new System.Drawing.Point(488, 173);
            this.txtClienteNomeFantasia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteNomeFantasia.MaxLength = 80;
            this.txtClienteNomeFantasia.Name = "txtClienteNomeFantasia";
            this.txtClienteNomeFantasia.Size = new System.Drawing.Size(398, 34);
            this.txtClienteNomeFantasia.TabIndex = 9;
            // 
            // txtClienteCnpj
            // 
            this.txtClienteCnpj.BackColor = System.Drawing.SystemColors.Menu;
            this.txtClienteCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClienteCnpj.Location = new System.Drawing.Point(51, 76);
            this.txtClienteCnpj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteCnpj.MaxLength = 22;
            this.txtClienteCnpj.Name = "txtClienteCnpj";
            this.txtClienteCnpj.Size = new System.Drawing.Size(371, 34);
            this.txtClienteCnpj.TabIndex = 1;
            // 
            // lblClienteNomeFantasia
            // 
            this.lblClienteNomeFantasia.AutoSize = true;
            this.lblClienteNomeFantasia.ForeColor = System.Drawing.Color.White;
            this.lblClienteNomeFantasia.Location = new System.Drawing.Point(483, 142);
            this.lblClienteNomeFantasia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteNomeFantasia.Name = "lblClienteNomeFantasia";
            this.lblClienteNomeFantasia.Size = new System.Drawing.Size(141, 28);
            this.lblClienteNomeFantasia.TabIndex = 8;
            this.lblClienteNomeFantasia.Text = "Nome Fantasia";
            // 
            // lblClienteRazao
            // 
            this.lblClienteRazao.AutoSize = true;
            this.lblClienteRazao.ForeColor = System.Drawing.Color.White;
            this.lblClienteRazao.Location = new System.Drawing.Point(483, 44);
            this.lblClienteRazao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteRazao.Name = "lblClienteRazao";
            this.lblClienteRazao.Size = new System.Drawing.Size(122, 28);
            this.lblClienteRazao.TabIndex = 2;
            this.lblClienteRazao.Text = "Razão Social";
            // 
            // txtClienteInscricao
            // 
            this.txtClienteInscricao.BackColor = System.Drawing.SystemColors.Menu;
            this.txtClienteInscricao.Location = new System.Drawing.Point(51, 173);
            this.txtClienteInscricao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteInscricao.MaxLength = 20;
            this.txtClienteInscricao.Name = "txtClienteInscricao";
            this.txtClienteInscricao.Size = new System.Drawing.Size(371, 34);
            this.txtClienteInscricao.TabIndex = 7;
            // 
            // lblClienteInscricao
            // 
            this.lblClienteInscricao.AutoSize = true;
            this.lblClienteInscricao.ForeColor = System.Drawing.Color.White;
            this.lblClienteInscricao.Location = new System.Drawing.Point(46, 142);
            this.lblClienteInscricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteInscricao.Name = "lblClienteInscricao";
            this.lblClienteInscricao.Size = new System.Drawing.Size(166, 28);
            this.lblClienteInscricao.TabIndex = 6;
            this.lblClienteInscricao.Text = "Inscrição Estadual";
            // 
            // btnClienteAdicionar
            // 
            this.btnClienteAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.btnClienteAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteAdicionar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnClienteAdicionar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClienteAdicionar.IconColor = System.Drawing.Color.Black;
            this.btnClienteAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClienteAdicionar.Location = new System.Drawing.Point(980, 338);
            this.btnClienteAdicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClienteAdicionar.Name = "btnClienteAdicionar";
            this.btnClienteAdicionar.Size = new System.Drawing.Size(194, 55);
            this.btnClienteAdicionar.TabIndex = 24;
            this.btnClienteAdicionar.Text = "Adicionar";
            this.btnClienteAdicionar.UseVisualStyleBackColor = false;
            this.btnClienteAdicionar.Click += new System.EventHandler(this.btnClienteAdicionar_Click);
            // 
            // btnClienteEditar
            // 
            this.btnClienteEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnClienteEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteEditar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteEditar.ForeColor = System.Drawing.Color.White;
            this.btnClienteEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClienteEditar.IconColor = System.Drawing.Color.Black;
            this.btnClienteEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClienteEditar.Location = new System.Drawing.Point(1176, 338);
            this.btnClienteEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClienteEditar.Name = "btnClienteEditar";
            this.btnClienteEditar.Size = new System.Drawing.Size(188, 55);
            this.btnClienteEditar.TabIndex = 25;
            this.btnClienteEditar.Text = "Editar";
            this.btnClienteEditar.UseVisualStyleBackColor = false;
            this.btnClienteEditar.Click += new System.EventHandler(this.btnClienteEditar_Click);
            // 
            // dataClientes
            // 
            this.dataClientes.AllowUserToAddRows = false;
            this.dataClientes.AllowUserToDeleteRows = false;
            this.dataClientes.AllowUserToResizeColumns = false;
            this.dataClientes.AllowUserToResizeRows = false;
            this.dataClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.dataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnCnpj,
            this.ColumnRazao,
            this.ColumnInscricao,
            this.ColumnNomeFantasia,
            this.ColumnObs,
            this.ColumnContatoNome,
            this.ColumnContatoEmail,
            this.ColumnContatoTelefone,
            this.ColumnEndereco,
            this.ColumnFreqCompra});
            this.dataClientes.Location = new System.Drawing.Point(12, 458);
            this.dataClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataClientes.Name = "dataClientes";
            this.dataClientes.RowHeadersVisible = false;
            this.dataClientes.RowHeadersWidth = 51;
            this.dataClientes.RowTemplate.Height = 25;
            this.dataClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataClientes.Size = new System.Drawing.Size(1352, 302);
            this.dataClientes.TabIndex = 23;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "Id";
            this.ColumnId.FillWeight = 25F;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            // 
            // ColumnCnpj
            // 
            this.ColumnCnpj.DataPropertyName = "Cnpj";
            this.ColumnCnpj.HeaderText = "Cnpj";
            this.ColumnCnpj.Name = "ColumnCnpj";
            // 
            // ColumnRazao
            // 
            this.ColumnRazao.DataPropertyName = "Razao";
            this.ColumnRazao.HeaderText = "Razão Social";
            this.ColumnRazao.Name = "ColumnRazao";
            // 
            // ColumnInscricao
            // 
            this.ColumnInscricao.DataPropertyName = "Inscricao";
            this.ColumnInscricao.HeaderText = "Inscricao";
            this.ColumnInscricao.Name = "ColumnInscricao";
            // 
            // ColumnNomeFantasia
            // 
            this.ColumnNomeFantasia.DataPropertyName = "NomeFantasia";
            this.ColumnNomeFantasia.HeaderText = "Nome Fantasia";
            this.ColumnNomeFantasia.Name = "ColumnNomeFantasia";
            // 
            // ColumnObs
            // 
            this.ColumnObs.DataPropertyName = "Obs";
            this.ColumnObs.HeaderText = "Observação";
            this.ColumnObs.Name = "ColumnObs";
            // 
            // ColumnContatoNome
            // 
            this.ColumnContatoNome.DataPropertyName = "ContatoNome";
            this.ColumnContatoNome.HeaderText = "Contato Nome";
            this.ColumnContatoNome.Name = "ColumnContatoNome";
            // 
            // ColumnContatoEmail
            // 
            this.ColumnContatoEmail.DataPropertyName = "ContatoEmail";
            this.ColumnContatoEmail.HeaderText = "Contato Email";
            this.ColumnContatoEmail.Name = "ColumnContatoEmail";
            // 
            // ColumnContatoTelefone
            // 
            this.ColumnContatoTelefone.DataPropertyName = "ContatoTelefone";
            this.ColumnContatoTelefone.HeaderText = "Contato Telefone";
            this.ColumnContatoTelefone.Name = "ColumnContatoTelefone";
            // 
            // ColumnEndereco
            // 
            this.ColumnEndereco.DataPropertyName = "Endereco";
            this.ColumnEndereco.HeaderText = "Endereço";
            this.ColumnEndereco.Name = "ColumnEndereco";
            // 
            // ColumnFreqCompra
            // 
            this.ColumnFreqCompra.DataPropertyName = "freq_compra";
            this.ColumnFreqCompra.HeaderText = "Frequência de compras";
            this.ColumnFreqCompra.Name = "ColumnFreqCompra";
            // 
            // btnClienteCancelar
            // 
            this.btnClienteCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnClienteCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteCancelar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteCancelar.ForeColor = System.Drawing.Color.White;
            this.btnClienteCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClienteCancelar.IconColor = System.Drawing.Color.Black;
            this.btnClienteCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClienteCancelar.Location = new System.Drawing.Point(980, 397);
            this.btnClienteCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClienteCancelar.Name = "btnClienteCancelar";
            this.btnClienteCancelar.Size = new System.Drawing.Size(194, 55);
            this.btnClienteCancelar.TabIndex = 26;
            this.btnClienteCancelar.Text = "Cancelar";
            this.btnClienteCancelar.UseVisualStyleBackColor = false;
            this.btnClienteCancelar.Click += new System.EventHandler(this.btnClienteCancelar_Click);
            // 
            // groupContatoCliente
            // 
            this.groupContatoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupContatoCliente.Controls.Add(this.lblClienteContatoTelefone);
            this.groupContatoCliente.Controls.Add(this.txtClienteContatoTelefone);
            this.groupContatoCliente.Controls.Add(this.lblClienteContatoEmail);
            this.groupContatoCliente.Controls.Add(this.lblClienteContatoNome);
            this.groupContatoCliente.Controls.Add(this.txtClienteContatoNome);
            this.groupContatoCliente.Controls.Add(this.txtClienteContatoEmail);
            this.groupContatoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupContatoCliente.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.groupContatoCliente.ForeColor = System.Drawing.Color.White;
            this.groupContatoCliente.Location = new System.Drawing.Point(980, 12);
            this.groupContatoCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupContatoCliente.Name = "groupContatoCliente";
            this.groupContatoCliente.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupContatoCliente.Size = new System.Drawing.Size(384, 320);
            this.groupContatoCliente.TabIndex = 22;
            this.groupContatoCliente.TabStop = false;
            this.groupContatoCliente.Text = "Contatos";
            // 
            // lblClienteContatoTelefone
            // 
            this.lblClienteContatoTelefone.AutoSize = true;
            this.lblClienteContatoTelefone.ForeColor = System.Drawing.Color.White;
            this.lblClienteContatoTelefone.Location = new System.Drawing.Point(30, 240);
            this.lblClienteContatoTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteContatoTelefone.Name = "lblClienteContatoTelefone";
            this.lblClienteContatoTelefone.Size = new System.Drawing.Size(164, 28);
            this.lblClienteContatoTelefone.TabIndex = 16;
            this.lblClienteContatoTelefone.Text = "Telefone Principal";
            // 
            // txtClienteContatoTelefone
            // 
            this.txtClienteContatoTelefone.BackColor = System.Drawing.SystemColors.Menu;
            this.txtClienteContatoTelefone.Location = new System.Drawing.Point(35, 271);
            this.txtClienteContatoTelefone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteContatoTelefone.MaxLength = 20;
            this.txtClienteContatoTelefone.Name = "txtClienteContatoTelefone";
            this.txtClienteContatoTelefone.Size = new System.Drawing.Size(315, 34);
            this.txtClienteContatoTelefone.TabIndex = 17;
            // 
            // lblClienteContatoEmail
            // 
            this.lblClienteContatoEmail.AutoSize = true;
            this.lblClienteContatoEmail.ForeColor = System.Drawing.Color.White;
            this.lblClienteContatoEmail.Location = new System.Drawing.Point(30, 140);
            this.lblClienteContatoEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteContatoEmail.Name = "lblClienteContatoEmail";
            this.lblClienteContatoEmail.Size = new System.Drawing.Size(67, 28);
            this.lblClienteContatoEmail.TabIndex = 14;
            this.lblClienteContatoEmail.Text = "E-mail";
            // 
            // lblClienteContatoNome
            // 
            this.lblClienteContatoNome.AutoSize = true;
            this.lblClienteContatoNome.ForeColor = System.Drawing.Color.White;
            this.lblClienteContatoNome.Location = new System.Drawing.Point(30, 42);
            this.lblClienteContatoNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteContatoNome.Name = "lblClienteContatoNome";
            this.lblClienteContatoNome.Size = new System.Drawing.Size(171, 28);
            this.lblClienteContatoNome.TabIndex = 12;
            this.lblClienteContatoNome.Text = "Nome do Contato";
            // 
            // txtClienteContatoNome
            // 
            this.txtClienteContatoNome.BackColor = System.Drawing.SystemColors.Menu;
            this.txtClienteContatoNome.Location = new System.Drawing.Point(35, 74);
            this.txtClienteContatoNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteContatoNome.MaxLength = 80;
            this.txtClienteContatoNome.Name = "txtClienteContatoNome";
            this.txtClienteContatoNome.Size = new System.Drawing.Size(315, 34);
            this.txtClienteContatoNome.TabIndex = 13;
            // 
            // txtClienteContatoEmail
            // 
            this.txtClienteContatoEmail.BackColor = System.Drawing.SystemColors.Menu;
            this.txtClienteContatoEmail.Location = new System.Drawing.Point(35, 171);
            this.txtClienteContatoEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteContatoEmail.MaxLength = 80;
            this.txtClienteContatoEmail.Name = "txtClienteContatoEmail";
            this.txtClienteContatoEmail.Size = new System.Drawing.Size(315, 34);
            this.txtClienteContatoEmail.TabIndex = 15;
            // 
            // btnClienteExcluir
            // 
            this.btnClienteExcluir.BackColor = System.Drawing.Color.Maroon;
            this.btnClienteExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteExcluir.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteExcluir.ForeColor = System.Drawing.Color.White;
            this.btnClienteExcluir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClienteExcluir.IconColor = System.Drawing.Color.Black;
            this.btnClienteExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClienteExcluir.Location = new System.Drawing.Point(1176, 397);
            this.btnClienteExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClienteExcluir.Name = "btnClienteExcluir";
            this.btnClienteExcluir.Size = new System.Drawing.Size(188, 55);
            this.btnClienteExcluir.TabIndex = 27;
            this.btnClienteExcluir.Text = "Excluir";
            this.btnClienteExcluir.UseVisualStyleBackColor = false;
            this.btnClienteExcluir.Click += new System.EventHandler(this.btnClienteExcluir_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1377, 772);
            this.Controls.Add(this.groupInfoCliente);
            this.Controls.Add(this.btnClienteAdicionar);
            this.Controls.Add(this.btnClienteEditar);
            this.Controls.Add(this.dataClientes);
            this.Controls.Add(this.btnClienteCancelar);
            this.Controls.Add(this.groupContatoCliente);
            this.Controls.Add(this.btnClienteExcluir);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.groupInfoCliente.ResumeLayout(false);
            this.groupInfoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).EndInit();
            this.groupContatoCliente.ResumeLayout(false);
            this.groupContatoCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInfoCliente;
        private System.Windows.Forms.Label lblClienteObs;
        private System.Windows.Forms.RichTextBox txtClienteObs;
        private System.Windows.Forms.Label lblClienteCnpj;
        private System.Windows.Forms.TextBox txtClienteRazao;
        private System.Windows.Forms.TextBox txtClienteNomeFantasia;
        private System.Windows.Forms.TextBox txtClienteCnpj;
        private System.Windows.Forms.Label lblClienteNomeFantasia;
        private System.Windows.Forms.Label lblClienteRazao;
        private System.Windows.Forms.TextBox txtClienteInscricao;
        private System.Windows.Forms.Label lblClienteInscricao;
        private FontAwesome.Sharp.IconButton btnClienteAdicionar;
        private FontAwesome.Sharp.IconButton btnClienteEditar;
        private System.Windows.Forms.DataGridView dataClientes;
        private FontAwesome.Sharp.IconButton btnClienteCancelar;
        private System.Windows.Forms.GroupBox groupContatoCliente;
        private System.Windows.Forms.Label lblClienteContatoTelefone;
        private System.Windows.Forms.TextBox txtClienteContatoTelefone;
        private System.Windows.Forms.Label lblClienteContatoEmail;
        private System.Windows.Forms.TextBox txtClienteContatoEmail;
        private System.Windows.Forms.Label lblClienteContatoNome;
        private System.Windows.Forms.TextBox txtClienteContatoNome;
        private FontAwesome.Sharp.IconButton btnClienteExcluir;
        private System.Windows.Forms.TextBox txtClienteEndereco;
        private System.Windows.Forms.Label lblClienteEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRazao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInscricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContatoNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContatoEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContatoTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFreqCompra;
    }
}