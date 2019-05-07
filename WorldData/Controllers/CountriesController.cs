using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WorldData.Models;

namespace WorldData.Controllers
{

    public class CountriesController : Controller
    {

        [HttpGet("/countries")]
        public ActionResult Index()
        {
            List<Country> allCountries = Country.GetAll();
            return View(allCountries);
        }

        // [HttpGet("/countries/{id}")]
        // public ActionResult Show(string id)
        // {
        //     List<Country> country = Country.GetAll();
        //     return View(country);
        // }

    }

}
