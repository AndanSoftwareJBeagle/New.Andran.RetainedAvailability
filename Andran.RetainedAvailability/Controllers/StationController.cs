using Andran.RetainedAvailability.BLL;
using Andran.RetainedAvailability.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Andran.RetainedAvailability.Controllers
{
    public class StationController : Controller
    {
        //
        // GET: /Station/

        public ActionResult Index()
        {
            var stationService = new StationBLL();

            var stationViewModel = new StationViewModel
            {
                Stations = stationService.GetStationsByName("Station1")
            };

            return View(stationViewModel);
        }
    }
}
