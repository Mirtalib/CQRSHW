﻿using EShop.Application.Repositories.ProductRepository;
using EShop.Domain.Entities;
using EShop.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Persistence.Repositories.ProductRepositoy
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(EShopDbContext context) : base(context)
        {
        }
    }
}
