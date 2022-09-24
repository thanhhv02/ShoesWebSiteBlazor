﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PoPoy.Api.Data;
using PoPoy.Shared.Dto;
using PoPoy.Shared.Paging;
using PoPoy.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PoPoy.Api.Services.ProductService
{

    public class ProductServices : IProductServices
    {
        private readonly DataContext _dataContext;
        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _configuration;

        public ProductServices(DataContext dataContext,
                                IWebHostEnvironment env,
                                IConfiguration configuration)
        {
            _dataContext = dataContext;
            _env = env;
            this._configuration = configuration;
        }

        public async Task<PagedList<Product>> GetAll(ProductParameters productParameters)
        {
            using (_dataContext)
            {
                var list_product = await _dataContext.Products.Include(x => x.ProductImages).ToListAsync();
                return PagedList<Product>
                            .ToPagedList(list_product, productParameters.PageNumber, productParameters.PageSize);
            }
        }
        public async Task<ServiceResponse<Product>> Get(int id)
        {
            using (_dataContext)
            {
                var product = await _dataContext.Products.Include(x => x.ProductImages)
                    .Include(x => x.ProductInCategories)
                    .ThenInclude(x => x.Category).FirstOrDefaultAsync(x => x.Id == id);
                product.Views++;
                await _dataContext.SaveChangesAsync();
                var response = new ServiceResponse<Product>
                {
                    Data = product
                };
                return response;
            }
        }

        public async Task<List<ProductVM>> GetAllProducts()
        {
            var query = from p in _dataContext.Products
                        join pic in _dataContext.ProductInCategories on p.Id equals pic.ProductId into ppic
                        from pic in ppic.DefaultIfEmpty()
                        join c in _dataContext.Categories on pic.CategoryId equals c.Id into picc
                        from c in picc.DefaultIfEmpty()
                        join pi in _dataContext.ProductImages on p.Id equals pi.ProductId into ppi
                        from pi in ppi.DefaultIfEmpty()
                        select new { p, pic, pi };

            return await query.Select(x => new ProductVM()
            {
                Id = x.p.Id,
                Title = x.p.Title,
                DateCreated = x.p.DateCreated,
                Description = x.p.Description,
                OriginalPrice = x.p.OriginalPrice,
                Price = x.p.Price,
                Stock = x.p.Stock,
                Views = x.p.Views,
                ThumbnailImage = x.pi.ImagePath
            }).ToListAsync();
        }

        public async Task<ProductVM> GetById(int productId)
        {
            var product = await _dataContext.Products.Include(x => x.ProductImages).FirstOrDefaultAsync(x => x.Id == productId);

            var categories = await (from c in _dataContext.Categories
                                    join p in _dataContext.Products on c.Id equals p.CategoryId
                                    where p.Id == productId
                                    select c.Name).ToListAsync();

            var productViewModel = new ProductVM()
            {
                Id = product.Id,
                Title = product.Title,
                DateCreated = product.DateCreated,
                Description = product.Description,
                OriginalPrice = product.OriginalPrice,
                Price = product.Price,
                Stock = product.Stock,
                Views = product.Views,
                Categories = categories,
                ProductImages = product.ProductImages
            };
            return productViewModel;
        }
        public async Task<bool> CreateProduct(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
                Title = request.Title,
                OriginalPrice = request.OriginalPrice,
                Description = request.Description,
                Stock = request.Stock,
                Views = 0,
                Quantity = request.Quantity,
                DateCreated = DateTime.Now
            };

            _dataContext.Products.Add(product);
            var result = await _dataContext.SaveChangesAsync();
            if (result == 1)
            {
                return true;
            }
            return false;
        }
        public async Task<bool> UpdateProduct(ProductUpdateRequest request)
        {
            var product = await _dataContext.Products.FindAsync(request.Id);

            product.Title = request.Title;
            product.Description = request.Description;
            product.Stock = request.Stock;
            product.Quantity = request.Quantity;
            product.Price = request.Price;
            product.OriginalPrice = request.OriginalPrice;

            _dataContext.Products.Update(product);
            var result = await _dataContext.SaveChangesAsync();
            if (result == 1)
            {
                return true;
            }
            return false;
        }

        public async Task<int> DeleteProduct(int productId)
        {
            var product = await _dataContext.ProductImages.FirstOrDefaultAsync(x=>x.Id == productId);
            if (product == null) throw new Exception($"Cannot find image: {productId}");


            _dataContext.ProductImages.Remove(product);

            return await _dataContext.SaveChangesAsync();
        }

        public async ValueTask<List<Product>> FilterAllByIdsAsync(int[] ids)
        {
            using (_dataContext)
            {
                return await _dataContext.Products.Where(x => ids.Contains(x.Id)).Include(x => x.ProductImages).ToListAsync();
            }
        }

        public async Task<List<ProductVM>> SearchProduct(string searchText)
        {
            var query = from p in _dataContext.Products
                        where p.Title.ToLower().Contains(searchText.ToLower())
                        select new { p };

            var categories = await (from c in _dataContext.Categories
                                    join pic in _dataContext.ProductInCategories on c.Id equals pic.CategoryId
                                    select c.Name).ToListAsync();

            return await query.Select(x => new ProductVM()
            {
                Id = x.p.Id,
                Stock = x.p.Stock,
                Title = x.p.Title,
                Description = x.p.Description,
                Price = x.p.Price,
                OriginalPrice = x.p.OriginalPrice,
                Views = x.p.Views,
                Categories = categories
            }).ToListAsync();
        }
        public async Task<ServiceResponse<List<UploadResult>>> UploadProductImage(List<IFormFile> files, int productId)
        {
            List<UploadResult> uploadResults = new List<UploadResult>();

            foreach (var file in files)
            {
                var uploadResult = new UploadResult();
                //string trustedFileNameForFileStorage;
                var untrustedFileName = file.FileName;
                uploadResult.FileName = untrustedFileName;
                //var trustedFileNameForDisplay = WebUtility.HtmlEncode(untrustedFileName);

                //trustedFileNameForFileStorage = Path.GetRandomFileName();
                var path = Path.Combine(_env.ContentRootPath, "wwwroot/uploads", untrustedFileName);

                await using FileStream fs = new(path, FileMode.Create);
                await file.CopyToAsync(fs);

                uploadResult.StoredFileName = untrustedFileName;
                uploadResult.ContentType = file.ContentType;
                uploadResults.Add(uploadResult);

                var productImg = new ProductImage()
                {
                    ProductId = productId,
                    ImagePath = _configuration["ApiUrl"] + "/uploads/" + untrustedFileName,
                    DateCreated = DateTime.Now,
                    FileSize = file.Length
                };
                _dataContext.ProductImages.Add(productImg);
            }

            await _dataContext.SaveChangesAsync();

            return new ServiceSuccessResponse<List<UploadResult>>(uploadResults);
        }

        public async Task<bool> DeleteProductImage(int productId)
        {
            var images = _dataContext.ProductImages.Where(i => i.Id == productId).FirstOrDefault();
            if (images == null)
                return false;
            _dataContext.Remove(images);
            await _dataContext.SaveChangesAsync();
            var GET_FILE_NAME_FROM_PATH = images.ImagePath.Replace(_configuration["ApiUrl"] + "/", "");
            var path = Path.Combine(_env.ContentRootPath, "wwwroot/uploads", GET_FILE_NAME_FROM_PATH);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            return true;
        }

        public async Task<ServiceResponse<bool>> CategoryAssign(int id, CategoryAssignRequest request)
        {
            var product = await _dataContext.Products.FindAsync(id);
            if (product == null)
            {
                return new ServiceErrorResponse<bool>($"Sản phẩm với id {id} không tồn tại");
            }
            foreach (var category in request.Categories)
            {
                var productInCategory = await _dataContext.ProductInCategories
                    .FirstOrDefaultAsync(x => x.CategoryId == int.Parse(category.Id)

                    && x.ProductId == id);
                if (productInCategory != null && category.Selected == false)
                {
                    _dataContext.ProductInCategories.Remove(productInCategory);
                }
                else if (productInCategory == null && category.Selected)
                {
                    await _dataContext.ProductInCategories.AddAsync(new ProductInCategory()
                    {
                        CategoryId = int.Parse(category.Id),
                        ProductId = id
                    });
                    product.CategoryId = int.Parse(category.Id);
                    _dataContext.Products.Update(product);
                }
            }
            await _dataContext.SaveChangesAsync();
            return new ServiceSuccessResponse<bool>();
        }
        public async Task<PagedList<Product>> GetProductsByCategory(ProductParameters productParameters, string categoryUrl)
        {
            var list_product = await (from p in _dataContext.Products
                                      join pic in _dataContext.ProductInCategories on p.Id equals pic.ProductId into ppic
                                      from pic in ppic.DefaultIfEmpty()
                                      join c in _dataContext.Categories on pic.CategoryId equals c.Id into picc
                                      from c in picc.DefaultIfEmpty()
                                      where c.Url == categoryUrl                                     
                                      select p).Include(x=>x.ProductImages).ToListAsync();
            return PagedList<Product>
                            .ToPagedList(list_product, productParameters.PageNumber, productParameters.PageSize);
        }
    }
}
