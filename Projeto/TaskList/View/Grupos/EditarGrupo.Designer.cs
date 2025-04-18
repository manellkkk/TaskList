﻿namespace TaskList.View.Grupos
{
    partial class EditarGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarGrupo));
            txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            label2 = new Label();
            lblSubT = new Label();
            lblLogin = new Label();
            btnLogin = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.AnimateReadOnly = false;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Depth = 0;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 12F);
            txtUsuario.LeadingIcon = null;
            txtUsuario.Location = new Point(31, 185);
            txtUsuario.MaxLength = 50;
            txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(380, 50);
            txtUsuario.TabIndex = 15;
            txtUsuario.Text = "Digite o novo nome do grupo";
            txtUsuario.TrailingIcon = null;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 149);
            label2.Name = "label2";
            label2.Size = new Size(135, 19);
            label2.TabIndex = 14;
            label2.Text = "Nome do Grupo";
            // 
            // lblSubT
            // 
            lblSubT.AutoSize = true;
            lblSubT.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubT.Location = new Point(40, 83);
            lblSubT.Name = "lblSubT";
            lblSubT.Size = new Size(321, 20);
            lblSubT.TabIndex = 13;
            lblSubT.Text = "Digite o nome do grupo no campo abaixo.";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(31, 39);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(178, 32);
            lblLogin.TabIndex = 12;
            lblLogin.Text = "Editar Grupo";
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = false;
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogin.Depth = 0;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.HighEmphasis = true;
            btnLogin.Icon = null;
            btnLogin.Location = new Point(66, 287);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(309, 43);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "confirmar";
            btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // EditarGrupo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 399);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(lblSubT);
            Controls.Add(lblLogin);
            Controls.Add(btnLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(473, 438);
            MinimumSize = new Size(473, 438);
            Name = "EditarGrupo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskList - Editar Grupo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private Label label2;
        private Label lblSubT;
        private Label lblLogin;
        private MaterialSkin.Controls.MaterialButton btnLogin;
    }
}