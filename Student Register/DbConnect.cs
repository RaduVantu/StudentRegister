using System.Configuration;

namespace Student_Register
{
    //this class will act as the connector between this application and the database
    public static class DbConnect
    {
        /* this method will retrieve from App.config the connection string with the 
           same name as the value of the variable 'name' */
        public static string ConAddress(string name)
        {
            //and will return the selected database connection string value
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
