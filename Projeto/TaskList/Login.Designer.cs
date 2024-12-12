namespace TaskList
{
    partial class JanelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaLogin));
            btnLogin = new MaterialSkin.Controls.MaterialButton();
            lblLogin = new Label();
            lblSubT = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            txtSenha = new MaterialSkin.Controls.MaterialTextBox();
            lblCadastrar = new Label();
            SuspendLayout();
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
            btnLogin.Location = new Point(87, 466);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(270, 43);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Acessar";
            btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(25, 29);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(83, 32);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login";
            // 
            // lblSubT
            // 
            lblSubT.AutoSize = true;
            lblSubT.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubT.Location = new Point(28, 73);
            lblSubT.Name = "lblSubT";
            lblSubT.Size = new Size(386, 20);
            lblSubT.TabIndex = 2;
            lblSubT.Text = "Digite os seus dados de acesso nos campos abaixo.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 165);
            label2.Name = "label2";
            label2.Size = new Size(142, 19);
            label2.TabIndex = 3;
            label2.Text = "Nome de Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 294);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 4;
            label3.Text = "Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.AnimateReadOnly = false;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Depth = 0;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 12F);
            txtUsuario.LeadingIcon = null;
            txtUsuario.Location = new Point(34, 201);
            txtUsuario.MaxLength = 50;
            txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(380, 50);
            txtUsuario.TabIndex = 5;
            txtUsuario.Text = "Digite seu nome de usuário";
            txtUsuario.TrailingIcon = null;
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Microsoft Sans Serif", 12F);
            txtSenha.LeadingIcon = null;
            txtSenha.Location = new Point(34, 334);
            txtSenha.MaxLength = 50;
            txtSenha.MouseState = MaterialSkin.MouseState.OUT;
            txtSenha.Multiline = false;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(380, 50);
            txtSenha.TabIndex = 6;
            txtSenha.Text = "Digite sua senha";
            txtSenha.TrailingIcon = null;
            // 
            // lblCadastrar
            // 
            lblCadastrar.AutoSize = true;
            lblCadastrar.Font = new Font("Century Gothic", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCadastrar.Location = new Point(34, 419);
            lblCadastrar.Name = "lblCadastrar";
            lblCadastrar.Size = new Size(82, 20);
            lblCadastrar.TabIndex = 7;
            lblCadastrar.Text = "Cadastrar";
            lblCadastrar.Click += lblCadastrar_Click_1;
            lblCadastrar.MouseEnter += lblCadastrar_MouseEnter;
            // 
            // JanelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 543);
            Controls.Add(lblCadastrar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblSubT);
            Controls.Add(lblLogin);
            Controls.Add(btnLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "JanelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskList - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnLogin;
        private Label lblLogin;
        private Label lblSubT;
        private Label label2;
        private Label label3;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private MaterialSkin.Controls.MaterialTextBox txtSenha;
        private Label lblCadastrar;
    }
}
