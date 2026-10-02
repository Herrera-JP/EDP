namespace ThreadPriorityApp
{
    partial class frmTrackThread
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
            lblStatus = new Label();
            btnRun = new Button();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Century", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(29, 60);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(389, 80);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "-Thread Starts-";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRun
            // 
            btnRun.BackColor = Color.FromArgb(0, 122, 204);
            btnRun.Cursor = Cursors.Hand;
            btnRun.FlatAppearance.BorderSize = 0;
            btnRun.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 150, 240);
            btnRun.FlatStyle = FlatStyle.Flat;
            btnRun.Font = new Font("Segoe UI", 14F);
            btnRun.ForeColor = Color.White;
            btnRun.Location = new Point(135, 160);
            btnRun.Margin = new Padding(3, 4, 3, 4);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(160, 60);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += btnRun_Click;
            // 
            // frmTrackThread
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(439, 281);
            Controls.Add(btnRun);
            Controls.Add(lblStatus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmTrackThread";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTrackThread";
            ResumeLayout(false);
        }

        #endregion

        private Label lblStatus;
        private Button btnRun;
    }
}
