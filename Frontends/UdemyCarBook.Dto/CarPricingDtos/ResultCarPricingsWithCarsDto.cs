using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.CarPricingDtos
{
    public class ResultCarPricingsWithCarsDto
    {
        public int carPricingID { get; set; }
        public int carID { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public float amount { get; set; }
        public string coverImageUrl { get; set; }
    }
}
