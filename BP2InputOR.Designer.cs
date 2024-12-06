namespace BackPropagation
{
    partial class BP2InputOR
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
            menuStrip1 = new MenuStrip();
            inputANDToolStripMenuItem = new ToolStripMenuItem();
            btnTestNN = new Button();
            btnTrainNN = new Button();
            btnCreateNN = new Button();
            tbOutput = new TextBox();
            tbInput1 = new TextBox();
            tbInput0 = new TextBox();
            lblStatus = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inputANDToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inputANDToolStripMenuItem
            // 
            inputANDToolStripMenuItem.Name = "inputANDToolStripMenuItem";
            inputANDToolStripMenuItem.Size = new Size(107, 24);
            inputANDToolStripMenuItem.Text = "4-input AND";
            inputANDToolStripMenuItem.Click += inputANDToolStripMenuItem_Click;
            // 
            // btnTestNN
            // 
            btnTestNN.Location = new Point(568, 305);
            btnTestNN.Name = "btnTestNN";
            btnTestNN.Size = new Size(198, 29);
            btnTestNN.TabIndex = 13;
            btnTestNN.Text = "Test";
            btnTestNN.UseVisualStyleBackColor = true;
            btnTestNN.Click += btnTestNN_Click;
            // 
            // btnTrainNN
            // 
            btnTrainNN.Location = new Point(304, 305);
            btnTrainNN.Name = "btnTrainNN";
            btnTrainNN.Size = new Size(198, 29);
            btnTrainNN.TabIndex = 12;
            btnTrainNN.Text = "Train the Neural Net";
            btnTrainNN.UseVisualStyleBackColor = true;
            btnTrainNN.Click += btnTrainNN_Click;
            // 
            // btnCreateNN
            // 
            btnCreateNN.Location = new Point(45, 305);
            btnCreateNN.Name = "btnCreateNN";
            btnCreateNN.Size = new Size(198, 29);
            btnCreateNN.TabIndex = 11;
            btnCreateNN.Text = "create BPNN";
            btnCreateNN.UseVisualStyleBackColor = true;
            btnCreateNN.Click += btnCreateNN_Click;
            // 
            // tbOutput
            // 
            tbOutput.Enabled = false;
            tbOutput.Location = new Point(415, 118);
            tbOutput.Name = "tbOutput";
            tbOutput.Size = new Size(351, 27);
            tbOutput.TabIndex = 10;
            // 
            // tbInput1
            // 
            tbInput1.Location = new Point(46, 153);
            tbInput1.MaxLength = 1;
            tbInput1.Name = "tbInput1";
            tbInput1.Size = new Size(249, 27);
            tbInput1.TabIndex = 9;
            // 
            // tbInput0
            // 
            tbInput0.Location = new Point(45, 97);
            tbInput0.MaxLength = 1;
            tbInput0.Name = "tbInput0";
            tbInput0.Size = new Size(250, 27);
            tbInput0.TabIndex = 8;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(281, 248);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 14;
            // 
            // BP2InputOR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(btnTestNN);
            Controls.Add(btnTrainNN);
            Controls.Add(btnCreateNN);
            Controls.Add(tbOutput);
            Controls.Add(tbInput1);
            Controls.Add(tbInput0);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "BP2InputOR";
            Text = "BP2InputOR";
            FormClosing += BP2InputOR_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inputANDToolStripMenuItem;
        private Button btnTestNN;
        private Button btnTrainNN;
        private Button btnCreateNN;
        private TextBox tbOutput;
        private TextBox tbInput1;
        private TextBox tbInput0;
        private Label lblStatus;
    }
}