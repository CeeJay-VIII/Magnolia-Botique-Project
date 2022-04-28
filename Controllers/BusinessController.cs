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
            DataAccess dataAccess = new DataAccess();
            dataAccess.TotalCartItems();
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
            }//End of first row
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
            }//End of second row
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
            }//End of third row
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
        public ActionResult Shoes(CartModel cartModel)
        {
            return View(cartModel);
        }
        [HttpPost]
        public ActionResult Shoes(CartModel cartModel, string S1152230, string S1153301, string S1156500,
            string S1157398, string S1158013, string S1158236, string S1158550, string S1158626, string S1158649,
            string S1159140, string S1159178, string S1159214)
        {
            DataAccess dataAccess = new DataAccess();
            if (S1152230 != null)
            {
                cartModel.productName = S1152230;
                cartModel.price = 500;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (S1153301 != null)
            {
                cartModel.productName = S1153301;
                cartModel.price = 500;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (S1156500 != null)
            {
                cartModel.productName = S1156500;
                cartModel.price = 400;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (S1157398 != null)
            {
                cartModel.productName = S1157398;
                cartModel.price = 500;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (S1158013 != null)
            {
                cartModel.productName = S1158013;
                cartModel.price = 1000;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (S1158236 != null)
            {
                cartModel.productName = S1158236;
                cartModel.price = 400;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (S1158550 != null)
            {
                cartModel.productName = S1158550;
                cartModel.price = 1500;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (S1158626 != null)
            {
                cartModel.productName = S1158626;
                cartModel.price = 650;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (S1158649 != null)
            {
                cartModel.productName = S1158649;
                cartModel.price = 700;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (S1159140 != null)
            {
                cartModel.productName = S1159140;
                cartModel.price = 500;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (S1159178 != null)
            {
                cartModel.productName = S1159178;
                cartModel.price = 300;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (S1159214 != null)
            {
                cartModel.productName = S1159214;
                cartModel.price = 1800;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            return View();
        }
        //Bags view
        public ActionResult Bags(CartModel cartModel)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.TotalCartItems();
            return View(cartModel);
        }
        [HttpPost]
        public ActionResult Bags(CartModel cartModel, string S1150422, string S1152214,
            string S1152228, string S1152231, string S1152551, string S1154402, string S1161325,
            string S1161326)
        {
            DataAccess dataAccess = new DataAccess();
            if (S1150422 != null)
            {
                cartModel.productName = S1150422;
                cartModel.price = 500;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (S1152214 != null)
            {
                cartModel.productName = S1152214;
                cartModel.price = 500;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (S1152228 != null)
            {
                cartModel.productName = S1152228;
                cartModel.price = 400;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (S1152231 != null)
            {
                cartModel.productName = S1152231;
                cartModel.price = 400;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (S1152551 != null)
            {
                cartModel.productName = S1152551;
                cartModel.price = 480;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (S1154402 != null)
            {
                cartModel.productName = S1154402;
                cartModel.price = 350;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (S1161325 != null)
            {
                cartModel.productName = S1161325;
                cartModel.price = 500;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
            else if (S1161326 != null)
            {
                cartModel.productName = S1161326;
                cartModel.price = 430;
                dataAccess.AddToCart(cartModel);
                return View(cartModel);
            }
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