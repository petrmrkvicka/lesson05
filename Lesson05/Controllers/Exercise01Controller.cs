using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson05.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson05.Controllers
{
    public class Exercise01Controller : Controller
    {

        private CountryRepository countryRepository;
        private List<SelectListItem> countriesDropdown = new List<SelectListItem>();

        public Exercise01Controller(CountryRepository repo) => countryRepository = repo;

        [HttpPost]
        public IActionResult Index(Country newCountry)
        {
            countryRepository.AddCountry(newCountry);
            foreach(Country item in countryRepository.Countries)
            {
                if(item.CountryCode == newCountry.CountryCode)
                {
                    countriesDropdown.Add(new SelectListItem { Text = item.CountryName, Value = item.CountryCode, Selected = true });
                } else
                {
                    countriesDropdown.Add(new SelectListItem { Text = item.CountryName, Value = item.CountryCode });
                }
            }
            ViewData["Countries"] = countriesDropdown;

            return View(newCountry);
        }


        // GET: /<controller>/
        public IActionResult Index(string country)
        {
            foreach (Country item in countryRepository.Countries)
            {
                if (!String.IsNullOrEmpty(country))
                {
                    if(item.CountryCode == country)
                    {
                        countriesDropdown.Add(new SelectListItem { Text = item.CountryName, Value = item.CountryCode, Selected = true });
                    }
                    else
                    {
                        countriesDropdown.Add(new SelectListItem { Text = item.CountryName, Value = item.CountryCode });
                    }
                }
                else
                {
                    countriesDropdown.Add(new SelectListItem { Text = item.CountryName, Value = item.CountryCode });
                }
            }

            ViewData["Countries"] = countriesDropdown;
            ViewData["Title"] = "Country";
            ViewData["CountryCode"] = country;

            return View();
        }
    }
}
