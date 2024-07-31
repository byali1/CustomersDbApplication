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
    public class EmailDetailManager : IEmailDetailService
    {
        private readonly IEmailDetailDal _emailDetailDal;

        public EmailDetailManager(IEmailDetailDal emailDetailDal)
        {
            _emailDetailDal = emailDetailDal;
        }

        public async Task<List<EmailDetail>> GetAllAsync()
        {
            return await _emailDetailDal.GetAllAsync();
        }

        public async Task AddAsync(EmailDetail emailDetail)
        {
            await _emailDetailDal.AddAsync(emailDetail);
        }

        public async Task UpdateAsync(EmailDetail emailDetail)
        {
            await _emailDetailDal.UpdateAsync(emailDetail);
        }

        public async Task DeleteAsync(EmailDetail emailDetail)
        {
            await _emailDetailDal.DeleteAsync(emailDetail);
        }
    }
}
