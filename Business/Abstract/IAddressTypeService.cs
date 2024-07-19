using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAddressTypeService
    {
        List<AddressType> GetAll();
        void Add(AddressType addressType);
        void Update(AddressType addressType);
        void Delete(AddressType addressType);
    }
}
