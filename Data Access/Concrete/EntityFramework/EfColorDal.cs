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
    public class EfColorDal : EfEntityRepositoryBase<Color, ReCapContext>, IColorDal
    {
        public List<ColorDetailDto> GetColorDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from co in context.Colors
                             select new ColorDetailDto { ColorId = co.ColorId, ColorName = co.ColorName};

                return result.ToList();
            }
        }
        
    }
}
