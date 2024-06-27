﻿using JewelryProduction.BusinessObject.Filter;
using JewelryProduction.BusinessObject.Models;
using JewelryProduction.BusinessObject.Paginate;
using JewelryProduction.Service.Request.Product;
using JewelryProduction.Service.Response.Product;
using JewelryProduction.Service.Response.ProductStone;
using JewelryProduction.Service.Response.ProductType;
using static JewelryProduction.Service.Constant.ApiEndPointConstant;

namespace JewelryProduction.Service.Service.ProductsImpl;

public interface IProductService
{
    GetProductResponse CreateProduct(GetProductRequest request);
    bool ChangeProductStatus(Guid id);
    GetProductResponse GetProductById(Guid id);
    PagingModel<GetProductResponse> GetProducts(FilterModel filterModel);
    List<GetProductResponse> GetProductsByMaterialId (Guid id);
    GetProductTypeResponse GetProductTypeById(Guid productTypeId);
    List<GetProductStoneResponse> GetProductStones(Guid productId);
    bool UpdateProduct(Guid id, GetProductRequest request);
    int GetTotalProducts();
    List<GetProductResponse> GetProductsActive();
    List<GetProductResponse> SearchProductByProductTypeName(string product_type_name);
    List<GetProductResponse> SearchProductByProductCode(string product_code);
    List<GetProductResponse> SearchProductByMaterialName(string material_name);
    List<GetProductResponse> SearchProductByCounterName(string counter_name);
    List<GetProductResponse> SearchProductsByPrice(decimal priceFrom, decimal priceTo);
    List<GetProductResponse> SearchSort(string counter_name, string product_code, string product_type, string material);
}