namespace QueuingForm
{
    partial class CashierWindowQueueForm
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
            btnRefresh = new Button();
            btnNext = new Button();
            listCashierQueue = new ListView();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(39, 28);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(121, 34);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(39, 68);
            btnNext.Margin = new Padding(3, 2, 3, 2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(121, 34);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // listCashierQueue
            // 
            listCashierQueue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listCashierQueue.Location = new Point(165, 28);
            listCashierQueue.Margin = new Padding(3, 2, 3, 2);
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(239, 234);
            listCashierQueue.TabIndex = 2;
            listCashierQueue.UseCompatibleStateImageBehavior = false;
            listCashierQueue.View = View.List;
            // 
            // CashierWindowQueueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 292);
            Controls.Add(listCashierQueue);
            Controls.Add(btnNext);
            Controls.Add(btnRefresh);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CashierWindowQueueForm";
            Text = "CashierWindowQueueForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private Button btnNext;
        private ListView listCashierQueue;
    }
}