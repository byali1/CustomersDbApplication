using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.AdoNet
{
    public class AdoNetCustomerAddressDal:ICustomerAddressDal
    {
        public List<CustomerAddress> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(CustomerAddress customerAddress)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerAddress customerAddress)
        {
            throw new NotImplementedException();
        }

        public void Delete(CustomerAddress customerAddress)
        {
            throw new NotImplementedException();
        }
    }
}
