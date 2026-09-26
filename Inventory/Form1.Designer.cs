namespace Inventory
{
    partial class frmAddProduct
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
            label1 = new Label();
            dtPickerMfgDate = new DateTimePicker();
            richtxtDescription = new RichTextBox();
            btnAddProduct = new Button();
            gridViewProductList = new DataGridView();
            label2 = new Label();
            dtPickerExpDate = new DateTimePicker();
            label4 = new Label();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            txtSellPrice = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cbCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 38);
            label1.TabIndex = 0;
            label1.Text = "ADD PRODUCT";
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtPickerMfgDate.Location = new Point(115, 148);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(272, 29);
            dtPickerMfgDate.TabIndex = 2;
            // 
            // richtxtDescription
            // 
            richtxtDescription.BorderStyle = BorderStyle.FixedSingle;
            richtxtDescription.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richtxtDescription.Location = new Point(442, 100);
            richtxtDescription.Name = "richtxtDescription";
            richtxtDescription.Size = new Size(313, 183);
            richtxtDescription.TabIndex = 3;
            richtxtDescription.Text = "";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.Black;
            btnAddProduct.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(618, 292);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(137, 33);
            btnAddProduct.TabIndex = 4;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // gridViewProductList
            // 
            gridViewProductList.BackgroundColor = Color.LightGray;
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(17, 331);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.Size = new Size(738, 180);
            gridViewProductList.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label2.Location = new Point(17, 117);
            label2.Name = "label2";
            label2.Size = new Size(86, 22);
            label2.TabIndex = 6;
            label2.Text = "Category";
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtPickerExpDate.Location = new Point(115, 186);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(272, 29);
            dtPickerExpDate.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 81);
            label4.Name = "label4";
            label4.Size = new Size(75, 22);
            label4.TabIndex = 10;
            label4.Text = "Product";
            // 
            // txtProductName
            // 
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtProductName.Location = new Point(115, 77);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(272, 29);
            txtProductName.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtQuantity.Location = new Point(115, 221);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(272, 29);
            txtQuantity.TabIndex = 12;
            // 
            // txtSellPrice
            // 
            txtSellPrice.BorderStyle = BorderStyle.FixedSingle;
            txtSellPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtSellPrice.Location = new Point(115, 256);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(272, 29);
            txtSellPrice.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label5.Location = new Point(17, 153);
            label5.Name = "label5";
            label5.Size = new Size(93, 22);
            label5.TabIndex = 14;
            label5.Text = "Mfg. Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label6.Location = new Point(17, 189);
            label6.Name = "label6";
            label6.Size = new Size(91, 22);
            label6.TabIndex = 13;
            label6.Text = "Exp. Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label7.Location = new Point(17, 225);
            label7.Name = "label7";
            label7.Size = new Size(81, 22);
            label7.TabIndex = 16;
            label7.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label8.Location = new Point(17, 261);
            label8.Name = "label8";
            label8.Size = new Size(88, 22);
            label8.TabIndex = 15;
            label8.Text = "Sell Price";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(442, 77);
            label9.Name = "label9";
            label9.Size = new Size(104, 22);
            label9.TabIndex = 17;
            label9.Text = "Description";
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(115, 113);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(272, 29);
            cbCategory.TabIndex = 19;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(775, 523);
            Controls.Add(cbCategory);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtQuantity);
            Controls.Add(txtSellPrice);
            Controls.Add(label4);
            Controls.Add(txtProductName);
            Controls.Add(dtPickerExpDate);
            Controls.Add(label2);
            Controls.Add(gridViewProductList);
            Controls.Add(btnAddProduct);
            Controls.Add(richtxtDescription);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(label1);
            Name = "frmAddProduct";
            Text = "Inventory";
            Load += frmAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private DateTimePicker dtPickerMfgDate;
        private RichTextBox richtxtDescription;
        private Button btnAddProduct;
        private DataGridView gridViewProductList;
        private Label label2;
        private DateTimePicker dtPickerExpDate;
        private Label label4;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private TextBox txtSellPrice;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cbCategory;
    }
}
