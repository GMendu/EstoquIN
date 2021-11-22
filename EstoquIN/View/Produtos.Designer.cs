
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
            this.groupProdutoInfo = new System.Windows.Forms.GroupBox();
            this.btnProdutoCancelar = new FontAwesome.Sharp.IconButton();
            this.groupProdutoFornecedor = new System.Windows.Forms.GroupBox();
            this.lblProdutosCodBar = new System.Windows.Forms.Label();
            this.txtProdutosCodBar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduto)).BeginInit();
            this.groupProdutoInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProdutoExcluir
            // 
            this.btnProdutoExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnProdutoExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutoExcluir.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProdutoExcluir.ForeColor = System.Drawing.Color.White;
            this.btnProdutoExcluir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProdutoExcluir.IconColor = System.Drawing.Color.Black;
            this.btnProdutoExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProdutoExcluir.Location = new System.Drawing.Point(789, 308);
            this.btnProdutoExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProdutoExcluir.Name = "btnProdutoExcluir";
            this.btnProdutoExcluir.Size = new System.Drawing.Size(159, 34);
            this.btnProdutoExcluir.TabIndex = 34;
            this.btnProdutoExcluir.Text = "Excluir";
            this.btnProdutoExcluir.UseVisualStyleBackColor = false;
            // 
            // lblProdutoObs
            // 
            this.lblProdutoObs.AutoSize = true;
            this.lblProdutoObs.ForeColor = System.Drawing.Color.White;
            this.lblProdutoObs.Location = new System.Drawing.Point(250, 172);
            this.lblProdutoObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdutoObs.Name = "lblProdutoObs";
            this.lblProdutoObs.Size = new System.Drawing.Size(127, 28);
            this.lblProdutoObs.TabIndex = 11;
            this.lblProdutoObs.Text = "Observações:";
            // 
            // txtProdutoObs
            // 
            this.txtProdutoObs.Location = new System.Drawing.Point(247, 198);
            this.txtProdutoObs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProdutoObs.MaxLength = 65000;
            this.txtProdutoObs.Name = "txtProdutoObs";
            this.txtProdutoObs.Size = new System.Drawing.Size(340, 116);
            this.txtProdutoObs.TabIndex = 10;
            this.txtProdutoObs.Text = "";
            // 
            // lblProdutoNome
            // 
            this.lblProdutoNome.AutoSize = true;
            this.lblProdutoNome.ForeColor = System.Drawing.Color.White;
            this.lblProdutoNome.Location = new System.Drawing.Point(20, 44);
            this.lblProdutoNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdutoNome.Name = "lblProdutoNome";
            this.lblProdutoNome.Size = new System.Drawing.Size(66, 28);
            this.lblProdutoNome.TabIndex = 0;
            this.lblProdutoNome.Text = "Nome";
            // 
            // txtValorVarejo
            // 
            this.txtValorVarejo.Location = new System.Drawing.Point(247, 72);
            this.txtValorVarejo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtValorVarejo.Name = "txtValorVarejo";
            this.txtValorVarejo.Size = new System.Drawing.Size(340, 34);
            this.txtValorVarejo.TabIndex = 3;
            // 
            // txtValorAtacado
            // 
            this.txtValorAtacado.Location = new System.Drawing.Point(247, 135);
            this.txtValorAtacado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtValorAtacado.Name = "txtValorAtacado";
            this.txtValorAtacado.Size = new System.Drawing.Size(340, 34);
            this.txtValorAtacado.TabIndex = 9;
            // 
            // txtProdutoNome
            // 
            this.txtProdutoNome.BackColor = System.Drawing.SystemColors.Menu;
            this.txtProdutoNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdutoNome.Location = new System.Drawing.Point(17, 73);
            this.txtProdutoNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProdutoNome.MaxLength = 45;
            this.txtProdutoNome.Name = "txtProdutoNome";
            this.txtProdutoNome.Size = new System.Drawing.Size(212, 34);
            this.txtProdutoNome.TabIndex = 1;
            // 
            // lblValorAtacado
            // 
            this.lblValorAtacado.AutoSize = true;
            this.lblValorAtacado.ForeColor = System.Drawing.Color.White;
            this.lblValorAtacado.Location = new System.Drawing.Point(250, 106);
            this.lblValorAtacado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorAtacado.Name = "lblValorAtacado";
            this.lblValorAtacado.Size = new System.Drawing.Size(163, 28);
            this.lblValorAtacado.TabIndex = 8;
            this.lblValorAtacado.Text = "Valor no Atacado";
            // 
            // lblValorVarejo
            // 
            this.lblValorVarejo.AutoSize = true;
            this.lblValorVarejo.ForeColor = System.Drawing.Color.White;
            this.lblValorVarejo.Location = new System.Drawing.Point(250, 44);
            this.lblValorVarejo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorVarejo.Name = "lblValorVarejo";
            this.lblValorVarejo.Size = new System.Drawing.Size(145, 28);
            this.lblValorVarejo.TabIndex = 2;
            this.lblValorVarejo.Text = "Valor no Varejo";
            // 
            // txtProdutoPeso
            // 
            this.txtProdutoPeso.Location = new System.Drawing.Point(17, 135);
            this.txtProdutoPeso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProdutoPeso.Name = "txtProdutoPeso";
            this.txtProdutoPeso.Size = new System.Drawing.Size(212, 34);
            this.txtProdutoPeso.TabIndex = 7;
            // 
            // lblProdutoPeso
            // 
            this.lblProdutoPeso.AutoSize = true;
            this.lblProdutoPeso.ForeColor = System.Drawing.Color.White;
            this.lblProdutoPeso.Location = new System.Drawing.Point(20, 106);
            this.lblProdutoPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdutoPeso.Name = "lblProdutoPeso";
            this.lblProdutoPeso.Size = new System.Drawing.Size(52, 28);
            this.lblProdutoPeso.TabIndex = 6;
            this.lblProdutoPeso.Text = "Peso";
            // 
            // btnProdutoAdicionar
            // 
            this.btnProdutoAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnProdutoAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutoAdicionar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProdutoAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnProdutoAdicionar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProdutoAdicionar.IconColor = System.Drawing.Color.Black;
            this.btnProdutoAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProdutoAdicionar.Location = new System.Drawing.Point(620, 267);
            this.btnProdutoAdicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProdutoAdicionar.Name = "btnProdutoAdicionar";
            this.btnProdutoAdicionar.Size = new System.Drawing.Size(159, 34);
            this.btnProdutoAdicionar.TabIndex = 31;
            this.btnProdutoAdicionar.Text = "Adicionar";
            this.btnProdutoAdicionar.UseVisualStyleBackColor = false;
            // 
            // btnProdutoEditar
            // 
            this.btnProdutoEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnProdutoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutoEditar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProdutoEditar.ForeColor = System.Drawing.Color.White;
            this.btnProdutoEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProdutoEditar.IconColor = System.Drawing.Color.Black;
            this.btnProdutoEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProdutoEditar.Location = new System.Drawing.Point(620, 308);
            this.btnProdutoEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProdutoEditar.Name = "btnProdutoEditar";
            this.btnProdutoEditar.Size = new System.Drawing.Size(159, 34);
            this.btnProdutoEditar.TabIndex = 32;
            this.btnProdutoEditar.Text = "Editar";
            this.btnProdutoEditar.UseVisualStyleBackColor = false;
            // 
            // dataProduto
            // 
            this.dataProduto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.dataProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProduto.Location = new System.Drawing.Point(11, 348);
            this.dataProduto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataProduto.Name = "dataProduto";
            this.dataProduto.RowHeadersWidth = 51;
            this.dataProduto.RowTemplate.Height = 25;
            this.dataProduto.Size = new System.Drawing.Size(937, 184);
            this.dataProduto.TabIndex = 30;
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
            this.groupProdutoInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupProdutoInfo.ForeColor = System.Drawing.Color.White;
            this.groupProdutoInfo.Location = new System.Drawing.Point(11, 10);
            this.groupProdutoInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupProdutoInfo.Name = "groupProdutoInfo";
            this.groupProdutoInfo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupProdutoInfo.Size = new System.Drawing.Size(601, 332);
            this.groupProdutoInfo.TabIndex = 28;
            this.groupProdutoInfo.TabStop = false;
            this.groupProdutoInfo.Text = "Informações do Produto";
            // 
            // btnProdutoCancelar
            // 
            this.btnProdutoCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnProdutoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutoCancelar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProdutoCancelar.ForeColor = System.Drawing.Color.White;
            this.btnProdutoCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProdutoCancelar.IconColor = System.Drawing.Color.Black;
            this.btnProdutoCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProdutoCancelar.Location = new System.Drawing.Point(789, 267);
            this.btnProdutoCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProdutoCancelar.Name = "btnProdutoCancelar";
            this.btnProdutoCancelar.Size = new System.Drawing.Size(159, 34);
            this.btnProdutoCancelar.TabIndex = 33;
            this.btnProdutoCancelar.Text = "Cancelar";
            this.btnProdutoCancelar.UseVisualStyleBackColor = false;
            // 
            // groupProdutoFornecedor
            // 
            this.groupProdutoFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupProdutoFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupProdutoFornecedor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupProdutoFornecedor.ForeColor = System.Drawing.Color.White;
            this.groupProdutoFornecedor.Location = new System.Drawing.Point(620, 10);
            this.groupProdutoFornecedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupProdutoFornecedor.Name = "groupProdutoFornecedor";
            this.groupProdutoFornecedor.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupProdutoFornecedor.Size = new System.Drawing.Size(329, 251);
            this.groupProdutoFornecedor.TabIndex = 29;
            this.groupProdutoFornecedor.TabStop = false;
            this.groupProdutoFornecedor.Text = "Possível Fornecedor";
            // 
            // lblProdutosCodBar
            // 
            this.lblProdutosCodBar.AutoSize = true;
            this.lblProdutosCodBar.Location = new System.Drawing.Point(17, 172);
            this.lblProdutosCodBar.Name = "lblProdutosCodBar";
            this.lblProdutosCodBar.Size = new System.Drawing.Size(163, 28);
            this.lblProdutosCodBar.TabIndex = 12;
            this.lblProdutosCodBar.Text = "Codigo de barras";
            // 
            // txtProdutosCodBar
            // 
            this.txtProdutosCodBar.Location = new System.Drawing.Point(17, 203);
            this.txtProdutosCodBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProdutosCodBar.MaxLength = 100;
            this.txtProdutosCodBar.Name = "txtProdutosCodBar";
            this.txtProdutosCodBar.Size = new System.Drawing.Size(212, 34);
            this.txtProdutosCodBar.TabIndex = 13;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(960, 542);
            this.Controls.Add(this.btnProdutoExcluir);
            this.Controls.Add(this.btnProdutoAdicionar);
            this.Controls.Add(this.btnProdutoEditar);
            this.Controls.Add(this.dataProduto);
            this.Controls.Add(this.groupProdutoInfo);
            this.Controls.Add(this.btnProdutoCancelar);
            this.Controls.Add(this.groupProdutoFornecedor);
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
        private System.Windows.Forms.GroupBox groupProdutoFornecedor;
        private System.Windows.Forms.TextBox txtProdutosCodBar;
        private System.Windows.Forms.Label lblProdutosCodBar;
    }
}