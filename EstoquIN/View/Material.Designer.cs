﻿
namespace EstoquIN.View
{
    partial class Material
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
            this.dataMaterial = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupMaterialInfo = new System.Windows.Forms.GroupBox();
            this.lblMaterialNome = new System.Windows.Forms.Label();
            this.txtMaterialNome = new System.Windows.Forms.TextBox();
            this.btnMaterialAdicionar = new FontAwesome.Sharp.IconButton();
            this.btnMaterialEditar = new FontAwesome.Sharp.IconButton();
            this.btnMaterialCancelar = new FontAwesome.Sharp.IconButton();
            this.btnMaterialExcluir = new FontAwesome.Sharp.IconButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataMaterialFornec = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataMaterial)).BeginInit();
            this.groupMaterialInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMaterialFornec)).BeginInit();
            this.SuspendLayout();
            // 
            // dataMaterial
            // 
            this.dataMaterial.AllowUserToAddRows = false;
            this.dataMaterial.AllowUserToDeleteRows = false;
            this.dataMaterial.AllowUserToResizeColumns = false;
            this.dataMaterial.AllowUserToResizeRows = false;
            this.dataMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMaterial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.dataMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId});
            this.dataMaterial.Location = new System.Drawing.Point(12, 12);
            this.dataMaterial.Name = "dataMaterial";
            this.dataMaterial.RowHeadersVisible = false;
            this.dataMaterial.RowTemplate.Height = 25;
            this.dataMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMaterial.Size = new System.Drawing.Size(349, 748);
            this.dataMaterial.TabIndex = 0;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "Id";
            this.ColumnId.FillWeight = 25F;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            // 
            // groupMaterialInfo
            // 
            this.groupMaterialInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupMaterialInfo.Controls.Add(this.lblMaterialNome);
            this.groupMaterialInfo.Controls.Add(this.txtMaterialNome);
            this.groupMaterialInfo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.groupMaterialInfo.ForeColor = System.Drawing.Color.White;
            this.groupMaterialInfo.Location = new System.Drawing.Point(367, 12);
            this.groupMaterialInfo.Name = "groupMaterialInfo";
            this.groupMaterialInfo.Size = new System.Drawing.Size(806, 418);
            this.groupMaterialInfo.TabIndex = 1;
            this.groupMaterialInfo.TabStop = false;
            this.groupMaterialInfo.Text = "Material";
            // 
            // lblMaterialNome
            // 
            this.lblMaterialNome.AutoSize = true;
            this.lblMaterialNome.ForeColor = System.Drawing.Color.White;
            this.lblMaterialNome.Location = new System.Drawing.Point(135, 157);
            this.lblMaterialNome.Name = "lblMaterialNome";
            this.lblMaterialNome.Size = new System.Drawing.Size(66, 28);
            this.lblMaterialNome.TabIndex = 2;
            this.lblMaterialNome.Text = "Nome";
            // 
            // txtMaterialNome
            // 
            this.txtMaterialNome.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMaterialNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaterialNome.Location = new System.Drawing.Point(130, 188);
            this.txtMaterialNome.MaxLength = 45;
            this.txtMaterialNome.Name = "txtMaterialNome";
            this.txtMaterialNome.Size = new System.Drawing.Size(513, 34);
            this.txtMaterialNome.TabIndex = 3;
            // 
            // btnMaterialAdicionar
            // 
            this.btnMaterialAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(203)))), ((int)(((byte)(116)))));
            this.btnMaterialAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterialAdicionar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterialAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnMaterialAdicionar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMaterialAdicionar.IconColor = System.Drawing.Color.Black;
            this.btnMaterialAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaterialAdicionar.Location = new System.Drawing.Point(1181, 15);
            this.btnMaterialAdicionar.Name = "btnMaterialAdicionar";
            this.btnMaterialAdicionar.Size = new System.Drawing.Size(186, 92);
            this.btnMaterialAdicionar.TabIndex = 21;
            this.btnMaterialAdicionar.Text = "Adicionar";
            this.btnMaterialAdicionar.UseVisualStyleBackColor = false;
            this.btnMaterialAdicionar.Click += new System.EventHandler(this.btnMaterialAdicionar_Click);
            // 
            // btnMaterialEditar
            // 
            this.btnMaterialEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnMaterialEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterialEditar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterialEditar.ForeColor = System.Drawing.Color.White;
            this.btnMaterialEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMaterialEditar.IconColor = System.Drawing.Color.Black;
            this.btnMaterialEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaterialEditar.Location = new System.Drawing.Point(1181, 113);
            this.btnMaterialEditar.Name = "btnMaterialEditar";
            this.btnMaterialEditar.Size = new System.Drawing.Size(186, 99);
            this.btnMaterialEditar.TabIndex = 22;
            this.btnMaterialEditar.Text = "Editar";
            this.btnMaterialEditar.UseVisualStyleBackColor = false;
            this.btnMaterialEditar.Click += new System.EventHandler(this.btnMaterialEditar_Click);
            // 
            // btnMaterialCancelar
            // 
            this.btnMaterialCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnMaterialCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterialCancelar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterialCancelar.ForeColor = System.Drawing.Color.White;
            this.btnMaterialCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMaterialCancelar.IconColor = System.Drawing.Color.Black;
            this.btnMaterialCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaterialCancelar.Location = new System.Drawing.Point(1180, 218);
            this.btnMaterialCancelar.Name = "btnMaterialCancelar";
            this.btnMaterialCancelar.Size = new System.Drawing.Size(187, 102);
            this.btnMaterialCancelar.TabIndex = 23;
            this.btnMaterialCancelar.Text = "Cancelar";
            this.btnMaterialCancelar.UseVisualStyleBackColor = false;
            this.btnMaterialCancelar.Click += new System.EventHandler(this.btnMaterialCancelar_Click);
            // 
            // btnMaterialExcluir
            // 
            this.btnMaterialExcluir.BackColor = System.Drawing.Color.Maroon;
            this.btnMaterialExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterialExcluir.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterialExcluir.ForeColor = System.Drawing.Color.White;
            this.btnMaterialExcluir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMaterialExcluir.IconColor = System.Drawing.Color.Black;
            this.btnMaterialExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaterialExcluir.Location = new System.Drawing.Point(1179, 326);
            this.btnMaterialExcluir.Name = "btnMaterialExcluir";
            this.btnMaterialExcluir.Size = new System.Drawing.Size(186, 104);
            this.btnMaterialExcluir.TabIndex = 24;
            this.btnMaterialExcluir.Text = "Excluir";
            this.btnMaterialExcluir.UseVisualStyleBackColor = false;
            this.btnMaterialExcluir.Click += new System.EventHandler(this.btnMaterialExcluir_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.FillWeight = 25F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataMaterialFornec
            // 
            this.dataMaterialFornec.AllowUserToAddRows = false;
            this.dataMaterialFornec.AllowUserToDeleteRows = false;
            this.dataMaterialFornec.AllowUserToResizeColumns = false;
            this.dataMaterialFornec.AllowUserToResizeRows = false;
            this.dataMaterialFornec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMaterialFornec.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.dataMaterialFornec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMaterialFornec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataMaterialFornec.Location = new System.Drawing.Point(367, 436);
            this.dataMaterialFornec.Name = "dataMaterialFornec";
            this.dataMaterialFornec.RowHeadersVisible = false;
            this.dataMaterialFornec.RowTemplate.Height = 25;
            this.dataMaterialFornec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMaterialFornec.Size = new System.Drawing.Size(998, 324);
            this.dataMaterialFornec.TabIndex = 25;
            // 
            // Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1377, 772);
            this.Controls.Add(this.dataMaterialFornec);
            this.Controls.Add(this.btnMaterialAdicionar);
            this.Controls.Add(this.btnMaterialEditar);
            this.Controls.Add(this.btnMaterialCancelar);
            this.Controls.Add(this.btnMaterialExcluir);
            this.Controls.Add(this.groupMaterialInfo);
            this.Controls.Add(this.dataMaterial);
            this.Name = "Material";
            this.Text = "Material";
            ((System.ComponentModel.ISupportInitialize)(this.dataMaterial)).EndInit();
            this.groupMaterialInfo.ResumeLayout(false);
            this.groupMaterialInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMaterialFornec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataMaterial;
        private System.Windows.Forms.GroupBox groupMaterialInfo;
        private System.Windows.Forms.Label lblMaterialNome;
        private System.Windows.Forms.TextBox txtMaterialNome;
        private FontAwesome.Sharp.IconButton btnMaterialAdicionar;
        private FontAwesome.Sharp.IconButton btnMaterialEditar;
        private FontAwesome.Sharp.IconButton btnMaterialCancelar;
        private FontAwesome.Sharp.IconButton btnMaterialExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataMaterialFornec;
    }
}