namespace EstoquIN.View
{
    partial class Submenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Submenu));
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtMenuRelogio = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.timerRelogio = new System.Windows.Forms.Timer(this.components);
            this.dataNotifCompras = new System.Windows.Forms.DataGridView();
            this.ColumnNomeF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFormPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNotifVendas = new System.Windows.Forms.DataGridView();
            this.ColumnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVendaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVendaValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVendaQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVendarFormPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNotifCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNotifVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(119, 35);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(178, 39);
            this.lblBemVindo.TabIndex = 8;
            this.lblBemVindo.Text = "Bem vindo";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconPictureBox1.Enabled = false;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 103;
            this.iconPictureBox1.Location = new System.Drawing.Point(102, 91);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(103, 107);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtMenuRelogio
            // 
            this.txtMenuRelogio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.txtMenuRelogio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMenuRelogio.Font = new System.Drawing.Font("Segoe UI", 40F);
            this.txtMenuRelogio.Location = new System.Drawing.Point(208, 103);
            this.txtMenuRelogio.Name = "txtMenuRelogio";
            this.txtMenuRelogio.Size = new System.Drawing.Size(226, 71);
            this.txtMenuRelogio.TabIndex = 6;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(56, 421);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(450, 300);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // timerRelogio
            // 
            this.timerRelogio.Enabled = true;
            this.timerRelogio.Interval = 1000;
            this.timerRelogio.Tick += new System.EventHandler(this.timerRelogio_Tick);
            // 
            // dataNotifCompras
            // 
            this.dataNotifCompras.AllowUserToAddRows = false;
            this.dataNotifCompras.AllowUserToDeleteRows = false;
            this.dataNotifCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNotifCompras.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataNotifCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNotifCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNomeF,
            this.ColumnMaterial,
            this.ColumnData,
            this.ColumnValorTotal,
            this.ColumnQuantidade,
            this.ColumnFormPag});
            this.dataNotifCompras.Location = new System.Drawing.Point(569, 35);
            this.dataNotifCompras.Name = "dataNotifCompras";
            this.dataNotifCompras.RowHeadersVisible = false;
            this.dataNotifCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataNotifCompras.Size = new System.Drawing.Size(777, 332);
            this.dataNotifCompras.TabIndex = 9;
            // 
            // ColumnNomeF
            // 
            this.ColumnNomeF.DataPropertyName = "Fornec";
            this.ColumnNomeF.HeaderText = "Fornecedor";
            this.ColumnNomeF.Name = "ColumnNomeF";
            // 
            // ColumnMaterial
            // 
            this.ColumnMaterial.DataPropertyName = "insumos";
            this.ColumnMaterial.HeaderText = "Material";
            this.ColumnMaterial.Name = "ColumnMaterial";
            // 
            // ColumnData
            // 
            this.ColumnData.DataPropertyName = "Data";
            this.ColumnData.HeaderText = "Data";
            this.ColumnData.Name = "ColumnData";
            // 
            // ColumnValorTotal
            // 
            this.ColumnValorTotal.DataPropertyName = "ValorTotal";
            this.ColumnValorTotal.HeaderText = "Valor Total";
            this.ColumnValorTotal.Name = "ColumnValorTotal";
            // 
            // ColumnQuantidade
            // 
            this.ColumnQuantidade.DataPropertyName = "Quant";
            this.ColumnQuantidade.HeaderText = "Quant.";
            this.ColumnQuantidade.Name = "ColumnQuantidade";
            // 
            // ColumnFormPag
            // 
            this.ColumnFormPag.DataPropertyName = "FormPag";
            this.ColumnFormPag.HeaderText = "Form. Pagamento";
            this.ColumnFormPag.Name = "ColumnFormPag";
            // 
            // dataNotifVendas
            // 
            this.dataNotifVendas.AllowUserToAddRows = false;
            this.dataNotifVendas.AllowUserToDeleteRows = false;
            this.dataNotifVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNotifVendas.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataNotifVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNotifVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCliente,
            this.ColumnProduto,
            this.ColumnVendaData,
            this.ColumnVendaValorTotal,
            this.ColumnVendaQuantidade,
            this.ColumnVendarFormPag});
            this.dataNotifVendas.Location = new System.Drawing.Point(569, 408);
            this.dataNotifVendas.Name = "dataNotifVendas";
            this.dataNotifVendas.RowHeadersVisible = false;
            this.dataNotifVendas.Size = new System.Drawing.Size(777, 332);
            this.dataNotifVendas.TabIndex = 10;
            // 
            // ColumnCliente
            // 
            this.ColumnCliente.DataPropertyName = "cliente";
            this.ColumnCliente.HeaderText = "Cliente";
            this.ColumnCliente.Name = "ColumnCliente";
            // 
            // ColumnProduto
            // 
            this.ColumnProduto.DataPropertyName = "produto";
            this.ColumnProduto.HeaderText = "Produto";
            this.ColumnProduto.Name = "ColumnProduto";
            // 
            // ColumnVendaData
            // 
            this.ColumnVendaData.DataPropertyName = "Data";
            this.ColumnVendaData.HeaderText = "Data";
            this.ColumnVendaData.Name = "ColumnVendaData";
            // 
            // ColumnVendaValorTotal
            // 
            this.ColumnVendaValorTotal.DataPropertyName = "ValorTotal";
            this.ColumnVendaValorTotal.HeaderText = "Valor Total";
            this.ColumnVendaValorTotal.Name = "ColumnVendaValorTotal";
            // 
            // ColumnVendaQuantidade
            // 
            this.ColumnVendaQuantidade.DataPropertyName = "Quant";
            this.ColumnVendaQuantidade.HeaderText = "Quant.";
            this.ColumnVendaQuantidade.Name = "ColumnVendaQuantidade";
            // 
            // ColumnVendarFormPag
            // 
            this.ColumnVendarFormPag.DataPropertyName = "FormPag";
            this.ColumnVendarFormPag.HeaderText = "Form. Pagamento";
            this.ColumnVendarFormPag.Name = "ColumnVendarFormPag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(569, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Compras a pagar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(569, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vendas pendentes";
            // 
            // Submenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1377, 772);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataNotifVendas);
            this.Controls.Add(this.dataNotifCompras);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.txtMenuRelogio);
            this.Controls.Add(this.picLogo);
            this.Name = "Submenu";
            this.Text = "Submenu";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNotifCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNotifVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBemVindo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox txtMenuRelogio;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Timer timerRelogio;
        private System.Windows.Forms.DataGridView dataNotifCompras;
        private System.Windows.Forms.DataGridView dataNotifVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFormPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVendaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVendaValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVendaQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVendarFormPag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}