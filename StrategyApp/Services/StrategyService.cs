using Microsoft.EntityFrameworkCore;
using StrategyApp.Data;
using StrategyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyApp.Services
{
    public class StrategyService
    {
        private ApplicationDbContext _dbContext;

        public StrategyService(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public void AddCountry(Country country)
        {
            _dbContext.Add(country);
            _dbContext.SaveChanges();
        }

        public void DeleteCountry(Country country)
        {
            _dbContext.Country.Remove(country);
        }

        public IEnumerable<Country> GetAllCountries()
        {
            return _dbContext.Country
                .Include(c => c.CountryUnits)
                .ThenInclude(cu => cu.Unit)
                .Include(c => c.CountryProjects)
                .ThenInclude(cp => cp.Project)
                .ToList();
        }

        public Country GetCountryById(int id)
        {
            return _dbContext.Country.Where(c => c.Id == id).SingleOrDefault();
        }
    }
}
