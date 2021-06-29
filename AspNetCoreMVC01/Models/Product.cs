using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVC01.Models
{
    [Keyless]
    public class Product
    {
        /// <summary>
        /// 제품 번호
        /// </summary>
        /// 
        public int Id { get; set; }

        /// <summary>
        /// 제품 이름
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 제품 가격
        /// </summary>
        public decimal Price { get; set; }
    }
}
