namespace TaskList
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            lblLogin = new Label();
            lblSubT = new Label();
            label2 = new Label();
            txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            label3 = new Label();
            txtSenha = new MaterialSkin.Controls.MaterialTextBox();
            btnLogin = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(26, 40);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(135, 32);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Cadastro";
            // 
            // lblSubT
            // 
            lblSubT.AutoSize = true;
            lblSubT.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubT.Location = new Point(26, 90);
            lblSubT.Name = "lblSubT";
            lblSubT.Size = new Size(529, 20);
            lblSubT.TabIndex = 3;
            lblSubT.Text = "Digite os dados desejados para realizar o cadastro nos campos abaixo.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 170);
            label2.Name = "label2";
            label2.Size = new Size(142, 19);
            label2.TabIndex = 4;
            label2.Text = "Nome de Usuário";
            // 
            // txtUsuario
            // 
            txtUsuario.AnimateReadOnly = false;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Depth = 0;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 12F);
            txtUsuario.LeadingIcon = null;
            txtUsuario.Location = new Point(26, 213);
            txtUsuario.MaxLength = 50;
            txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(508, 50);
            txtUsuario.TabIndex = 6;
            txtUsuario.Text = "Digite seu nome de usuário";
            txtUsuario.TrailingIcon = null;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 308);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 7;
            label3.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Microsoft Sans Serif", 12F);
            txtSenha.LeadingIcon = null;
            txtSenha.Location = new Point(26, 359);
            txtSenha.MaxLength = 50;
            txtSenha.MouseState = MaterialSkin.MouseState.OUT;
            txtSenha.Multiline = false;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(508, 50);
            txtSenha.TabIndex = 8;
            txtSenha.Text = "Digite sua senha";
            txtSenha.TrailingIcon = null;
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
            btnLogin.Location = new Point(53, 474);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(461, 43);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Criar Conta";
            btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 543);
            Controls.Add(btnLogin);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(lblSubT);
            Controls.Add(lblLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskList - Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblSubT;
        private Label label2;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private Label label3;
        private MaterialSkin.Controls.MaterialTextBox txtSenha;
        private MaterialSkin.Controls.MaterialButton btnLogin;
    }
}