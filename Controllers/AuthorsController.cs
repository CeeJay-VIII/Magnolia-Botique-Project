using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using ProjectVIII.Models;
using System.Configuration;
using System.Globalization;

namespace ProjectVIII.Controllers
{
    public class AuthorsController : Controller
    {
        //ConnectionString to a Database
        readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HP_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        
        //Registration actionNames
        public ActionResult Register()
        {
            ModelState.Clear();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(AdminRegister adminRegister)
        {
            if (!ModelState.IsValid)
            {
                TempData["Success"] = "Something went wrong!";
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("AdminLogin", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataAccess dataAccess = new DataAccess();
                    try
                    {
                        while (reader.Read())
                        {
                            if (reader.GetInt32(2) == adminRegister.studentNumber)
                            {
                                TempData["Register"] = "Account with the same student number alraedy exist!";
                                return View(adminRegister);
                            }
                        }
                        ModelState.Clear();
                        dataAccess.AddUser(adminRegister);
                        TempData["Register"] = "Registered successfully!";
                    }
                    catch (Exception)
                    {
                        TempData["Register"] = "Account with the same student number alraedy exist!";
                    }
                }
            }
            return View(adminRegister);
        }

        //Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AdminLogin adminLogin)
        {
            if (!ModelState.IsValid)
            {
                TempData["Login"] = "Something went wrong";
            }
            else
            {
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
                            if(reader.GetString(6) == adminLogin.emailAddress && reader.GetString(7) == adminLogin.password)
                            {
                                TempData["User"] = $"{reader.GetString(0).Substring(0,1)}. {reader.GetString(1)}";
                                return RedirectToAction("Admins", "Authors");
                            }
                        }
                        TempData["Login"] = "Account not found!";
                    }
                    else
                        TempData["Login"] = "Account not found!";
                }
            }
            return View(adminLogin);
        }

        //Contact info for administrators
        public ActionResult Admins()
        {
            List<AdminRegister> adminList = new List<AdminRegister>();
            adminList.Clear();

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

                        adminList.Add(admin);
                    }
                }
                else
                    TempData["Admins"] = "Something went wrong!";
            }
            return View(adminList);
        }

        //Delete Admin
        public ActionResult Delete(int Student)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.DeleteAdmin(Student);
            return RedirectToAction("Admins", "Authors");
        }
    }
}