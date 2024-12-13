namespace TaskList.View.Usuário
{
    partial class EditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarUsuario));
            label1 = new Label();
            txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            label2 = new Label();
            lblSubT = new Label();
            lblLogin = new Label();
            btnLogin = new MaterialSkin.Controls.MaterialButton();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            label3 = new Label();
            materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 256);
            label1.Name = "label1";
            label1.Size = new Size(102, 19);
            label1.TabIndex = 23;
            label1.Text = "Nova senha";
            // 
            // txtUsuario
            // 
            txtUsuario.AnimateReadOnly = false;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Depth = 0;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 12F);
            txtUsuario.LeadingIcon = null;
            txtUsuario.Location = new Point(36, 187);
            txtUsuario.MaxLength = 50;
            txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(380, 50);
            txtUsuario.TabIndex = 22;
            txtUsuario.Text = "Digite o nome do usuário";
            txtUsuario.TrailingIcon = null;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 150);
            label2.Name = "label2";
            label2.Size = new Size(185, 19);
            label2.TabIndex = 21;
            label2.Text = "Novo nome do Usuário";
            // 
            // lblSubT
            // 
            lblSubT.AutoSize = true;
            lblSubT.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubT.Location = new Point(36, 90);
            lblSubT.Name = "lblSubT";
            lblSubT.Size = new Size(351, 20);
            lblSubT.TabIndex = 20;
            lblSubT.Text = "Digite os dados do usuário nos campos abaixo.";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(27, 46);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(191, 32);
            lblLogin.TabIndex = 19;
            lblLogin.Text = "Editar Usuário";
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
            btnLogin.Location = new Point(36, 390);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(380, 69);
            btnLogin.TabIndex = 18;
            btnLogin.Text = "Confirmar";
            btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Microsoft Sans Serif", 12F);
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(36, 295);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(380, 50);
            materialTextBox1.TabIndex = 24;
            materialTextBox1.Text = "Digite a senha usuário";
            materialTextBox1.TrailingIcon = null;
            // 
            // materialCheckbox1
            // 
            materialCheckbox1.AutoSize = true;
            materialCheckbox1.Depth = 0;
            materialCheckbox1.Location = new Point(498, 179);
            materialCheckbox1.Margin = new Padding(0);
            materialCheckbox1.MouseLocation = new Point(-1, -1);
            materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox1.Name = "materialCheckbox1";
            materialCheckbox1.ReadOnly = false;
            materialCheckbox1.Ripple = true;
            materialCheckbox1.Size = new Size(155, 37);
            materialCheckbox1.TabIndex = 25;
            materialCheckbox1.Text = "Nome de usuário";
            materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(487, 150);
            label3.Name = "label3";
            label3.Size = new Size(91, 19);
            label3.TabIndex = 26;
            label3.Text = "Alterações";
            // 
            // materialCheckbox2
            // 
            materialCheckbox2.AutoSize = true;
            materialCheckbox2.Depth = 0;
            materialCheckbox2.Location = new Point(498, 229);
            materialCheckbox2.Margin = new Padding(0);
            materialCheckbox2.MouseLocation = new Point(-1, -1);
            materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox2.Name = "materialCheckbox2";
            materialCheckbox2.ReadOnly = false;
            materialCheckbox2.Ripple = true;
            materialCheckbox2.Size = new Size(158, 37);
            materialCheckbox2.TabIndex = 27;
            materialCheckbox2.Text = "Senha de usuário";
            materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // EditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 521);
            Controls.Add(materialCheckbox2);
            Controls.Add(label3);
            Controls.Add(materialCheckbox1);
            Controls.Add(materialTextBox1);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(lblSubT);
            Controls.Add(lblLogin);
            Controls.Add(btnLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskList - Editar Usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private Label label2;
        private Label lblSubT;
        private Label lblLogin;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private Label label3;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
    }
}