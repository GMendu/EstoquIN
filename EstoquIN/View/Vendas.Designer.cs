
namespace EstoquIN.View
{
    partial class Vendas
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
            this.groupVendaInfo = new System.Windows.Forms.GroupBox();
            this.txtVendaValorUnit = new System.Windows.Forms.TextBox();
            this.lblVendaValorUnit = new System.Windows.Forms.Label();
            this.cbVendaFormaPagamento = new System.Windows.Forms.ComboBox();
            this.dateVendaData = new System.Windows.Forms.DateTimePicker();
            this.lblVendaData = new System.Windows.Forms.Label();
            this.lblVendaQuantidade = new System.Windows.Forms.Label();
            this.txtVendaQuantidade = new System.Windows.Forms.TextBox();
            this.cbVendaProdutoFornecido = new System.Windows.Forms.ComboBox();
            this.cbVendaFornecedor = new System.Windows.Forms.ComboBox();
            this.lblVendaFornecedor = new System.Windows.Forms.Label();
            this.txtVendaValorTotal = new System.Windows.Forms.TextBox();
            this.lblVendaValorTotal = new System.Windows.Forms.Label();
            this.lblVendaProdutoFornecido = new System.Windows.Forms.Label();
            this.lblVendaFormaPagamento = new System.Windows.Forms.Label();
            this.btnVendaAdicionar = new FontAwesome.Sharp.IconButton();
            this.btnVendaEditar = new FontAwesome.Sharp.IconButton();
            this.dataVenda = new System.Windows.Forms.DataGridView();
            this.btnVendaCancelar = new FontAwesome.Sharp.IconButton();
            this.btnVendaExcluir = new FontAwesome.Sharp.IconButton();
            this.groupVendaStatus = new System.Windows.Forms.GroupBox();
            this.checkVendaStatus = new System.Windows.Forms.CheckBox();
            this.groupVendaInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVenda)).BeginInit();
            this.groupVendaStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupVendaInfo
            // 
            this.groupVendaInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupVendaInfo.Controls.Add(this.txtVendaValorUnit);
            this.groupVendaInfo.Controls.Add(this.lblVendaValorUnit);
            this.groupVendaInfo.Controls.Add(this.cbVendaFormaPagamento);
            this.groupVendaInfo.Controls.Add(this.dateVendaData);
            this.groupVendaInfo.Controls.Add(this.lblVendaData);
            this.groupVendaInfo.Controls.Add(this.lblVendaQuantidade);
            this.groupVendaInfo.Controls.Add(this.txtVendaQuantidade);
            this.groupVendaInfo.Controls.Add(this.cbVendaProdutoFornecido);
            this.groupVendaInfo.Controls.Add(this.cbVendaFornecedor);
            this.groupVendaInfo.Controls.Add(this.lblVendaFornecedor);
            this.groupVendaInfo.Controls.Add(this.txtVendaValorTotal);
            this.groupVendaInfo.Controls.Add(this.lblVendaValorTotal);
            this.groupVendaInfo.Controls.Add(this.lblVendaProdutoFornecido);
            this.groupVendaInfo.Controls.Add(this.lblVendaFormaPagamento);
            this.groupVendaInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupVendaInfo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.groupVendaInfo.ForeColor = System.Drawing.Color.White;
            this.groupVendaInfo.Location = new System.Drawing.Point(9, 9);
            this.groupVendaInfo.Name = "groupVendaInfo";
            this.groupVendaInfo.Size = new System.Drawing.Size(625, 326);
            this.groupVendaInfo.TabIndex = 28;
            this.groupVendaInfo.TabStop = false;
            this.groupVendaInfo.Text = "Venda do Produto";
            // 
            // txtVendaValorUnit
            // 
            this.txtVendaValorUnit.Location = new System.Drawing.Point(435, 139);
            this.txtVendaValorUnit.Name = "txtVendaValorUnit";
            this.txtVendaValorUnit.Size = new System.Drawing.Size(161, 34);
            this.txtVendaValorUnit.TabIndex = 20;
            // 
            // lblVendaValorUnit
            // 
            this.lblVendaValorUnit.AutoSize = true;
            this.lblVendaValorUnit.ForeColor = System.Drawing.Color.White;
            this.lblVendaValorUnit.Location = new System.Drawing.Point(430, 106);
            this.lblVendaValorUnit.Name = "lblVendaValorUnit";
            this.lblVendaValorUnit.Size = new System.Drawing.Size(133, 28);
            this.lblVendaValorUnit.TabIndex = 19;
            this.lblVendaValorUnit.Text = "Valor Unitario";
            // 
            // cbVendaFormaPagamento
            // 
            this.cbVendaFormaPagamento.FormattingEnabled = true;
            this.cbVendaFormaPagamento.Location = new System.Drawing.Point(14, 209);
            this.cbVendaFormaPagamento.Name = "cbVendaFormaPagamento";
            this.cbVendaFormaPagamento.Size = new System.Drawing.Size(232, 36);
            this.cbVendaFormaPagamento.TabIndex = 18;
            // 
            // dateVendaData
            // 
            this.dateVendaData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVendaData.Location = new System.Drawing.Point(252, 211);
            this.dateVendaData.Name = "dateVendaData";
            this.dateVendaData.Size = new System.Drawing.Size(143, 34);
            this.dateVendaData.TabIndex = 17;
            // 
            // lblVendaData
            // 
            this.lblVendaData.AutoSize = true;
            this.lblVendaData.ForeColor = System.Drawing.Color.White;
            this.lblVendaData.Location = new System.Drawing.Point(256, 180);
            this.lblVendaData.Name = "lblVendaData";
            this.lblVendaData.Size = new System.Drawing.Size(53, 28);
            this.lblVendaData.TabIndex = 16;
            this.lblVendaData.Text = "Data";
            // 
            // lblVendaQuantidade
            // 
            this.lblVendaQuantidade.AutoSize = true;
            this.lblVendaQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblVendaQuantidade.Location = new System.Drawing.Point(430, 38);
            this.lblVendaQuantidade.Name = "lblVendaQuantidade";
            this.lblVendaQuantidade.Size = new System.Drawing.Size(115, 28);
            this.lblVendaQuantidade.TabIndex = 15;
            this.lblVendaQuantidade.Text = "Quantidade";
            // 
            // txtVendaQuantidade
            // 
            this.txtVendaQuantidade.Location = new System.Drawing.Point(435, 69);
            this.txtVendaQuantidade.Name = "txtVendaQuantidade";
            this.txtVendaQuantidade.Size = new System.Drawing.Size(161, 34);
            this.txtVendaQuantidade.TabIndex = 14;
            // 
            // cbVendaProdutoFornecido
            // 
            this.cbVendaProdutoFornecido.FormattingEnabled = true;
            this.cbVendaProdutoFornecido.Location = new System.Drawing.Point(14, 139);
            this.cbVendaProdutoFornecido.Name = "cbVendaProdutoFornecido";
            this.cbVendaProdutoFornecido.Size = new System.Drawing.Size(381, 36);
            this.cbVendaProdutoFornecido.TabIndex = 13;
            // 
            // cbVendaFornecedor
            // 
            this.cbVendaFornecedor.FormattingEnabled = true;
            this.cbVendaFornecedor.Location = new System.Drawing.Point(17, 69);
            this.cbVendaFornecedor.Name = "cbVendaFornecedor";
            this.cbVendaFornecedor.Size = new System.Drawing.Size(378, 36);
            this.cbVendaFornecedor.TabIndex = 12;
            // 
            // lblVendaFornecedor
            // 
            this.lblVendaFornecedor.AutoSize = true;
            this.lblVendaFornecedor.ForeColor = System.Drawing.Color.White;
            this.lblVendaFornecedor.Location = new System.Drawing.Point(17, 38);
            this.lblVendaFornecedor.Name = "lblVendaFornecedor";
            this.lblVendaFornecedor.Size = new System.Drawing.Size(72, 28);
            this.lblVendaFornecedor.TabIndex = 0;
            this.lblVendaFornecedor.Text = "Cliente";
            // 
            // txtVendaValorTotal
            // 
            this.txtVendaValorTotal.Location = new System.Drawing.Point(435, 209);
            this.txtVendaValorTotal.Name = "txtVendaValorTotal";
            this.txtVendaValorTotal.Size = new System.Drawing.Size(161, 34);
            this.txtVendaValorTotal.TabIndex = 9;
            // 
            // lblVendaValorTotal
            // 
            this.lblVendaValorTotal.AutoSize = true;
            this.lblVendaValorTotal.ForeColor = System.Drawing.Color.White;
            this.lblVendaValorTotal.Location = new System.Drawing.Point(430, 176);
            this.lblVendaValorTotal.Name = "lblVendaValorTotal";
            this.lblVendaValorTotal.Size = new System.Drawing.Size(104, 28);
            this.lblVendaValorTotal.TabIndex = 8;
            this.lblVendaValorTotal.Text = "Valor Total";
            // 
            // lblVendaProdutoFornecido
            // 
            this.lblVendaProdutoFornecido.AutoSize = true;
            this.lblVendaProdutoFornecido.ForeColor = System.Drawing.Color.White;
            this.lblVendaProdutoFornecido.Location = new System.Drawing.Point(17, 108);
            this.lblVendaProdutoFornecido.Name = "lblVendaProdutoFornecido";
            this.lblVendaProdutoFornecido.Size = new System.Drawing.Size(84, 28);
            this.lblVendaProdutoFornecido.TabIndex = 2;
            this.lblVendaProdutoFornecido.Text = "Produto";
            // 
            // lblVendaFormaPagamento
            // 
            this.lblVendaFormaPagamento.AutoSize = true;
            this.lblVendaFormaPagamento.ForeColor = System.Drawing.Color.White;
            this.lblVendaFormaPagamento.Location = new System.Drawing.Point(17, 178);
            this.lblVendaFormaPagamento.Name = "lblVendaFormaPagamento";
            this.lblVendaFormaPagamento.Size = new System.Drawing.Size(199, 28);
            this.lblVendaFormaPagamento.TabIndex = 6;
            this.lblVendaFormaPagamento.Text = "Forma de Pagamento";
            // 
            // btnVendaAdicionar
            // 
            this.btnVendaAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnVendaAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendaAdicionar.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnVendaAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnVendaAdicionar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVendaAdicionar.IconColor = System.Drawing.Color.Black;
            this.btnVendaAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendaAdicionar.Location = new System.Drawing.Point(640, 247);
            this.btnVendaAdicionar.Name = "btnVendaAdicionar";
            this.btnVendaAdicionar.Size = new System.Drawing.Size(151, 41);
            this.btnVendaAdicionar.TabIndex = 31;
            this.btnVendaAdicionar.Text = "Adicionar";
            this.btnVendaAdicionar.UseVisualStyleBackColor = false;
            // 
            // btnVendaEditar
            // 
            this.btnVendaEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnVendaEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendaEditar.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnVendaEditar.ForeColor = System.Drawing.Color.White;
            this.btnVendaEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVendaEditar.IconColor = System.Drawing.Color.Black;
            this.btnVendaEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendaEditar.Location = new System.Drawing.Point(640, 294);
            this.btnVendaEditar.Name = "btnVendaEditar";
            this.btnVendaEditar.Size = new System.Drawing.Size(151, 41);
            this.btnVendaEditar.TabIndex = 32;
            this.btnVendaEditar.Text = "Editar";
            this.btnVendaEditar.UseVisualStyleBackColor = false;
            // 
            // dataVenda
            // 
            this.dataVenda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.dataVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVenda.Location = new System.Drawing.Point(9, 341);
            this.dataVenda.Name = "dataVenda";
            this.dataVenda.RowHeadersWidth = 51;
            this.dataVenda.RowTemplate.Height = 25;
            this.dataVenda.Size = new System.Drawing.Size(939, 189);
            this.dataVenda.TabIndex = 30;
            // 
            // btnVendaCancelar
            // 
            this.btnVendaCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnVendaCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendaCancelar.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnVendaCancelar.ForeColor = System.Drawing.Color.White;
            this.btnVendaCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVendaCancelar.IconColor = System.Drawing.Color.Black;
            this.btnVendaCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendaCancelar.Location = new System.Drawing.Point(797, 247);
            this.btnVendaCancelar.Name = "btnVendaCancelar";
            this.btnVendaCancelar.Size = new System.Drawing.Size(151, 41);
            this.btnVendaCancelar.TabIndex = 33;
            this.btnVendaCancelar.Text = "Cancelar";
            this.btnVendaCancelar.UseVisualStyleBackColor = false;
            // 
            // btnVendaExcluir
            // 
            this.btnVendaExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnVendaExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendaExcluir.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnVendaExcluir.ForeColor = System.Drawing.Color.White;
            this.btnVendaExcluir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVendaExcluir.IconColor = System.Drawing.Color.Black;
            this.btnVendaExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendaExcluir.Location = new System.Drawing.Point(797, 294);
            this.btnVendaExcluir.Name = "btnVendaExcluir";
            this.btnVendaExcluir.Size = new System.Drawing.Size(151, 41);
            this.btnVendaExcluir.TabIndex = 34;
            this.btnVendaExcluir.Text = "Excluir";
            this.btnVendaExcluir.UseVisualStyleBackColor = false;
            // 
            // groupVendaStatus
            // 
            this.groupVendaStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupVendaStatus.Controls.Add(this.checkVendaStatus);
            this.groupVendaStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupVendaStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupVendaStatus.ForeColor = System.Drawing.Color.White;
            this.groupVendaStatus.Location = new System.Drawing.Point(640, 9);
            this.groupVendaStatus.Name = "groupVendaStatus";
            this.groupVendaStatus.Size = new System.Drawing.Size(308, 232);
            this.groupVendaStatus.TabIndex = 35;
            this.groupVendaStatus.TabStop = false;
            this.groupVendaStatus.Text = "Status da Venda";
            // 
            // checkVendaStatus
            // 
            this.checkVendaStatus.AutoSize = true;
            this.checkVendaStatus.Location = new System.Drawing.Point(14, 24);
            this.checkVendaStatus.Name = "checkVendaStatus";
            this.checkVendaStatus.Size = new System.Drawing.Size(142, 25);
            this.checkVendaStatus.TabIndex = 0;
            this.checkVendaStatus.Text = "Venda finalizada";
            this.checkVendaStatus.UseVisualStyleBackColor = true;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(960, 542);
            this.Controls.Add(this.groupVendaStatus);
            this.Controls.Add(this.groupVendaInfo);
            this.Controls.Add(this.btnVendaAdicionar);
            this.Controls.Add(this.btnVendaEditar);
            this.Controls.Add(this.dataVenda);
            this.Controls.Add(this.btnVendaCancelar);
            this.Controls.Add(this.btnVendaExcluir);
            this.Name = "Vendas";
            this.Text = "Vendas";
            this.groupVendaInfo.ResumeLayout(false);
            this.groupVendaInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVenda)).EndInit();
            this.groupVendaStatus.ResumeLayout(false);
            this.groupVendaStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupVendaInfo;
        private System.Windows.Forms.Label lblVendaFornecedor;
        private System.Windows.Forms.TextBox txtVendaValorTotal;
        private System.Windows.Forms.Label lblVendaValorTotal;
        private System.Windows.Forms.Label lblVendaProdutoFornecido;
        private System.Windows.Forms.Label lblVendaFormaPagamento;
        private FontAwesome.Sharp.IconButton btnVendaAdicionar;
        private FontAwesome.Sharp.IconButton btnVendaEditar;
        private System.Windows.Forms.DataGridView dataVenda;
        private FontAwesome.Sharp.IconButton btnVendaCancelar;
        private FontAwesome.Sharp.IconButton btnVendaExcluir;
        private System.Windows.Forms.ComboBox cbVendaFornecedor;
        private System.Windows.Forms.ComboBox cbVendaProdutoFornecido;
        private System.Windows.Forms.ComboBox cbVendaFormaPagamento;
        private System.Windows.Forms.DateTimePicker dateVendaData;
        private System.Windows.Forms.Label lblVendaData;
        private System.Windows.Forms.Label lblVendaQuantidade;
        private System.Windows.Forms.TextBox txtVendaQuantidade;
        private System.Windows.Forms.TextBox txtVendaValorUnit;
        private System.Windows.Forms.Label lblVendaValorUnit;
        private System.Windows.Forms.GroupBox groupVendaStatus;
        private System.Windows.Forms.CheckBox checkVendaStatus;
    }
}