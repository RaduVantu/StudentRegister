using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Student_Register
{
    //this class will handle the dysplay of student related information
    public partial class TeacherProfile : Form
    {
        //a new Teacher class type instances is created
        private Teacher teacherToProfile;        

        //the teacherId variable contains the value of the Teacher ID
        public TeacherProfile(Teacher seletedTeacher)
        {
            InitializeComponent();

            //the course and group labels are hidden until populated with data
            ProfTeacherCourse1Lbl.Visible = false;
            ProfTeacherCourse2Lbl.Visible = false;
            ProfTeacherCourse3Lbl.Visible = false;
            ProfTeacherCourse4Lbl.Visible = false;
            ProfTeacherCourse1GrpLbl.Visible = false;
            ProfTeacherCourse2GrpLbl.Visible = false;
            ProfTeacherCourse3GrpLbl.Visible = false;
            ProfTeacherCourse4GrpLbl.Visible = false;

            /*the Teacher ID value is passed through the input variable to the GetStudent DataAccess method
             and the retrieved Teacher type object is stored in 'seletedTeacher'*/
            teacherToProfile = seletedTeacher;
    }

        private void TeacherProfile_Load(object sender, EventArgs e)
        {
            /* the values of the variables that form the Teacher class object stored in 
               teacherToProfile are set to the different labels */
            ProfTeacherTitleLbl.Text = teacherToProfile.Title;
            ProfTeacherFullnameLbl.Text = teacherToProfile.Surname + "  " + teacherToProfile.FirstName;
            ProfTeacherIdLbl.Text = teacherToProfile.TeacherCode;
            ProfTeacherAddressLbl.Text = teacherToProfile.HomeAddress;
            ProfTeacherPostcodeLbl.Text = teacherToProfile.Postcode;
            ProfTeacherTelLbl.Text = teacherToProfile.Tel;
            ProfTeacherPEmailLbl.Text = teacherToProfile.PersonalEmail;
            ProfTeacherAEmailLbl.Text = teacherToProfile.AcademicEmail;
            ProfTeacherContactLbl.Text = teacherToProfile.Contact;
            ProfTeacherContactTelLbl.Text = teacherToProfile.ContactTel;
            ProfTeacherSpecLbl.Text = teacherToProfile.Specialization;
            ProfTeacherModulesLbl.Text = teacherToProfile.Modules;

            /*splits the value of the Course variable in the Teacher object at each ',' and stores 
              these separate values into an array*/
            string[] teacherCourses = teacherToProfile.Courses.Split(',');

            /*checks if the value at index 0 in the teacherCourses is not null, make the course label visible
             and populate it with the value*/
            if (0 < teacherCourses.Length && teacherCourses.ElementAtOrDefault(0) != null)
            {                
                ProfTeacherCourse1Lbl.Visible = true;
                ProfTeacherCourse1Lbl.Text = teacherCourses[0];
                char courseInitial = ProfTeacherCourse1Lbl.Text[0];

                //also make the group label visible and call the CourseGroups function
                ProfTeacherCourse1GrpLbl.Visible = true;
                //dysplays any course specific groups assigned to the selected teacher
                if(CourseGroups(courseInitial) != string.Empty)
                {
                    ProfTeacherCourse1GrpLbl.Text = CourseGroups(courseInitial);
                }
                //if no groups are returned a predifined message will be printed
                else
                {
                    ProfTeacherCourse1GrpLbl.Text = "No groups assigned";
                }
                
            }
            //same for 'index 1'
            if (1 < teacherCourses.Length && teacherCourses.ElementAtOrDefault(1) != null)
            {
                ProfTeacherCourse2Lbl.Visible = true;
                ProfTeacherCourse2Lbl.Text = teacherCourses[1];
                char courseInitial = ProfTeacherCourse2Lbl.Text[0];

                ProfTeacherCourse2GrpLbl.Visible = true;
                if (CourseGroups(courseInitial) != string.Empty)
                {
                    ProfTeacherCourse2GrpLbl.Text = CourseGroups(courseInitial);
                }
                else
                {
                    ProfTeacherCourse2GrpLbl.Text = "No groups assigned";
                }
            }
            //same for 'index 2'
            if (2 < teacherCourses.Length && teacherCourses.ElementAtOrDefault(2) != null)
            {
                ProfTeacherCourse3Lbl.Visible = true;
                ProfTeacherCourse3Lbl.Text = teacherCourses[2];
                char courseInitial = ProfTeacherCourse3Lbl.Text[0];

                ProfTeacherCourse3GrpLbl.Visible = true;
                if (CourseGroups(courseInitial) != string.Empty)
                {
                    ProfTeacherCourse3GrpLbl.Text = CourseGroups(courseInitial);
                }
                else
                {
                    ProfTeacherCourse3GrpLbl.Text = "No groups assigned";
                }

            }
            //same for 'index 3'
            if (3 < teacherCourses.Length && teacherCourses.ElementAtOrDefault(2) != null)
            {
                ProfTeacherCourse4Lbl.Visible = true;
                ProfTeacherCourse4Lbl.Text = teacherCourses[3];
                char courseInitial = ProfTeacherCourse4Lbl.Text[0];

                ProfTeacherCourse4GrpLbl.Visible = true;
                if (CourseGroups(courseInitial) != string.Empty)
                {
                    ProfTeacherCourse4GrpLbl.Text = CourseGroups(courseInitial);
                }
                else
                {
                    ProfTeacherCourse4GrpLbl.Text = "No groups assigned";
                }
            }
        }

        /*extracts the group codes partaining to each course from the GroupCode value of the 
         teacherToProfile object using the courseInitial variable*/
        private string CourseGroups(char courseInitial)
        {
            /*transforms the value of the GroupCode variable in the Teacher object into an array
            and adds each ',' separated value as a separate entry in the array*/
            string[] teacherGroups = teacherToProfile.GroupCodes.Split(',');

            //this list will contain the validated group codes
            List<string> selectedGroupCodes = new List<string>();

            /*checks each group code in the array and adds it it to the 'selectedGroupCodes' list
            if it the course initial (index 2) in the group code mathcehes the courseInitial*/
            foreach (string groupInList in teacherGroups)
            {
                //variable that holds the character at index 2 of the selected group code
                char groupCodeCourseInitial = groupInList[2];
                
                if (courseInitial == groupCodeCourseInitial)
                {
                    //validated group codes are added to the list
                    selectedGroupCodes.Add(groupInList);
                }
            }
            //all validated group codes in the list are added to this string with a ',' separator
            string courseSpecificGroupCodes = string.Join(", ", selectedGroupCodes.ToArray());
             
            //returns the string's value
            return courseSpecificGroupCodes;
        }

        //method executes when the 'Done' button is clicked
        private void ProfTeacherDoneBtn_Click(object sender, EventArgs e)
        {
            //this form instance is closed
            this.Close();
        }

        //method executes when the 'Timetable' button is clicked
        private void ProfTeacherTimetblBtn_Click(object sender, EventArgs e)
        {
            //message box will appear
            MessageBox.Show("Function will be implemented by Science College");
        }
    }
}
