using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Student_Register
{
    //this class will handle the dysplay of student related information
    public partial class StudentProfile : Form
    {
        //new Student, DataAccess and PdfCreator class type instances are created
        private Student studentToProfile;
        private DataAccess db = new DataAccess();
        private PdfCreator pdfCreator;


        /*This method is called by the AddStudent form to display a newly added student's profile. The studentId
          variable contains the value of the Student ID*/
        public StudentProfile(string studentId)
        {
            InitializeComponent();

            //the Student ID value is passed through the input variable to the GetStudent DataAccess method
            studentToProfile = db.GetStudent(studentId);

            //the 'studentToProfile' Student type object is passed to the 'PdfCreator' class
            pdfCreator = new PdfCreator(studentToProfile);
        }


        //This method is called by the HomeScreen form to display the profile of the selected student
        public StudentProfile(Student selectedStudent)
        {
            InitializeComponent();

            //the 'selectedStudent' Student type object is stored in 'studentToProfile'
            studentToProfile = selectedStudent;
            //the 'studentToProfile' Student type object is passed to the 'PdfCreator' class
            pdfCreator = new PdfCreator(studentToProfile);
        }

        private void StudentProfile_Load(object sender, EventArgs e)
        {
            /* the values of the variables that form the Student class object stored in the 
               studentToProfile are set to the different text boxes */
            ProfStudentIdLbl.Text = studentToProfile.StudentId;
            ProfTitleLbl.Text = studentToProfile.Title;
            ProfFullnameLbl.Text = studentToProfile.Surname + "  " + studentToProfile.FirstName;            
            //the date value is set in the label in ShortDate format
            ProfDoBLbl.Text = studentToProfile.DoB.ToShortDateString();  
            ProfHAddressLbl.Text = studentToProfile.HomeAddress;
            ProfHPostcodeLbl.Text = studentToProfile.Postcode;
            ProfSAddressLbl.Text = studentToProfile.StudyAddress;
            ProfSPostcodeLbl.Text = studentToProfile.StudyPostcode;
            ProfPEmailLbl.Text = studentToProfile.PersonalEmail;
            ProfAEmailLbl.Text = studentToProfile.AcademicEmail;
            ProfTelLbl.Text = studentToProfile.Tel;
            ProfGuardLbl.Text = studentToProfile.Guardian;
            ProfGuardTelLbl.Text = studentToProfile.GuardianTel;
            ProfGuard1Lbl.Text = studentToProfile.Guardian1;
            ProfGuard1TelLbl.Text = studentToProfile.Guardian1Tel;            
            ProfCourseLbl.Text = studentToProfile.Course;
            ProfCourseTypeLbl.Text = studentToProfile.CourseType;
            ProfYearLbl.Text = studentToProfile.AcademicYear;
            ProfGroupLbl.Text = studentToProfile.GroupCode;
            
            //if the Study Address value is not null, makes the labels visible
            if (ProfSAddressLbl.Text != string.Empty)
            {
                ProfSAddressLbl.Visible = true;
                ProfSAddressLabelLbl.Visible = true;
            }

            //if the Study Postcode value is not null, makes the labels visible
            if (ProfSPostcodeLbl.Text != string.Empty)
            {
                ProfSPostcodeLbl.Visible = true;
                ProfSPostcodeLabelLbl.Visible = true;
            }

            //if the Guardian1 value is not null, makes the labels visible
            if (ProfGuard1Lbl.Text != string.Empty)
            {
                ProfGuard1Lbl.Visible = true;
                ProfGuard1Lbl.Visible = true;                
            }

            //if the Guardian1 Telephone value is not null, makes the labels visible
            if (ProfGuard1TelLbl.Text != string.Empty)
            {
                ProfGuard1TelLbl.Visible = true;
                ProfGuard1Lbl.Visible = true;
            }
        }

        //method executes when the Edit button is clicked
        private void ProfEditBtn_Click(object sender, EventArgs e)
        {
            //a new instance of the EditStudent is created and the Student ID is passed to it
            var newEditStudentForm = new EditStudentForm(ProfStudentIdLbl.Text);

            //displays the new form instance
            newEditStudentForm.Show();            

            //this form is closed
            this.Close();
        }

        //method executes when the Timetable button is clicked (not included in the project)
        private void ProfTimetblBtn_Click(object sender, EventArgs e)
        {
            //message box will appear
            MessageBox.Show("Function will be implemented by Science College");
        }

        //method executes when the Academic Record button is clicked (not included in the project)
        private void ProfAcaRecBtn_Click(object sender, EventArgs e)
        {
            //message box will appear
            MessageBox.Show("Function will be implemented by Science College");
        }

        //method executes when the Generate Entry Code button is clicked
        private void EntryCodeBtn_Click(object sender, EventArgs e)
        {
            //sets the path and naming protocol for the pdf files            
            string pdfPath = Path.Combine("C:\\Temporary Codes\\" + studentToProfile.StudentId + ".pdf");

            //create the access code in .pdf format using PdfCreator instance
            pdfCreator.CreateAndSavePdf(pdfPath);

            //opens the PDF in the default PDF browser
            Process.Start(pdfPath);

            //this form instance is closed
            this.Close();
        }

        //method executes when the Done Code button is clicked
        private void ProfDoneBtn_Click(object sender, EventArgs e)
        {
            //this form instance is closed
            this.Close();
        }
    }
}
