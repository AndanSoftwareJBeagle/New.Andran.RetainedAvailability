using Andran.RetainedAvailability.DAL.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL
{
    public class RetainedAvailabilityContext : DbContext, IUnitOfWork
    {
        public void Save()
        {
            SaveChanges();
        }
    }
}
