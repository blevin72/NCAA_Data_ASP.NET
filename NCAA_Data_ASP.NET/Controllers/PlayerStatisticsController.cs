using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NCAA_Data;

namespace NCAA_Data_ASP.NET.Controllers
{
    public class PlayerStatisticsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            PlayerStatistics playerStatistics = new PlayerStatistics();
            return View(playerStatistics);
        }
    }
}

