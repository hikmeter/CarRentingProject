using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.StatisticsDtos
{
    public class ResultStatisticsDto
    {
        public ResultData result { get; set; }
    }

    public class ResultData
    {
        public int carCount { get; set; }
        public int locationCount { get; set; }
        public int authorCount { get; set; }
        public int blogCount { get; set; }
        public int brandCount { get; set; }
        public decimal averageDailyRentPrice { get; set; }
        public decimal averageWeeklyRentPrice { get; set; }
        public decimal averageMonthlyRentPrice { get; set; }
        public int automaticTransmissionCarCount { get; set; }
        public string brandWithMostCars { get; set; }
        public string blogWithMostComments { get; set; }
        public int carCountWithLessThan10000Km { get; set; }
        public int carCountWithGasolineOrDiesel { get; set; }
        public int carCountElectricFuel { get; set; }
        public string mostExpensiveCarByDailyRent { get; set; }
        public string cheapestCarByDailyRent { get; set; }
    }

}
