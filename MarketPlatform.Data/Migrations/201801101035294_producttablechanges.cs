namespace MarketPlatform.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class producttablechanges : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Product", "ProductTemplateId");
            DropColumn("dbo.Product", "LimitedToStores");
            DropColumn("dbo.Product", "IsRecurring");
            DropColumn("dbo.Product", "IsShipEnabled");
            DropColumn("dbo.Product", "IsFreeShipping");
            DropColumn("dbo.Product", "ShipSeparately");
            DropColumn("dbo.Product", "AdditionalShippingCharge");
            DropColumn("dbo.Product", "DeliveryDateId");
            DropColumn("dbo.Product", "MinStockQuantity");
            DropColumn("dbo.Product", "BackorderModeId");
            DropColumn("dbo.Product", "AllowBackInStockSubscriptions");
            DropColumn("dbo.Product", "OrderMinimumQuantity");
            DropColumn("dbo.Product", "OrderMaximumQuantity");
            DropColumn("dbo.Product", "AllowedQuantities");
            DropColumn("dbo.Product", "NotReturnable");
            DropColumn("dbo.Product", "DisableBuyButton");
            DropColumn("dbo.Product", "DisableWishlistButton");
            DropColumn("dbo.Product", "AvailableForPreOrder");
            DropColumn("dbo.Product", "PreOrderAvailabilityStartDateTimeUtc");
            DropColumn("dbo.Product", "CallForPrice");
            DropColumn("dbo.Product", "OldPrice");
            DropColumn("dbo.Product", "SpecialPrice");
            DropColumn("dbo.Product", "SpecialPriceStartDateTimeUtc");
            DropColumn("dbo.Product", "SpecialPriceEndDateTimeUtc");
            DropColumn("dbo.Product", "CustomerEntersPrice");
            DropColumn("dbo.Product", "MinimumCustomerEnteredPrice");
            DropColumn("dbo.Product", "MaximumCustomerEnteredPrice");
            DropColumn("dbo.Product", "BasepriceEnabled");
            DropColumn("dbo.Product", "BasepriceAmount");
            DropColumn("dbo.Product", "BasepriceUnitId");
            DropColumn("dbo.Product", "BasepriceBaseAmount");
            DropColumn("dbo.Product", "BasepriceBaseUnitId");
            DropColumn("dbo.Product", "MarkAsNew");
            DropColumn("dbo.Product", "MarkAsNewStartDateTimeUtc");
            DropColumn("dbo.Product", "MarkAsNewEndDateTimeUtc");
            DropColumn("dbo.Product", "HasTierPrices");
            DropColumn("dbo.Product", "HasDiscountsApplied");
            DropColumn("dbo.Product", "Weight");
            DropColumn("dbo.Product", "Length");
            DropColumn("dbo.Product", "Width");
            DropColumn("dbo.Product", "Height");
            DropColumn("dbo.Product", "AvailableStartDateTimeUtc");
            DropColumn("dbo.Product", "AvailableEndDateTimeUtc");
            DropColumn("dbo.Product", "DisplayOrder");
            DropColumn("dbo.Product", "DisContinued");
            DropColumn("dbo.Product", "Published");
            DropColumn("dbo.Product", "Title");
            DropColumn("dbo.Product", "Headline");
            DropColumn("dbo.Product", "SubHeadline");
            DropColumn("dbo.Product", "TechnicalSpecification");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product", "TechnicalSpecification", c => c.String());
            AddColumn("dbo.Product", "SubHeadline", c => c.String());
            AddColumn("dbo.Product", "Headline", c => c.String());
            AddColumn("dbo.Product", "Title", c => c.String());
            AddColumn("dbo.Product", "Published", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "DisContinued", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "DisplayOrder", c => c.Int(nullable: false));
            AddColumn("dbo.Product", "AvailableEndDateTimeUtc", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Product", "AvailableStartDateTimeUtc", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Product", "Height", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Product", "Width", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Product", "Length", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Product", "Weight", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Product", "HasDiscountsApplied", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "HasTierPrices", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "MarkAsNewEndDateTimeUtc", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Product", "MarkAsNewStartDateTimeUtc", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Product", "MarkAsNew", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "BasepriceBaseUnitId", c => c.Int(nullable: false));
            AddColumn("dbo.Product", "BasepriceBaseAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Product", "BasepriceUnitId", c => c.Int(nullable: false));
            AddColumn("dbo.Product", "BasepriceAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Product", "BasepriceEnabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "MaximumCustomerEnteredPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Product", "MinimumCustomerEnteredPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Product", "CustomerEntersPrice", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "SpecialPriceEndDateTimeUtc", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Product", "SpecialPriceStartDateTimeUtc", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Product", "SpecialPrice", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Product", "OldPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Product", "CallForPrice", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "PreOrderAvailabilityStartDateTimeUtc", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Product", "AvailableForPreOrder", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "DisableWishlistButton", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "DisableBuyButton", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "NotReturnable", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "AllowedQuantities", c => c.String());
            AddColumn("dbo.Product", "OrderMaximumQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.Product", "OrderMinimumQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.Product", "AllowBackInStockSubscriptions", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "BackorderModeId", c => c.Int(nullable: false));
            AddColumn("dbo.Product", "MinStockQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.Product", "DeliveryDateId", c => c.Int(nullable: false));
            AddColumn("dbo.Product", "AdditionalShippingCharge", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Product", "ShipSeparately", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "IsFreeShipping", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "IsShipEnabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "IsRecurring", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "LimitedToStores", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "ProductTemplateId", c => c.Int(nullable: false));
        }
    }
}
