using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
    }
}