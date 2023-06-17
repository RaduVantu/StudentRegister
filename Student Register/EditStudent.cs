using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Student_Register
{
    //this class will handle the updating of any existing student profiles in the database
    public partial class EditStudentForm : Form
    {
        //new Student and DataAccess class type instances are created
        private Student studentToProfile;        
        private DataAccess db = new DataAccess();

        //the passingInput variable contains the value of the Student ID passed from the StudentProfile form
        public EditStudentForm(string passingInput) 
        {
            InitializeComponent();            
           
            /*the Student ID value is passed through the passingInput variable to the GetStudent
              DataAccess method which populates studentToProfile with a Student class type object*/
            studentToProfile = db.GetStudent(passingInput);
        }
        private void EditStudentForm_Load(object sender, EventArgs e)
        {
            
            /*the values of the variables that form the Student class object stored in the 
               studentToProfile are set to the different text boxes*/
            EIdNumberLbl.Text = studentToProfile.StudentId;
            //the Title control box will display the value of the Title variable at index 0 in the list
            ETitleCB.Text = studentToProfile.Title;
            ESurnameTB.Text = studentToProfile.Surname;
            EFirstNameTB.Text = studentToProfile.FirstName;
            EDobDtp.Value = studentToProfile.DoB;
            EHAddTB.Text = studentToProfile.HomeAddress;
            EHPostcodeTB.Text = studentToProfile.Postcode;
            ESAddTB.Text = studentToProfile.StudyAddress;
            ESPostcodeTB.Text = studentToProfile.StudyPostcode;
            EPemailTB.Text = studentToProfile.PersonalEmail;
            EAemailTB.Text = studentToProfile.AcademicEmail;
            ETelTB.Text = studentToProfile.Tel;
            EGuardianTB.Text = studentToProfile.Guardian;
            EGuardianTelTB.Text = studentToProfile.GuardianTel;
            EGuardian1TB.Text = studentToProfile.Guardian1;
            EGuardian1TelTB.Text = studentToProfile.Guardian1Tel;            
            ECourseCB.Text = studentToProfile.Course;            

            //the value of the Course Type will be used to display the correct predefined value in the Course Type control box
            switch (studentToProfile.CourseType)
            {
                case "Fulltime":
                    //if the value is 'Fulltime' the Fulltime value at index 0 will be selected 
                    ECourseTypeCB.SelectedIndex = 0;
                    break;
                case "Evening":
                    //if the value is 'Evening' the Evening value at index 1 will be selected
                    ECourseTypeCB.SelectedIndex = 1;
                    break;
                case "Distance":
                    //if the value is 'Distance' the Distance value at index 2 will be selected
                    ECourseTypeCB.SelectedIndex = 2;
                    break;
            } 

            EYearCB.Text = studentToProfile.AcademicYear;
            EGroupTB.Text = studentToProfile.GroupCode;            
        }

        //method executes when the Done button is clicked
        private void EditStuDoneButton_Click(object sender, EventArgs e)
        {
            //verifies if the mandatory fields have data. The StudentId cannnot be modified
            if (ESurnameTB.Text != string.Empty && EFirstNameTB.Text != string.Empty && EHAddTB.Text != string.Empty && 
                EHPostcodeTB.Text != string.Empty && ETelTB.Text != string.Empty && EPemailTB.Text != string.Empty &&
                EAemailTB.Text != string.Empty && EGuardianTB.Text != string.Empty && EGuardianTelTB.Text != string.Empty &&
                ECourseCB.Text != string.Empty && ECourseTypeCB.Text != string.Empty && EYearCB.Text != string.Empty && EGroupTB.Text != string.Empty &&
                ETitleCB.SelectedItem != null && ECourseCB.SelectedItem != null && ECourseTypeCB.SelectedItem != null && EYearCB.SelectedItem != null)
            {

                //verifies if the email addresses are valid
                if (!Utility.IsValidEmail(EPemailTB.Text))
                {
                    MessageBox.Show("Please enter a valid personal email!");
                    return;
                }

                if (!Utility.IsValidEmail(EAemailTB.Text))
                {
                    MessageBox.Show("Please enter a valid personal email!");
                    return;
                }

                //a list of Student class objects is created
                List<Student> updatedStudent = new List<Student>();

                //a new Student type object is created and added to the list
                updatedStudent.Add(new Student
                {                    
                    StudentId = EIdNumberLbl.Text,
                    Title = ETitleCB.Text,
                    Surname = ESurnameTB.Text,
                    FirstName = EFirstNameTB.Text,
                    DoB = EDobDtp.Value,
                    HomeAddress = EHAddTB.Text,
                    Postcode = EHPostcodeTB.Text,
                    StudyAddress = ESAddTB.Text,
                    StudyPostcode = ESPostcodeTB.Text,
                    Tel = ETelTB.Text,
                    PersonalEmail = EPemailTB.Text,
                    AcademicEmail = EAemailTB.Text,
                    Guardian = EGuardianTB.Text,
                    GuardianTel = EGuardianTelTB.Text,
                    Guardian1 = EGuardian1TB.Text,
                    Guardian1Tel = EGuardian1TelTB.Text,
                    CourseType = ECourseTypeCB.Text,
                    Course = ECourseCB.Text,
                    AcademicYear = EYearCB.Text,
                    GroupCode = EGroupTB.Text.ToUpper()
                });

                //the AddStudent method (from the DataAccess class) is called and the updatedStudent list is passed
                db.UpdateStudent(updatedStudent);
                
                //a new instance of the StudentProfile is created and the Student ID is passed to it
                var refreshedStudentProfileForm = new StudentProfile(studentToProfile.StudentId);
                
                //displays the updated StudentProfile form
                refreshedStudentProfileForm.Show();

                //this form instance is closed
                this.Close();
            }
            else
            {
                //if any mandatory data is not filled, a message box will appear
                MessageBox.Show("All mandatory fields must be filled!");
            } 
        }

        //method executes when the Delete button is clicked
        private void EditStuDeleteBtn_Click(object sender, EventArgs e)
        {
            //confirmation dialog box is generated
            DialogResult confirmation = MessageBox.Show("Student record will be permanently DELETED!" +
                "\n" + "Are you sure?", "Delete confirmation", MessageBoxButtons.YesNo);

            switch (confirmation)
            {
                case DialogResult.Yes:
                 /* if Yes button is selected:  DeleteStudent method (from the DataAccess class) is called and the value of the 
                    Student ID variable at index 0 in the list is passed */
                    db.DeleteStudent(studentToProfile.StudentId);

                    //a confirmation message box will be displayed and the form instance is closed
                    MessageBox.Show("Student deleted");
                    this.Close();
                    break;
                
                case DialogResult.No:
                    //if the No button is selected do nothing
                    break;
            }
        }

        //method executes when the Close button is clicked
        private void EditStuCancelButton_Click(object sender, EventArgs e)
        {
            //the form instance is closed
            this.Close();
        }
    }
}
