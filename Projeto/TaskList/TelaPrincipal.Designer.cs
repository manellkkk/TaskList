namespace TaskList
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            plNav = new Panel();
            btnUsuario = new Button();
            btnSair = new Button();
            btnTarefas = new Button();
            btnGrupos = new Button();
            btnAdicionar = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Descrição = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label6 = new Label();
            materialProgressBar2 = new MaterialSkin.Controls.MaterialProgressBar();
            label3 = new Label();
            label2 = new Label();
            materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            label5 = new Label();
            lblTarefasDia = new Label();
            plNav.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // plNav
            // 
            plNav.BackColor = Color.SteelBlue;
            plNav.Controls.Add(btnUsuario);
            plNav.Controls.Add(btnSair);
            plNav.Controls.Add(btnTarefas);
            plNav.Controls.Add(btnGrupos);
            plNav.Controls.Add(btnAdicionar);
            plNav.Dock = DockStyle.Left;
            plNav.Location = new Point(0, 0);
            plNav.Name = "plNav";
            plNav.Padding = new Padding(15);
            plNav.Size = new Size(194, 681);
            plNav.TabIndex = 0;
            // 
            // btnUsuario
            // 
            btnUsuario.Anchor = AnchorStyles.Top;
            btnUsuario.AutoSize = true;
            btnUsuario.BackColor = Color.Transparent;
            btnUsuario.BackgroundImageLayout = ImageLayout.None;
            btnUsuario.Cursor = Cursors.Hand;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnUsuario.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuario.ForeColor = Color.WhiteSmoke;
            btnUsuario.Image = (Image)resources.GetObject("btnUsuario.Image");
            btnUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuario.Location = new Point(6, 284);
            btnUsuario.Margin = new Padding(10);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(178, 80);
            btnUsuario.TabIndex = 4;
            btnUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnSair
            // 
            btnSair.AutoSize = true;
            btnSair.BackColor = Color.Transparent;
            btnSair.BackgroundImageLayout = ImageLayout.None;
            btnSair.Cursor = Cursors.Hand;
            btnSair.Dock = DockStyle.Bottom;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSair.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.WhiteSmoke;
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(15, 586);
            btnSair.Margin = new Padding(10);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(164, 80);
            btnSair.TabIndex = 3;
            btnSair.TextAlign = ContentAlignment.MiddleRight;
            btnSair.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnTarefas
            // 
            btnTarefas.Anchor = AnchorStyles.Top;
            btnTarefas.AutoSize = true;
            btnTarefas.BackColor = Color.Transparent;
            btnTarefas.BackgroundImageLayout = ImageLayout.None;
            btnTarefas.Cursor = Cursors.Hand;
            btnTarefas.FlatAppearance.BorderSize = 0;
            btnTarefas.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTarefas.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTarefas.FlatStyle = FlatStyle.Flat;
            btnTarefas.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTarefas.ForeColor = Color.WhiteSmoke;
            btnTarefas.Image = (Image)resources.GetObject("btnTarefas.Image");
            btnTarefas.ImageAlign = ContentAlignment.MiddleLeft;
            btnTarefas.Location = new Point(3, 196);
            btnTarefas.Margin = new Padding(10);
            btnTarefas.Name = "btnTarefas";
            btnTarefas.Size = new Size(178, 80);
            btnTarefas.TabIndex = 2;
            btnTarefas.TextAlign = ContentAlignment.MiddleRight;
            btnTarefas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTarefas.UseVisualStyleBackColor = false;
            btnTarefas.Click += btnTarefas_Click;
            // 
            // btnGrupos
            // 
            btnGrupos.Anchor = AnchorStyles.Top;
            btnGrupos.AutoSize = true;
            btnGrupos.BackColor = Color.Transparent;
            btnGrupos.BackgroundImageLayout = ImageLayout.None;
            btnGrupos.Cursor = Cursors.Hand;
            btnGrupos.FlatAppearance.BorderSize = 0;
            btnGrupos.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnGrupos.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnGrupos.FlatStyle = FlatStyle.Flat;
            btnGrupos.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGrupos.ForeColor = Color.WhiteSmoke;
            btnGrupos.Image = (Image)resources.GetObject("btnGrupos.Image");
            btnGrupos.ImageAlign = ContentAlignment.MiddleLeft;
            btnGrupos.Location = new Point(3, 111);
            btnGrupos.Margin = new Padding(10);
            btnGrupos.Name = "btnGrupos";
            btnGrupos.Size = new Size(178, 80);
            btnGrupos.TabIndex = 1;
            btnGrupos.TextAlign = ContentAlignment.MiddleRight;
            btnGrupos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGrupos.UseVisualStyleBackColor = false;
            btnGrupos.Click += btnGrupos_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Top;
            btnAdicionar.AutoSize = true;
            btnAdicionar.BackColor = Color.Transparent;
            btnAdicionar.BackgroundImageLayout = ImageLayout.None;
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAdicionar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.WhiteSmoke;
            btnAdicionar.Image = (Image)resources.GetObject("btnAdicionar.Image");
            btnAdicionar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionar.Location = new Point(3, 19);
            btnAdicionar.Margin = new Padding(10);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(178, 80);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.TextAlign = ContentAlignment.MiddleRight;
            btnAdicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(194, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5387F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 87.4613F));
            tableLayoutPanel3.Size = new Size(1044, 681);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(40, 40, 0, 0);
            label4.Size = new Size(236, 68);
            label4.TabIndex = 2;
            label4.Text = "Olá, Manellkkk!";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(lblTarefasDia, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 88);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.78466F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56.5454559F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.727272F));
            tableLayoutPanel1.Size = new Size(1038, 590);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, Descrição });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.Window;
            dataGridView1.Location = new Point(23, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(493, 304);
            dataGridView1.TabIndex = 5;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 7;
            Nome.Name = "Nome";
            Nome.Resizable = DataGridViewTriState.False;
            // 
            // Descrição
            // 
            Descrição.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descrição.HeaderText = "Data";
            Descrição.Name = "Descrição";
            Descrição.Resizable = DataGridViewTriState.False;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(522, 20);
            label1.Name = "label1";
            label1.Size = new Size(124, 28);
            label1.TabIndex = 1;
            label1.Text = "Progresso";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label6, 1, 2);
            tableLayoutPanel2.Controls.Add(materialProgressBar2, 1, 1);
            tableLayoutPanel2.Controls.Add(label3, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(materialProgressBar1, 0, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(522, 60);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 214F));
            tableLayoutPanel2.Size = new Size(493, 304);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Libre Franklin", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(278, 136);
            label6.Name = "label6";
            label6.Size = new Size(182, 91);
            label6.TabIndex = 5;
            label6.Text = "75%";
            // 
            // materialProgressBar2
            // 
            materialProgressBar2.Anchor = AnchorStyles.None;
            materialProgressBar2.Depth = 0;
            materialProgressBar2.ForeColor = Color.SteelBlue;
            materialProgressBar2.Location = new Point(258, 42);
            materialProgressBar2.MouseState = MaterialSkin.MouseState.HOVER;
            materialProgressBar2.Name = "materialProgressBar2";
            materialProgressBar2.Size = new Size(222, 5);
            materialProgressBar2.Style = ProgressBarStyle.Continuous;
            materialProgressBar2.TabIndex = 3;
            materialProgressBar2.Value = 75;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(249, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 1;
            label3.Text = "Geral";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 0;
            label2.Text = "Hoje";
            // 
            // materialProgressBar1
            // 
            materialProgressBar1.Anchor = AnchorStyles.None;
            materialProgressBar1.Depth = 0;
            materialProgressBar1.ForeColor = Color.SteelBlue;
            materialProgressBar1.Location = new Point(5, 42);
            materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            materialProgressBar1.Name = "materialProgressBar1";
            materialProgressBar1.Size = new Size(236, 5);
            materialProgressBar1.Style = ProgressBarStyle.Continuous;
            materialProgressBar1.TabIndex = 2;
            materialProgressBar1.Value = 27;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Libre Franklin", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(33, 136);
            label5.Name = "label5";
            label5.Size = new Size(180, 91);
            label5.TabIndex = 4;
            label5.Text = "27%";
            // 
            // lblTarefasDia
            // 
            lblTarefasDia.AutoSize = true;
            lblTarefasDia.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTarefasDia.Location = new Point(23, 20);
            lblTarefasDia.Name = "lblTarefasDia";
            lblTarefasDia.Size = new Size(64, 28);
            lblTarefasDia.TabIndex = 0;
            lblTarefasDia.Text = "Hoje";
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1238, 681);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(plNav);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(720, 720);
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskList";
            WindowState = FormWindowState.Maximized;
            plNav.ResumeLayout(false);
            plNav.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel plNav;
        private Button btnAdicionar;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar2;
        private Label label3;
        private Label label2;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private Label lblTarefasDia;
        private Button btnGrupos;
        private Button btnTarefas;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descrição;
        private Label label5;
        private Label label6;
        private Button btnSair;
        private Button btnUsuario;
    }
}