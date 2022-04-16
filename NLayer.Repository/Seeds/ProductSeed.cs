﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Name = "Kalem 1", CategoryId = 1, Price = 100, Stock = 20, CreatedDate = DateTime.Now },
                new Product { Id = 2, Name = "Kalem 2", CategoryId = 1, Price = 20, Stock = 30, CreatedDate = DateTime.Now },
                new Product { Id = 3, Name = "Kalem 3", CategoryId = 1, Price = 50, Stock = 20, CreatedDate = DateTime.Now },
                new Product { Id = 1, Name = "Kitap 1", CategoryId = 2, Price = 100, Stock = 20, CreatedDate = DateTime.Now },
                new Product { Id = 2, Name = "Kitap 2", CategoryId = 2, Price = 20, Stock = 30, CreatedDate = DateTime.Now },
                new Product { Id = 3, Name = "Kitap 3", CategoryId = 2, Price = 50, Stock = 20, CreatedDate = DateTime.Now },
                new Product { Id = 1, Name = "Defter 1", CategoryId = 3, Price = 100, Stock = 20, CreatedDate = DateTime.Now },
                new Product { Id = 2, Name = "Defter 2", CategoryId = 3, Price = 20, Stock = 30, CreatedDate = DateTime.Now },
                new Product { Id = 3, Name = "Defter 3", CategoryId = 3, Price = 50, Stock = 20, CreatedDate = DateTime.Now }
                );
        }
    }
}
