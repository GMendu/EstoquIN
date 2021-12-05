
namespace EstoquIN.View
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.labelLoginLogin = new System.Windows.Forms.Label();
            this.labelLoginUser = new System.Windows.Forms.Label();
            this.labelLoginSenha = new System.Windows.Forms.Label();
            this.txtLoginUser = new System.Windows.Forms.TextBox();
            this.txtLoginSenha = new System.Windows.Forms.TextBox();
            this.btnLoginLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1598, 842);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 842);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Logo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(419, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1179, 215);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(419, 624);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1179, 218);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1245, 215);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(353, 409);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.panel6.Controls.Add(this.btnLoginLogin);
            this.panel6.Controls.Add(this.txtLoginSenha);
            this.panel6.Controls.Add(this.txtLoginUser);
            this.panel6.Controls.Add(this.labelLoginSenha);
            this.panel6.Controls.Add(this.labelLoginUser);
            this.panel6.Controls.Add(this.labelLoginLogin);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(419, 215);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(826, 409);
            this.panel6.TabIndex = 4;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(345, 52);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(166, 163);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // labelLoginLogin
            // 
            this.labelLoginLogin.AutoSize = true;
            this.labelLoginLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginLogin.ForeColor = System.Drawing.Color.White;
            this.labelLoginLogin.Location = new System.Drawing.Point(386, 76);
            this.labelLoginLogin.Name = "labelLoginLogin";
            this.labelLoginLogin.Size = new System.Drawing.Size(96, 37);
            this.labelLoginLogin.TabIndex = 0;
            this.labelLoginLogin.Text = "Login";
            // 
            // labelLoginUser
            // 
            this.labelLoginUser.AutoSize = true;
            this.labelLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginUser.ForeColor = System.Drawing.Color.White;
            this.labelLoginUser.Location = new System.Drawing.Point(210, 121);
            this.labelLoginUser.Name = "labelLoginUser";
            this.labelLoginUser.Size = new System.Drawing.Size(74, 24);
            this.labelLoginUser.TabIndex = 1;
            this.labelLoginUser.Text = "Usuário";
            // 
            // labelLoginSenha
            // 
            this.labelLoginSenha.AutoSize = true;
            this.labelLoginSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginSenha.ForeColor = System.Drawing.Color.White;
            this.labelLoginSenha.Location = new System.Drawing.Point(209, 186);
            this.labelLoginSenha.Name = "labelLoginSenha";
            this.labelLoginSenha.Size = new System.Drawing.Size(65, 24);
            this.labelLoginSenha.TabIndex = 2;
            this.labelLoginSenha.Text = "Senha";
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.Location = new System.Drawing.Point(213, 147);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(410, 20);
            this.txtLoginUser.TabIndex = 3;
            // 
            // txtLoginSenha
            // 
            this.txtLoginSenha.Location = new System.Drawing.Point(213, 213);
            this.txtLoginSenha.Name = "txtLoginSenha";
            this.txtLoginSenha.Size = new System.Drawing.Size(410, 20);
            this.txtLoginSenha.TabIndex = 4;
            // 
            // btnLoginLogin
            // 
            this.btnLoginLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginLogin.ForeColor = System.Drawing.Color.White;
            this.btnLoginLogin.Location = new System.Drawing.Point(382, 290);
            this.btnLoginLogin.Name = "btnLoginLogin";
            this.btnLoginLogin.Size = new System.Drawing.Size(100, 40);
            this.btnLoginLogin.TabIndex = 5;
            this.btnLoginLogin.Text = "Logar";
            this.btnLoginLogin.UseVisualStyleBackColor = true;
            this.btnLoginLogin.Click += new System.EventHandler(this.btnLoginLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 842);
            this.Controls.Add(this.panel1);
            this.Name = "FormLogin";
            this.Text = "Log_in";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button btnLoginLogin;
        private System.Windows.Forms.TextBox txtLoginSenha;
        private System.Windows.Forms.TextBox txtLoginUser;
        private System.Windows.Forms.Label labelLoginSenha;
        private System.Windows.Forms.Label labelLoginUser;
        private System.Windows.Forms.Label labelLoginLogin;
    }
}