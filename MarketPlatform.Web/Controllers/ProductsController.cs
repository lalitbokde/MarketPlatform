using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarketPlatform.Core.Domain.Products;
using MarketPlatform.Services.Products;
using MarketPlatform.Web.Models.Products;

namespace MarketPlatform.Web.Controllers
{
    public class ProductsController : Controller
    {
        #region Fields
        private readonly IProductsService _ProductsService;
        #endregion

        #region Ctor
        public ProductsController(IProductsService _ProductsService)
        {
            this._ProductsService = _ProductsService;
        }
        #endregion

        // GET: Products
        public ActionResult Index()
        {
            var products = _ProductsService.getAllProducts();
            return View(products);
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(ProductModel model)
        {
            try
            {
                Product _product = new Product();
                _product.Name = model.Name;
                _product.AmazonSKU = model.AmazonSKU;
                _product.CreatedOnUtc = DateTime.UtcNow;
                _product.Deleted = false;
                _product.Description = model.Description;
                _product.FullDescription = model.FullDescription;
                _product.Gtin = model.Gtin;
                _product.ManufacturerPartNumber = model.ManufacturerPartNumber;
                _product.NeweggSKU = model.NeweggSKU;
                _product.Price = model.Price;
                _product.ProductCost = model.ProductCost;
                _product.ShortDescription = model.ShortDescription;
                _product.Sku = model.Sku;
                _product.StockQuantity = model.StockQuantity;
                _product.UPC = model.UPC;
                _product.UpdatedOnUtc = DateTime.UtcNow;
                _product.UseMultipleWarehouses = true;
                _product.VendorId = 1;
                _product.WalmartSKU = model.WalmartSKU;
                _product.WarehouseId = 1;
                _ProductsService.insertProduct(_product);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        
        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
