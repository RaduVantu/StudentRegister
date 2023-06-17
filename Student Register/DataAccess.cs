using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;

namespace Student_Register
{
    //this class holds all the database related methods
    public class DataAccess
    {
        //method takes toSearch parameter and returns a list of Student class type objects
        public List<Student> SearchStudents(string toSearch)
        {
            /* creates a new database connection using the connection string provided by the DbConnect class.
               the connection will be closed automatically when the query results are received 
               With the using statement we dispose the connection when we return */

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbConnect.ConAddress("StudentRegisterDB")))
            {
                /* this variable holds the Student type list object that will contain the results returned by 
                   the sql-stored-procedure-based query. The toSearch variable passed from 'HomeForm' is used as the parameter for the query */
                var output = connection.Query<Student>("dbo.procedureSearchStudent @searchBy", new { searchBy = toSearch }).ToList();
                
                //returns the list
                return output;
            }
        }

        //same as public List<Student> SearchStudents, but for teacher
        public List<Teacher> SearchTeachers(string toSearch)
        {            
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbConnect.ConAddress("StudentRegisterDB")))
            {                
                var output = connection.Query<Teacher>("dbo.procedureSearchTeacher @searchBy", new { searchBy = toSearch }).ToList();
                return output;
            }
        }

        //method takes toSearch parameter and returns a Student class type object
        public Student GetStudent(string toSearch)
        {
            return SearchStudents(toSearch).ElementAt(0);
        }

        //method takes toSearch parameter and returns a Teacher class type object
        public Teacher GetTeacher(string toSearch)
        {
            return SearchTeachers(toSearch).ElementAt(0);
        }

        //method that gets all the students in the database using the designated sql stored procedure
        public List<Student> GetAllStudents()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbConnect.ConAddress("StudentRegisterDB")))
            {                
                var output = connection.Query<Student>("dbo.procedureSelectAllStudents");
                return output.ToList();
            }                                                        
        }

        //method that gets all the teachers in the database using the designated sql stored procedure
        public List<Teacher> GetAllTeachers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbConnect.ConAddress("StudentRegisterDB")))
            {
                var output = connection.Query<Teacher>("dbo.procedureSelectAllTeachers").ToList(); 
                return output.ToList();
            }                                                        
        }

        //method takes a list parameter that contains the variable values for the new student
        public void AddStudent(List<Student> studentToAdd)
        {            
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbConnect.ConAddress("StudentRegisterDB")))
            {
                /* uses the specified sql stored procedure to add a new entry to database, based on the variables contained in 
                   the studentToAdd Student class type list*/
                connection.Execute("dbo.procedureAddStudent @StudentId, @Title, @Surname, @FirstName, @DoB, @HomeAddress," +
                    " @Postcode, @StudyAddress, @StudyPostcode, @Tel, @PersonalEmail, @AcademicEmail, @Guardian, @GuardianTel, " +
                    "@Guardian1, @Guardian1Tel, @CourseType, @Course, @AcademicYear, @GroupCode", studentToAdd);
            }
        }

        //method takes a list parameter that contains the variable values needed to update an existing student database entry
        public void UpdateStudent(List<Student> updatedStudent)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbConnect.ConAddress("StudentRegisterDB")))
            {
                /* uses the specified sql stored procedure to replace an existing entry in database, based on the variables 
                   contained in the updatedStudent Student class type list*/
                connection.Execute("dbo.procedureUpdateStudent @StudentId, @Title, @Surname, @FirstName, @DoB, @HomeAddress, " +
                    "@Postcode, @StudyAddress, @StudyPostcode, @Tel, @PersonalEmail, @AcademicEmail, @Guardian, @GuardianTel, " +
                    "@Guardian1, @Guardian1Tel, @CourseType, @Course, @AcademicYear, @GroupCode", updatedStudent);
            }
        }        

        //method takes studentId parameter that identifies the entry to be deleted
        public void DeleteStudent(string studentId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbConnect.ConAddress("StudentRegisterDB")))
            {
                /* uses the specified sql stored procedure to delete the specified entry from database. A dynamic class is used to 
                   pass the studentId value to the query*/
                connection.Execute("dbo.procedureDeleteStudent @StudentId", new{ StudentId = studentId });
            }
        }

        //method that reads the latest student id from the database
        public string GetLatestStudentId()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbConnect.ConAddress("StudentRegisterDB")))
            {
                /* selects the latest student from the database and returns its StudentId*/
                var result = connection.Query<string>("SELECT TOP 1 StudentId from [StudentRegister].[dbo].[Students] ORDER BY StudentId DESC");
                return result.FirstOrDefault();
            }
        }
    }
}
