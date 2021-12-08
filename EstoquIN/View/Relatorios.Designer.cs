
namespace EstoquIN.View
{
    partial class Relatorios
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
            this.dataRelatorio = new System.Windows.Forms.DataGridView();
            this.btnRelatorioComp = new System.Windows.Forms.Button();
            this.btnRelatorioForn = new System.Windows.Forms.Button();
            this.btnRelatorioVend = new System.Windows.Forms.Button();
            this.btnRelatorioClient = new System.Windows.Forms.Button();
            this.btnRelatorioProd = new System.Windows.Forms.Button();
            this.btnRelatorioMat = new System.Windows.Forms.Button();
            this.btnCompraLimpar = new System.Windows.Forms.Button();
            this.dateCompraInicio = new System.Windows.Forms.DateTimePicker();
            this.dateCompraFim = new System.Windows.Forms.DateTimePicker();
            this.dateVendaInicio = new System.Windows.Forms.DateTimePicker();
            this.dateVendaFim = new System.Windows.Forms.DateTimePicker();
            this.btnVendaLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // dataRelatorio
            // 
            this.dataRelatorio.AllowUserToAddRows = false;
            this.dataRelatorio.AllowUserToDeleteRows = false;
            this.dataRelatorio.AllowUserToOrderColumns = true;
            this.dataRelatorio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRelatorio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.dataRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRelatorio.Location = new System.Drawing.Point(46, 100);
            this.dataRelatorio.Name = "dataRelatorio";
            this.dataRelatorio.RowHeadersVisible = false;
            this.dataRelatorio.Size = new System.Drawing.Size(1284, 626);
            this.dataRelatorio.TabIndex = 0;
            // 
            // btnRelatorioComp
            // 
            this.btnRelatorioComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnRelatorioComp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRelatorioComp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorioComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRelatorioComp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRelatorioComp.Location = new System.Drawing.Point(46, 36);
            this.btnRelatorioComp.Name = "btnRelatorioComp";
            this.btnRelatorioComp.Size = new System.Drawing.Size(126, 47);
            this.btnRelatorioComp.TabIndex = 1;
            this.btnRelatorioComp.Text = "Compras";
            this.btnRelatorioComp.UseVisualStyleBackColor = false;
            this.btnRelatorioComp.Click += new System.EventHandler(this.btnRelatorioComp_Click);
            // 
            // btnRelatorioForn
            // 
            this.btnRelatorioForn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnRelatorioForn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRelatorioForn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorioForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRelatorioForn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRelatorioForn.Location = new System.Drawing.Point(178, 36);
            this.btnRelatorioForn.Name = "btnRelatorioForn";
            this.btnRelatorioForn.Size = new System.Drawing.Size(144, 47);
            this.btnRelatorioForn.TabIndex = 2;
            this.btnRelatorioForn.Text = "Fornecedores";
            this.btnRelatorioForn.UseVisualStyleBackColor = false;
            this.btnRelatorioForn.Click += new System.EventHandler(this.btnRelatorioForn_Click);
            // 
            // btnRelatorioVend
            // 
            this.btnRelatorioVend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnRelatorioVend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRelatorioVend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorioVend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRelatorioVend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRelatorioVend.Location = new System.Drawing.Point(457, 36);
            this.btnRelatorioVend.Name = "btnRelatorioVend";
            this.btnRelatorioVend.Size = new System.Drawing.Size(115, 47);
            this.btnRelatorioVend.TabIndex = 3;
            this.btnRelatorioVend.Text = "Vendas";
            this.btnRelatorioVend.UseVisualStyleBackColor = false;
            this.btnRelatorioVend.Click += new System.EventHandler(this.btnRelatorioVend_Click);
            // 
            // btnRelatorioClient
            // 
            this.btnRelatorioClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnRelatorioClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRelatorioClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorioClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRelatorioClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRelatorioClient.Location = new System.Drawing.Point(578, 36);
            this.btnRelatorioClient.Name = "btnRelatorioClient";
            this.btnRelatorioClient.Size = new System.Drawing.Size(115, 47);
            this.btnRelatorioClient.TabIndex = 4;
            this.btnRelatorioClient.Text = "Clientes";
            this.btnRelatorioClient.UseVisualStyleBackColor = false;
            this.btnRelatorioClient.Click += new System.EventHandler(this.btnRelatorioClient_Click);
            // 
            // btnRelatorioProd
            // 
            this.btnRelatorioProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnRelatorioProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRelatorioProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorioProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRelatorioProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRelatorioProd.Location = new System.Drawing.Point(699, 36);
            this.btnRelatorioProd.Name = "btnRelatorioProd";
            this.btnRelatorioProd.Size = new System.Drawing.Size(122, 47);
            this.btnRelatorioProd.TabIndex = 6;
            this.btnRelatorioProd.Text = "Produtos";
            this.btnRelatorioProd.UseVisualStyleBackColor = false;
            this.btnRelatorioProd.Click += new System.EventHandler(this.btnRelatorioProd_Click);
            // 
            // btnRelatorioMat
            // 
            this.btnRelatorioMat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnRelatorioMat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRelatorioMat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorioMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRelatorioMat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRelatorioMat.Location = new System.Drawing.Point(328, 36);
            this.btnRelatorioMat.Name = "btnRelatorioMat";
            this.btnRelatorioMat.Size = new System.Drawing.Size(123, 47);
            this.btnRelatorioMat.TabIndex = 5;
            this.btnRelatorioMat.Text = "Materiais";
            this.btnRelatorioMat.UseVisualStyleBackColor = false;
            this.btnRelatorioMat.Click += new System.EventHandler(this.btnRelatorioMat_Click);
            // 
            // btnCompraLimpar
            // 
            this.btnCompraLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnCompraLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCompraLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompraLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCompraLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCompraLimpar.Location = new System.Drawing.Point(1154, 36);
            this.btnCompraLimpar.Name = "btnCompraLimpar";
            this.btnCompraLimpar.Size = new System.Drawing.Size(176, 47);
            this.btnCompraLimpar.TabIndex = 7;
            this.btnCompraLimpar.Text = "Todos os tempos";
            this.btnCompraLimpar.UseVisualStyleBackColor = false;
            this.btnCompraLimpar.Click += new System.EventHandler(this.btnCompraLimpar_Click);
            // 
            // dateCompraInicio
            // 
            this.dateCompraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateCompraInicio.Location = new System.Drawing.Point(854, 36);
            this.dateCompraInicio.Name = "dateCompraInicio";
            this.dateCompraInicio.Size = new System.Drawing.Size(294, 23);
            this.dateCompraInicio.TabIndex = 8;
            this.dateCompraInicio.ValueChanged += new System.EventHandler(this.dateCompraInicio_ValueChanged);
            // 
            // dateCompraFim
            // 
            this.dateCompraFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateCompraFim.Location = new System.Drawing.Point(854, 60);
            this.dateCompraFim.Name = "dateCompraFim";
            this.dateCompraFim.Size = new System.Drawing.Size(294, 23);
            this.dateCompraFim.TabIndex = 9;
            this.dateCompraFim.ValueChanged += new System.EventHandler(this.dateCompraFim_ValueChanged);
            // 
            // dateVendaInicio
            // 
            this.dateVendaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateVendaInicio.Location = new System.Drawing.Point(854, 36);
            this.dateVendaInicio.Name = "dateVendaInicio";
            this.dateVendaInicio.Size = new System.Drawing.Size(294, 23);
            this.dateVendaInicio.TabIndex = 10;
            this.dateVendaInicio.ValueChanged += new System.EventHandler(this.dateVendaInicio_ValueChanged);
            // 
            // dateVendaFim
            // 
            this.dateVendaFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateVendaFim.Location = new System.Drawing.Point(854, 60);
            this.dateVendaFim.Name = "dateVendaFim";
            this.dateVendaFim.Size = new System.Drawing.Size(294, 23);
            this.dateVendaFim.TabIndex = 11;
            this.dateVendaFim.ValueChanged += new System.EventHandler(this.dateVendaFim_ValueChanged);
            // 
            // btnVendaLimpar
            // 
            this.btnVendaLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnVendaLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVendaLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVendaLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnVendaLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVendaLimpar.Location = new System.Drawing.Point(1154, 36);
            this.btnVendaLimpar.Name = "btnVendaLimpar";
            this.btnVendaLimpar.Size = new System.Drawing.Size(176, 47);
            this.btnVendaLimpar.TabIndex = 12;
            this.btnVendaLimpar.Text = "Todos os tempos";
            this.btnVendaLimpar.UseVisualStyleBackColor = false;
            this.btnVendaLimpar.Click += new System.EventHandler(this.btnVendaLimpar_Click);
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1377, 772);
            this.Controls.Add(this.btnVendaLimpar);
            this.Controls.Add(this.dateVendaFim);
            this.Controls.Add(this.dateVendaInicio);
            this.Controls.Add(this.dateCompraFim);
            this.Controls.Add(this.dateCompraInicio);
            this.Controls.Add(this.btnCompraLimpar);
            this.Controls.Add(this.btnRelatorioProd);
            this.Controls.Add(this.btnRelatorioMat);
            this.Controls.Add(this.btnRelatorioClient);
            this.Controls.Add(this.btnRelatorioVend);
            this.Controls.Add(this.btnRelatorioForn);
            this.Controls.Add(this.btnRelatorioComp);
            this.Controls.Add(this.dataRelatorio);
            this.Name = "Relatorios";
            this.Text = "Relatorios";
            ((System.ComponentModel.ISupportInitialize)(this.dataRelatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataRelatorio;
        private System.Windows.Forms.Button btnRelatorioComp;
        private System.Windows.Forms.Button btnRelatorioForn;
        private System.Windows.Forms.Button btnRelatorioVend;
        private System.Windows.Forms.Button btnRelatorioClient;
        private System.Windows.Forms.Button btnRelatorioProd;
        private System.Windows.Forms.Button btnRelatorioMat;
        private System.Windows.Forms.Button btnCompraLimpar;
        private System.Windows.Forms.DateTimePicker dateCompraInicio;
        private System.Windows.Forms.DateTimePicker dateCompraFim;
        private System.Windows.Forms.DateTimePicker dateVendaInicio;
        private System.Windows.Forms.DateTimePicker dateVendaFim;
        private System.Windows.Forms.Button btnVendaLimpar;
    }
}