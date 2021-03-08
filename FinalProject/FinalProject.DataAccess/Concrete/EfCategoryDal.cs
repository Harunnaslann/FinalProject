using FinalProject.Core.DataAccess.EntityFramework;
using FinalProject.DataAccess.Abstract;
using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.DataAccess.Concrete
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,FinalContext>,ICategoryDal
    {

    }
}
