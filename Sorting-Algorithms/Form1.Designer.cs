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
            btnBubble = new Button();
            btnInsertion = new Button();
            lstNumbers = new ListView();
            btnMerge = new Button();
            btnQuick = new Button();
            btnSelection = new Button();
            btnHeap = new Button();
            SuspendLayout();
            // 
            // btnBubble
            // 
            btnBubble.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBubble.Location = new Point(63, 230);
            btnBubble.Name = "btnBubble";
            btnBubble.Size = new Size(126, 46);
            btnBubble.TabIndex = 0;
            btnBubble.Text = "Bubble";
            btnBubble.UseVisualStyleBackColor = true;
            // 
            // btnInsertion
            // 
            btnInsertion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertion.Location = new Point(245, 230);
            btnInsertion.Name = "btnInsertion";
            btnInsertion.Size = new Size(126, 46);
            btnInsertion.TabIndex = 1;
            btnInsertion.Text = "Insertion";
            btnInsertion.UseVisualStyleBackColor = true;
            // 
            // lstNumbers
            // 
            lstNumbers.Location = new Point(63, 42);
            lstNumbers.Name = "lstNumbers";
            lstNumbers.Size = new Size(672, 146);
            lstNumbers.TabIndex = 2;
            lstNumbers.UseCompatibleStateImageBehavior = false;
            // 
            // btnMerge
            // 
            btnMerge.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMerge.Location = new Point(423, 230);
            btnMerge.Name = "btnMerge";
            btnMerge.Size = new Size(126, 46);
            btnMerge.TabIndex = 3;
            btnMerge.Text = "Merge";
            btnMerge.UseVisualStyleBackColor = true;
            // 
            // btnQuick
            // 
            btnQuick.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuick.Location = new Point(609, 230);
            btnQuick.Name = "btnQuick";
            btnQuick.Size = new Size(126, 46);
            btnQuick.TabIndex = 4;
            btnQuick.Text = "Quick";
            btnQuick.UseVisualStyleBackColor = true;
            // 
            // btnSelection
            // 
            btnSelection.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelection.Location = new Point(157, 309);
            btnSelection.Name = "btnSelection";
            btnSelection.Size = new Size(126, 46);
            btnSelection.TabIndex = 5;
            btnSelection.Text = "Selection";
            btnSelection.UseVisualStyleBackColor = true;
            // 
            // btnHeap
            // 
            btnHeap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHeap.Location = new Point(337, 309);
            btnHeap.Name = "btnHeap";
            btnHeap.Size = new Size(126, 46);
            btnHeap.TabIndex = 6;
            btnHeap.Text = "Heap";
            btnHeap.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHeap);
            Controls.Add(btnSelection);
            Controls.Add(btnQuick);
            Controls.Add(btnMerge);
            Controls.Add(lstNumbers);
            Controls.Add(btnInsertion);
            Controls.Add(btnBubble);
            Name = "frmMain";
            Text = "Sorting Algorithms";
            Load += frmMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBubble;
        private Button btnInsertion;
        private ListView lstNumbers;
        private Button btnMerge;
        private Button btnQuick;
        private Button btnSelection;
        private Button btnHeap;
    }
}
