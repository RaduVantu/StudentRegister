using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Student_Register
{
    //this class handles all program mainscreen interactions
    public partial class HomeForm : Form
    {
        //new Student, Teacher and DataAccess class type instances are created
        private List<Student> studentResults = new List<Student>();
        private List<Teacher> teacherResults = new List<Teacher>();
        private DataAccess db = new DataAccess();

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            //ensures all student and teacher related labels, textboxes and buttons are hidden
            HideElements();
        }


        //method executes when the 'Search Student' button is clicked
        private void StudentsButton_Click(object sender, EventArgs e)
        {
            HideElements();

            /*makes the student related page title, buttons and search box visible and sets
              the focus on search box*/
            AddStuButton.Visible = true;
            StudentLbl.Visible = true;            
            SubmitStuSearchButton.Visible = true;
            ShowAllStuButton.Visible = true;
            StudentSearchBarTb.Visible = true;
            StudentSearchBarTb.Focus();
        }

        //method executes when the 'Search button' is clicked
        private void SubmitStuSearchButton_Click(object sender, EventArgs e)
        {
            /*the 'studentResults' list will be populated with the results of the database search,
              based on the user input present in the search box*/
            studentResults = db.SearchStudents(StudentSearchBarTb.Text.Trim());

            //check the search box for input
            if (StudentSearchBarTb.Text == string.Empty)
            {
                //if no input is detected, hides (or keeps hidden) the search results gridview
                StudentSearchResultsGV.Visible = false;
            }
            else
            {
                //if input is present and no result
                if (studentResults.Count == 0)
                {
                    /* if no results have been found, hide the results gridview and display a message box
                       and retain focus on the search box */
                    StudentSearchResultsGV.Visible = false;
                    MessageBox.Show("No students found");
                    StudentSearchBarTb.Focus();
                }
                else
                {
                    /* if results are found update the list with the students, show the results gridview
                       and switch the focus on it */
                    StudentSearchResultsGV.Visible = true;                    
                    UpdateStudentGridView();
                    StudentSearchResultsGV.Focus();
                }
            }
        }

        //method executes when a specific key (in this case 'Enter") is pressed while the search box has focus
        private void StudentSearchBarTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if 'Enter' key is pressed, perform click on Search button function
            if (e.KeyChar == (char)13)
                SubmitStuSearchButton.PerformClick();
        }

        //method executes when 'Show All' button is clicked while in 'Search Student'
        private void ShowAllStuButton_Click(object sender, EventArgs e)
        {
            //get all students from DB
            studentResults = db.GetAllStudents();

            //make the gridview visible, load the data and focus on it
            StudentSearchResultsGV.Visible = true;
            UpdateStudentGridView();
            StudentSearchResultsGV.Focus();
        }

        //method executes when a result is double-clicked the gridview
        private void StudentSearchResultsGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Student selectedStudent = ExtractCurrentSelectedStudent();

            //a new instance of the Student Profile form is created with 'Student' object as parameter 
            var newStudentProfile = new StudentProfile(selectedStudent);

            //display the new form instance
            newStudentProfile.ShowDialog();

            //the results gridview is hidden
            StudentSearchResultsGV.Visible = false;
        }

        /*method executes when a specific key (in this case 'Enter") is pressed while a position is selected 
          in the gridview*/
        private void StudentSearchResultsGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if 'Enter' key is pressed
            if (e.KeyChar == (char)13)
            {
                //same as 'private void StudentSearchResultsGV_CellDoubleClick'
                Student selectedStudent = ExtractCurrentSelectedStudent();
                var newStudentProfile = new StudentProfile(selectedStudent);
                newStudentProfile.Show();
            }
        }

        /*this method creates a 'Student' type object containing the details of
        the selected Student object from the gridview*/
        private Student ExtractCurrentSelectedStudent()
        {
            //get the current selected Row index 
            int selectedStudentIndex = this.StudentSearchResultsGV.CurrentRow.Index;

            //retrieve the student at that index from the 'studentResults' list 
            Student selectedStudent = studentResults[selectedStudentIndex];

            return selectedStudent;
        }

        //method executes when the 'Add Student' button is clicked
        private void AddStuButton_Click(object sender, EventArgs e)
        {
            HideElements();

            //an instance of the AddStudent form is created and displayed
            var newAddStudentForm = new AddStudent();
            newAddStudentForm.ShowDialog();
        }

        //method executes when the 'Search Teacher' button is clicked (not included in the project)
        private void TeachersButton_Click(object sender, EventArgs e)
        {
            HideElements();

            /*makes the teacher related page title, buttons and search box visible and sets
            the focus on search box */
            TeacherLbl.Visible = true;
            SubmitTeacherSearchButton.Visible = true;
            ShowAllTeachersButton.Visible = true;
            TeacherSearchBarTb.Visible = true;
            TeacherSearchBarTb.Focus();
        }

        //same as 'SubmitStuSearchButton_Click' but for teacher
        private void SubmitTeacherSearchButton_Click(object sender, EventArgs e)
        {            
            teacherResults = db.SearchTeachers(TeacherSearchBarTb.Text.Trim());
                       
            if (TeacherSearchBarTb.Text == string.Empty)
            {               
                TeacherSearchResultsGV.Visible = false;
            }
            else
            {
                if (teacherResults.Count == 0)
                {
                    TeacherSearchResultsGV.Visible = false;
                    MessageBox.Show("No teachers found");
                    TeacherSearchBarTb.Focus();
                }
                else
                {
                    TeacherSearchResultsGV.Visible = true;
                    UpdateTeacherGridView();
                    TeacherSearchResultsGV.Focus();
                }
            }
        }

        //same as 'StudentSearchBarTb_KeyPress' but for teacher
        private void TeacherSearchBarTb_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (e.KeyChar == (char)13)
                SubmitTeacherSearchButton.PerformClick();
        }

        //same as'ShowAllStuButton_Click' but for teacher
        private void ShowAllTeachersButton_Click(object sender, EventArgs e)
        {
            teacherResults = db.GetAllTeachers();

            TeacherSearchResultsGV.Visible = true;
            UpdateTeacherGridView();
            TeacherSearchResultsGV.Focus();
        }

        //same as'StudentSearchResultsGV_CellDoubleClick' but for teacher
        private void TeacherSearchResultsGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Teacher selectedTeacher = ExtractCurrentSelectedTeacher();
            var newTeacherProfile = new TeacherProfile(selectedTeacher);
            newTeacherProfile.ShowDialog();
            TeacherSearchResultsGV.Visible = false;
        }

        //same as'StudentSearchResultsGV_KeyPress' but for teacher        
        private void TeacherSearchResultsGV_KeyPress(object sender, KeyPressEventArgs e)
        {            
            Teacher selectedTeacher = ExtractCurrentSelectedTeacher();
            var newTeacherProfile = new TeacherProfile(selectedTeacher);
            newTeacherProfile.ShowDialog();
            TeacherSearchResultsGV.Visible = false;
        }

        //same as 'ExtractCurrentSelectedStudent' but for teacher
        private Teacher ExtractCurrentSelectedTeacher()
        {            
            int selectedTeacherIndex = this.TeacherSearchResultsGV.CurrentRow.Index;
            Teacher teacher = teacherResults[selectedTeacherIndex];
            return teacher;
        }

        //method executes when the Search Timetables button is clicked (not included in the project)
        private void TimetablesButton_Click(object sender, EventArgs e)
        {
            HideElements();

            //message box will appear
            MessageBox.Show("Function will be implemented by Science College");
        }

        //method executes when the Contacts button is clicked (not included in the project)
        private void ContactsButton_Click(object sender, EventArgs e)
        {            
            HideElements();

            //message box will appear
            MessageBox.Show("Function will be implemented by Science College");
        }

        //method executes when the Exit button is clicked
        private void ExitAppBtn_Click(object sender, EventArgs e)
        {
            //variable holds the path for the folder containing the QR codes generated in the StudentProfile form
            DirectoryInfo generatedCodeFolder = new DirectoryInfo(@"c:\Temporary Codes\");
                        
            //delete all existing QR code files in the folder and close the application
            foreach (FileInfo file in generatedCodeFolder.EnumerateFiles())
            {
                file.Delete();
            }

            Application.Exit();
        }

        //method for populating the results gridview
        private void UpdateStudentGridView()
        {
            StudentSearchResultsGV.DataSource = studentResults;
        }

        //method for populating the results gridview
        private void UpdateTeacherGridView()
        {
            TeacherSearchResultsGV.DataSource = teacherResults;
        }

        //hides teacher and student specific elements like lables, buttons, text boxes and gridviews
        private void HideElements()
        {
            AddStuButton.Visible = false;
            TeacherLbl.Visible = false;
            StudentLbl.Visible = false;                        
            SubmitStuSearchButton.Visible = false;
            SubmitTeacherSearchButton.Visible = false;
            ShowAllStuButton.Visible = false;
            ShowAllTeachersButton.Visible = false;
            StudentSearchBarTb.Visible = false;
            TeacherSearchBarTb.Visible = false;
            StudentSearchResultsGV.Visible = false;
            TeacherSearchResultsGV.Visible = false;
        }        
    }
}
