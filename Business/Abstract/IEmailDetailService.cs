using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEmailDetailService
    {
        List<EmailDetail> GetAll();

        void Add(EmailDetail emailDetail);
        void Update(EmailDetail emailDetail);
        void Delete(EmailDetail emailDetail);
    }
}
