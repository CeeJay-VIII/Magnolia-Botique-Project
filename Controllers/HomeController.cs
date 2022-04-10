using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectVIII.Models;

namespace ProjectVIII.Controllers
{
    public class HomeController : Controller
    {
        //connetion string
        readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HP_DB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            List<AdminRegister> adminsList = new List<AdminRegister>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AdminLogin", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        AdminRegister admin = new AdminRegister();
                        admin.firstName = reader.GetString(0);
                        admin.lastName = reader.GetString(1);
                        admin.studentNumber = reader.GetInt32(2);
                        admin.DOB = reader.GetString(3);
                        admin.gender = reader.GetString(4);
                        admin.age = reader.GetInt32(5);
                        admin.emailAddress = reader.GetString(6);

                        adminsList.Add(admin);
                    }
                }
                else
                    TempData["Admins"] = "Something went wrong!";
            }
            return View(adminsList);
        }
    }
}