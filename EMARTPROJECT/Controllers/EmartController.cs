using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EMARTPROJECT.Models;
using Microsoft.AspNetCore.Hosting;

namespace EMARTPROJECT.Controllers
{
    public class EmartController : Controller
    {
        public readonly SellerContext _context;
        public readonly BuyerContext _context1;
        public readonly ProductContext _context2;
        private readonly IWebHostEnvironment hostingEnvironment;
        public EmartController(SellerContext context,BuyerContext context1,ProductContext context2,IWebHostEnvironment hostingEnvironment)
        {
           this. _context = context;
            this._context1 = context1;
            this._context2 = context2;
            this.hostingEnvironment = hostingEnvironment;
        }
        // GET: Emart
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult S_SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult S_SignUp(Seller s)
        {
            try
            {
                _context.Add(s);
                _context.SaveChanges();
                ViewBag.message = s.s_username + " has got successfully registered";
                return RedirectToAction("S_Login");
            }
            catch (Exception e)
            {
                ViewBag.message = s.s_username + " Registration failed";
                return View();
            }
            
        }
        [HttpGet]
        public ActionResult B_SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult B_SignUp(Buyer b)
        {
            try
            {
                _context1.Add(b);
                _context1.SaveChanges();
                ViewBag.message = b.b_username + " has got successfully registered";
                return RedirectToAction("B_Login");
            }
            catch (Exception e)
            {
                ViewBag.message = b.b_username + " Registration failed";
                return View();
            }

        }
        public ActionResult S_Index()
        {
            return View();
        }
        public ActionResult B_Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult S_Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult S_Login(Seller s)
        {
            var logUser = _context.Sellers.Where(e => e.s_id == s.s_id && e.s_pwd == s.s_pwd).ToList();
            if (logUser.Count == 0)
            {
                ViewBag.message="Invalid Credentials";
                return View();
            }
            else
            {
                ViewBag.message="Login successfull";
                //HttpContext.Session.SetInt32("UName", s.s_id);
                return RedirectToAction("SellerDashBoard");
                //return View();
            }

        }
        [HttpGet]
        public ActionResult B_Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult B_Login(Buyer b)
        {
            var logUser = _context1.Buyers.Where(e => e.b_id == b.b_id && e.b_pwd == b.b_pwd).ToList();
            if (logUser.Count == 0)
            {
                ViewBag.message="Invalid Credentials";
                return View();
            }
            else
            {
                ViewBag.message="Login successfull";
                //HttpContext.Session.SetInt32("UName", b.b_id);
                return RedirectToAction("BuyerDashBoard");
                //return View();
            }

        }
        public ActionResult SellerDashBoard()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddItems()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddItems(Product p)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                // If the Photo property on the incoming model object is not null, then the user
                // has selected an image to upload.
                if (model.ItemPhoto != null)
                {
                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Images");
                    // To make sure the file name is unique we are appending a new
                    // GUID value and and an underscore to the file name
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.photopath.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    // Use CopyTo() method provided by IFormFile interface to
                    // copy the file to wwwroot/images folder
                    model.photopath.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Product newProduct = new Product
                {
                    s_username = model.s_username,
                    s_email_id = model.s_email_id,
                    s_pwd = model.s_pwd,
                    GSTIN = model.GSTIN,
                    sbank_accno = model.sbank_accno,

                    // Store the file name in PhotoPath property of the employee object
                    // which gets saved to the Employees database table
                     = uniqueFileName
                };

                _context2.Add(newSeller);
                _context2.SaveChanges();
                return RedirectToAction("Details", new { id = newSeller.i_id });
            }

            return View();
        }

    }
        public ActionResult BuyerDashBoard()
        {
            return View();
        }
        // GET: Emart/Details/5
        

        // GET: Emart/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emart/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SellerCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                // If the Photo property on the incoming model object is not null, then the user
                // has selected an image to upload.
                if (model.photopath != null)
                {
                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Images");
                    // To make sure the file name is unique we are appending a new
                    // GUID value and and an underscore to the file name
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.photopath.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    // Use CopyTo() method provided by IFormFile interface to
                    // copy the file to wwwroot/images folder
                    model.photopath.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Seller newSeller = new Seller
                {
                    s_username = model.s_username,
                    s_email_id = model.s_email_id,
                    s_pwd = model.s_pwd,
                    GSTIN = model.GSTIN,
                    sbank_accno=model.sbank_accno,

                // Store the file name in PhotoPath property of the employee object
                // which gets saved to the Employees database table
                    photopath = uniqueFileName
                };

                _context.Add(newSeller);
                _context.SaveChanges();
                return RedirectToAction("Details", new { id = newSeller.s_id });
            }

            return View();
        }
        public ActionResult Details(int id)
        {
            Seller seller = _context.Sellers.FirstOrDefault(e => e.s_id == id);
            return View(seller);
        }
        // GET: Emart/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Emart/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Emart/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Emart/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}