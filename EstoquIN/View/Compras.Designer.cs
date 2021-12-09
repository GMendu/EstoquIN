
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
            this.btnCompraUpload = new FontAwesome.Sharp.IconButton();
            this.picNotaFiscal = new System.Windows.Forms.PictureBox();
            this.checkCompraStatus = new System.Windows.Forms.CheckBox();
            this.groupCompraInfo = new System.Windows.Forms.GroupBox();
            this.txtCompraFormaPagamento = new System.Windows.Forms.TextBox();
            this.txtCompraValorUnit = new System.Windows.Forms.TextBox();
            this.lblCompraValorUnit = new System.Windows.Forms.Label();
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
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnFornec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFormPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCompraCancelar = new FontAwesome.Sharp.IconButton();
            this.btnCompraExcluir = new FontAwesome.Sharp.IconButton();
            this.groupCompraStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNotaFiscal)).BeginInit();
            this.groupCompraInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupCompraStatus
            // 
            this.groupCompraStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupCompraStatus.Controls.Add(this.btnCompraUpload);
            this.groupCompraStatus.Controls.Add(this.picNotaFiscal);
            this.groupCompraStatus.Controls.Add(this.checkCompraStatus);
            this.groupCompraStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupCompraStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupCompraStatus.ForeColor = System.Drawing.Color.White;
            this.groupCompraStatus.Location = new System.Drawing.Point(773, 9);
            this.groupCompraStatus.Name = "groupCompraStatus";
            this.groupCompraStatus.Size = new System.Drawing.Size(592, 346);
            this.groupCompraStatus.TabIndex = 42;
            this.groupCompraStatus.TabStop = false;
            this.groupCompraStatus.Text = "Status da Compra";
            // 
            // btnCompraUpload
            // 
            this.btnCompraUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraUpload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCompraUpload.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCompraUpload.IconColor = System.Drawing.Color.Black;
            this.btnCompraUpload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompraUpload.Location = new System.Drawing.Point(6, 271);
            this.btnCompraUpload.Name = "btnCompraUpload";
            this.btnCompraUpload.Size = new System.Drawing.Size(185, 69);
            this.btnCompraUpload.TabIndex = 2;
            this.btnCompraUpload.Text = "Upload";
            this.btnCompraUpload.UseVisualStyleBackColor = true;
            this.btnCompraUpload.Click += new System.EventHandler(this.btnCompraUpload_Click);
            // 
            // picNotaFiscal
            // 
            this.picNotaFiscal.BackColor = System.Drawing.Color.DodgerBlue;
            this.picNotaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNotaFiscal.Location = new System.Drawing.Point(197, 15);
            this.picNotaFiscal.Name = "picNotaFiscal";
            this.picNotaFiscal.Size = new System.Drawing.Size(389, 325);
            this.picNotaFiscal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNotaFiscal.TabIndex = 1;
            this.picNotaFiscal.TabStop = false;
            // 
            // checkCompraStatus
            // 
            this.checkCompraStatus.AutoSize = true;
            this.checkCompraStatus.Location = new System.Drawing.Point(14, 24);
            this.checkCompraStatus.Name = "checkCompraStatus";
            this.checkCompraStatus.Size = new System.Drawing.Size(155, 25);
            this.checkCompraStatus.TabIndex = 0;
            this.checkCompraStatus.Text = "Compra finalizada";
            this.checkCompraStatus.UseVisualStyleBackColor = true;
            // 
            // groupCompraInfo
            // 
            this.groupCompraInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupCompraInfo.Controls.Add(this.txtCompraFormaPagamento);
            this.groupCompraInfo.Controls.Add(this.txtCompraValorUnit);
            this.groupCompraInfo.Controls.Add(this.lblCompraValorUnit);
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
            this.groupCompraInfo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.groupCompraInfo.ForeColor = System.Drawing.Color.White;
            this.groupCompraInfo.Location = new System.Drawing.Point(10, 9);
            this.groupCompraInfo.Name = "groupCompraInfo";
            this.groupCompraInfo.Size = new System.Drawing.Size(757, 393);
            this.groupCompraInfo.TabIndex = 36;
            this.groupCompraInfo.TabStop = false;
            this.groupCompraInfo.Text = "Compra de material";
            // 
            // txtCompraFormaPagamento
            // 
            this.txtCompraFormaPagamento.Location = new System.Drawing.Point(49, 306);
            this.txtCompraFormaPagamento.Name = "txtCompraFormaPagamento";
            this.txtCompraFormaPagamento.Size = new System.Drawing.Size(216, 34);
            this.txtCompraFormaPagamento.TabIndex = 21;
            // 
            // txtCompraValorUnit
            // 
            this.txtCompraValorUnit.Location = new System.Drawing.Point(551, 203);
            this.txtCompraValorUnit.Name = "txtCompraValorUnit";
            this.txtCompraValorUnit.Size = new System.Drawing.Size(142, 34);
            this.txtCompraValorUnit.TabIndex = 20;
            // 
            // lblCompraValorUnit
            // 
            this.lblCompraValorUnit.AutoSize = true;
            this.lblCompraValorUnit.ForeColor = System.Drawing.Color.White;
            this.lblCompraValorUnit.Location = new System.Drawing.Point(546, 172);
            this.lblCompraValorUnit.Name = "lblCompraValorUnit";
            this.lblCompraValorUnit.Size = new System.Drawing.Size(133, 28);
            this.lblCompraValorUnit.TabIndex = 19;
            this.lblCompraValorUnit.Text = "Valor Unitario";
            // 
            // dateCompraData
            // 
            this.dateCompraData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCompraData.Location = new System.Drawing.Point(317, 304);
            this.dateCompraData.Name = "dateCompraData";
            this.dateCompraData.Size = new System.Drawing.Size(154, 34);
            this.dateCompraData.TabIndex = 17;
            // 
            // lblCompraData
            // 
            this.lblCompraData.AutoSize = true;
            this.lblCompraData.ForeColor = System.Drawing.Color.White;
            this.lblCompraData.Location = new System.Drawing.Point(312, 273);
            this.lblCompraData.Name = "lblCompraData";
            this.lblCompraData.Size = new System.Drawing.Size(53, 28);
            this.lblCompraData.TabIndex = 16;
            this.lblCompraData.Text = "Data";
            // 
            // lblCompraQuantidade
            // 
            this.lblCompraQuantidade.AutoSize = true;
            this.lblCompraQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblCompraQuantidade.Location = new System.Drawing.Point(546, 69);
            this.lblCompraQuantidade.Name = "lblCompraQuantidade";
            this.lblCompraQuantidade.Size = new System.Drawing.Size(115, 28);
            this.lblCompraQuantidade.TabIndex = 15;
            this.lblCompraQuantidade.Text = "Quantidade";
            // 
            // txtCompraQuantidade
            // 
            this.txtCompraQuantidade.Location = new System.Drawing.Point(549, 101);
            this.txtCompraQuantidade.Name = "txtCompraQuantidade";
            this.txtCompraQuantidade.Size = new System.Drawing.Size(144, 34);
            this.txtCompraQuantidade.TabIndex = 14;
            // 
            // cbCompraProdutoFornecido
            // 
            this.cbCompraProdutoFornecido.FormattingEnabled = true;
            this.cbCompraProdutoFornecido.Location = new System.Drawing.Point(49, 203);
            this.cbCompraProdutoFornecido.Name = "cbCompraProdutoFornecido";
            this.cbCompraProdutoFornecido.Size = new System.Drawing.Size(422, 36);
            this.cbCompraProdutoFornecido.TabIndex = 13;
            // 
            // cbCompraFornecedor
            // 
            this.cbCompraFornecedor.FormattingEnabled = true;
            this.cbCompraFornecedor.Location = new System.Drawing.Point(49, 101);
            this.cbCompraFornecedor.Name = "cbCompraFornecedor";
            this.cbCompraFornecedor.Size = new System.Drawing.Size(422, 36);
            this.cbCompraFornecedor.TabIndex = 12;
            // 
            // lblCompraFornecedor
            // 
            this.lblCompraFornecedor.AutoSize = true;
            this.lblCompraFornecedor.ForeColor = System.Drawing.Color.White;
            this.lblCompraFornecedor.Location = new System.Drawing.Point(44, 69);
            this.lblCompraFornecedor.Name = "lblCompraFornecedor";
            this.lblCompraFornecedor.Size = new System.Drawing.Size(112, 28);
            this.lblCompraFornecedor.TabIndex = 0;
            this.lblCompraFornecedor.Text = "Fornecedor";
            // 
            // txtCompraValorTotal
            // 
            this.txtCompraValorTotal.Location = new System.Drawing.Point(549, 306);
            this.txtCompraValorTotal.Name = "txtCompraValorTotal";
            this.txtCompraValorTotal.Size = new System.Drawing.Size(144, 34);
            this.txtCompraValorTotal.TabIndex = 9;
            // 
            // lblCompraValorTotal
            // 
            this.lblCompraValorTotal.AutoSize = true;
            this.lblCompraValorTotal.ForeColor = System.Drawing.Color.White;
            this.lblCompraValorTotal.Location = new System.Drawing.Point(557, 275);
            this.lblCompraValorTotal.Name = "lblCompraValorTotal";
            this.lblCompraValorTotal.Size = new System.Drawing.Size(104, 28);
            this.lblCompraValorTotal.TabIndex = 8;
            this.lblCompraValorTotal.Text = "Valor Total";
            // 
            // lblCompraProdutoFornecido
            // 
            this.lblCompraProdutoFornecido.AutoSize = true;
            this.lblCompraProdutoFornecido.ForeColor = System.Drawing.Color.White;
            this.lblCompraProdutoFornecido.Location = new System.Drawing.Point(50, 172);
            this.lblCompraProdutoFornecido.Name = "lblCompraProdutoFornecido";
            this.lblCompraProdutoFornecido.Size = new System.Drawing.Size(84, 28);
            this.lblCompraProdutoFornecido.TabIndex = 2;
            this.lblCompraProdutoFornecido.Text = "Material";
            // 
            // lblCompraFormaPagamento
            // 
            this.lblCompraFormaPagamento.AutoSize = true;
            this.lblCompraFormaPagamento.ForeColor = System.Drawing.Color.White;
            this.lblCompraFormaPagamento.Location = new System.Drawing.Point(44, 275);
            this.lblCompraFormaPagamento.Name = "lblCompraFormaPagamento";
            this.lblCompraFormaPagamento.Size = new System.Drawing.Size(199, 28);
            this.lblCompraFormaPagamento.TabIndex = 6;
            this.lblCompraFormaPagamento.Text = "Forma de Pagamento";
            // 
            // btnCompraAdicionar
            // 
            this.btnCompraAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.btnCompraAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraAdicionar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnCompraAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnCompraAdicionar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCompraAdicionar.IconColor = System.Drawing.Color.Black;
            this.btnCompraAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompraAdicionar.Location = new System.Drawing.Point(773, 361);
            this.btnCompraAdicionar.Name = "btnCompraAdicionar";
            this.btnCompraAdicionar.Size = new System.Drawing.Size(160, 41);
            this.btnCompraAdicionar.TabIndex = 38;
            this.btnCompraAdicionar.Text = "Adicionar";
            this.btnCompraAdicionar.UseVisualStyleBackColor = false;
            this.btnCompraAdicionar.Click += new System.EventHandler(this.btnCompraAdicionar_Click);
            // 
            // btnCompraEditar
            // 
            this.btnCompraEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnCompraEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraEditar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnCompraEditar.ForeColor = System.Drawing.Color.White;
            this.btnCompraEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCompraEditar.IconColor = System.Drawing.Color.Black;
            this.btnCompraEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompraEditar.Location = new System.Drawing.Point(939, 361);
            this.btnCompraEditar.Name = "btnCompraEditar";
            this.btnCompraEditar.Size = new System.Drawing.Size(145, 41);
            this.btnCompraEditar.TabIndex = 39;
            this.btnCompraEditar.Text = "Editar";
            this.btnCompraEditar.UseVisualStyleBackColor = false;
            this.btnCompraEditar.Click += new System.EventHandler(this.btnCompraEditar_Click);
            // 
            // dataCompra
            // 
            this.dataCompra.AllowUserToAddRows = false;
            this.dataCompra.AllowUserToDeleteRows = false;
            this.dataCompra.AllowUserToResizeColumns = false;
            this.dataCompra.AllowUserToResizeRows = false;
            this.dataCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.dataCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnStatus,
            this.ColumnFornec,
            this.ColumnInsu,
            this.ColumnQuant,
            this.ColumnValorUnit,
            this.ColumnValorTotal,
            this.ColumnFormPag,
            this.ColumnData,
            this.ColumnNota});
            this.dataCompra.Location = new System.Drawing.Point(10, 408);
            this.dataCompra.Name = "dataCompra";
            this.dataCompra.RowHeadersVisible = false;
            this.dataCompra.RowHeadersWidth = 51;
            this.dataCompra.RowTemplate.Height = 25;
            this.dataCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCompra.Size = new System.Drawing.Size(1355, 352);
            this.dataCompra.TabIndex = 37;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "Id";
            this.ColumnId.FillWeight = 25F;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.DataPropertyName = "Status";
            this.ColumnStatus.FillWeight = 40F;
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            // 
            // ColumnFornec
            // 
            this.ColumnFornec.DataPropertyName = "Fornec";
            this.ColumnFornec.HeaderText = "Fornecedor";
            this.ColumnFornec.Name = "ColumnFornec";
            this.ColumnFornec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnInsu
            // 
            this.ColumnInsu.DataPropertyName = "Insumos";
            this.ColumnInsu.HeaderText = "Material";
            this.ColumnInsu.Name = "ColumnInsu";
            this.ColumnInsu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnQuant
            // 
            this.ColumnQuant.DataPropertyName = "Quant";
            this.ColumnQuant.FillWeight = 40F;
            this.ColumnQuant.HeaderText = "Quant.";
            this.ColumnQuant.Name = "ColumnQuant";
            this.ColumnQuant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnQuant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnValorUnit
            // 
            this.ColumnValorUnit.DataPropertyName = "ValorUnit";
            this.ColumnValorUnit.FillWeight = 40F;
            this.ColumnValorUnit.HeaderText = "V. Unit";
            this.ColumnValorUnit.Name = "ColumnValorUnit";
            this.ColumnValorUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnValorUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnValorTotal
            // 
            this.ColumnValorTotal.DataPropertyName = "ValorTotal";
            this.ColumnValorTotal.FillWeight = 40F;
            this.ColumnValorTotal.HeaderText = "V. Total";
            this.ColumnValorTotal.Name = "ColumnValorTotal";
            this.ColumnValorTotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnValorTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnFormPag
            // 
            this.ColumnFormPag.DataPropertyName = "FormPag";
            this.ColumnFormPag.HeaderText = "For. Pag.";
            this.ColumnFormPag.Name = "ColumnFormPag";
            this.ColumnFormPag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnFormPag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnData
            // 
            this.ColumnData.DataPropertyName = "Data";
            this.ColumnData.HeaderText = "Data";
            this.ColumnData.Name = "ColumnData";
            this.ColumnData.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnNota
            // 
            this.ColumnNota.DataPropertyName = "Images";
            this.ColumnNota.HeaderText = "Nota Fiscal";
            this.ColumnNota.Name = "ColumnNota";
            this.ColumnNota.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnNota.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnCompraCancelar
            // 
            this.btnCompraCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnCompraCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraCancelar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnCompraCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCompraCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCompraCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCompraCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompraCancelar.Location = new System.Drawing.Point(1090, 361);
            this.btnCompraCancelar.Name = "btnCompraCancelar";
            this.btnCompraCancelar.Size = new System.Drawing.Size(143, 41);
            this.btnCompraCancelar.TabIndex = 40;
            this.btnCompraCancelar.Text = "Cancelar";
            this.btnCompraCancelar.UseVisualStyleBackColor = false;
            this.btnCompraCancelar.Click += new System.EventHandler(this.btnCompraCancelar_Click);
            // 
            // btnCompraExcluir
            // 
            this.btnCompraExcluir.BackColor = System.Drawing.Color.Maroon;
            this.btnCompraExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraExcluir.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnCompraExcluir.ForeColor = System.Drawing.Color.White;
            this.btnCompraExcluir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCompraExcluir.IconColor = System.Drawing.Color.Black;
            this.btnCompraExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompraExcluir.Location = new System.Drawing.Point(1239, 361);
            this.btnCompraExcluir.Name = "btnCompraExcluir";
            this.btnCompraExcluir.Size = new System.Drawing.Size(126, 41);
            this.btnCompraExcluir.TabIndex = 41;
            this.btnCompraExcluir.Text = "Excluir";
            this.btnCompraExcluir.UseVisualStyleBackColor = false;
            this.btnCompraExcluir.Click += new System.EventHandler(this.btnCompraExcluir_Click);
            // 
            // Compras
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1377, 772);
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
            ((System.ComponentModel.ISupportInitialize)(this.picNotaFiscal)).EndInit();
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
        private System.Windows.Forms.PictureBox picNotaFiscal;
        private FontAwesome.Sharp.IconButton btnCompraUpload;
        private System.Windows.Forms.TextBox txtCompraFormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFornec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFormPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNota;
    }
}