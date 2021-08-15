using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace classes_project
{
    public static class Login
    {
        public  static void IntroScreen()
        {
            Console.WriteLine("Welcome! Please, type your email below so you can login: (*leave it blank to create a new user)");
            string userEmail = Console.ReadLine();
            Console.WriteLine("Perfect! Now, please, type your password!");
            string userPassword = Console.ReadLine();
            string connectionString = "Data Source=DESKTOP-IG588LE;" + "Initial Catalog=database_test;" + "Integrated Security=SSPI;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM [dbo].[user_info]";

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
      
                        if ((userEmail == dr["email"].ToString()) && (userPassword == dr["password"].ToString()))
                        {
                            Console.WriteLine("Login done");
                        }
                        else
                        {
                            Console.WriteLine("Plase, try again:");
                            Login.IntroScreen();
                        }
                    }
                    dr.Close();
                }
            }
        }
    }
}
