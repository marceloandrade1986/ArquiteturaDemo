﻿using ArquiteturaDemo.Domain.Entities;
using ArquiteturaDemo.Domain.Interfaces;

namespace ArquiteturaDemo.Application
{
    public class ProductApplication: ApplicationBase
    {
        private readonly IProductRepository _productRepository;

        public ProductApplication(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
    }
}
