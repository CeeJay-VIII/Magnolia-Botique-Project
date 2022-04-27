using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Documents;
using ProjectVIII.Models;
using System.Data;

namespace ProjectVIII.Controllers
{
    public class BusinessController : Controller
    {
        readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HP_DB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        //Clothes controller
        public ActionResult Clothes(CartModel cartModel)
        {
            return View(cartModel);
        }
        [HttpPost]
        public ActionResult Clothes(CartModel cartModel, string Delave, string Chenille, 
            string FleeceX, string Abrasion, string Denin, string Funnel, string Dress, 
            string Fleece, string FleeceS, string Chino, string Blazer, string SweatshirtX)
        {
            DataAccess dataAccess = new DataAccess();
            if (Delave != null)
            {
                cartModel.productName = Delave;
                cartModel.price = 250;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (Chenille != null)
            {
                cartModel.productName = Chenille;
                cartModel.price = 300;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (FleeceX != null)
            {
                cartModel.productName = FleeceX;
                cartModel.price = 450;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (Abrasion != null)
            {
                cartModel.productName = Abrasion;
                cartModel.price = 500;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (Denin!=null)
            {
                cartModel.productName = Denin;
                cartModel.price = 230;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (Funnel!=null)
            {
                cartModel.productName = Funnel;
                cartModel.price = 500;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (Dress!=null)
            {
                cartModel.productName = Dress;
                cartModel.price = 700;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (Fleece!=null)
            {
                cartModel.productName = Fleece;
                cartModel.price = 900;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (FleeceS!=null)
            {
                cartModel.productName = FleeceS;
                cartModel.price = 400;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (Chino!=null)
            {
                cartModel.productName = Chino;
                cartModel.price = 300;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (Blazer!=null)
            {
                cartModel.productName = Blazer;
                cartModel.price = 1000;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (SweatshirtX!=null)
            {
                cartModel.productName = SweatshirtX;
                cartModel.price = 300;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            return View();
        }


        //Shoes view
        public ActionResult Shoes()
        {
            return View();
        }
        public ActionResult Bags()
        {
            return View();
        }
        public ActionResult Transactions()
        {
            return View();
        }

        //Cart view
        public ActionResult Cart()
        {
            List<CartModel> cartList = new List<CartModel>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ReadCart", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CartModel cartModel = new CartModel();
                        cartModel.Id = reader.GetInt32(0);
                        cartModel.productName = reader.GetString(1);
                        cartModel.price = reader.GetDouble(2);

                        cartList.Add(cartModel);
                    }
                }
                else
                {
                    
                }
            }
            return View(cartList);
        }
        
        //Delete from the cart
        public ActionResult CartDelete(int Id)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.DeleteFromCart(Id);
            return RedirectToAction("Cart", "Business");
        }
        public ActionResult Checkout()
        {
            var delivery = new List<string>(){"Delivery","Collection"};
            ViewBag.DeliveryMethod = delivery;

            var payment = new List<string>(){"Credit & Debit card"};
            ViewBag.PaymentMethod = payment;

            var bank = new List<string>() { "Absa", "Capitec", "FNB", "Standard bank" };
            ViewBag.BankName = bank;

            return View();
        }
    }
}