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
            plNav = new Panel();
            btnAdicionar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTarefasDia = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            materialProgressBar2 = new MaterialSkin.Controls.MaterialProgressBar();
            label3 = new Label();
            label2 = new Label();
            materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            plNav.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // plNav
            // 
            plNav.BackColor = Color.SkyBlue;
            plNav.Controls.Add(btnAdicionar);
            plNav.Dock = DockStyle.Left;
            plNav.Location = new Point(0, 0);
            plNav.Name = "plNav";
            plNav.Padding = new Padding(15);
            plNav.Size = new Size(223, 646);
            plNav.TabIndex = 0;
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
            btnAdicionar.Location = new Point(23, 15);
            btnAdicionar.Margin = new Padding(10);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(178, 80);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.TextAlign = ContentAlignment.MiddleRight;
            btnAdicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblTarefasDia, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(223, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.5693216F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.43068F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 276F));
            tableLayoutPanel1.Size = new Size(953, 646);
            tableLayoutPanel1.TabIndex = 1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(479, 20);
            label1.Name = "label1";
            label1.Size = new Size(124, 28);
            label1.TabIndex = 1;
            label1.Text = "Progresso";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.Window;
            dataGridView1.Location = new Point(23, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(450, 279);
            dataGridView1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(materialProgressBar2, 1, 1);
            tableLayoutPanel2.Controls.Add(label3, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(materialProgressBar1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(479, 67);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 42.1875F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 57.8125F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 214F));
            tableLayoutPanel2.Size = new Size(451, 279);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // materialProgressBar2
            // 
            materialProgressBar2.Anchor = AnchorStyles.None;
            materialProgressBar2.Depth = 0;
            materialProgressBar2.Location = new Point(239, 43);
            materialProgressBar2.MouseState = MaterialSkin.MouseState.HOVER;
            materialProgressBar2.Name = "materialProgressBar2";
            materialProgressBar2.Size = new Size(197, 5);
            materialProgressBar2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(228, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 1;
            label3.Text = "Geral";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 0;
            label2.Text = "Hoje";
            // 
            // materialProgressBar1
            // 
            materialProgressBar1.Anchor = AnchorStyles.None;
            materialProgressBar1.Depth = 0;
            materialProgressBar1.Location = new Point(14, 43);
            materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            materialProgressBar1.Name = "materialProgressBar1";
            materialProgressBar1.Size = new Size(197, 5);
            materialProgressBar1.TabIndex = 2;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1176, 646);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(plNav);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskList";
            WindowState = FormWindowState.Maximized;
            plNav.ResumeLayout(false);
            plNav.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel plNav;
        private Button btnAdicionar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTarefasDia;
        private DataGridView dataGridView1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label3;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar2;
    }
}