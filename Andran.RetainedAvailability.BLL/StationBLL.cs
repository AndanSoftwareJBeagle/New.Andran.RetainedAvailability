using Andran.RetainedAvailability.DAL.Repositories.Base;
using Andran.RetainedAvailability.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.BLL
{
    public class StationBLL
    {
        public IEnumerable<Station> GetStationsByName(string name, bool caseSensitive = true)
        {
            IEnumerable<Station> stations;

            using (var uow = new UnitOfWork())
            {
                if (!caseSensitive)
                    stations = uow.StationRepository.Find(x => x.Name.ToUpper() == name.ToUpper());
                else
                    stations = uow.StationRepository.Find(x => x.Name == name);

                return stations;
            }
        }
    }
}
