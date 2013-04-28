using Andran.RetainedAvailability.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Repositories.Base
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private RetainedAvailabilityContext context = new RetainedAvailabilityContext();
        private RetainedAvailabilityRepository<Station> stationRepository;

        public RetainedAvailabilityRepository<Station> StationRepository
        {
            get
            {
                if (this.stationRepository == null)
                {
                    this.stationRepository = new RetainedAvailabilityRepository<Station>(context);
                }
                return stationRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    this.context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
