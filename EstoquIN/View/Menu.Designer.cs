
namespace EstoquIN
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMaterial = new FontAwesome.Sharp.IconButton();
            this.btnCompras = new FontAwesome.Sharp.IconButton();
            this.btnConfiguracoes = new FontAwesome.Sharp.IconButton();
            this.btnRelatorios = new FontAwesome.Sharp.IconButton();
            this.btnFornecedores = new FontAwesome.Sharp.IconButton();
            this.btnProdutos = new FontAwesome.Sharp.IconButton();
            this.btnVendas = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.BtnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtMenuRelogio = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerRelogio = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.panelMenu.Controls.Add(this.btnMaterial);
            this.panelMenu.Controls.Add(this.btnCompras);
            this.panelMenu.Controls.Add(this.btnConfiguracoes);
            this.panelMenu.Controls.Add(this.btnRelatorios);
            this.panelMenu.Controls.Add(this.btnFornecedores);
            this.panelMenu.Controls.Add(this.btnProdutos);
            this.panelMenu.Controls.Add(this.btnVendas);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(205, 842);
            this.panelMenu.TabIndex = 0;
            // 
            // btnMaterial
            // 
            this.btnMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterial.FlatAppearance.BorderSize = 0;
            this.btnMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterial.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnMaterial.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaterial.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.btnMaterial.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaterial.IconSize = 32;
            this.btnMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterial.Location = new System.Drawing.Point(0, 433);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnMaterial.Size = new System.Drawing.Size(205, 52);
            this.btnMaterial.TabIndex = 8;
            this.btnMaterial.Text = "Material";
            this.btnMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnCompras.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCompras.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnCompras.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompras.IconSize = 32;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(0, 381);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnCompras.Size = new System.Drawing.Size(205, 52);
            this.btnCompras.TabIndex = 7;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnConfiguracoes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConfiguracoes.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnConfiguracoes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnConfiguracoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfiguracoes.IconSize = 32;
            this.btnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracoes.Location = new System.Drawing.Point(0, 790);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnConfiguracoes.Size = new System.Drawing.Size(205, 52);
            this.btnConfiguracoes.TabIndex = 6;
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracoes.UseVisualStyleBackColor = true;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnRelatorios.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRelatorios.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnRelatorios.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRelatorios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRelatorios.IconSize = 32;
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.Location = new System.Drawing.Point(0, 329);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnRelatorios.Size = new System.Drawing.Size(205, 52);
            this.btnRelatorios.TabIndex = 5;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFornecedores.FlatAppearance.BorderSize = 0;
            this.btnFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedores.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnFornecedores.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFornecedores.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnFornecedores.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFornecedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFornecedores.IconSize = 32;
            this.btnFornecedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFornecedores.Location = new System.Drawing.Point(0, 277);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnFornecedores.Size = new System.Drawing.Size(205, 52);
            this.btnFornecedores.TabIndex = 4;
            this.btnFornecedores.Text = "Fornecedores";
            this.btnFornecedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFornecedores.UseVisualStyleBackColor = true;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnProdutos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProdutos.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.btnProdutos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProdutos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProdutos.IconSize = 32;
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.Location = new System.Drawing.Point(0, 225);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnProdutos.Size = new System.Drawing.Size(205, 52);
            this.btnProdutos.TabIndex = 3;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnVendas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVendas.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.btnVendas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendas.IconSize = 32;
            this.btnVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendas.Location = new System.Drawing.Point(0, 173);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnVendas.Size = new System.Drawing.Size(205, 52);
            this.btnVendas.TabIndex = 2;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnClientes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 32;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 121);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnClientes.Size = new System.Drawing.Size(205, 52);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.panelLogo.Controls.Add(this.BtnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(205, 121);
            this.panelLogo.TabIndex = 0;
            // 
            // BtnHome
            // 
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.Location = new System.Drawing.Point(10, 21);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(152, 86);
            this.BtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnHome.TabIndex = 0;
            this.BtnHome.TabStop = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.panelTitleBar.Controls.Add(this.btnMinimizar);
            this.panelTitleBar.Controls.Add(this.btnMaximizar);
            this.panelTitleBar.Controls.Add(this.btnFechar);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(205, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1393, 65);
            this.panelTitleBar.TabIndex = 1;
          
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnMinimizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimizar.Location = new System.Drawing.Point(1301, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(27, 32);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.Text = ".";
            this.btnMinimizar.UseVisualStyleBackColor = true;

            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnMaximizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaximizar.Location = new System.Drawing.Point(1332, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(27, 32);
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.Text = "o";
            this.btnMaximizar.UseVisualStyleBackColor = true;
           
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnFechar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFechar.Location = new System.Drawing.Point(1364, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(27, 32);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "O";
            this.btnFechar.UseVisualStyleBackColor = true;

            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(51, 26);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(65, 28);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 27;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(18, 26);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(27, 28);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(89)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(205, 65);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1393, 8);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.panelDesktop.Controls.Add(this.iconPictureBox1);
            this.panelDesktop.Controls.Add(this.txtMenuRelogio);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(205, 73);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1393, 769);
            this.panelDesktop.TabIndex = 3;
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
            this.iconPictureBox1.Location = new System.Drawing.Point(28, 384);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(103, 107);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtMenuRelogio
            // 
            this.txtMenuRelogio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.txtMenuRelogio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMenuRelogio.Font = new System.Drawing.Font("Segoe UI", 40F);
            this.txtMenuRelogio.Location = new System.Drawing.Point(122, 396);
            this.txtMenuRelogio.Name = "txtMenuRelogio";
            this.txtMenuRelogio.Size = new System.Drawing.Size(226, 71);
            this.txtMenuRelogio.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(522, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timerRelogio
            // 
            this.timerRelogio.Enabled = true;
            this.timerRelogio.Interval = 1000;
            this.timerRelogio.Tick += new System.EventHandler(this.timerRelogio_Tick);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 842);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnConfiguracoes;
        private FontAwesome.Sharp.IconButton btnRelatorios;
        private FontAwesome.Sharp.IconButton btnFornecedores;
        private FontAwesome.Sharp.IconButton btnProdutos;
        private FontAwesome.Sharp.IconButton btnVendas;
        private FontAwesome.Sharp.IconButton btnClientes;
        private System.Windows.Forms.PictureBox BtnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Timer timerRelogio;
        private System.Windows.Forms.TextBox txtMenuRelogio;
        private FontAwesome.Sharp.IconButton btnCompras;
        private FontAwesome.Sharp.IconButton btnMaterial;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}

