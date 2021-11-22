
namespace EstoquIN.View
{
    partial class Compras
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
            this.groupCompraStatus = new System.Windows.Forms.GroupBox();
            this.checkCompraStatus = new System.Windows.Forms.CheckBox();
            this.groupCompraInfo = new System.Windows.Forms.GroupBox();
            this.txtCompraValorUnit = new System.Windows.Forms.TextBox();
            this.lblCompraValorUnit = new System.Windows.Forms.Label();
            this.cbCompraFormaPagamento = new System.Windows.Forms.ComboBox();
            this.dateCompraData = new System.Windows.Forms.DateTimePicker();
            this.lblCompraData = new System.Windows.Forms.Label();
            this.lblCompraQuantidade = new System.Windows.Forms.Label();
            this.txtCompraQuantidade = new System.Windows.Forms.TextBox();
            this.cbCompraProdutoFornecido = new System.Windows.Forms.ComboBox();
            this.cbCompraFornecedor = new System.Windows.Forms.ComboBox();
            this.lblCompraFornecedor = new System.Windows.Forms.Label();
            this.txtCompraValorTotal = new System.Windows.Forms.TextBox();
            this.lblCompraValorTotal = new System.Windows.Forms.Label();
            this.lblCompraProdutoFornecido = new System.Windows.Forms.Label();
            this.lblCompraFormaPagamento = new System.Windows.Forms.Label();
            this.btnCompraAdicionar = new FontAwesome.Sharp.IconButton();
            this.btnCompraEditar = new FontAwesome.Sharp.IconButton();
            this.dataCompra = new System.Windows.Forms.DataGridView();
            this.btnCompraCancelar = new FontAwesome.Sharp.IconButton();
            this.btnCompraExcluir = new FontAwesome.Sharp.IconButton();
            this.groupCompraStatus.SuspendLayout();
            this.groupCompraInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupCompraStatus
            // 
            this.groupCompraStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupCompraStatus.Controls.Add(this.checkCompraStatus);
            this.groupCompraStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupCompraStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupCompraStatus.ForeColor = System.Drawing.Color.White;
            this.groupCompraStatus.Location = new System.Drawing.Point(622, 13);
            this.groupCompraStatus.Name = "groupCompraStatus";
            this.groupCompraStatus.Size = new System.Drawing.Size(326, 248);
            this.groupCompraStatus.TabIndex = 42;
            this.groupCompraStatus.TabStop = false;
            this.groupCompraStatus.Text = "Status da Compra";
            // 
            // checkCompraStatus
            // 
            this.checkCompraStatus.AutoSize = true;
            this.checkCompraStatus.Location = new System.Drawing.Point(16, 28);
            this.checkCompraStatus.Name = "checkCompraStatus";
            this.checkCompraStatus.Size = new System.Drawing.Size(155, 25);
            this.checkCompraStatus.TabIndex = 0;
            this.checkCompraStatus.Text = "Compra finalizada";
            this.checkCompraStatus.UseVisualStyleBackColor = true;
            // 
            // groupCompraInfo
            // 
            this.groupCompraInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupCompraInfo.Controls.Add(this.txtCompraValorUnit);
            this.groupCompraInfo.Controls.Add(this.lblCompraValorUnit);
            this.groupCompraInfo.Controls.Add(this.cbCompraFormaPagamento);
            this.groupCompraInfo.Controls.Add(this.dateCompraData);
            this.groupCompraInfo.Controls.Add(this.lblCompraData);
            this.groupCompraInfo.Controls.Add(this.lblCompraQuantidade);
            this.groupCompraInfo.Controls.Add(this.txtCompraQuantidade);
            this.groupCompraInfo.Controls.Add(this.cbCompraProdutoFornecido);
            this.groupCompraInfo.Controls.Add(this.cbCompraFornecedor);
            this.groupCompraInfo.Controls.Add(this.lblCompraFornecedor);
            this.groupCompraInfo.Controls.Add(this.txtCompraValorTotal);
            this.groupCompraInfo.Controls.Add(this.lblCompraValorTotal);
            this.groupCompraInfo.Controls.Add(this.lblCompraProdutoFornecido);
            this.groupCompraInfo.Controls.Add(this.lblCompraFormaPagamento);
            this.groupCompraInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupCompraInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupCompraInfo.ForeColor = System.Drawing.Color.White;
            this.groupCompraInfo.Location = new System.Drawing.Point(12, 10);
            this.groupCompraInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupCompraInfo.Name = "groupCompraInfo";
            this.groupCompraInfo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupCompraInfo.Size = new System.Drawing.Size(601, 332);
            this.groupCompraInfo.TabIndex = 36;
            this.groupCompraInfo.TabStop = false;
            this.groupCompraInfo.Text = "Compra de material";
            // 
            // txtCompraValorUnit
            // 
            this.txtCompraValorUnit.Location = new System.Drawing.Point(422, 139);
            this.txtCompraValorUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCompraValorUnit.Name = "txtCompraValorUnit";
            this.txtCompraValorUnit.Size = new System.Drawing.Size(133, 34);
            this.txtCompraValorUnit.TabIndex = 20;
            // 
            // lblCompraValorUnit
            // 
            this.lblCompraValorUnit.AutoSize = true;
            this.lblCompraValorUnit.ForeColor = System.Drawing.Color.White;
            this.lblCompraValorUnit.Location = new System.Drawing.Point(423, 109);
            this.lblCompraValorUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompraValorUnit.Name = "lblCompraValorUnit";
            this.lblCompraValorUnit.Size = new System.Drawing.Size(133, 28);
            this.lblCompraValorUnit.TabIndex = 19;
            this.lblCompraValorUnit.Text = "Valor Unitario";
            // 
            // cbCompraFormaPagamento
            // 
            this.cbCompraFormaPagamento.FormattingEnabled = true;
            this.cbCompraFormaPagamento.Location = new System.Drawing.Point(20, 220);
            this.cbCompraFormaPagamento.Name = "cbCompraFormaPagamento";
            this.cbCompraFormaPagamento.Size = new System.Drawing.Size(199, 36);
            this.cbCompraFormaPagamento.TabIndex = 18;
            // 
            // dateCompraData
            // 
            this.dateCompraData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCompraData.Location = new System.Drawing.Point(263, 218);
            this.dateCompraData.Name = "dateCompraData";
            this.dateCompraData.Size = new System.Drawing.Size(120, 34);
            this.dateCompraData.TabIndex = 17;
            // 
            // lblCompraData
            // 
            this.lblCompraData.AutoSize = true;
            this.lblCompraData.ForeColor = System.Drawing.Color.White;
            this.lblCompraData.Location = new System.Drawing.Point(264, 187);
            this.lblCompraData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompraData.Name = "lblCompraData";
            this.lblCompraData.Size = new System.Drawing.Size(53, 28);
            this.lblCompraData.TabIndex = 16;
            this.lblCompraData.Text = "Data";
            // 
            // lblCompraQuantidade
            // 
            this.lblCompraQuantidade.AutoSize = true;
            this.lblCompraQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblCompraQuantidade.Location = new System.Drawing.Point(423, 44);
            this.lblCompraQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompraQuantidade.Name = "lblCompraQuantidade";
            this.lblCompraQuantidade.Size = new System.Drawing.Size(115, 28);
            this.lblCompraQuantidade.TabIndex = 15;
            this.lblCompraQuantidade.Text = "Quantidade";
            // 
            // txtCompraQuantidade
            // 
            this.txtCompraQuantidade.Location = new System.Drawing.Point(422, 70);
            this.txtCompraQuantidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCompraQuantidade.Name = "txtCompraQuantidade";
            this.txtCompraQuantidade.Size = new System.Drawing.Size(133, 34);
            this.txtCompraQuantidade.TabIndex = 14;
            // 
            // cbCompraProdutoFornecido
            // 
            this.cbCompraProdutoFornecido.FormattingEnabled = true;
            this.cbCompraProdutoFornecido.Location = new System.Drawing.Point(17, 137);
            this.cbCompraProdutoFornecido.Name = "cbCompraProdutoFornecido";
            this.cbCompraProdutoFornecido.Size = new System.Drawing.Size(366, 36);
            this.cbCompraProdutoFornecido.TabIndex = 13;
            // 
            // cbCompraFornecedor
            // 
            this.cbCompraFornecedor.FormattingEnabled = true;
            this.cbCompraFornecedor.Location = new System.Drawing.Point(17, 70);
            this.cbCompraFornecedor.Name = "cbCompraFornecedor";
            this.cbCompraFornecedor.Size = new System.Drawing.Size(366, 36);
            this.cbCompraFornecedor.TabIndex = 12;
            // 
            // lblCompraFornecedor
            // 
            this.lblCompraFornecedor.AutoSize = true;
            this.lblCompraFornecedor.ForeColor = System.Drawing.Color.White;
            this.lblCompraFornecedor.Location = new System.Drawing.Point(21, 44);
            this.lblCompraFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompraFornecedor.Name = "lblCompraFornecedor";
            this.lblCompraFornecedor.Size = new System.Drawing.Size(72, 28);
            this.lblCompraFornecedor.TabIndex = 0;
            this.lblCompraFornecedor.Text = "Cliente";
            // 
            // txtCompraValorTotal
            // 
            this.txtCompraValorTotal.Location = new System.Drawing.Point(422, 218);
            this.txtCompraValorTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCompraValorTotal.Name = "txtCompraValorTotal";
            this.txtCompraValorTotal.Size = new System.Drawing.Size(133, 34);
            this.txtCompraValorTotal.TabIndex = 9;
            // 
            // lblCompraValorTotal
            // 
            this.lblCompraValorTotal.AutoSize = true;
            this.lblCompraValorTotal.ForeColor = System.Drawing.Color.White;
            this.lblCompraValorTotal.Location = new System.Drawing.Point(423, 187);
            this.lblCompraValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompraValorTotal.Name = "lblCompraValorTotal";
            this.lblCompraValorTotal.Size = new System.Drawing.Size(104, 28);
            this.lblCompraValorTotal.TabIndex = 8;
            this.lblCompraValorTotal.Text = "Valor Total";
            // 
            // lblCompraProdutoFornecido
            // 
            this.lblCompraProdutoFornecido.AutoSize = true;
            this.lblCompraProdutoFornecido.ForeColor = System.Drawing.Color.White;
            this.lblCompraProdutoFornecido.Location = new System.Drawing.Point(21, 109);
            this.lblCompraProdutoFornecido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompraProdutoFornecido.Name = "lblCompraProdutoFornecido";
            this.lblCompraProdutoFornecido.Size = new System.Drawing.Size(84, 28);
            this.lblCompraProdutoFornecido.TabIndex = 2;
            this.lblCompraProdutoFornecido.Text = "Produto";
            // 
            // lblCompraFormaPagamento
            // 
            this.lblCompraFormaPagamento.AutoSize = true;
            this.lblCompraFormaPagamento.ForeColor = System.Drawing.Color.White;
            this.lblCompraFormaPagamento.Location = new System.Drawing.Point(21, 187);
            this.lblCompraFormaPagamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompraFormaPagamento.Name = "lblCompraFormaPagamento";
            this.lblCompraFormaPagamento.Size = new System.Drawing.Size(199, 28);
            this.lblCompraFormaPagamento.TabIndex = 6;
            this.lblCompraFormaPagamento.Text = "Forma de Pagamento";
            // 
            // btnCompraAdicionar
            // 
            this.btnCompraAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnCompraAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraAdicionar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompraAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnCompraAdicionar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCompraAdicionar.IconColor = System.Drawing.Color.Black;
            this.btnCompraAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompraAdicionar.Location = new System.Drawing.Point(621, 267);
            this.btnCompraAdicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCompraAdicionar.Name = "btnCompraAdicionar";
            this.btnCompraAdicionar.Size = new System.Drawing.Size(159, 34);
            this.btnCompraAdicionar.TabIndex = 38;
            this.btnCompraAdicionar.Text = "Adicionar";
            this.btnCompraAdicionar.UseVisualStyleBackColor = false;
            // 
            // btnCompraEditar
            // 
            this.btnCompraEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnCompraEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraEditar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompraEditar.ForeColor = System.Drawing.Color.White;
            this.btnCompraEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCompraEditar.IconColor = System.Drawing.Color.Black;
            this.btnCompraEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompraEditar.Location = new System.Drawing.Point(621, 308);
            this.btnCompraEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCompraEditar.Name = "btnCompraEditar";
            this.btnCompraEditar.Size = new System.Drawing.Size(159, 34);
            this.btnCompraEditar.TabIndex = 39;
            this.btnCompraEditar.Text = "Editar";
            this.btnCompraEditar.UseVisualStyleBackColor = false;
            // 
            // dataCompra
            // 
            this.dataCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.dataCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCompra.Location = new System.Drawing.Point(12, 348);
            this.dataCompra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataCompra.Name = "dataCompra";
            this.dataCompra.RowHeadersWidth = 51;
            this.dataCompra.RowTemplate.Height = 25;
            this.dataCompra.Size = new System.Drawing.Size(937, 184);
            this.dataCompra.TabIndex = 37;
            // 
            // btnCompraCancelar
            // 
            this.btnCompraCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnCompraCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraCancelar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompraCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCompraCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCompraCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCompraCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompraCancelar.Location = new System.Drawing.Point(790, 267);
            this.btnCompraCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCompraCancelar.Name = "btnCompraCancelar";
            this.btnCompraCancelar.Size = new System.Drawing.Size(159, 34);
            this.btnCompraCancelar.TabIndex = 40;
            this.btnCompraCancelar.Text = "Cancelar";
            this.btnCompraCancelar.UseVisualStyleBackColor = false;
            // 
            // btnCompraExcluir
            // 
            this.btnCompraExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnCompraExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraExcluir.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompraExcluir.ForeColor = System.Drawing.Color.White;
            this.btnCompraExcluir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCompraExcluir.IconColor = System.Drawing.Color.Black;
            this.btnCompraExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompraExcluir.Location = new System.Drawing.Point(790, 308);
            this.btnCompraExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCompraExcluir.Name = "btnCompraExcluir";
            this.btnCompraExcluir.Size = new System.Drawing.Size(159, 34);
            this.btnCompraExcluir.TabIndex = 41;
            this.btnCompraExcluir.Text = "Excluir";
            this.btnCompraExcluir.UseVisualStyleBackColor = false;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(960, 542);
            this.Controls.Add(this.groupCompraStatus);
            this.Controls.Add(this.groupCompraInfo);
            this.Controls.Add(this.btnCompraAdicionar);
            this.Controls.Add(this.btnCompraEditar);
            this.Controls.Add(this.dataCompra);
            this.Controls.Add(this.btnCompraCancelar);
            this.Controls.Add(this.btnCompraExcluir);
            this.Name = "Compras";
            this.Text = "Compras";
            this.groupCompraStatus.ResumeLayout(false);
            this.groupCompraStatus.PerformLayout();
            this.groupCompraInfo.ResumeLayout(false);
            this.groupCompraInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupCompraStatus;
        private System.Windows.Forms.CheckBox checkCompraStatus;
        private System.Windows.Forms.GroupBox groupCompraInfo;
        private System.Windows.Forms.TextBox txtCompraValorUnit;
        private System.Windows.Forms.Label lblCompraValorUnit;
        private System.Windows.Forms.ComboBox cbCompraFormaPagamento;
        private System.Windows.Forms.DateTimePicker dateCompraData;
        private System.Windows.Forms.Label lblCompraData;
        private System.Windows.Forms.Label lblCompraQuantidade;
        private System.Windows.Forms.TextBox txtCompraQuantidade;
        private System.Windows.Forms.ComboBox cbCompraProdutoFornecido;
        private System.Windows.Forms.ComboBox cbCompraFornecedor;
        private System.Windows.Forms.Label lblCompraFornecedor;
        private System.Windows.Forms.TextBox txtCompraValorTotal;
        private System.Windows.Forms.Label lblCompraValorTotal;
        private System.Windows.Forms.Label lblCompraProdutoFornecido;
        private System.Windows.Forms.Label lblCompraFormaPagamento;
        private FontAwesome.Sharp.IconButton btnCompraAdicionar;
        private FontAwesome.Sharp.IconButton btnCompraEditar;
        private System.Windows.Forms.DataGridView dataCompra;
        private FontAwesome.Sharp.IconButton btnCompraCancelar;
        private FontAwesome.Sharp.IconButton btnCompraExcluir;
    }
}