using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emart.Model;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Emart.Controllers;

namespace Emart.Controllers
{
    public class EmartController:Controller
    {
        //IsellerBo sellerbo = new SellerBo();
        private readonly IsellerBo sellerbo;
        public EmartController(IsellerBo sellerBO)
        {
            sellerbo = sellerBO;
        }
        public IActionResult Search(int? id)
        {
            int s_id = (int)(id == null ? 1 : id);
            Seller s = sellerbo.Search_Id(s_id);
            return View(s);
        }

        
        public IActionResult Index()
        {
            List<Seller> se = sellerbo.DisplayDetails();
            return View(se);
        }
        //public ViewResult AboutUs()
        //{
        //    return View();
        //}
        public IActionResult GetAllSellers()
        {
            List<Seller> slist = (sellerbo.DisplayDetails()).Where(e=>e.postal_address=="ongole").ToList();
            return View("Index",slist);
        }
    }
}
