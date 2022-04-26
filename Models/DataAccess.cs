using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectVIII.Models
{
    public class DataAccess
    {
        readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HP_DB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        public bool UserAdded = true;
        //Add user
        public void AddUser( AdminRegister adminRegister )
        {

            try
            {
                adminRegister.DOB = adminRegister.getDOB().ToString("d");
                adminRegister.age = adminRegister.calcAge();
                adminRegister.gender = adminRegister.getGender();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("AddAdmin", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(@"Name", $"{adminRegister.firstName.Substring(0, 1).ToUpper()}{adminRegister.firstName.Substring(1).ToLower()}");
                    cmd.Parameters.AddWithValue(@"Surname", $"{adminRegister.lastName.Substring(0, 1).ToUpper()}{adminRegister.lastName.Substring(1).ToLower()}");
                    cmd.Parameters.AddWithValue(@"StudentNumber", adminRegister.studentNumber);
                    cmd.Parameters.AddWithValue(@"DOB", adminRegister.DOB);
                    cmd.Parameters.AddWithValue(@"Gender", adminRegister.gender);
                    cmd.Parameters.AddWithValue(@"Age", adminRegister.age);
                    cmd.Parameters.AddWithValue(@"EmailAddress", adminRegister.emailAddress);
                    cmd.Parameters.AddWithValue(@"Password", adminRegister.password);
                    cmd.ExecuteNonQuery();
                    UserAdded = true;
                }
            }
            catch (Exception)
            {
                UserAdded = false;
            }
        }
        //Delete Admin
        public void DeleteAdmin(int StudentNo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql_proc = "DELETE FROM [dbo].[Admins] WHERE [StudentNumber] =" + StudentNo + "";
                using (SqlCommand cmd = new SqlCommand(sql_proc, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void ViewAdmins()
        {

        }
    }
}