﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IDbContext
    {
        void OpenConnectionIfClosed();
        void CloseConnectionIfOpen();
        SqlConnection GetConnection();
    }

}
