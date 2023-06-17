using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Student_Register
{
    public partial class AddStudent : Form
    {
        //new DataAccess and Student class type instances are created
        private DataAccess db = new DataAccess();
        List<Student> studentToAdd = new List<Student>();

        //this class will handle the addition of new students to the register
        public AddStudent()
        {
            InitializeComponent();
            // sets the next available StudentId in the designated textbox  
            SetNextAvailableStudentId();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            //set focus on the Surname text box
            SurnameTB.Focus();

            //label colors are used to highlight mandatory fields
            TitleLbl.ForeColor = Color.Red;
            SurnameLbl.ForeColor = Color.Red;
            NameLbl.ForeColor = Color.Red;
            DobLbl.ForeColor = Color.Red;
            HAddLbl.ForeColor = Color.Red;
            HPostcodeLbl.ForeColor = Color.Red;            
            TelLbl.ForeColor = Color.Red;
            PemailLbl.ForeColor = Color.Red;
            AemailLbl.ForeColor = Color.Red;
            GuardianLbl.ForeColor = Color.Red;
            GuardianTelLbl.ForeColor = Color.Red;
            CourseLbl.ForeColor = Color.Red;
            CourseTypeLbl.ForeColor = Color.Red;
            YearLbl.ForeColor = Color.Red;
            GroupLbl.ForeColor = Color.Red;           

        }

        //method executes when the AddStudent button is clicked
        private void AddStuDoneButton_Click(object sender, EventArgs e)
        {
            //verifies if the mandatory fields have data
            //for the comboboxes we check for SelectedItem not null
            //the StudentId is self-generated and cannnot be modified
            if (StudentIdTB.Text != string.Empty && SurnameTB.Text != string.Empty && NameTB.Text != string.Empty &&  HAddTB.Text != string.Empty &&
                HPostcodeTB.Text != string.Empty && TelTB.Text != string.Empty && PemailTB.Text != string.Empty && AemailTB.Text != string.Empty &&
                GuardianTB.Text != string.Empty && GuardianTelTB.Text != string.Empty && GroupTB.Text != string.Empty && 
                TitleCB.SelectedItem != null && CourseCB.SelectedItem != null && CourseTypeCB.SelectedItem != null && YearCB.SelectedItem != null)
            {                
                //verifies if the email addresses are valid
                if (!Utility.IsValidEmail(PemailTB.Text))
                {
                    PemailLbl.ForeColor = Color.Red;
                    MessageBox.Show("Please enter a valid Personal Email!");
                    return;
                }

                if (!Utility.IsValidEmail(AemailTB.Text))
                {
                    AemailLbl.ForeColor = Color.Red;
                    MessageBox.Show("Please enter a valid Academic Email!");
                    return;
                }                

                //a new Student type object is created and added to the list
                studentToAdd.Add(new Student
                {
                    StudentId = StudentIdTB.Text,
                    Title = TitleCB.Text,
                    Surname = SurnameTB.Text,
                    FirstName = NameTB.Text,
                    DoB = DobDtp.Value,
                    HomeAddress = HAddTB.Text,
                    Postcode = HPostcodeTB.Text,
                    StudyAddress = SAddTB.Text,
                    StudyPostcode = SPostcodeTB.Text,
                    Tel = TelTB.Text,
                    PersonalEmail = PemailTB.Text,
                    AcademicEmail = AemailTB.Text,
                    Guardian = GuardianTB.Text,
                    GuardianTel = GuardianTelTB.Text,
                    Guardian1 = Guardian1TB.Text,
                    Guardian1Tel = Guardian1TelTB.Text,
                    CourseType = CourseTypeCB.Text,
                    Course = CourseCB.Text,
                    AcademicYear = YearCB.Text,
                    GroupCode = GroupTB.Text.ToUpper()
                });

                //the DataAccess type AddStudent method is called and the required list is passed
                db.AddStudent(studentToAdd);

                //a confirmation message box will be displayed
                MessageBox.Show("A new student was added:\r\n"+
                                "ID: "+StudentIdTB.Text+"\r\n" + 
                                "Name: "+ SurnameTB.Text + " "+ NameTB.Text);

                //the newly added student's profile is displayed
                StudentProfile profileForm = new StudentProfile(StudentIdTB.Text);
                profileForm.ShowDialog();

                //this form instance is closed
                this.Close();
            }
            else
            {
                //if any mandatory data is not filled, a message box will appear
                MessageBox.Show("All mandatory fields must be filled!");
            }
        }

        //executes when an element is selected in the Title control box 
        private void TitleCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change the color of the label to black
            TitleLbl.ForeColor = Color.Black;
        }
        
        //executes when the value in the text box has changed
        private void DobDtp_ValueChanged(object sender, EventArgs e)
        {
            DobLbl.ForeColor = Color.Black;
        }

        /*executes when text box value has changed and 
          calls the 'ValidateTextBoxContent' to check for user input */
        private void SurnameTB_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxContent(SurnameTB, SurnameLbl);
        }

        //same as 'SurnameTB_TextChanged'
        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxContent(NameTB, NameLbl);
        }

        //same as 'SurnameTB_TextChanged'
        private void HAddTB_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxContent(HAddTB, HAddLbl);
        }

        //same as 'SurnameTB_TextChanged'
        private void HPostcodeTB_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxContent(HPostcodeTB, HPostcodeLbl);
        }

        //same as 'SurnameTB_TextChanged'
        private void TelTB_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxContent(TelTB, TelLbl);
        }

        //same as 'SurnameTB_TextChanged'
        private void PemailTB_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxContent(PemailTB, PemailLbl);
        }

        //same as 'SurnameTB_TextChanged'
        private void AemailTB_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxContent(AemailTB, AemailLbl);
        }

        //same as 'SurnameTB_TextChanged'
        private void GuardianTB_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxContent(GuardianTB, GuardianLbl);
        }

        //same as 'SurnameTB_TextChanged'
        private void GuardianTelTB_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxContent(GuardianTelTB, GuardianTelLbl);
        }

        //same as 'SurnameTB_TextChanged'
        private void CourseCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseLbl.ForeColor = Color.Black;
        }

        //same as 'SurnameTB_TextChanged'
        private void CourseTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseTypeLbl.ForeColor = Color.Black;
        }

        //same as 'SurnameTB_TextChanged'
        private void YearCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            YearLbl.ForeColor = Color.Black;
        }

        //same as 'SurnameTB_TextChanged'
        private void GroupTB_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxContent(GroupTB, GroupLbl);
        }

        //method executes when the Cancel button is clicked
        private void AddStuCancelButton_Click(object sender, EventArgs e)
        {
            //closes the form instance
            this.Close();
        }

        //method that checks if mandatory fields have input; changes the label colour as necessary 
        private void ValidateTextBoxContent(TextBox textbox, Label label)
        {
            //if the text box has user input
            if (textbox.Text != string.Empty)
            {
                //change the color of the label to black
                label.ForeColor = Color.Black;
            }
            else
            {
                //if not, keeps/changes the color to red
                label.ForeColor = Color.Red;
            }
        }

        //method generates the next available student id
        private void SetNextAvailableStudentId()
        {
            //get the latest StudentId from the database 
            string latestStudentId = db.GetLatestStudentId();

            /*since the StudentId is 8 character long it does not fit in 32 bit integer and
              thus it is converted to a 64 bit integer and incremented*/
            long nextStudentIdNumber = long.Parse(latestStudentId) + 1;

            //adds the zeros back using PadLeft for the max length 8 and padding character 0
            string nextStudentId =nextStudentIdNumber.ToString().PadLeft(8, '0');

            //sets the StudentId textbox value
            StudentIdTB.Text = nextStudentId;
        }
    }
}
