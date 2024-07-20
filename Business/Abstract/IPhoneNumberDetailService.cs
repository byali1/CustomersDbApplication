using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPhoneNumberDetailService
    {
        List<PhoneNumberDetail> GetAll();
        void Add(PhoneNumberDetail phoneNumberDetail);
        void Update(PhoneNumberDetail phoneNumberDetail);
        void Delete(PhoneNumberDetail phoneNumberDetail);
    }
}
