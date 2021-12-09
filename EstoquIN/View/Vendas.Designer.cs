
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
            this.txtVendaFormaPagamento = new System.Windows.Forms.TextBox();
            this.txtVendaValorUnit = new System.Windows.Forms.TextBox();
            this.lblVendaValorUnit = new System.Windows.Forms.Label();
            this.dateVendaData = new System.Windows.Forms.DateTimePicker();
            this.lblVendaData = new System.Windows.Forms.Label();
            this.lblVendaQuantidade = new System.Windows.Forms.Label();
            this.txtVendaQuantidade = new System.Windows.Forms.TextBox();
            this.cbVendaProdutoCliente = new System.Windows.Forms.ComboBox();
            this.cbVendaCliente = new System.Windows.Forms.ComboBox();
            this.lblVendaFornecedor = new System.Windows.Forms.Label();
            this.txtVendaValorTotal = new System.Windows.Forms.TextBox();
            this.lblVendaValorTotal = new System.Windows.Forms.Label();
            this.lblVendaProdutoFornecido = new System.Windows.Forms.Label();
            this.lblVendaFormaPagamento = new System.Windows.Forms.Label();
            this.btnVendaAdicionar = new FontAwesome.Sharp.IconButton();
            this.btnVendaEditar = new FontAwesome.Sharp.IconButton();
            this.dataVenda = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFormPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNotaFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVendaCancelar = new FontAwesome.Sharp.IconButton();
            this.btnVendaExcluir = new FontAwesome.Sharp.IconButton();
            this.groupVendaStatus = new System.Windows.Forms.GroupBox();
            this.btnVendaUpload = new FontAwesome.Sharp.IconButton();
            this.checkVendaStatus = new System.Windows.Forms.CheckBox();
            this.picVendaNotaFiscal = new System.Windows.Forms.PictureBox();
            this.groupVendaInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVenda)).BeginInit();
            this.groupVendaStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVendaNotaFiscal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupVendaInfo
            // 
            this.groupVendaInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupVendaInfo.Controls.Add(this.txtVendaFormaPagamento);
            this.groupVendaInfo.Controls.Add(this.txtVendaValorUnit);
            this.groupVendaInfo.Controls.Add(this.lblVendaValorUnit);
            this.groupVendaInfo.Controls.Add(this.dateVendaData);
            this.groupVendaInfo.Controls.Add(this.lblVendaData);
            this.groupVendaInfo.Controls.Add(this.lblVendaQuantidade);
            this.groupVendaInfo.Controls.Add(this.txtVendaQuantidade);
            this.groupVendaInfo.Controls.Add(this.cbVendaProdutoCliente);
            this.groupVendaInfo.Controls.Add(this.cbVendaCliente);
            this.groupVendaInfo.Controls.Add(this.lblVendaFornecedor);
            this.groupVendaInfo.Controls.Add(this.txtVendaValorTotal);
            this.groupVendaInfo.Controls.Add(this.lblVendaValorTotal);
            this.groupVendaInfo.Controls.Add(this.lblVendaProdutoFornecido);
            this.groupVendaInfo.Controls.Add(this.lblVendaFormaPagamento);
            this.groupVendaInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupVendaInfo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.groupVendaInfo.ForeColor = System.Drawing.Color.White;
            this.groupVendaInfo.Location = new System.Drawing.Point(9, 12);
            this.groupVendaInfo.Name = "groupVendaInfo";
            this.groupVendaInfo.Size = new System.Drawing.Size(746, 382);
            this.groupVendaInfo.TabIndex = 28;
            this.groupVendaInfo.TabStop = false;
            this.groupVendaInfo.Text = "Venda do Produto";
            // 
            // txtVendaFormaPagamento
            // 
            this.txtVendaFormaPagamento.Location = new System.Drawing.Point(41, 299);
            this.txtVendaFormaPagamento.Name = "txtVendaFormaPagamento";
            this.txtVendaFormaPagamento.Size = new System.Drawing.Size(216, 34);
            this.txtVendaFormaPagamento.TabIndex = 22;
            // 
            // txtVendaValorUnit
            // 
            this.txtVendaValorUnit.Location = new System.Drawing.Point(519, 194);
            this.txtVendaValorUnit.Name = "txtVendaValorUnit";
            this.txtVendaValorUnit.Size = new System.Drawing.Size(161, 34);
            this.txtVendaValorUnit.TabIndex = 20;
            // 
            // lblVendaValorUnit
            // 
            this.lblVendaValorUnit.AutoSize = true;
            this.lblVendaValorUnit.ForeColor = System.Drawing.Color.White;
            this.lblVendaValorUnit.Location = new System.Drawing.Point(514, 161);
            this.lblVendaValorUnit.Name = "lblVendaValorUnit";
            this.lblVendaValorUnit.Size = new System.Drawing.Size(133, 28);
            this.lblVendaValorUnit.TabIndex = 19;
            this.lblVendaValorUnit.Text = "Valor Unitario";
            // 
            // dateVendaData
            // 
            this.dateVendaData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVendaData.Location = new System.Drawing.Point(299, 297);
            this.dateVendaData.Name = "dateVendaData";
            this.dateVendaData.Size = new System.Drawing.Size(143, 34);
            this.dateVendaData.TabIndex = 17;
            // 
            // lblVendaData
            // 
            this.lblVendaData.AutoSize = true;
            this.lblVendaData.ForeColor = System.Drawing.Color.White;
            this.lblVendaData.Location = new System.Drawing.Point(294, 266);
            this.lblVendaData.Name = "lblVendaData";
            this.lblVendaData.Size = new System.Drawing.Size(53, 28);
            this.lblVendaData.TabIndex = 16;
            this.lblVendaData.Text = "Data";
            // 
            // lblVendaQuantidade
            // 
            this.lblVendaQuantidade.AutoSize = true;
            this.lblVendaQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblVendaQuantidade.Location = new System.Drawing.Point(514, 63);
            this.lblVendaQuantidade.Name = "lblVendaQuantidade";
            this.lblVendaQuantidade.Size = new System.Drawing.Size(115, 28);
            this.lblVendaQuantidade.TabIndex = 15;
            this.lblVendaQuantidade.Text = "Quantidade";
            // 
            // txtVendaQuantidade
            // 
            this.txtVendaQuantidade.Location = new System.Drawing.Point(519, 94);
            this.txtVendaQuantidade.Name = "txtVendaQuantidade";
            this.txtVendaQuantidade.Size = new System.Drawing.Size(161, 34);
            this.txtVendaQuantidade.TabIndex = 14;
            // 
            // cbVendaProdutoCliente
            // 
            this.cbVendaProdutoCliente.FormattingEnabled = true;
            this.cbVendaProdutoCliente.Location = new System.Drawing.Point(41, 190);
            this.cbVendaProdutoCliente.Name = "cbVendaProdutoCliente";
            this.cbVendaProdutoCliente.Size = new System.Drawing.Size(381, 36);
            this.cbVendaProdutoCliente.TabIndex = 13;
            // 
            // cbVendaCliente
            // 
            this.cbVendaCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbVendaCliente.FormattingEnabled = true;
            this.cbVendaCliente.Location = new System.Drawing.Point(41, 92);
            this.cbVendaCliente.Name = "cbVendaCliente";
            this.cbVendaCliente.Size = new System.Drawing.Size(378, 36);
            this.cbVendaCliente.TabIndex = 12;
            // 
            // lblVendaFornecedor
            // 
            this.lblVendaFornecedor.AutoSize = true;
            this.lblVendaFornecedor.ForeColor = System.Drawing.Color.White;
            this.lblVendaFornecedor.Location = new System.Drawing.Point(41, 61);
            this.lblVendaFornecedor.Name = "lblVendaFornecedor";
            this.lblVendaFornecedor.Size = new System.Drawing.Size(72, 28);
            this.lblVendaFornecedor.TabIndex = 0;
            this.lblVendaFornecedor.Text = "Cliente";
            // 
            // txtVendaValorTotal
            // 
            this.txtVendaValorTotal.Location = new System.Drawing.Point(519, 299);
            this.txtVendaValorTotal.Name = "txtVendaValorTotal";
            this.txtVendaValorTotal.Size = new System.Drawing.Size(161, 34);
            this.txtVendaValorTotal.TabIndex = 9;
            // 
            // lblVendaValorTotal
            // 
            this.lblVendaValorTotal.AutoSize = true;
            this.lblVendaValorTotal.ForeColor = System.Drawing.Color.White;
            this.lblVendaValorTotal.Location = new System.Drawing.Point(514, 266);
            this.lblVendaValorTotal.Name = "lblVendaValorTotal";
            this.lblVendaValorTotal.Size = new System.Drawing.Size(104, 28);
            this.lblVendaValorTotal.TabIndex = 8;
            this.lblVendaValorTotal.Text = "Valor Total";
            // 
            // lblVendaProdutoFornecido
            // 
            this.lblVendaProdutoFornecido.AutoSize = true;
            this.lblVendaProdutoFornecido.ForeColor = System.Drawing.Color.White;
            this.lblVendaProdutoFornecido.Location = new System.Drawing.Point(44, 159);
            this.lblVendaProdutoFornecido.Name = "lblVendaProdutoFornecido";
            this.lblVendaProdutoFornecido.Size = new System.Drawing.Size(84, 28);
            this.lblVendaProdutoFornecido.TabIndex = 2;
            this.lblVendaProdutoFornecido.Text = "Produto";
            // 
            // lblVendaFormaPagamento
            // 
            this.lblVendaFormaPagamento.AutoSize = true;
            this.lblVendaFormaPagamento.ForeColor = System.Drawing.Color.White;
            this.lblVendaFormaPagamento.Location = new System.Drawing.Point(44, 268);
            this.lblVendaFormaPagamento.Name = "lblVendaFormaPagamento";
            this.lblVendaFormaPagamento.Size = new System.Drawing.Size(199, 28);
            this.lblVendaFormaPagamento.TabIndex = 6;
            this.lblVendaFormaPagamento.Text = "Forma de Pagamento";
            // 
            // btnVendaAdicionar
            // 
            this.btnVendaAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.btnVendaAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendaAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendaAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnVendaAdicionar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVendaAdicionar.IconColor = System.Drawing.Color.Black;
            this.btnVendaAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendaAdicionar.Location = new System.Drawing.Point(761, 342);
            this.btnVendaAdicionar.Name = "btnVendaAdicionar";
            this.btnVendaAdicionar.Size = new System.Drawing.Size(144, 52);
            this.btnVendaAdicionar.TabIndex = 31;
            this.btnVendaAdicionar.Text = "Adicionar";
            this.btnVendaAdicionar.UseVisualStyleBackColor = false;
            this.btnVendaAdicionar.Click += new System.EventHandler(this.btnVendaAdicionar_Click);
            // 
            // btnVendaEditar
            // 
            this.btnVendaEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnVendaEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendaEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendaEditar.ForeColor = System.Drawing.Color.White;
            this.btnVendaEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVendaEditar.IconColor = System.Drawing.Color.Black;
            this.btnVendaEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendaEditar.Location = new System.Drawing.Point(911, 342);
            this.btnVendaEditar.Name = "btnVendaEditar";
            this.btnVendaEditar.Size = new System.Drawing.Size(143, 53);
            this.btnVendaEditar.TabIndex = 32;
            this.btnVendaEditar.Text = "Editar";
            this.btnVendaEditar.UseVisualStyleBackColor = false;
            this.btnVendaEditar.Click += new System.EventHandler(this.btnVendaEditar_Click);
            // 
            // dataVenda
            // 
            this.dataVenda.AllowUserToAddRows = false;
            this.dataVenda.AllowUserToDeleteRows = false;
            this.dataVenda.AllowUserToResizeColumns = false;
            this.dataVenda.AllowUserToResizeRows = false;
            this.dataVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataVenda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.dataVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnStatus,
            this.ColumnClient,
            this.ColumnProd,
            this.ColumnQuant,
            this.ColumnVUnit,
            this.ColumnVTotal,
            this.ColumnFormPag,
            this.ColumnData,
            this.ColumnNotaFiscal});
            this.dataVenda.Location = new System.Drawing.Point(9, 400);
            this.dataVenda.Name = "dataVenda";
            this.dataVenda.RowHeadersVisible = false;
            this.dataVenda.RowHeadersWidth = 51;
            this.dataVenda.RowTemplate.Height = 25;
            this.dataVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataVenda.Size = new System.Drawing.Size(1356, 360);
            this.dataVenda.TabIndex = 30;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "Id";
            this.ColumnId.FillWeight = 25F;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.DataPropertyName = "Status";
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            // 
            // ColumnClient
            // 
            this.ColumnClient.DataPropertyName = "cliente";
            this.ColumnClient.HeaderText = "Cliente";
            this.ColumnClient.Name = "ColumnClient";
            this.ColumnClient.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnClient.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnProd
            // 
            this.ColumnProd.DataPropertyName = "produto";
            this.ColumnProd.HeaderText = "Produto";
            this.ColumnProd.Name = "ColumnProd";
            this.ColumnProd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnProd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnQuant
            // 
            this.ColumnQuant.DataPropertyName = "Quant";
            this.ColumnQuant.HeaderText = "Quant.";
            this.ColumnQuant.Name = "ColumnQuant";
            this.ColumnQuant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnQuant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnVUnit
            // 
            this.ColumnVUnit.DataPropertyName = "ValorUnit";
            this.ColumnVUnit.HeaderText = "V. Unit";
            this.ColumnVUnit.Name = "ColumnVUnit";
            this.ColumnVUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnVUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnVTotal
            // 
            this.ColumnVTotal.DataPropertyName = "ValorTotal";
            this.ColumnVTotal.HeaderText = "V. Total";
            this.ColumnVTotal.Name = "ColumnVTotal";
            this.ColumnVTotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnVTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnFormPag
            // 
            this.ColumnFormPag.DataPropertyName = "FormPag";
            this.ColumnFormPag.HeaderText = "Form. Pag";
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
            // ColumnNotaFiscal
            // 
            this.ColumnNotaFiscal.DataPropertyName = "Images";
            this.ColumnNotaFiscal.HeaderText = "Nota Fiscal";
            this.ColumnNotaFiscal.Name = "ColumnNotaFiscal";
            this.ColumnNotaFiscal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnNotaFiscal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnVendaCancelar
            // 
            this.btnVendaCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnVendaCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendaCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendaCancelar.ForeColor = System.Drawing.Color.White;
            this.btnVendaCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVendaCancelar.IconColor = System.Drawing.Color.Black;
            this.btnVendaCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendaCancelar.Location = new System.Drawing.Point(1060, 342);
            this.btnVendaCancelar.Name = "btnVendaCancelar";
            this.btnVendaCancelar.Size = new System.Drawing.Size(152, 53);
            this.btnVendaCancelar.TabIndex = 33;
            this.btnVendaCancelar.Text = "Cancelar";
            this.btnVendaCancelar.UseVisualStyleBackColor = false;
            this.btnVendaCancelar.Click += new System.EventHandler(this.btnVendaCancelar_Click);
            // 
            // btnVendaExcluir
            // 
            this.btnVendaExcluir.BackColor = System.Drawing.Color.Maroon;
            this.btnVendaExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendaExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendaExcluir.ForeColor = System.Drawing.Color.White;
            this.btnVendaExcluir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVendaExcluir.IconColor = System.Drawing.Color.Black;
            this.btnVendaExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendaExcluir.Location = new System.Drawing.Point(1218, 342);
            this.btnVendaExcluir.Name = "btnVendaExcluir";
            this.btnVendaExcluir.Size = new System.Drawing.Size(147, 53);
            this.btnVendaExcluir.TabIndex = 34;
            this.btnVendaExcluir.Text = "Excluir";
            this.btnVendaExcluir.UseVisualStyleBackColor = false;
            this.btnVendaExcluir.Click += new System.EventHandler(this.btnVendaExcluir_Click);
            // 
            // groupVendaStatus
            // 
            this.groupVendaStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupVendaStatus.Controls.Add(this.btnVendaUpload);
            this.groupVendaStatus.Controls.Add(this.checkVendaStatus);
            this.groupVendaStatus.Controls.Add(this.picVendaNotaFiscal);
            this.groupVendaStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupVendaStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupVendaStatus.ForeColor = System.Drawing.Color.White;
            this.groupVendaStatus.Location = new System.Drawing.Point(761, 12);
            this.groupVendaStatus.Name = "groupVendaStatus";
            this.groupVendaStatus.Size = new System.Drawing.Size(604, 324);
            this.groupVendaStatus.TabIndex = 35;
            this.groupVendaStatus.TabStop = false;
            this.groupVendaStatus.Text = "Status da Venda";
            // 
            // btnVendaUpload
            // 
            this.btnVendaUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendaUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendaUpload.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVendaUpload.IconColor = System.Drawing.Color.Black;
            this.btnVendaUpload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendaUpload.Location = new System.Drawing.Point(6, 247);
            this.btnVendaUpload.Name = "btnVendaUpload";
            this.btnVendaUpload.Size = new System.Drawing.Size(150, 65);
            this.btnVendaUpload.TabIndex = 37;
            this.btnVendaUpload.Text = "Upload";
            this.btnVendaUpload.UseVisualStyleBackColor = true;
            this.btnVendaUpload.Click += new System.EventHandler(this.btnVendaUpload_Click);
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
            // picVendaNotaFiscal
            // 
            this.picVendaNotaFiscal.BackColor = System.Drawing.Color.DodgerBlue;
            this.picVendaNotaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVendaNotaFiscal.Location = new System.Drawing.Point(162, 24);
            this.picVendaNotaFiscal.Name = "picVendaNotaFiscal";
            this.picVendaNotaFiscal.Size = new System.Drawing.Size(436, 294);
            this.picVendaNotaFiscal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVendaNotaFiscal.TabIndex = 36;
            this.picVendaNotaFiscal.TabStop = false;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1377, 772);
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
            ((System.ComponentModel.ISupportInitialize)(this.picVendaNotaFiscal)).EndInit();
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
        private System.Windows.Forms.ComboBox cbVendaCliente;
        private System.Windows.Forms.ComboBox cbVendaProdutoCliente;
        private System.Windows.Forms.DateTimePicker dateVendaData;
        private System.Windows.Forms.Label lblVendaData;
        private System.Windows.Forms.Label lblVendaQuantidade;
        private System.Windows.Forms.TextBox txtVendaQuantidade;
        private System.Windows.Forms.TextBox txtVendaValorUnit;
        private System.Windows.Forms.Label lblVendaValorUnit;
        private System.Windows.Forms.GroupBox groupVendaStatus;
        private System.Windows.Forms.CheckBox checkVendaStatus;
        private FontAwesome.Sharp.IconButton btnVendaUpload;
        private System.Windows.Forms.PictureBox picVendaNotaFiscal;
        private System.Windows.Forms.TextBox txtVendaFormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFormPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNotaFiscal;
    }
}