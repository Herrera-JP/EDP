namespace Account_Registration
{
    partial class FrmRegistration
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
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            txtFirstName = new TextBox();
            txtContactNo = new TextBox();
            txtMiddleName = new TextBox();
            btnnext = new Button();
            cbProgram = new ComboBox();
            lblstudentNo = new Label();
            lbllastName = new Label();
            lblage = new Label();
            txtProgram = new Label();
            lblfirstName = new Label();
            lblmiddleName = new Label();
            lblcontactNo = new Label();
            lbladdress = new Label();
            txtAddress = new TextBox();
            SuspendLayout();
            // 
            // txtStudentNo
            // 
            txtStudentNo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentNo.Location = new Point(34, 47);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(253, 31);
            txtStudentNo.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(34, 98);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(236, 31);
            txtLastName.TabIndex = 1;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(34, 153);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(236, 31);
            txtAge.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(276, 98);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(254, 31);
            txtFirstName.TabIndex = 3;
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactNo.Location = new Point(276, 153);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(254, 31);
            txtContactNo.TabIndex = 4;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleName.Location = new Point(536, 98);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(242, 31);
            txtMiddleName.TabIndex = 5;
            // 
            // btnnext
            // 
            btnnext.Location = new Point(339, 393);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(124, 45);
            btnnext.TabIndex = 7;
            btnnext.Text = "Next";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnNext_Click;
            // 
            // cbProgram
            // 
            cbProgram.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbProgram.FormattingEnabled = true;
            cbProgram.Location = new Point(293, 47);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(485, 31);
            cbProgram.TabIndex = 8;
            // 
            // lblstudentNo
            // 
            lblstudentNo.AutoSize = true;
            lblstudentNo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblstudentNo.Location = new Point(34, 21);
            lblstudentNo.Name = "lblstudentNo";
            lblstudentNo.Size = new Size(119, 23);
            lblstudentNo.TabIndex = 9;
            lblstudentNo.Text = "Student No.:";
            // 
            // lbllastName
            // 
            lbllastName.AutoSize = true;
            lbllastName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbllastName.Location = new Point(34, 81);
            lbllastName.Name = "lbllastName";
            lbllastName.Size = new Size(108, 23);
            lbllastName.TabIndex = 10;
            lbllastName.Text = "Last name:";
            // 
            // lblage
            // 
            lblage.AutoSize = true;
            lblage.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblage.Location = new Point(34, 132);
            lblage.Name = "lblage";
            lblage.Size = new Size(51, 23);
            lblage.TabIndex = 11;
            lblage.Text = "Age;";
            // 
            // txtProgram
            // 
            txtProgram.AutoSize = true;
            txtProgram.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProgram.Location = new Point(293, 21);
            txtProgram.Name = "txtProgram";
            txtProgram.Size = new Size(86, 23);
            txtProgram.TabIndex = 12;
            txtProgram.Text = "Program";
            // 
            // lblfirstName
            // 
            lblfirstName.AutoSize = true;
            lblfirstName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblfirstName.Location = new Point(276, 81);
            lblfirstName.Name = "lblfirstName";
            lblfirstName.Size = new Size(109, 23);
            lblfirstName.TabIndex = 13;
            lblfirstName.Text = "First name:";
            // 
            // lblmiddleName
            // 
            lblmiddleName.AutoSize = true;
            lblmiddleName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmiddleName.Location = new Point(536, 81);
            lblmiddleName.Name = "lblmiddleName";
            lblmiddleName.Size = new Size(128, 23);
            lblmiddleName.TabIndex = 14;
            lblmiddleName.Text = "Middle name:";
            // 
            // lblcontactNo
            // 
            lblcontactNo.AutoSize = true;
            lblcontactNo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcontactNo.Location = new Point(276, 132);
            lblcontactNo.Name = "lblcontactNo";
            lblcontactNo.Size = new Size(120, 23);
            lblcontactNo.TabIndex = 15;
            lblcontactNo.Text = "Contact No.:";
            // 
            // lbladdress
            // 
            lbladdress.AutoSize = true;
            lbladdress.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbladdress.Location = new Point(34, 200);
            lbladdress.Name = "lbladdress";
            lbladdress.Size = new Size(89, 23);
            lbladdress.TabIndex = 16;
            lbladdress.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(34, 226);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(744, 161);
            txtAddress.TabIndex = 17;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAddress);
            Controls.Add(lbladdress);
            Controls.Add(lblcontactNo);
            Controls.Add(lblmiddleName);
            Controls.Add(lblfirstName);
            Controls.Add(txtProgram);
            Controls.Add(lblage);
            Controls.Add(lbllastName);
            Controls.Add(lblstudentNo);
            Controls.Add(cbProgram);
            Controls.Add(btnnext);
            Controls.Add(txtMiddleName);
            Controls.Add(txtContactNo);
            Controls.Add(txtFirstName);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Name = "FrmRegistration";
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtAge;
        private TextBox txtFirstName;
        private TextBox txtContactNo;
        private TextBox txtMiddleName;
        private Button btnnext;
        private ComboBox cbProgram;
        private Label lblstudentNo;
        private Label lbllastName;
        private Label lblage;
        private Label txtProgram;
        private Label lblfirstName;
        private Label lblmiddleName;
        private Label lblcontactNo;
        private Label lbladdress;
        private TextBox txtAddress;
    }
}
