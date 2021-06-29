using AspNetCoreMVC01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVC01.Services
{
    public interface IProductService
    {
        /// <summary>
        /// 제품 목록 보기
        /// </summary>
        /// <returns></returns>
        List<Product> GetProductList();
        
        /// <summary>
        /// 제품 상세 보기
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Product GetProduct(int Id);
        
        /// <summary>
        /// 제품 추가
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        bool AddProduct(Product product);
        
        /// <summary>
        /// 제품 수정
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        bool EditProduct(Product product);
        
        /// <summary>
        /// 제푸 삭제
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        bool DeleteProduct(int Id);
    }
}
