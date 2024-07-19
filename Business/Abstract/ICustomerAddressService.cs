﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerAddressService
    {
        List<CustomerAddress> GetAll();
        void Add(CustomerAddress customerAddress);
        void Update(CustomerAddress customerAddress);
        void Delete(CustomerAddress customerAddress);
    }
}
