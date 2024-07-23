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
    public class EmailDetailManager:IEmailDetailService
    {
        private IEmailDetailDal _emailDetailDal;

        public EmailDetailManager(IEmailDetailDal emailDetailDal)
        {
            _emailDetailDal = emailDetailDal;
        }
        public List<EmailDetail> GetAll()
        {
            return _emailDetailDal.GetAll();
        }

        public void Add(EmailDetail emailDetail)
        {
            _emailDetailDal.Add(emailDetail);
        }

        public void Update(EmailDetail emailDetail)
        {
            _emailDetailDal.Update(emailDetail);
        }

        public void Delete(EmailDetail emailDetail)
        {
            _emailDetailDal.Delete(emailDetail);
        }
    }
}
