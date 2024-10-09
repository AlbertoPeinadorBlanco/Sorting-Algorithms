namespace Sorting_Algorithms
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            fileToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            cbChoseAlgorithm = new ComboBox();
            btnStart = new Button();
            btnReset = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem2 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LightSlateGray;
            panel1.Location = new Point(12, 203);
            panel1.Name = "panel1";
            panel1.Size = new Size(2200, 900);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(122, 68);
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(121, 32);
            fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(121, 32);
            helpToolStripMenuItem.Text = "Help";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(24, 24);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(111, 36);
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(110, 32);
            fileToolStripMenuItem1.Text = "File";
            // 
            // cbChoseAlgorithm
            // 
            cbChoseAlgorithm.FormattingEnabled = true;
            cbChoseAlgorithm.Location = new Point(12, 112);
            cbChoseAlgorithm.Name = "cbChoseAlgorithm";
            cbChoseAlgorithm.Size = new Size(269, 33);
            cbChoseAlgorithm.TabIndex = 2;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(313, 112);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 34);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(456, 112);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(254, 25);
            label1.TabIndex = 5;
            label1.Text = "Chose a Sorting Algorithm:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem2, helpToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2378, 33);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem2
            // 
            fileToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            fileToolStripMenuItem2.Size = new Size(54, 29);
            fileToolStripMenuItem2.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(141, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(65, 29);
            helpToolStripMenuItem1.Text = "Help";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2378, 1634);
            Controls.Add(label1);
            Controls.Add(btnReset);
            Controls.Add(btnStart);
            Controls.Add(cbChoseAlgorithm);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Sorting Algorithms";
            Load += frmMain_Load;
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ComboBox cbChoseAlgorithm;
        private Button btnStart;
        private Button btnReset;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem2;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
