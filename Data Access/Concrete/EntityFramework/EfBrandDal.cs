using Core.Data_Access.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, ReCapContext>, IBrandDal
    {
        public List<BrandDetailDto> GetBrandDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from b in context.Brands
                             select new BrandDetailDto { BrandId = b.BrandId, BrandName = b.BrandName};

                return result.ToList();
            }
        }

    }
}
