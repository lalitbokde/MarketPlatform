using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlatform.Core.Domain
{
    public class Products
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string FullDescription { get; set; }

        public int ProductTemplateId { get; set; }

        public int VendorId { get; set; }

        public bool LimitedToStores { get; set; }

        public string Sku { get; set; }

        public string ManufacturerPartNumber { get; set; }

        public string UPC { get; set; }

        public string Gtin { get; set; }
        
        public bool IsRecurring { get; set; }
        
        public bool IsShipEnabled { get; set; }

        public bool IsFreeShipping { get; set; }

        public bool ShipSeparately { get; set; }

        public decimal AdditionalShippingCharge { get; set; }

        public int DeliveryDateId { get; set; }

        public bool UseMultipleWarehouses { get; set; }

        public int WarehouseId { get; set; }

        public int StockQuantity { get; set; }

        public int MinStockQuantity { get; set; }

        public int BackorderModeId { get; set; }

        public bool AllowBackInStockSubscriptions { get; set; }

        public int OrderMinimumQuantity { get; set; }

        public int OrderMaximumQuantity { get; set; }

        public string AllowedQuantities { get; set; }

        public bool NotReturnable { get; set; }

        public bool DisableBuyButton { get; set; }

        public bool DisableWishlistButton { get; set; }

        public bool AvailableForPreOrder { get; set; }

        public DateTime? PreOrderAvailabilityStartDateTimeUtc { get; set; }

        public bool CallForPrice { get; set; }

        public decimal Price { get; set; }

        public decimal OldPrice { get; set; }

        public decimal ProductCost { get; set; }

        public decimal? SpecialPrice { get; set; }

        public DateTime? SpecialPriceStartDateTimeUtc { get; set; }

        public DateTime? SpecialPriceEndDateTimeUtc { get; set; }

        public bool CustomerEntersPrice { get; set; }

        public decimal MinimumCustomerEnteredPrice { get; set; }

        public decimal MaximumCustomerEnteredPrice { get; set; }

        public bool BasepriceEnabled { get; set; }

        public decimal BasepriceAmount { get; set; }

        public int BasepriceUnitId { get; set; }

        public decimal BasepriceBaseAmount { get; set; }

        public int BasepriceBaseUnitId { get; set; }

        public bool MarkAsNew { get; set; }

        public DateTime? MarkAsNewStartDateTimeUtc { get; set; }

        public DateTime? MarkAsNewEndDateTimeUtc { get; set; }

        public bool HasTierPrices { get; set; }

        public bool HasDiscountsApplied { get; set; }

        public decimal Weight { get; set; }

        public decimal Length { get; set; }

        public decimal Width { get; set; }

        public decimal Height { get; set; }

        public DateTime? AvailableStartDateTimeUtc { get; set; }

        public DateTime? AvailableEndDateTimeUtc { get; set; }

        public int DisplayOrder { get; set; }

        public bool DisContinued { get; set; }

        public bool Published { get; set; }

        public bool Deleted { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime UpdatedOnUtc { get; set; }

        public string AmazonSKU { get; set; }

        public string WalmartSKU { get; set; }

        public string NeweggSKU { get; set; }

        public string Title { get; set; }

        public string Headline { get; set; }

        public string SubHeadline { get; set; }

        public string Description { get; set; }

        public string TechnicalSpecification { get; set; }
    }
}
