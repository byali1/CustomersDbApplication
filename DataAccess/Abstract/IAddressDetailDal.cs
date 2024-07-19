using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAddressDetailDal
    {
        List<AddressDetail> GetAll();
        void Add(AddressDetail addressDetail);
        void Update(AddressDetail addressDetail);
        void Delete(AddressDetail addressDetail);
    }
}
