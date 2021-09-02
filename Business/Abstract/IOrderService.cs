using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        List<Category> GetAll();
        List<Category> GetById(int categoryId);
    }
}
