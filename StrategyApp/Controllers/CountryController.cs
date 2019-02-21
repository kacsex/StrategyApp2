using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StrategyApp.Data;
using StrategyApp.Dtos;
using StrategyApp.Models;
using StrategyApp.Services;

namespace StrategyApp.Controllers
{
    public class CountryController : Controller
    {
        public readonly StrategyService _service;

        public CountryController(ApplicationDbContext dbContext, StrategyService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Selectcountry(int id)
        {
            var tempCountry = _service.GetCountryById(id);
            if (tempCountry == null)
            {
                return NotFound();
            }
            CountryDto countryDto = new CountryDto(tempCountry);
            return View(countryDto);
        }

        [HttpGet]
        public IActionResult GetCountries()
        {
            var tempCountries = _service.GetAllCountries();
            if (tempCountries == null)
            {
                return NotFound();
            }
            List<CountryDto> dtoList = new List<CountryDto>();
            foreach(Country c in tempCountries)
            {
                dtoList.Add(new CountryDto(c));
            }
            return View(dtoList);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PostCountry(Country country)
        {
            _service.AddCountry(country);

            return View(new CountryDto(country));
        }
    }
}