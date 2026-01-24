using ProductApi.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApi.Application.DTOs.Conversion
{
    public static class ProductConversion
    {
        public static Product ToEntity(ProductDto product) => new()
        {
            Id = product.Id,
            Name = product.Name,
            Quantity = product.Quantity,
            Price = product.Price
        };
        public static(ProductDto?, IEnumerable<ProductDto>?) FromEntity(Product product, IEnumerable<Product>? products)
        {
            if(product is not null || products is null)
            {
                var singleProduct = new ProductDto
                (product!.Id,
                 product.Name!,
                 product.Quantity,
                 product.Price);
            }
        }
    }
}
