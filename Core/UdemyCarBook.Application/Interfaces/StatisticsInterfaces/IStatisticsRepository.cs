using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Interfaces.StatisticsInterfaces
{
    public interface IStatisticsRepository
    {
        int GetCarCount();
        int GetLocationCount();
        int GetAuthorCount();
        int GetBlogCount();
        int GetBrandCount();
        decimal GetAverageDailyRentPrice();
        decimal GetAverageWeeklyRentPrice();
        decimal GetAverageMonthlyRentPrice();
        int GetAutomaticTransmissionCarCount();
        string GetBrandWithMostCars();
        string GetBlogWithMostComments();
        int GetCarCountWithLessThan10000Km();
        int GetCarCountWithGasolineOrDiesel();
        int GetCarCountElectricFuel();
        string GetMostExpensiveCarByDailyRent();
        string GetCheapestCarByDailyRent();
    }
}
