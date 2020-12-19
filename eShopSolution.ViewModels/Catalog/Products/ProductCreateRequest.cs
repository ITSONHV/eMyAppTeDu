using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class ProductCreateRequest
    {
        [Display(Name = "Giá bán")]
        public decimal Price { set; get; }

        [Display(Name = "Giá nhập")]
        public decimal OriginalPrice { set; get; }

        [Display(Name = "Số lượng tồn")]
        public int Stock { set; get; }

        [Display(Name = "Tên sản phẩm")]
        [Required(ErrorMessage = "Tên sản phẩm không được bỏ trống")]
        public string Name { set; get; }

        [Display(Name = "Mô tả sản phẩm")]
        public string Description { set; get; }

        [Display(Name = "Chi tiết sản phẩm")]
        public string Details { set; get; }

        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }

        public string SeoAlias { get; set; }

        [Display(Name = "Mã ngôn ngữ")]
        public string LanguageId { set; get; }

        [Display(Name = "Hình ảnh")]
        public IFormFile ThumbnailImage { get; set; }
    }
}