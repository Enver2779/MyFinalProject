using Core.DataAccess.EntityFramwork;
using DataAccess.Abtract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : IEntityRepositoryBase<Category, NorthwindContext>,ICategoryDal
    {     
        
    }
}
