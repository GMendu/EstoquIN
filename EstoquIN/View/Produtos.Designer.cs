
namespace EstoquIN.View
{
    partial class Produtos
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
            this.btnProdutoExcluir = new FontAwesome.Sharp.IconButton();
            this.lblProdutoObs = new System.Windows.Forms.Label();
            this.txtProdutoObs = new System.Windows.Forms.RichTextBox();
            this.lblProdutoNome = new System.Windows.Forms.Label();
            this.txtValorVarejo = new System.Windows.Forms.TextBox();
            this.txtValorAtacado = new System.Windows.Forms.TextBox();
            this.txtProdutoNome = new System.Windows.Forms.TextBox();
            this.lblValorAtacado = new System.Windows.Forms.Label();
            this.lblValorVarejo = new System.Windows.Forms.Label();
            this.txtProdutoPeso = new System.Windows.Forms.TextBox();
            this.lblProdutoPeso = new System.Windows.Forms.Label();
            this.btnProdutoAdicionar = new FontAwesome.Sharp.IconButton();
            this.btnProdutoEditar = new FontAwesome.Sharp.IconButton();
            this.dataProduto = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupProdutoInfo = new System.Windows.Forms.GroupBox();
            this.txtProdutosCodBar = new System.Windows.Forms.TextBox();
            this.lblProdutosCodBar = new System.Windows.Forms.Label();
            this.btnProdutoCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduto)).BeginInit();
            this.groupProdutoInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProdutoExcluir
            // 
            this.btnProdutoExcluir.BackColor = System.Drawing.Color.Maroon;
            this.btnProdutoExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutoExcluir.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutoExcluir.ForeColor = System.Drawing.Color.White;
            this.btnProdutoExcluir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProdutoExcluir.IconColor = System.Drawing.Color.Black;
            this.btnProdutoExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProdutoExcluir.Location = new System.Drawing.Point(1055, 346);
            this.btnProdutoExcluir.Name = "btnProdutoExcluir";
            this.btnProdutoExcluir.Size = new System.Drawing.Size(310, 73);
            this.btnProdutoExcluir.TabIndex = 34;
            this.btnProdutoExcluir.Text = "Excluir";
            this.btnProdutoExcluir.UseVisualStyleBackColor = false;
            this.btnProdutoExcluir.Click += new System.EventHandler(this.btnProdutoExcluir_Click);
            // 
            // lblProdutoObs
            // 
            this.lblProdutoObs.AutoSize = true;
            this.lblProdutoObs.ForeColor = System.Drawing.Color.White;
            this.lblProdutoObs.Location = new System.Drawing.Point(832, 143);
            this.lblProdutoObs.Name = "lblProdutoObs";
            this.lblProdutoObs.Size = new System.Drawing.Size(127, 28);
            this.lblProdutoObs.TabIndex = 11;
            this.lblProdutoObs.Text = "Observações:";
            // 
            // txtProdutoObs
            // 
            this.txtProdutoObs.Location = new System.Drawing.Point(837, 174);
            this.txtProdutoObs.MaxLength = 65000;
            this.txtProdutoObs.Name = "txtProdutoObs";
            this.txtProdutoObs.Size = new System.Drawing.Size(439, 101);
            this.txtProdutoObs.TabIndex = 10;
            this.txtProdutoObs.Text = "";
            // 
            // lblProdutoNome
            // 
            this.lblProdutoNome.AutoSize = true;
            this.lblProdutoNome.ForeColor = System.Drawing.Color.White;
            this.lblProdutoNome.Location = new System.Drawing.Point(54, 60);
            this.lblProdutoNome.Name = "lblProdutoNome";
            this.lblProdutoNome.Size = new System.Drawing.Size(66, 28);
            this.lblProdutoNome.TabIndex = 0;
            this.lblProdutoNome.Text = "Nome";
            // 
            // txtValorVarejo
            // 
            this.txtValorVarejo.Location = new System.Drawing.Point(484, 92);
            this.txtValorVarejo.Name = "txtValorVarejo";
            this.txtValorVarejo.Size = new System.Drawing.Size(292, 34);
            this.txtValorVarejo.TabIndex = 3;
            // 
            // txtValorAtacado
            // 
            this.txtValorAtacado.Location = new System.Drawing.Point(484, 241);
            this.txtValorAtacado.Name = "txtValorAtacado";
            this.txtValorAtacado.Size = new System.Drawing.Size(292, 34);
            this.txtValorAtacado.TabIndex = 9;
            // 
            // txtProdutoNome
            // 
            this.txtProdutoNome.BackColor = System.Drawing.SystemColors.Menu;
            this.txtProdutoNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdutoNome.Location = new System.Drawing.Point(56, 92);
            this.txtProdutoNome.MaxLength = 45;
            this.txtProdutoNome.Name = "txtProdutoNome";
            this.txtProdutoNome.Size = new System.Drawing.Size(329, 34);
            this.txtProdutoNome.TabIndex = 1;
            // 
            // lblValorAtacado
            // 
            this.lblValorAtacado.AutoSize = true;
            this.lblValorAtacado.ForeColor = System.Drawing.Color.White;
            this.lblValorAtacado.Location = new System.Drawing.Point(479, 210);
            this.lblValorAtacado.Name = "lblValorAtacado";
            this.lblValorAtacado.Size = new System.Drawing.Size(163, 28);
            this.lblValorAtacado.TabIndex = 8;
            this.lblValorAtacado.Text = "Valor no Atacado";
            // 
            // lblValorVarejo
            // 
            this.lblValorVarejo.AutoSize = true;
            this.lblValorVarejo.ForeColor = System.Drawing.Color.White;
            this.lblValorVarejo.Location = new System.Drawing.Point(479, 60);
            this.lblValorVarejo.Name = "lblValorVarejo";
            this.lblValorVarejo.Size = new System.Drawing.Size(145, 28);
            this.lblValorVarejo.TabIndex = 2;
            this.lblValorVarejo.Text = "Valor no Varejo";
            // 
            // txtProdutoPeso
            // 
            this.txtProdutoPeso.Location = new System.Drawing.Point(56, 241);
            this.txtProdutoPeso.Name = "txtProdutoPeso";
            this.txtProdutoPeso.Size = new System.Drawing.Size(329, 34);
            this.txtProdutoPeso.TabIndex = 7;
            // 
            // lblProdutoPeso
            // 
            this.lblProdutoPeso.AutoSize = true;
            this.lblProdutoPeso.ForeColor = System.Drawing.Color.White;
            this.lblProdutoPeso.Location = new System.Drawing.Point(54, 210);
            this.lblProdutoPeso.Name = "lblProdutoPeso";
            this.lblProdutoPeso.Size = new System.Drawing.Size(52, 28);
            this.lblProdutoPeso.TabIndex = 6;
            this.lblProdutoPeso.Text = "Peso";
            // 
            // btnProdutoAdicionar
            // 
            this.btnProdutoAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.btnProdutoAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutoAdicionar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutoAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnProdutoAdicionar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProdutoAdicionar.IconColor = System.Drawing.Color.Black;
            this.btnProdutoAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProdutoAdicionar.Location = new System.Drawing.Point(9, 344);
            this.btnProdutoAdicionar.Name = "btnProdutoAdicionar";
            this.btnProdutoAdicionar.Size = new System.Drawing.Size(343, 74);
            this.btnProdutoAdicionar.TabIndex = 31;
            this.btnProdutoAdicionar.Text = "Adicionar";
            this.btnProdutoAdicionar.UseVisualStyleBackColor = false;
            this.btnProdutoAdicionar.Click += new System.EventHandler(this.btnProdutoAdicionar_Click);
            // 
            // btnProdutoEditar
            // 
            this.btnProdutoEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnProdutoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutoEditar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutoEditar.ForeColor = System.Drawing.Color.White;
            this.btnProdutoEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProdutoEditar.IconColor = System.Drawing.Color.Black;
            this.btnProdutoEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProdutoEditar.Location = new System.Drawing.Point(358, 344);
            this.btnProdutoEditar.Name = "btnProdutoEditar";
            this.btnProdutoEditar.Size = new System.Drawing.Size(335, 73);
            this.btnProdutoEditar.TabIndex = 32;
            this.btnProdutoEditar.Text = "Editar";
            this.btnProdutoEditar.UseVisualStyleBackColor = false;
            this.btnProdutoEditar.Click += new System.EventHandler(this.btnProdutoEditar_Click);
            // 
            // dataProduto
            // 
            this.dataProduto.AllowUserToAddRows = false;
            this.dataProduto.AllowUserToDeleteRows = false;
            this.dataProduto.AllowUserToResizeColumns = false;
            this.dataProduto.AllowUserToResizeRows = false;
            this.dataProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProduto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.dataProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId});
            this.dataProduto.Location = new System.Drawing.Point(9, 435);
            this.dataProduto.Name = "dataProduto";
            this.dataProduto.RowHeadersVisible = false;
            this.dataProduto.RowHeadersWidth = 51;
            this.dataProduto.RowTemplate.Height = 25;
            this.dataProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProduto.Size = new System.Drawing.Size(1356, 325);
            this.dataProduto.TabIndex = 30;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "Id";
            this.ColumnId.FillWeight = 25F;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            // 
            // groupProdutoInfo
            // 
            this.groupProdutoInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupProdutoInfo.Controls.Add(this.txtProdutosCodBar);
            this.groupProdutoInfo.Controls.Add(this.lblProdutosCodBar);
            this.groupProdutoInfo.Controls.Add(this.lblProdutoObs);
            this.groupProdutoInfo.Controls.Add(this.txtProdutoObs);
            this.groupProdutoInfo.Controls.Add(this.lblProdutoNome);
            this.groupProdutoInfo.Controls.Add(this.txtValorVarejo);
            this.groupProdutoInfo.Controls.Add(this.txtValorAtacado);
            this.groupProdutoInfo.Controls.Add(this.txtProdutoNome);
            this.groupProdutoInfo.Controls.Add(this.lblValorAtacado);
            this.groupProdutoInfo.Controls.Add(this.lblValorVarejo);
            this.groupProdutoInfo.Controls.Add(this.txtProdutoPeso);
            this.groupProdutoInfo.Controls.Add(this.lblProdutoPeso);
            this.groupProdutoInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupProdutoInfo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.groupProdutoInfo.ForeColor = System.Drawing.Color.White;
            this.groupProdutoInfo.Location = new System.Drawing.Point(9, 9);
            this.groupProdutoInfo.Name = "groupProdutoInfo";
            this.groupProdutoInfo.Size = new System.Drawing.Size(1356, 330);
            this.groupProdutoInfo.TabIndex = 28;
            this.groupProdutoInfo.TabStop = false;
            this.groupProdutoInfo.Text = "Informações do Produto";
            // 
            // txtProdutosCodBar
            // 
            this.txtProdutosCodBar.Location = new System.Drawing.Point(837, 92);
            this.txtProdutosCodBar.MaxLength = 100;
            this.txtProdutosCodBar.Name = "txtProdutosCodBar";
            this.txtProdutosCodBar.Size = new System.Drawing.Size(439, 34);
            this.txtProdutosCodBar.TabIndex = 13;
            // 
            // lblProdutosCodBar
            // 
            this.lblProdutosCodBar.AutoSize = true;
            this.lblProdutosCodBar.Location = new System.Drawing.Point(832, 61);
            this.lblProdutosCodBar.Name = "lblProdutosCodBar";
            this.lblProdutosCodBar.Size = new System.Drawing.Size(163, 28);
            this.lblProdutosCodBar.TabIndex = 12;
            this.lblProdutosCodBar.Text = "Codigo de barras";
            // 
            // btnProdutoCancelar
            // 
            this.btnProdutoCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnProdutoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutoCancelar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutoCancelar.ForeColor = System.Drawing.Color.White;
            this.btnProdutoCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProdutoCancelar.IconColor = System.Drawing.Color.Black;
            this.btnProdutoCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProdutoCancelar.Location = new System.Drawing.Point(699, 345);
            this.btnProdutoCancelar.Name = "btnProdutoCancelar";
            this.btnProdutoCancelar.Size = new System.Drawing.Size(350, 74);
            this.btnProdutoCancelar.TabIndex = 33;
            this.btnProdutoCancelar.Text = "Cancelar";
            this.btnProdutoCancelar.UseVisualStyleBackColor = false;
            this.btnProdutoCancelar.Click += new System.EventHandler(this.btnProdutoCancelar_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1377, 772);
            this.Controls.Add(this.btnProdutoExcluir);
            this.Controls.Add(this.btnProdutoEditar);
            this.Controls.Add(this.dataProduto);
            this.Controls.Add(this.btnProdutoAdicionar);
            this.Controls.Add(this.groupProdutoInfo);
            this.Controls.Add(this.btnProdutoCancelar);
            this.Name = "Produtos";
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataProduto)).EndInit();
            this.groupProdutoInfo.ResumeLayout(false);
            this.groupProdutoInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnProdutoExcluir;
        private System.Windows.Forms.Label lblProdutoObs;
        private System.Windows.Forms.RichTextBox txtProdutoObs;
        private System.Windows.Forms.Label lblProdutoNome;
        private System.Windows.Forms.TextBox txtValorVarejo;
        private System.Windows.Forms.TextBox txtValorAtacado;
        private System.Windows.Forms.TextBox txtProdutoNome;
        private System.Windows.Forms.Label lblValorAtacado;
        private System.Windows.Forms.Label lblValorVarejo;
        private System.Windows.Forms.TextBox txtProdutoPeso;
        private System.Windows.Forms.Label lblProdutoPeso;
        private FontAwesome.Sharp.IconButton btnProdutoAdicionar;
        private FontAwesome.Sharp.IconButton btnProdutoEditar;
        private System.Windows.Forms.DataGridView dataProduto;
        private System.Windows.Forms.GroupBox groupProdutoInfo;
        private FontAwesome.Sharp.IconButton btnProdutoCancelar;
        private System.Windows.Forms.TextBox txtProdutosCodBar;
        private System.Windows.Forms.Label lblProdutosCodBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
    }
}