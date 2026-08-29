
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
            ArrayList programList = new ArrayList();
            programList.Add("BS Information Technology");
            programList.Add("BS Computer Engineering");
            programList.Add("BS Computer Science");
            programList.Add("BS Psychology");
            programList.Add("BS Tourism");
            programList.Add("BS Criminology");

            cbProgram.Items.AddRange(programList.ToArray());
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            StudentInfoClass.StudentNo = long.Parse(txtStudentNo.Text);
            StudentInfoClass.FirstName = txtFirstName.Text;
            StudentInfoClass.MiddleName = txtMiddleName.Text;
            StudentInfoClass.LastName = txtLastName.Text;
            StudentInfoClass.Age = long.Parse(txtAge.Text);
            StudentInfoClass.ContactNo = long.Parse(txtContactNo.Text);
            StudentInfoClass.Program = cbProgram.Text;
            StudentInfoClass.Address = txtAddress.Text;

            FrmConfirm confirmForm = new FrmConfirm();

            if (confirmForm.ShowDialog() == DialogResult.OK)
            {
                txtStudentNo.Clear();
                txtFirstName.Clear();
                txtMiddleName.Clear();
                txtLastName.Clear();
                txtAge.Clear();
                txtContactNo.Clear();
                txtAddress.Clear();
                cbProgram.SelectedIndex = -1;
            }
        }
    }
}