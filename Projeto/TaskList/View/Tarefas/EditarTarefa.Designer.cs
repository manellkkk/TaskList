namespace TaskList.View.Tarefas
{
    partial class EditarTarefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarTarefa));
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            label4 = new Label();
            materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            label3 = new Label();
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            label1 = new Label();
            txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            label2 = new Label();
            lblSubT = new Label();
            lblLogin = new Label();
            btnEditar = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(471, 297);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(380, 50);
            materialTextBox1.TabIndex = 32;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(471, 264);
            label4.Name = "label4";
            label4.Size = new Size(129, 19);
            label4.TabIndex = 31;
            label4.Text = "Prazo da Tarefa";
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
            materialComboBox2.Location = new Point(471, 189);
            materialComboBox2.MaxDropDownItems = 4;
            materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox2.Name = "materialComboBox2";
            materialComboBox2.Size = new Size(380, 49);
            materialComboBox2.StartIndex = 0;
            materialComboBox2.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(471, 158);
            label3.Name = "label3";
            label3.Size = new Size(167, 19);
            label3.TabIndex = 29;
            label3.Text = "Prioridade da Tarefa";
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
            materialComboBox1.Location = new Point(42, 295);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(380, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 264);
            label1.Name = "label1";
            label1.Size = new Size(136, 19);
            label1.TabIndex = 27;
            label1.Text = "Grupo da Tarefa";
            // 
            // txtUsuario
            // 
            txtUsuario.AnimateReadOnly = false;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Depth = 0;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 12F);
            txtUsuario.LeadingIcon = null;
            txtUsuario.Location = new Point(42, 195);
            txtUsuario.MaxLength = 50;
            txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(380, 50);
            txtUsuario.TabIndex = 26;
            txtUsuario.Text = "Digite o nome da sua tarefa";
            txtUsuario.TrailingIcon = null;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 158);
            label2.Name = "label2";
            label2.Size = new Size(135, 19);
            label2.TabIndex = 25;
            label2.Text = "Nome da Tarefa";
            // 
            // lblSubT
            // 
            lblSubT.AutoSize = true;
            lblSubT.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubT.Location = new Point(42, 93);
            lblSubT.Name = "lblSubT";
            lblSubT.Size = new Size(422, 20);
            lblSubT.TabIndex = 24;
            lblSubT.Text = "Digite os novos dados da sua tarefa nos campos abaixo.";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(33, 49);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(176, 32);
            lblLogin.TabIndex = 23;
            lblLogin.Text = "Editar Tarefa";
            // 
            // btnEditar
            // 
            btnEditar.AutoSize = false;
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.Location = new Point(215, 403);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(448, 69);
            btnEditar.TabIndex = 22;
            btnEditar.Text = "confirmar";
            btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // EditarTarefa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 539);
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
            Controls.Add(btnEditar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(938, 578);
            MinimumSize = new Size(938, 578);
            Name = "EditarTarefa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskList - Editar Tarefa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private Label label4;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        private Label label3;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private Label label2;
        private Label lblSubT;
        private Label lblLogin;
        private MaterialSkin.Controls.MaterialButton btnEditar;
    }
}