using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerPhoneNumberService
    {
        List<CustomerPhoneNumber> GetAll();
        void Add(CustomerPhoneNumber customerPhoneNumber);
        void Update(CustomerPhoneNumber customerPhoneNumber);
        void Delete(CustomerPhoneNumber customerPhoneNumber);
    }
}
