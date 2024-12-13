namespace TaskList.View.Tarefas
{
    partial class AdicionarTarefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarTarefa));
            txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            label2 = new Label();
            lblSubT = new Label();
            lblLogin = new Label();
            btnLogin = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            label3 = new Label();
            label4 = new Label();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.AnimateReadOnly = false;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Depth = 0;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 12F);
            txtUsuario.LeadingIcon = null;
            txtUsuario.Location = new Point(43, 180);
            txtUsuario.MaxLength = 50;
            txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(380, 50);
            txtUsuario.TabIndex = 15;
            txtUsuario.Text = "Digite o nome da sua tarefa";
            txtUsuario.TrailingIcon = null;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 143);
            label2.Name = "label2";
            label2.Size = new Size(135, 19);
            label2.TabIndex = 14;
            label2.Text = "Nome da Tarefa";
            // 
            // lblSubT
            // 
            lblSubT.AutoSize = true;
            lblSubT.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubT.Location = new Point(43, 78);
            lblSubT.Name = "lblSubT";
            lblSubT.Size = new Size(373, 20);
            lblSubT.TabIndex = 13;
            lblSubT.Text = "Digite os dados da sua tarefa nos campos abaixo.";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(34, 34);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(230, 32);
            lblLogin.TabIndex = 12;
            lblLogin.Text = "Adicionar Tarefa";
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
            btnLogin.Location = new Point(216, 388);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(448, 69);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Adicionar";
            btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 249);
            label1.Name = "label1";
            label1.Size = new Size(136, 19);
            label1.TabIndex = 16;
            label1.Text = "Grupo da Tarefa";
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Location = new Point(43, 280);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(380, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 17;
            // 
            // materialComboBox2
            // 
            materialComboBox2.AutoResize = false;
            materialComboBox2.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox2.Depth = 0;
            materialComboBox2.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox2.DropDownHeight = 174;
            materialComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox2.DropDownWidth = 121;
            materialComboBox2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox2.FormattingEnabled = true;
            materialComboBox2.IntegralHeight = false;
            materialComboBox2.ItemHeight = 43;
            materialComboBox2.Location = new Point(472, 174);
            materialComboBox2.MaxDropDownItems = 4;
            materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox2.Name = "materialComboBox2";
            materialComboBox2.Size = new Size(380, 49);
            materialComboBox2.StartIndex = 0;
            materialComboBox2.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(472, 143);
            label3.Name = "label3";
            label3.Size = new Size(167, 19);
            label3.TabIndex = 18;
            label3.Text = "Prioridade da Tarefa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(472, 249);
            label4.Name = "label4";
            label4.Size = new Size(129, 19);
            label4.TabIndex = 20;
            label4.Text = "Prazo da Tarefa";
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(472, 282);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(380, 50);
            materialTextBox1.TabIndex = 21;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // AdicionarTarefa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 505);
            Controls.Add(materialTextBox1);
            Controls.Add(label4);
            Controls.Add(materialComboBox2);
            Controls.Add(label3);
            Controls.Add(materialComboBox1);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(lblSubT);
            Controls.Add(lblLogin);
            Controls.Add(btnLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(922, 544);
            MinimumSize = new Size(922, 544);
            Name = "AdicionarTarefa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskList - Adicionar Tarefa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private Label label2;
        private Label lblSubT;
        private Label lblLogin;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private Label label1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        private Label label3;
        private Label label4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
    }
}