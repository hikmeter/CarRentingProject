using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Results.CarPricingResults;
using UdemyCarBook.Application.Interfaces.CarPricingInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.CarPricingRepositories
{
    public class CarPricingRepository : ICarPricingRepository
    {
        private readonly CarBookContext _context;
        public CarPricingRepository(CarBookContext context)
        {
            _context = context;
        }
        public List<CarPricing> GetCarPricingsWithCars()
        {
            var values = _context.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand).Include(x => x.Pricing).Where(z => z.PricingID == 1).ToList();
            return values;
        }
        public List<GetCarPricingsWithTimePeriodsQueryResult> GetCarPricingsWithTimePeriods()
        {
            var values = (from cp in _context.CarPricings
                          join c in _context.Cars on cp.CarID equals c.CarID
                          join b in _context.Brands on c.BrandID equals b.BrandID
                          group cp by new { BrandModel = b.Name + " " + c.Model, c.CoverImageUrl } into g
                          select new GetCarPricingsWithTimePeriodsQueryResult
                          {
                              BrandModel = g.Key.BrandModel,
                              CoverImageUrl = g.Key.CoverImageUrl,
                              DailyAmount = g.Where(x => x.PricingID == 1).Sum(y => y.Amount),
                              WeeklyAmount = g.Where(x => x.PricingID == 2).Sum(y => y.Amount),
                              MonthlyAmount = g.Where(x => x.PricingID == 3).Sum(y => y.Amount)
                          }).ToList();
            return values;
        }
    }
}
