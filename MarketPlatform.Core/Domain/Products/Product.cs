using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlatform.Core.Domain.Products
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string FullDescription { get; set; }

        public int VendorId { get; set; }

        public string Sku { get; set; }

        public string ManufacturerPartNumber { get; set; }

        public string UPC { get; set; }

        public string Gtin { get; set; }
        
        public bool UseMultipleWarehouses { get; set; }

        public int WarehouseId { get; set; }

        public int StockQuantity { get; set; }

        public decimal Price { get; set; }

        public decimal ProductCost { get; set; }

        public bool Deleted { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime UpdatedOnUtc { get; set; }

        public string AmazonSKU { get; set; }

        public string WalmartSKU { get; set; }

        public string NeweggSKU { get; set; }

        public string Description { get; set; }
    }
}
