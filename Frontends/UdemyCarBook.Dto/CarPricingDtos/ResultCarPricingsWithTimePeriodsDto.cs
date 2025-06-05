using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.CarPricingDtos
{
    public class ResultCarPricingsWithTimePeriodsDto
    {
        public string brandModel { get; set; }
        public string coverImageUrl { get; set; }
        public float dailyAmount { get; set; }
        public float weeklyAmount { get; set; }
        public float monthlyAmount { get; set; }
    }
}
