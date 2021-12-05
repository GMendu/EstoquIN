
namespace EstoquIN.View
{
    partial class Fornecedores
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
            this.groupInfoFornec = new System.Windows.Forms.GroupBox();
            this.txtFornecEndereco = new System.Windows.Forms.TextBox();
            this.lblFornecEndereco = new System.Windows.Forms.Label();
            this.lblFornecObs = new System.Windows.Forms.Label();
            this.txtFornecObs = new System.Windows.Forms.RichTextBox();
            this.lblFornecCnpj = new System.Windows.Forms.Label();
            this.txtFornecRazao = new System.Windows.Forms.TextBox();
            this.txtFornecNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtFornecCnpj = new System.Windows.Forms.TextBox();
            this.lblFornecNomeFantasia = new System.Windows.Forms.Label();
            this.lblFornecRazao = new System.Windows.Forms.Label();
            this.txtFornecInscricao = new System.Windows.Forms.TextBox();
            this.lblFornecInscricao = new System.Windows.Forms.Label();
            this.btnFornecAdicionar = new FontAwesome.Sharp.IconButton();
            this.btnFornecEditar = new FontAwesome.Sharp.IconButton();
            this.dataFornec = new System.Windows.Forms.DataGridView();
            this.btnFornecCancelar = new FontAwesome.Sharp.IconButton();
            this.groupContatoFornec = new System.Windows.Forms.GroupBox();
            this.lblFornecContatoTelefone = new System.Windows.Forms.Label();
            this.txtFornecContatoTelefone = new System.Windows.Forms.TextBox();
            this.lblFornecContatoEmail = new System.Windows.Forms.Label();
            this.txtFornecContatoEmail = new System.Windows.Forms.TextBox();
            this.lblFornecContatoNome = new System.Windows.Forms.Label();
            this.txtFornecContatoNome = new System.Windows.Forms.TextBox();
            this.btnFornecExcluir = new FontAwesome.Sharp.IconButton();
            this.groupInfoFornec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFornec)).BeginInit();
            this.groupContatoFornec.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInfoFornec
            // 
            this.groupInfoFornec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupInfoFornec.Controls.Add(this.txtFornecEndereco);
            this.groupInfoFornec.Controls.Add(this.lblFornecEndereco);
            this.groupInfoFornec.Controls.Add(this.lblFornecObs);
            this.groupInfoFornec.Controls.Add(this.txtFornecObs);
            this.groupInfoFornec.Controls.Add(this.lblFornecCnpj);
            this.groupInfoFornec.Controls.Add(this.txtFornecRazao);
            this.groupInfoFornec.Controls.Add(this.txtFornecNomeFantasia);
            this.groupInfoFornec.Controls.Add(this.txtFornecCnpj);
            this.groupInfoFornec.Controls.Add(this.lblFornecNomeFantasia);
            this.groupInfoFornec.Controls.Add(this.lblFornecRazao);
            this.groupInfoFornec.Controls.Add(this.txtFornecInscricao);
            this.groupInfoFornec.Controls.Add(this.lblFornecInscricao);
            this.groupInfoFornec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupInfoFornec.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.groupInfoFornec.ForeColor = System.Drawing.Color.White;
            this.groupInfoFornec.Location = new System.Drawing.Point(12, 12);
            this.groupInfoFornec.Name = "groupInfoFornec";
            this.groupInfoFornec.Size = new System.Drawing.Size(960, 364);
            this.groupInfoFornec.TabIndex = 14;
            this.groupInfoFornec.TabStop = false;
            this.groupInfoFornec.Text = "Informações empresariais";
            // 
            // txtFornecEndereco
            // 
            this.txtFornecEndereco.Location = new System.Drawing.Point(20, 299);
            this.txtFornecEndereco.MaxLength = 100;
            this.txtFornecEndereco.Name = "txtFornecEndereco";
            this.txtFornecEndereco.Size = new System.Drawing.Size(496, 34);
            this.txtFornecEndereco.TabIndex = 15;
            // 
            // lblFornecEndereco
            // 
            this.lblFornecEndereco.AutoSize = true;
            this.lblFornecEndereco.ForeColor = System.Drawing.Color.White;
            this.lblFornecEndereco.Location = new System.Drawing.Point(15, 268);
            this.lblFornecEndereco.Name = "lblFornecEndereco";
            this.lblFornecEndereco.Size = new System.Drawing.Size(93, 28);
            this.lblFornecEndereco.TabIndex = 14;
            this.lblFornecEndereco.Text = "Endereço";
            // 
            // lblFornecObs
            // 
            this.lblFornecObs.AutoSize = true;
            this.lblFornecObs.ForeColor = System.Drawing.Color.White;
            this.lblFornecObs.Location = new System.Drawing.Point(593, 42);
            this.lblFornecObs.Name = "lblFornecObs";
            this.lblFornecObs.Size = new System.Drawing.Size(127, 28);
            this.lblFornecObs.TabIndex = 11;
            this.lblFornecObs.Text = "Observações:";
            // 
            // txtFornecObs
            // 
            this.txtFornecObs.Location = new System.Drawing.Point(598, 73);
            this.txtFornecObs.MaxLength = 65000;
            this.txtFornecObs.Name = "txtFornecObs";
            this.txtFornecObs.Size = new System.Drawing.Size(346, 261);
            this.txtFornecObs.TabIndex = 10;
            this.txtFornecObs.Text = "";
            // 
            // lblFornecCnpj
            // 
            this.lblFornecCnpj.AutoSize = true;
            this.lblFornecCnpj.ForeColor = System.Drawing.Color.White;
            this.lblFornecCnpj.Location = new System.Drawing.Point(15, 41);
            this.lblFornecCnpj.Name = "lblFornecCnpj";
            this.lblFornecCnpj.Size = new System.Drawing.Size(56, 28);
            this.lblFornecCnpj.TabIndex = 0;
            this.lblFornecCnpj.Text = "CNPJ";
            // 
            // txtFornecRazao
            // 
            this.txtFornecRazao.Location = new System.Drawing.Point(20, 152);
            this.txtFornecRazao.MaxLength = 80;
            this.txtFornecRazao.Name = "txtFornecRazao";
            this.txtFornecRazao.Size = new System.Drawing.Size(496, 34);
            this.txtFornecRazao.TabIndex = 3;
            // 
            // txtFornecNomeFantasia
            // 
            this.txtFornecNomeFantasia.Location = new System.Drawing.Point(20, 231);
            this.txtFornecNomeFantasia.MaxLength = 80;
            this.txtFornecNomeFantasia.Name = "txtFornecNomeFantasia";
            this.txtFornecNomeFantasia.Size = new System.Drawing.Size(496, 34);
            this.txtFornecNomeFantasia.TabIndex = 9;
            // 
            // txtFornecCnpj
            // 
            this.txtFornecCnpj.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFornecCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecCnpj.Location = new System.Drawing.Point(20, 73);
            this.txtFornecCnpj.MaxLength = 22;
            this.txtFornecCnpj.Name = "txtFornecCnpj";
            this.txtFornecCnpj.Size = new System.Drawing.Size(238, 34);
            this.txtFornecCnpj.TabIndex = 1;
            // 
            // lblFornecNomeFantasia
            // 
            this.lblFornecNomeFantasia.AutoSize = true;
            this.lblFornecNomeFantasia.ForeColor = System.Drawing.Color.White;
            this.lblFornecNomeFantasia.Location = new System.Drawing.Point(15, 200);
            this.lblFornecNomeFantasia.Name = "lblFornecNomeFantasia";
            this.lblFornecNomeFantasia.Size = new System.Drawing.Size(141, 28);
            this.lblFornecNomeFantasia.TabIndex = 8;
            this.lblFornecNomeFantasia.Text = "Nome Fantasia";
            // 
            // lblFornecRazao
            // 
            this.lblFornecRazao.AutoSize = true;
            this.lblFornecRazao.ForeColor = System.Drawing.Color.White;
            this.lblFornecRazao.Location = new System.Drawing.Point(15, 121);
            this.lblFornecRazao.Name = "lblFornecRazao";
            this.lblFornecRazao.Size = new System.Drawing.Size(122, 28);
            this.lblFornecRazao.TabIndex = 2;
            this.lblFornecRazao.Text = "Razão Social";
            // 
            // txtFornecInscricao
            // 
            this.txtFornecInscricao.Location = new System.Drawing.Point(278, 72);
            this.txtFornecInscricao.MaxLength = 22;
            this.txtFornecInscricao.Name = "txtFornecInscricao";
            this.txtFornecInscricao.Size = new System.Drawing.Size(238, 34);
            this.txtFornecInscricao.TabIndex = 7;
            // 
            // lblFornecInscricao
            // 
            this.lblFornecInscricao.AutoSize = true;
            this.lblFornecInscricao.ForeColor = System.Drawing.Color.White;
            this.lblFornecInscricao.Location = new System.Drawing.Point(273, 41);
            this.lblFornecInscricao.Name = "lblFornecInscricao";
            this.lblFornecInscricao.Size = new System.Drawing.Size(166, 28);
            this.lblFornecInscricao.TabIndex = 6;
            this.lblFornecInscricao.Text = "Inscrição Estadual";
            // 
            // btnFornecAdicionar
            // 
            this.btnFornecAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnFornecAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecAdicionar.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnFornecAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnFornecAdicionar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFornecAdicionar.IconColor = System.Drawing.Color.Black;
            this.btnFornecAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFornecAdicionar.Location = new System.Drawing.Point(12, 382);
            this.btnFornecAdicionar.Name = "btnFornecAdicionar";
            this.btnFornecAdicionar.Size = new System.Drawing.Size(317, 64);
            this.btnFornecAdicionar.TabIndex = 17;
            this.btnFornecAdicionar.Text = "Adicionar";
            this.btnFornecAdicionar.UseVisualStyleBackColor = false;
            this.btnFornecAdicionar.Click += new System.EventHandler(this.btnFornecAdicionar_Click);
            // 
            // btnFornecEditar
            // 
            this.btnFornecEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnFornecEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecEditar.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnFornecEditar.ForeColor = System.Drawing.Color.White;
            this.btnFornecEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFornecEditar.IconColor = System.Drawing.Color.Black;
            this.btnFornecEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFornecEditar.Location = new System.Drawing.Point(363, 382);
            this.btnFornecEditar.Name = "btnFornecEditar";
            this.btnFornecEditar.Size = new System.Drawing.Size(317, 64);
            this.btnFornecEditar.TabIndex = 18;
            this.btnFornecEditar.Text = "Editar";
            this.btnFornecEditar.UseVisualStyleBackColor = false;
            this.btnFornecEditar.Click += new System.EventHandler(this.btnFornecEditar_Click);
            // 
            // dataFornec
            // 
            this.dataFornec.AllowUserToAddRows = false;
            this.dataFornec.AllowUserToDeleteRows = false;
            this.dataFornec.AllowUserToResizeColumns = false;
            this.dataFornec.AllowUserToResizeRows = false;
            this.dataFornec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFornec.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.dataFornec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFornec.Location = new System.Drawing.Point(12, 459);
            this.dataFornec.Name = "dataFornec";
            this.dataFornec.RowHeadersVisible = false;
            this.dataFornec.RowHeadersWidth = 51;
            this.dataFornec.RowTemplate.Height = 25;
            this.dataFornec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFornec.Size = new System.Drawing.Size(1353, 301);
            this.dataFornec.TabIndex = 16;
            // 
            // btnFornecCancelar
            // 
            this.btnFornecCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnFornecCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecCancelar.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnFornecCancelar.ForeColor = System.Drawing.Color.White;
            this.btnFornecCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFornecCancelar.IconColor = System.Drawing.Color.Black;
            this.btnFornecCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFornecCancelar.Location = new System.Drawing.Point(705, 382);
            this.btnFornecCancelar.Name = "btnFornecCancelar";
            this.btnFornecCancelar.Size = new System.Drawing.Size(317, 64);
            this.btnFornecCancelar.TabIndex = 19;
            this.btnFornecCancelar.Text = "Cancelar";
            this.btnFornecCancelar.UseVisualStyleBackColor = false;
            this.btnFornecCancelar.Click += new System.EventHandler(this.btnFornecCancelar_Click);
            // 
            // groupContatoFornec
            // 
            this.groupContatoFornec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupContatoFornec.Controls.Add(this.lblFornecContatoTelefone);
            this.groupContatoFornec.Controls.Add(this.txtFornecContatoTelefone);
            this.groupContatoFornec.Controls.Add(this.lblFornecContatoEmail);
            this.groupContatoFornec.Controls.Add(this.txtFornecContatoEmail);
            this.groupContatoFornec.Controls.Add(this.lblFornecContatoNome);
            this.groupContatoFornec.Controls.Add(this.txtFornecContatoNome);
            this.groupContatoFornec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupContatoFornec.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.groupContatoFornec.ForeColor = System.Drawing.Color.White;
            this.groupContatoFornec.Location = new System.Drawing.Point(978, 12);
            this.groupContatoFornec.Name = "groupContatoFornec";
            this.groupContatoFornec.Size = new System.Drawing.Size(387, 364);
            this.groupContatoFornec.TabIndex = 15;
            this.groupContatoFornec.TabStop = false;
            this.groupContatoFornec.Text = "Contatos";
            // 
            // lblFornecContatoTelefone
            // 
            this.lblFornecContatoTelefone.AutoSize = true;
            this.lblFornecContatoTelefone.ForeColor = System.Drawing.Color.White;
            this.lblFornecContatoTelefone.Location = new System.Drawing.Point(73, 208);
            this.lblFornecContatoTelefone.Name = "lblFornecContatoTelefone";
            this.lblFornecContatoTelefone.Size = new System.Drawing.Size(164, 28);
            this.lblFornecContatoTelefone.TabIndex = 16;
            this.lblFornecContatoTelefone.Text = "Telefone Principal";
            // 
            // txtFornecContatoTelefone
            // 
            this.txtFornecContatoTelefone.Location = new System.Drawing.Point(72, 239);
            this.txtFornecContatoTelefone.MaxLength = 20;
            this.txtFornecContatoTelefone.Name = "txtFornecContatoTelefone";
            this.txtFornecContatoTelefone.Size = new System.Drawing.Size(254, 34);
            this.txtFornecContatoTelefone.TabIndex = 17;
            // 
            // lblFornecContatoEmail
            // 
            this.lblFornecContatoEmail.AutoSize = true;
            this.lblFornecContatoEmail.ForeColor = System.Drawing.Color.White;
            this.lblFornecContatoEmail.Location = new System.Drawing.Point(73, 131);
            this.lblFornecContatoEmail.Name = "lblFornecContatoEmail";
            this.lblFornecContatoEmail.Size = new System.Drawing.Size(67, 28);
            this.lblFornecContatoEmail.TabIndex = 14;
            this.lblFornecContatoEmail.Text = "E-mail";
            // 
            // txtFornecContatoEmail
            // 
            this.txtFornecContatoEmail.Location = new System.Drawing.Point(72, 163);
            this.txtFornecContatoEmail.MaxLength = 80;
            this.txtFornecContatoEmail.Name = "txtFornecContatoEmail";
            this.txtFornecContatoEmail.Size = new System.Drawing.Size(254, 34);
            this.txtFornecContatoEmail.TabIndex = 15;
            // 
            // lblFornecContatoNome
            // 
            this.lblFornecContatoNome.AutoSize = true;
            this.lblFornecContatoNome.ForeColor = System.Drawing.Color.White;
            this.lblFornecContatoNome.Location = new System.Drawing.Point(73, 64);
            this.lblFornecContatoNome.Name = "lblFornecContatoNome";
            this.lblFornecContatoNome.Size = new System.Drawing.Size(171, 28);
            this.lblFornecContatoNome.TabIndex = 12;
            this.lblFornecContatoNome.Text = "Nome do Contato";
            // 
            // txtFornecContatoNome
            // 
            this.txtFornecContatoNome.Location = new System.Drawing.Point(72, 94);
            this.txtFornecContatoNome.MaxLength = 80;
            this.txtFornecContatoNome.Name = "txtFornecContatoNome";
            this.txtFornecContatoNome.Size = new System.Drawing.Size(254, 34);
            this.txtFornecContatoNome.TabIndex = 13;
            // 
            // btnFornecExcluir
            // 
            this.btnFornecExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnFornecExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecExcluir.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnFornecExcluir.ForeColor = System.Drawing.Color.White;
            this.btnFornecExcluir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFornecExcluir.IconColor = System.Drawing.Color.Black;
            this.btnFornecExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFornecExcluir.Location = new System.Drawing.Point(1050, 382);
            this.btnFornecExcluir.Name = "btnFornecExcluir";
            this.btnFornecExcluir.Size = new System.Drawing.Size(314, 64);
            this.btnFornecExcluir.TabIndex = 20;
            this.btnFornecExcluir.Text = "Excluir";
            this.btnFornecExcluir.UseVisualStyleBackColor = false;
            this.btnFornecExcluir.Click += new System.EventHandler(this.btnFornecExcluir_Click);
            // 
            // Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1377, 772);
            this.Controls.Add(this.groupInfoFornec);
            this.Controls.Add(this.btnFornecAdicionar);
            this.Controls.Add(this.btnFornecEditar);
            this.Controls.Add(this.dataFornec);
            this.Controls.Add(this.btnFornecCancelar);
            this.Controls.Add(this.groupContatoFornec);
            this.Controls.Add(this.btnFornecExcluir);
            this.Name = "Fornecedores";
            this.Text = "Fornecedores";
            this.groupInfoFornec.ResumeLayout(false);
            this.groupInfoFornec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFornec)).EndInit();
            this.groupContatoFornec.ResumeLayout(false);
            this.groupContatoFornec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInfoFornec;
        private System.Windows.Forms.Label lblFornecObs;
        private System.Windows.Forms.RichTextBox txtFornecObs;
        private System.Windows.Forms.Label lblFornecCnpj;
        private System.Windows.Forms.TextBox txtFornecRazao;
        private System.Windows.Forms.TextBox txtFornecNomeFantasia;
        private System.Windows.Forms.TextBox txtFornecCnpj;
        private System.Windows.Forms.Label lblFornecNomeFantasia;
        private System.Windows.Forms.Label lblFornecRazao;
        private System.Windows.Forms.TextBox txtFornecInscricao;
        private System.Windows.Forms.Label lblFornecInscricao;
        private FontAwesome.Sharp.IconButton btnFornecAdicionar;
        private FontAwesome.Sharp.IconButton btnFornecEditar;
        private System.Windows.Forms.DataGridView dataFornec;
        private FontAwesome.Sharp.IconButton btnFornecCancelar;
        private System.Windows.Forms.GroupBox groupContatoFornec;
        private System.Windows.Forms.Label lblFornecContatoTelefone;
        private System.Windows.Forms.TextBox txtFornecContatoTelefone;
        private System.Windows.Forms.Label lblFornecContatoEmail;
        private System.Windows.Forms.TextBox txtFornecContatoEmail;
        private System.Windows.Forms.Label lblFornecContatoNome;
        private System.Windows.Forms.TextBox txtFornecContatoNome;
        private FontAwesome.Sharp.IconButton btnFornecExcluir;
        private System.Windows.Forms.TextBox txtFornecEndereco;
        private System.Windows.Forms.Label lblFornecEndereco;
    }
}