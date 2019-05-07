using Microsoft.AspNetCore.Mvc;
using WorldData.Models;
using System.Collections.Generic;

namespace WorldData.Controllers
{

    public class CitiesController : Controller
    {

        [HttpGet("/countries/{countryid}")]
        public ActionResult Index(string countryid)
        {
            List<City> city = City.GetAll(countryid);
            return View(city);
        }

    }

}
