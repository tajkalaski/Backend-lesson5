using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lesson05.Controllers
{


    public class Ex01Controller : Controller
    {
        // GET: /<controller>/
        private CountryRepository countryRepository;
        private List<SelectListItem> countriesDropdown = new List<SelectListItem>();

        public Ex01Controller(CountryRepository repo)
        {
            countryRepository = repo;
        }

        public IActionResult Index(string country)
        {

            ViewData["Title"] = "Countries";
            ViewData["CountryCode"] = country;

            foreach (Country item in countryRepository.Countries)
            {
                // if there is a country parameter in the URL
                if (!String.IsNullOrEmpty(country))
                {
                    // if the country from the countries List we're looking at right
                    //now has the same country code value given as the parameter
                    if (item.CountryCode == country)
                    {
                        // mark the SelectLisItem as seleced
                        countriesDropdown.Add(
                            new SelectListItem
                            {
                                Text = item.Name,
                                Value = item.CountryCode,
                                Selected = true
                            }
                        );
                    }

                    else
                    {
                        // otherwise it should not be marked as selected
                        countriesDropdown.Add(
                            new SelectListItem
                            {
                                Text = item.Name,
                                Value = item.CountryCode
                            }
                        );
                    }
                }


                else
                {
                    // if no country parameter is given, no SelectLisItem should be marked as
                    //seleced
                    countriesDropdown.Add(
                        new SelectListItem
                        {
                            Text = item.Name,
                            Value = item.CountryCode
                        }
                    );
                }
            }

            ViewData["Countries"] = countriesDropdown;
            ViewData["Title"] = "Country";

            return View();
        }


        [HttpPost]
        public IActionResult Index(Country newCountry)
        {
            // Add the new country to the repository
            countryRepository.AddCountry(newCountry);
            // loop though the list for countries
            foreach (Country item in countryRepository.Countries)
            {
                // add new selectitem elements to the countriesDropdown list
                // make element selected if it is an element with newCountry ConutryCode
                if (item.CountryCode == newCountry.CountryCode)
                {
                    countriesDropdown.Add(new SelectListItem
                    {
                        Text = item.Name,
                        Value =
                   item.CountryCode,
                        Selected = true
                    });
                }
                else
                {
                    countriesDropdown.Add(new SelectListItem
                    {
                        Text = item.Name,
                        Value =
                   item.CountryCode
                    });
                }
            }
            ViewData["Countries"] = countriesDropdown;
            return View(newCountry);
        }

    }


}
