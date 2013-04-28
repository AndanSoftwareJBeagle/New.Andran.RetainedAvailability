﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Repositories.Base
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
