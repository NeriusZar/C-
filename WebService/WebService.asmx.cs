using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using UI;

namespace WebService
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public void InsertRow(User user, SqlConnection connection)
        {
            var commandString = "INSERT INTO dbo.PeopleFaceTable (First_Name, Last_Name ,Education, Photo) VALUES (@First_Name, @Last_Name, @Education, @Photo)";
            SqlCommand command = new SqlCommand(commandString, connection);

            command.Parameters.AddWithValue("@First_Name", user.FirstName);
            command.Parameters.AddWithValue("@Last_Name", user.LastName);
            command.Parameters.AddWithValue("@Education", user.Information);
            command.Parameters.AddWithValue("@Photo", "87d87e9wq7888d7w9f7889");

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();


        }


        [WebMethod]
        public void GetDataFromDatabase(List<User> Users, SqlConnection connection)
        {
            //var user = new User
            var commandString = "Select * From dbo.PeopleFaceTable";
            using (SqlCommand command = new SqlCommand(commandString, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var user = new User(
                            reader["First_Name"].ToString(),
                            reader["Last_Name"].ToString(),
                            reader["Education"].ToString());

                        Users.Add(user);
                    }
                }
                connection.Close();
            }
        }
    }
}
