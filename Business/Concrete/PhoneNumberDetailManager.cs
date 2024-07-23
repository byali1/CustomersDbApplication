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
    public class PhoneNumberDetailManager:IPhoneNumberDetailService
    {
        private IPhoneNumberDetailDal _phoneNumberDetailDal;

        public PhoneNumberDetailManager(IPhoneNumberDetailDal phoneNumberDetailDal)
        {
            _phoneNumberDetailDal = phoneNumberDetailDal;
        }
        public List<PhoneNumberDetail> GetAll()
        {
            return _phoneNumberDetailDal.GetAll();
        }

        public void Add(PhoneNumberDetail phoneNumberDetail)
        {
            _phoneNumberDetailDal.Add(phoneNumberDetail);
        }

        public void Update(PhoneNumberDetail phoneNumberDetail)
        {
            _phoneNumberDetailDal.Update(phoneNumberDetail);
        }

        public void Delete(PhoneNumberDetail phoneNumberDetail)
        {
            _phoneNumberDetailDal.Delete(phoneNumberDetail);
        }
    }
}
