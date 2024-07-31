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
        Task<List<EmailDetail>> GetAllAsync();
        Task AddAsync(EmailDetail emailDetail);
        Task UpdateAsync(EmailDetail emailDetail);
        Task DeleteAsync(EmailDetail emailDetail);
    }
}
