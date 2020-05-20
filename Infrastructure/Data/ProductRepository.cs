using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext context;

        public ProductRepository(StoreContext context)
        {
            this.context = context;
        }

        public async Task<ProductBrand> GetProductBrandByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync()
        {
            return await context.ProductBrands.ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await context.Products
                                .Include(p => p.ProductType)
                                .Include(p => p.ProductBrand)
                                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await context.Products
                                .Include(p => p.ProductType)
                                .Include(p => p.ProductBrand)
                                .ToListAsync();
        }

        public Task<ProductType> GetProductTypeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<ProductType>> GetProductTypesAsync()
        {
            return await context.ProductTypes.ToListAsync();
        }
    }
}
