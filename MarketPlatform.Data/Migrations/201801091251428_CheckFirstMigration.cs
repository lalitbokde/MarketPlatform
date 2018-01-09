namespace MarketPlatform.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CheckFirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ShortDescription = c.String(),
                        FullDescription = c.String(),
                        ProductTemplateId = c.Int(nullable: false),
                        VendorId = c.Int(nullable: false),
                        LimitedToStores = c.Boolean(nullable: false),
                        Sku = c.String(),
                        ManufacturerPartNumber = c.String(),
                        UPC = c.String(),
                        Gtin = c.String(),
                        IsRecurring = c.Boolean(nullable: false),
                        IsShipEnabled = c.Boolean(nullable: false),
                        IsFreeShipping = c.Boolean(nullable: false),
                        ShipSeparately = c.Boolean(nullable: false),
                        AdditionalShippingCharge = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DeliveryDateId = c.Int(nullable: false),
                        UseMultipleWarehouses = c.Boolean(nullable: false),
                        WarehouseId = c.Int(nullable: false),
                        StockQuantity = c.Int(nullable: false),
                        MinStockQuantity = c.Int(nullable: false),
                        BackorderModeId = c.Int(nullable: false),
                        AllowBackInStockSubscriptions = c.Boolean(nullable: false),
                        OrderMinimumQuantity = c.Int(nullable: false),
                        OrderMaximumQuantity = c.Int(nullable: false),
                        AllowedQuantities = c.String(),
                        NotReturnable = c.Boolean(nullable: false),
                        DisableBuyButton = c.Boolean(nullable: false),
                        DisableWishlistButton = c.Boolean(nullable: false),
                        AvailableForPreOrder = c.Boolean(nullable: false),
                        PreOrderAvailabilityStartDateTimeUtc = c.DateTime(precision: 7, storeType: "datetime2"),
                        CallForPrice = c.Boolean(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OldPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SpecialPrice = c.Decimal(precision: 18, scale: 2),
                        SpecialPriceStartDateTimeUtc = c.DateTime(precision: 7, storeType: "datetime2"),
                        SpecialPriceEndDateTimeUtc = c.DateTime(precision: 7, storeType: "datetime2"),
                        CustomerEntersPrice = c.Boolean(nullable: false),
                        MinimumCustomerEnteredPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaximumCustomerEnteredPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BasepriceEnabled = c.Boolean(nullable: false),
                        BasepriceAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BasepriceUnitId = c.Int(nullable: false),
                        BasepriceBaseAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BasepriceBaseUnitId = c.Int(nullable: false),
                        MarkAsNew = c.Boolean(nullable: false),
                        MarkAsNewStartDateTimeUtc = c.DateTime(precision: 7, storeType: "datetime2"),
                        MarkAsNewEndDateTimeUtc = c.DateTime(precision: 7, storeType: "datetime2"),
                        HasTierPrices = c.Boolean(nullable: false),
                        HasDiscountsApplied = c.Boolean(nullable: false),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Length = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Width = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AvailableStartDateTimeUtc = c.DateTime(precision: 7, storeType: "datetime2"),
                        AvailableEndDateTimeUtc = c.DateTime(precision: 7, storeType: "datetime2"),
                        DisplayOrder = c.Int(nullable: false),
                        DisContinued = c.Boolean(nullable: false),
                        Published = c.Boolean(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        CreatedOnUtc = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UpdatedOnUtc = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        AmazonSKU = c.String(),
                        WalmartSKU = c.String(),
                        NeweggSKU = c.String(),
                        Title = c.String(),
                        Headline = c.String(),
                        SubHeadline = c.String(),
                        Description = c.String(),
                        TechnicalSpecification = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Product");
        }
    }
}
