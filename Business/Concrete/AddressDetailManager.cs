using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AddressDetailManager :IAddressDetailService
    {
        private IAddressDetailDal _addressDetailDal;

        public AddressDetailManager(IAddressDetailDal addressDetailDal)
        {
            _addressDetailDal = addressDetailDal;
        }
        public List<AddressDetail> GetAll()
        {
            return _addressDetailDal.GetAll();
        }

        public void Add(AddressDetail addressDetail)
        {
            _addressDetailDal.Add(addressDetail);
        }

        public void Update(AddressDetail addressDetail)
        {
            _addressDetailDal.Update(addressDetail);
        }

        public void Delete(AddressDetail addressDetail)
        {
            _addressDetailDal.Delete(addressDetail);
        }
    }
}
