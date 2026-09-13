namespace QueuingForm
{
    partial class QueuingTP
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblView = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 30);
            label1.Name = "label1";
            label1.Size = new Size(162, 31);
            label1.TabIndex = 0;
            label1.Text = "*Now Serving";
            // 
            // lblView
            // 
            lblView.AutoSize = true;
            lblView.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblView.Location = new Point(43, 92);
            lblView.Name = "lblView";
            lblView.Size = new Size(250, 81);
            lblView.TabIndex = 1;
            lblView.Text = "P-10000";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // QueuingTP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 224);
            Controls.Add(lblView);
            Controls.Add(label1);
            Name = "QueuingTP";
            Text = "QueuingTP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblView;
        private System.Windows.Forms.Timer timer1;
    }
}