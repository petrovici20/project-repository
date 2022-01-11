using Dashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PatientService;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dashboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            JsonSerializerOptions jsonDeserializerOptions = new() { PropertyNameCaseInsensitive = true };
            var patients = JsonSerializer.Deserialize<List<PatientClient>>(PatientConnection.GetPatients(), jsonDeserializerOptions);

            var divisionRNCCI = new List<int>();
            var divisionUnit = new List<int>();

            var RNCCI = patients.Select(x => x.RNCCITypology).Distinct();
            var Unit = patients.Select(x => x.HospitalUnit).Distinct();

            foreach(var item in RNCCI)
            {
                divisionRNCCI.Add(patients.Count(x => x.RNCCITypology.Equals(item)));
            }

            foreach (var item in Unit)
            {
                divisionUnit.Add(patients.Count(x => x.HospitalUnit.Equals(item)));
            }

            var rep1 = divisionRNCCI;
            var rep2 = divisionUnit;

            ViewBag.RNCCI = RNCCI;
            ViewBag.Unit = Unit;

            ViewBag.REP1 = rep1.ToList();
            ViewBag.REP2 = rep2.ToList();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
