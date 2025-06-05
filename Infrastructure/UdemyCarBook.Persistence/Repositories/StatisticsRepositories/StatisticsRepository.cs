using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Interfaces.StatisticsInterfaces;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.StatisticsRepositories
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly CarBookContext _context;
        public StatisticsRepository(CarBookContext context)
        {
            _context = context;
        }
        public int GetAuthorCount()
        {
            var value = _context.Authors.Count();
            return value;
        }
        public int GetAutomaticTransmissionCarCount()
        {
            var value = _context.Cars.Count(x => x.Transmission == "Otomatik");
            return value;
        }
        public decimal GetAverageDailyRentPrice()
        {
            var value = _context.CarPricings.Where(y => y.PricingID == 1).Average(x => x.Amount);
            return value;
        }
        public decimal GetAverageMonthlyRentPrice()
        {
            var value = _context.CarPricings.Where(y => y.PricingID == 3).Average(x => x.Amount);
            return value;
        }
        public decimal GetAverageWeeklyRentPrice()
        {
            var value = _context.CarPricings.Where(y => y.PricingID == 2).Average(x => x.Amount);
            return value;
        }
        public int GetBlogCount()
        {
            var value = _context.Blogs.Count();
            return value;
        }
        public string GetBlogWithMostComments()
        {
            var value = (from  b in _context.Blogs
                         join c in _context.Comments on b.BlogID equals c.BlogID
                         group c by b.Title into grouped
                         orderby grouped.Count() descending
                         select grouped.Key).FirstOrDefault();
            return value;
        }
        public int GetBrandCount()
        {
            var value = _context.Brands.Count();
            return value;
        }
        public string GetBrandWithMostCars()
        {
            var value = (from b in _context.Brands
                         join c in _context.Cars on b.BrandID equals c.BrandID
                         group c by b.Name into grouped
                         orderby grouped.Count() descending
                         select grouped.Key).FirstOrDefault();
            return value;
        }
        public int GetCarCount()
        {
            var value = _context.Cars.Count();
            return value;
        }
        public int GetCarCountElectricFuel()
        {
            var value = _context.Cars.Count(x => x.Fuel == "Elektrik");
            return value;
        }
        public int GetCarCountWithGasolineOrDiesel()
        {
            var value = _context.Cars.Count(x => x.Fuel == "Benzin" || x.Fuel == "Dizel");
            return value;
        }
        public int GetCarCountWithLessThan10000Km()
        {
            var value = _context.Cars.Count(x => x.Km < 10000);
            return value;
        }
        public string GetCheapestCarByDailyRent()
        {
            var value = (from cp in _context.CarPricings
                         join c in _context.Cars on cp.CarID equals c.CarID
                         join b in _context.Brands on c.BrandID equals b.BrandID
                         where cp.PricingID == 1
                         orderby cp.Amount ascending
                         select b.Name).FirstOrDefault();
            return value;
        }
        public int GetLocationCount()
        {
            var value = _context.Locations.Count();
            return value;
        }
        public string GetMostExpensiveCarByDailyRent()
        {
            var value = (from cp in _context.CarPricings
                         join c in _context.Cars on cp.CarID equals c.CarID
                         join b in _context.Brands on c.BrandID equals b.BrandID
                         where cp.PricingID == 1
                         orderby cp.Amount descending
                         select b.Name).FirstOrDefault();
            return value;
        }
    }
}
