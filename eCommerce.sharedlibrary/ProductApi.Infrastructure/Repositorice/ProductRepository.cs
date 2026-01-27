using Ecommerces.sherd.Responses;
using ProductApi.Application.Interface;
using ProductApi.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ProductApi.Infrastructure.Repositorice
{
    internal class ProductRepository : IProduct
    {
        public Task<Response> CreateAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<Response> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByAsync(Expression<Func<Product, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
