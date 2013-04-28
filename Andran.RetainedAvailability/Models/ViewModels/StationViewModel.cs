using Andran.RetainedAvailability.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Andran.RetainedAvailability.Models.ViewModels
{
    public class StationViewModel
    {
        public IEnumerable<Station> Stations { get; set; }
    }
}