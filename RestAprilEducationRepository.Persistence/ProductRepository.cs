using RestAprilEducationRepository.Application.Products;
using RestAprilEducationRepository.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAprilEducationRepository.Persistence
{
    public class ProductRepository(AppDbContext context) : GenericRepository<Product>(context), IProductRepository
    {
        public Task<List<Product>> GetAllWithPagedAsync(int pageNumber, int pageSize)
        {
            return _dbSet.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        public Task<Product?> AnyAsync(string name)
        {
            return _dbSet.FirstOrDefaultAsync(p => p.Name == name);
        }
    }
}
