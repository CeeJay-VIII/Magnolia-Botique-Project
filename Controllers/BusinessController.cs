using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Documents;
using ProjectVIII.Models;

namespace ProjectVIII.Controllers
{
    public class BusinessController : Controller
    {
        public ActionResult Clothes()
        {
            return View();
        }
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
        public ActionResult Cart(CartModel cartModel)
        {
            List<CartModel> cartList = new List<CartModel>();
            cartList.Add(cartModel);
            return View(cartList);
        }
        public ActionResult Checkout()
        {
            var delivery = new List<string>(){"Delivery","Collection"};
            ViewBag.DeliveryMethod = delivery;

            var payment = new List<string>(){"Credit & Debit card","PayPal"};
            ViewBag.PaymentMethod = payment;

            var bank = new List<string>() { "Absa", "Capitec", "FNB", "Standard bank" };
            ViewBag.BankName = bank;

            return View();
        }
    }
}