using MarketPlatform.Core.Domain.Products;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlatform.Data.Mapping.Products
{
    public partial class ProductMap : EntityTypeConfiguration<Product>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public ProductMap()
        {
            this.ToTable("Product");
            this.HasKey(ea => ea.Id);
            this.Property(ea => ea.Name).IsRequired();
            this.Property(ea => ea.CreatedOnUtc).IsRequired();
            this.Property(ea => ea.Deleted).IsRequired();
        }
    }
}
