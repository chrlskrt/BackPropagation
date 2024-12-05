namespace BackPropagation
{
    partial class BackPropagation
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
            tbInput0 = new TextBox();
            tbInput1 = new TextBox();
            tbInput2 = new TextBox();
            tbInput3 = new TextBox();
            tbOutput = new TextBox();
            btnCreateNN = new Button();
            btnTrainNN = new Button();
            btnTestNN = new Button();
            lblStatus = new Label();
            lblEpoch = new Label();
            tbInputEpoch = new TextBox();
            lblInputEpoch = new Label();
            SuspendLayout();
            // 
            // tbInput0
            // 
            tbInput0.Location = new Point(35, 64);
            tbInput0.MaxLength = 1;
            tbInput0.Name = "tbInput0";
            tbInput0.Size = new Size(250, 27);
            tbInput0.TabIndex = 0;
            // 
            // tbInput1
            // 
            tbInput1.Location = new Point(36, 120);
            tbInput1.MaxLength = 1;
            tbInput1.Name = "tbInput1";
            tbInput1.Size = new Size(249, 27);
            tbInput1.TabIndex = 1;
            // 
            // tbInput2
            // 
            tbInput2.Location = new Point(38, 171);
            tbInput2.MaxLength = 1;
            tbInput2.Name = "tbInput2";
            tbInput2.Size = new Size(247, 27);
            tbInput2.TabIndex = 2;
            // 
            // tbInput3
            // 
            tbInput3.Location = new Point(37, 221);
            tbInput3.MaxLength = 1;
            tbInput3.Name = "tbInput3";
            tbInput3.Size = new Size(248, 27);
            tbInput3.TabIndex = 3;
            // 
            // tbOutput
            // 
            tbOutput.Enabled = false;
            tbOutput.Location = new Point(326, 118);
            tbOutput.Name = "tbOutput";
            tbOutput.Size = new Size(351, 27);
            tbOutput.TabIndex = 4;
            // 
            // btnCreateNN
            // 
            btnCreateNN.Location = new Point(67, 394);
            btnCreateNN.Name = "btnCreateNN";
            btnCreateNN.Size = new Size(198, 29);
            btnCreateNN.TabIndex = 5;
            btnCreateNN.Text = "create BPNN";
            btnCreateNN.UseVisualStyleBackColor = true;
            btnCreateNN.Click += btnCreateNN_Click;
            // 
            // btnTrainNN
            // 
            btnTrainNN.Location = new Point(326, 394);
            btnTrainNN.Name = "btnTrainNN";
            btnTrainNN.Size = new Size(198, 29);
            btnTrainNN.TabIndex = 6;
            btnTrainNN.Text = "Train the Neural Net";
            btnTrainNN.UseVisualStyleBackColor = true;
            btnTrainNN.Click += btnTrainNN_Click;
            // 
            // btnTestNN
            // 
            btnTestNN.Location = new Point(590, 394);
            btnTestNN.Name = "btnTestNN";
            btnTestNN.Size = new Size(198, 29);
            btnTestNN.TabIndex = 7;
            btnTestNN.Text = "Test";
            btnTestNN.UseVisualStyleBackColor = true;
            btnTestNN.Click += btnTestNN_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(131, 277);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 23);
            lblStatus.TabIndex = 8;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEpoch
            // 
            lblEpoch.AutoSize = true;
            lblEpoch.Location = new Point(326, 64);
            lblEpoch.Name = "lblEpoch";
            lblEpoch.Size = new Size(0, 20);
            lblEpoch.TabIndex = 10;
            // 
            // tbInputEpoch
            // 
            tbInputEpoch.Location = new Point(328, 351);
            tbInputEpoch.Name = "tbInputEpoch";
            tbInputEpoch.Size = new Size(196, 27);
            tbInputEpoch.TabIndex = 11;
            tbInputEpoch.Text = "1000";
            tbInputEpoch.Visible = false;
            // 
            // lblInputEpoch
            // 
            lblInputEpoch.AutoSize = true;
            lblInputEpoch.Location = new Point(330, 326);
            lblInputEpoch.Name = "lblInputEpoch";
            lblInputEpoch.Size = new Size(145, 20);
            lblInputEpoch.TabIndex = 12;
            lblInputEpoch.Text = "Epochs to train data:";
            lblInputEpoch.Visible = false;
            // 
            // BackPropagation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInputEpoch);
            Controls.Add(tbInputEpoch);
            Controls.Add(lblEpoch);
            Controls.Add(lblStatus);
            Controls.Add(btnTestNN);
            Controls.Add(btnTrainNN);
            Controls.Add(btnCreateNN);
            Controls.Add(tbOutput);
            Controls.Add(tbInput3);
            Controls.Add(tbInput2);
            Controls.Add(tbInput1);
            Controls.Add(tbInput0);
            Name = "BackPropagation";
            Text = "BackPropagation";
            Load += BackPropagation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbInput0;
        private TextBox tbInput1;
        private TextBox tbInput2;
        private TextBox tbInput3;
        private TextBox tbOutput;
        private Button btnCreateNN;
        private Button btnTrainNN;
        private Button btnTestNN;
        private Label lblStatus;
        private Label lblEpoch;
        private TextBox tbInputEpoch;
        private Label lblInputEpoch;
    }
}
