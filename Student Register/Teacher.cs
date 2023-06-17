using System;

namespace Student_Register
{
    /*this class acts as a model on which all teacher information will be exchanged to and from that database
      the Dapper library uses the field names to map to column names in the database so the names must match*/ 
    public class Teacher
    {
        //a separate variable is created for each column in the teacher database table        
        public string TeacherCode { get; set; } //gets the passed value and sets it in this variable
        public string Title { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Specialization { get; set; }
        public string Courses { get; set; }

        /*System.ComponentModel.Browsable attribute is used to filter out the columns that are
        not to be displayed in the results gridview in HomeForm*/
        [System.ComponentModel.Browsable(false)]
        public string HomeAddress { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string Postcode { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string Tel { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string PersonalEmail { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string AcademicEmail { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string Contact { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string ContactTel { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string GroupCodes { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string Modules { get; set; }
    }
}
