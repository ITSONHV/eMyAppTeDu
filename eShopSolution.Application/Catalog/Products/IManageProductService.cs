﻿using eShopSolution.Application.Catalog.DTOS;
using eShopSolution.Application.Catalog.Products.Dtos;
using eShopSolution.Application.Catalog.Products.Dtos.Manage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewcount(int productId);

        Task<PageResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);

        //Task<int> AddImages(int productId, List<IFormFile> files);

       // Task<int> RemoveImages(int imageId);

        //Task<int> UpdateImage(int imageId, string caption, bool isDefault);

        //Task<List<ProductImageViewModel>> GetListImage(int productId);

    }
}
