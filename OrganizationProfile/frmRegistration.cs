using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrganizationProfile
{
    public partial class frmRegistration : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;

        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]{
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
        };
            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }
        }
        public long StudentNumber(string studNum)
        {

            if (Regex.IsMatch(studNum, @"^[0-9]{1,11}$"))
            {
                _StudentNo = long.Parse(studNum);
            }
            else
            {
                throw new OverflowException("Student number must contain numbers only.");
            }
            return _StudentNo;
        }


        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }
            else
            {
                throw new OverflowException("Contact number must be 10 to 11 digits.");
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+(\s[a-zA-Z]+)*$") &&
                Regex.IsMatch(FirstName, @"^[a-zA-Z]+(\s[a-zA-Z]+)*$") &&
                Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + " " + MiddleInitial + ".";
            }
            else
            {
                throw new ArgumentNullException("Name", "Please enter a valid last name and first name.");
            }
            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }
            else
            {
                throw new IndexOutOfRangeException("Enter valid age.");
            }
            return _Age;
        }

        public string Program(string program)
        {
            if (!string.IsNullOrWhiteSpace(program))
            {
                return program;
            }
            else
            {
                throw new ArgumentNullException("Please select a program.");
            }
        }

        public string Gender(string gender)
        {
            if (!string.IsNullOrWhiteSpace(gender))
            {
                return gender;
            }
            else
            {
                throw new ArgumentNullException("Please select a gender.");
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            { 
            StudentInformationClass.SetFullName = FullName(txtLastName.Text,txtFirstName.Text, txtMiddleInitial.Text);
            StudentInformationClass.SetStudentNo = StudentNumber(txtStudentNo.Text);
            StudentInformationClass.SetProgram = Program(cbPrograms.Text);       
            StudentInformationClass.SetGender = Gender(cbGender.Text);
            StudentInformationClass.SetContactNo = ContactNo(txtContactNo.Text);
            StudentInformationClass.SetAge = Age(txtAge.Text);
            StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-   MM - dd");
            frmConfirmation frm = new frmConfirmation();
            frm.ShowDialog();

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format error: " + ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Missing or invalid name field: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Contact number error: " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Student number error: " + ex.Message);
            }
            finally
            {
                MessageBox.Show("Registration attempt processed.");
            }
        }
    }
}  


