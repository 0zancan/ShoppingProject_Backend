using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        public IDataResult<List<Order>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Order> GetById(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
