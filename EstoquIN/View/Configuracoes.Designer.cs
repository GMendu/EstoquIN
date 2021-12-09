
namespace EstoquIN.View
{
    partial class Configuracoes
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
            this.groupConfigUsuario = new System.Windows.Forms.GroupBox();
            this.cbTipos = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblConfigSenhaRep = new System.Windows.Forms.Label();
            this.txtConfigSenhaRep = new System.Windows.Forms.TextBox();
            this.lblConfigSenha = new System.Windows.Forms.Label();
            this.txtConfigSenha = new System.Windows.Forms.TextBox();
            this.lblConfigUsuario = new System.Windows.Forms.Label();
            this.txtConfigUsuario = new System.Windows.Forms.TextBox();
            this.btnConfigExcluir = new FontAwesome.Sharp.IconButton();
            this.btnConfigAdicionar = new FontAwesome.Sharp.IconButton();
            this.btnConfigEditar = new FontAwesome.Sharp.IconButton();
            this.btnConfigCancelar = new FontAwesome.Sharp.IconButton();
            this.dataConfigUsuario = new System.Windows.Forms.DataGridView();
            this.groupConfigLogo = new System.Windows.Forms.GroupBox();
            this.btnUpload = new FontAwesome.Sharp.IconButton();
            this.picLogoMenu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupConfigUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataConfigUsuario)).BeginInit();
            this.groupConfigLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupConfigUsuario
            // 
            this.groupConfigUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupConfigUsuario.Controls.Add(this.cbTipos);
            this.groupConfigUsuario.Controls.Add(this.lblTipo);
            this.groupConfigUsuario.Controls.Add(this.lblConfigSenhaRep);
            this.groupConfigUsuario.Controls.Add(this.txtConfigSenhaRep);
            this.groupConfigUsuario.Controls.Add(this.lblConfigSenha);
            this.groupConfigUsuario.Controls.Add(this.txtConfigSenha);
            this.groupConfigUsuario.Controls.Add(this.lblConfigUsuario);
            this.groupConfigUsuario.Controls.Add(this.txtConfigUsuario);
            this.groupConfigUsuario.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.groupConfigUsuario.ForeColor = System.Drawing.Color.White;
            this.groupConfigUsuario.Location = new System.Drawing.Point(12, 12);
            this.groupConfigUsuario.Name = "groupConfigUsuario";
            this.groupConfigUsuario.Size = new System.Drawing.Size(658, 388);
            this.groupConfigUsuario.TabIndex = 0;
            this.groupConfigUsuario.TabStop = false;
            this.groupConfigUsuario.Text = "Configurações de usuário";
            // 
            // cbTipos
            // 
            this.cbTipos.FormattingEnabled = true;
            this.cbTipos.Location = new System.Drawing.Point(38, 236);
            this.cbTipos.Name = "cbTipos";
            this.cbTipos.Size = new System.Drawing.Size(263, 36);
            this.cbTipos.TabIndex = 9;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(33, 203);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(56, 28);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo ";
            // 
            // lblConfigSenhaRep
            // 
            this.lblConfigSenhaRep.AutoSize = true;
            this.lblConfigSenhaRep.ForeColor = System.Drawing.Color.White;
            this.lblConfigSenhaRep.Location = new System.Drawing.Point(354, 203);
            this.lblConfigSenhaRep.Name = "lblConfigSenhaRep";
            this.lblConfigSenhaRep.Size = new System.Drawing.Size(129, 28);
            this.lblConfigSenhaRep.TabIndex = 6;
            this.lblConfigSenhaRep.Text = "Repetir senha";
            // 
            // txtConfigSenhaRep
            // 
            this.txtConfigSenhaRep.BackColor = System.Drawing.SystemColors.Menu;
            this.txtConfigSenhaRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfigSenhaRep.Location = new System.Drawing.Point(359, 236);
            this.txtConfigSenhaRep.MaxLength = 22;
            this.txtConfigSenhaRep.Name = "txtConfigSenhaRep";
            this.txtConfigSenhaRep.Size = new System.Drawing.Size(258, 34);
            this.txtConfigSenhaRep.TabIndex = 7;
            this.txtConfigSenhaRep.UseSystemPasswordChar = true;
            // 
            // lblConfigSenha
            // 
            this.lblConfigSenha.AutoSize = true;
            this.lblConfigSenha.ForeColor = System.Drawing.Color.White;
            this.lblConfigSenha.Location = new System.Drawing.Point(354, 97);
            this.lblConfigSenha.Name = "lblConfigSenha";
            this.lblConfigSenha.Size = new System.Drawing.Size(65, 28);
            this.lblConfigSenha.TabIndex = 4;
            this.lblConfigSenha.Text = "Senha";
            // 
            // txtConfigSenha
            // 
            this.txtConfigSenha.BackColor = System.Drawing.SystemColors.Menu;
            this.txtConfigSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfigSenha.Location = new System.Drawing.Point(359, 128);
            this.txtConfigSenha.MaxLength = 22;
            this.txtConfigSenha.Name = "txtConfigSenha";
            this.txtConfigSenha.Size = new System.Drawing.Size(258, 34);
            this.txtConfigSenha.TabIndex = 5;
            this.txtConfigSenha.UseSystemPasswordChar = true;
            // 
            // lblConfigUsuario
            // 
            this.lblConfigUsuario.AutoSize = true;
            this.lblConfigUsuario.ForeColor = System.Drawing.Color.White;
            this.lblConfigUsuario.Location = new System.Drawing.Point(33, 97);
            this.lblConfigUsuario.Name = "lblConfigUsuario";
            this.lblConfigUsuario.Size = new System.Drawing.Size(79, 28);
            this.lblConfigUsuario.TabIndex = 2;
            this.lblConfigUsuario.Text = "Usuário";
            // 
            // txtConfigUsuario
            // 
            this.txtConfigUsuario.BackColor = System.Drawing.SystemColors.Menu;
            this.txtConfigUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfigUsuario.Location = new System.Drawing.Point(38, 128);
            this.txtConfigUsuario.MaxLength = 22;
            this.txtConfigUsuario.Name = "txtConfigUsuario";
            this.txtConfigUsuario.Size = new System.Drawing.Size(263, 34);
            this.txtConfigUsuario.TabIndex = 3;
            // 
            // btnConfigExcluir
            // 
            this.btnConfigExcluir.BackColor = System.Drawing.Color.Maroon;
            this.btnConfigExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigExcluir.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigExcluir.ForeColor = System.Drawing.Color.White;
            this.btnConfigExcluir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConfigExcluir.IconColor = System.Drawing.Color.Black;
            this.btnConfigExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfigExcluir.Location = new System.Drawing.Point(676, 304);
            this.btnConfigExcluir.Name = "btnConfigExcluir";
            this.btnConfigExcluir.Size = new System.Drawing.Size(257, 96);
            this.btnConfigExcluir.TabIndex = 39;
            this.btnConfigExcluir.Text = "Excluir";
            this.btnConfigExcluir.UseVisualStyleBackColor = false;
            this.btnConfigExcluir.Click += new System.EventHandler(this.btnConfigExcluir_Click);
            // 
            // btnConfigAdicionar
            // 
            this.btnConfigAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.btnConfigAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigAdicionar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnConfigAdicionar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConfigAdicionar.IconColor = System.Drawing.Color.Black;
            this.btnConfigAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfigAdicionar.Location = new System.Drawing.Point(676, 12);
            this.btnConfigAdicionar.Name = "btnConfigAdicionar";
            this.btnConfigAdicionar.Size = new System.Drawing.Size(257, 98);
            this.btnConfigAdicionar.TabIndex = 36;
            this.btnConfigAdicionar.Text = "Adicionar";
            this.btnConfigAdicionar.UseVisualStyleBackColor = false;
            this.btnConfigAdicionar.Click += new System.EventHandler(this.btnConfigAdicionar_Click);
            // 
            // btnConfigEditar
            // 
            this.btnConfigEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnConfigEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigEditar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigEditar.ForeColor = System.Drawing.Color.White;
            this.btnConfigEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConfigEditar.IconColor = System.Drawing.Color.Black;
            this.btnConfigEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfigEditar.Location = new System.Drawing.Point(676, 116);
            this.btnConfigEditar.Name = "btnConfigEditar";
            this.btnConfigEditar.Size = new System.Drawing.Size(257, 84);
            this.btnConfigEditar.TabIndex = 37;
            this.btnConfigEditar.Text = "Editar";
            this.btnConfigEditar.UseVisualStyleBackColor = false;
            this.btnConfigEditar.Click += new System.EventHandler(this.btnConfigEditar_Click);
            // 
            // btnConfigCancelar
            // 
            this.btnConfigCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnConfigCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigCancelar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigCancelar.ForeColor = System.Drawing.Color.White;
            this.btnConfigCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConfigCancelar.IconColor = System.Drawing.Color.Black;
            this.btnConfigCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfigCancelar.Location = new System.Drawing.Point(676, 206);
            this.btnConfigCancelar.Name = "btnConfigCancelar";
            this.btnConfigCancelar.Size = new System.Drawing.Size(257, 92);
            this.btnConfigCancelar.TabIndex = 38;
            this.btnConfigCancelar.Text = "Cancelar";
            this.btnConfigCancelar.UseVisualStyleBackColor = false;
            this.btnConfigCancelar.Click += new System.EventHandler(this.btnConfigCancelar_Click);
            // 
            // dataConfigUsuario
            // 
            this.dataConfigUsuario.AllowUserToAddRows = false;
            this.dataConfigUsuario.AllowUserToDeleteRows = false;
            this.dataConfigUsuario.AllowUserToResizeColumns = false;
            this.dataConfigUsuario.AllowUserToResizeRows = false;
            this.dataConfigUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataConfigUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.dataConfigUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataConfigUsuario.Location = new System.Drawing.Point(939, 12);
            this.dataConfigUsuario.Name = "dataConfigUsuario";
            this.dataConfigUsuario.RowHeadersVisible = false;
            this.dataConfigUsuario.RowTemplate.Height = 25;
            this.dataConfigUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataConfigUsuario.Size = new System.Drawing.Size(426, 748);
            this.dataConfigUsuario.TabIndex = 40;
            // 
            // groupConfigLogo
            // 
            this.groupConfigLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupConfigLogo.Controls.Add(this.label2);
            this.groupConfigLogo.Controls.Add(this.label1);
            this.groupConfigLogo.Controls.Add(this.btnUpload);
            this.groupConfigLogo.Controls.Add(this.picLogoMenu);
            this.groupConfigLogo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.groupConfigLogo.ForeColor = System.Drawing.Color.White;
            this.groupConfigLogo.Location = new System.Drawing.Point(12, 406);
            this.groupConfigLogo.Name = "groupConfigLogo";
            this.groupConfigLogo.Size = new System.Drawing.Size(921, 354);
            this.groupConfigLogo.TabIndex = 41;
            this.groupConfigLogo.TabStop = false;
            this.groupConfigLogo.Text = "Logo do menu";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUpload.IconColor = System.Drawing.Color.Black;
            this.btnUpload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpload.Location = new System.Drawing.Point(676, 33);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(225, 300);
            this.btnUpload.TabIndex = 42;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // picLogoMenu
            // 
            this.picLogoMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogoMenu.Location = new System.Drawing.Point(208, 33);
            this.picLogoMenu.Name = "picLogoMenu";
            this.picLogoMenu.Size = new System.Drawing.Size(450, 300);
            this.picLogoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoMenu.TabIndex = 0;
            this.picLogoMenu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 43;
            this.label1.Text = "formato padrão:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 44;
            this.label2.Text = "450 x 300";
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1377, 772);
            this.Controls.Add(this.groupConfigLogo);
            this.Controls.Add(this.dataConfigUsuario);
            this.Controls.Add(this.btnConfigExcluir);
            this.Controls.Add(this.btnConfigAdicionar);
            this.Controls.Add(this.btnConfigEditar);
            this.Controls.Add(this.btnConfigCancelar);
            this.Controls.Add(this.groupConfigUsuario);
            this.Name = "Configuracoes";
            this.Text = "Configurações";
            this.groupConfigUsuario.ResumeLayout(false);
            this.groupConfigUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataConfigUsuario)).EndInit();
            this.groupConfigLogo.ResumeLayout(false);
            this.groupConfigLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupConfigUsuario;
        private FontAwesome.Sharp.IconButton btnConfigExcluir;
        private FontAwesome.Sharp.IconButton btnConfigAdicionar;
        private FontAwesome.Sharp.IconButton btnConfigEditar;
        private FontAwesome.Sharp.IconButton btnConfigCancelar;
        private System.Windows.Forms.DataGridView dataConfigUsuario;
        private System.Windows.Forms.Label lblConfigSenhaRep;
        private System.Windows.Forms.TextBox txtConfigSenhaRep;
        private System.Windows.Forms.Label lblConfigSenha;
        private System.Windows.Forms.TextBox txtConfigSenha;
        private System.Windows.Forms.Label lblConfigUsuario;
        private System.Windows.Forms.TextBox txtConfigUsuario;
        private System.Windows.Forms.GroupBox groupConfigLogo;
        private System.Windows.Forms.ComboBox cbTipos;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.PictureBox picLogoMenu;
        private FontAwesome.Sharp.IconButton btnUpload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}