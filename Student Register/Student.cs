using System;

namespace Student_Register
{
    /*this class acts as a model on which all student information will be exchanged to and from that database.
      The Dapper library uses the field names to map to column names in the database so the names must match*/
    public class Student
    {
        //a separate variable is created for each column in the student database table
        public string StudentId { get; set; } //gets the passed value and sets it in this variable
        public string Title { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public DateTime DoB { get; set; }
        public string Course { get; set; }
        public string AcademicYear { get; set; }

        /*System.ComponentModel.Browsable attribute is used to filter out the columns that are
          not to be displayed in the results gridview in HomeForm*/
        [System.ComponentModel.Browsable(false)]
        public string HomeAddress { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string Postcode { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string StudyAddress { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string StudyPostcode { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string Tel { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string PersonalEmail { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string AcademicEmail { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string Guardian { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string GuardianTel { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string Guardian1 { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string Guardian1Tel { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string CourseType { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string GroupCode { get; set; }
    }
}
