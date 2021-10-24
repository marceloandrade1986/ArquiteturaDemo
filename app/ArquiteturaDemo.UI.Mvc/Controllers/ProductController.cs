using ArquiteturaDemo.Application;
using ArquiteturaDemo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArquiteturaDemo.UI.Mvc.Controllers
{
    public class ProductController : Controller
    {

        private readonly ProductApplication _productApplication;
        private readonly IProductRepository _productRepository;

        public ProductController(ProductApplication productApplication, IProductRepository productRepository)
        {
            _productApplication = productApplication;
            _productRepository = productRepository;
        }

        // GET: Product
        public ActionResult Index()
        {

            var products = _productRepository.Get();
            return View(products);
        }
    }
}