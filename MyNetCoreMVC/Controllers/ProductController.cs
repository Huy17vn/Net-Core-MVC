using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyNetCoreMVC.Models;
using Newtonsoft.Json;

namespace MyNetCoreMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly myDbContext _context;

        public ProductController(myDbContext context)
        {
            _context = context;
            if (_context.Products.Count() == 0)
            {
                _context.Products.Add(new Product()
                {
                    name = "San Pham 1",
                    price = 1000
                });
                _context.Products.Add(new Product()
                {
                    name = "San Pham 2",
                    price = 2000
                });
                _context.SaveChanges();
            }
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult GetList()
        {
            return View(_context.Products.ToList());
        }
        public IActionResult Update(long id)
        {
            var product = _context.Products.Find(id);
            return View(product);
        }
        public IActionResult Delete(long id)
        {
            var product = _context.Products.Find(id);
            return View(product);
        }
        public IActionResult UpdateProduct(Product product)
        {
            var item = _context.Products.Find(product.id);
            item.name = product.name;
            item.price = product.price;
            _context.Products.Update(item);
            _context.SaveChanges();
            TempData["nontification"] = "Update success!";
            return new RedirectResult("GetList");
        }
        public IActionResult AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            TempData["nontification"] = "Create success!";
            return new RedirectResult("GetList");
        }
        public IActionResult DeleteProduct(long id)
        {
            var item = _context.Products.Find(id);
            _context.Products.Remove(item);
            _context.SaveChanges();
            TempData["nontification"] = "Delete success!";
            return new RedirectResult("GetList");
        }
    }
}