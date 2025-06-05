using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.ReservationDtos
{
    public class CreateReservationDto
    {
        public string name { get; set; }
        public string surName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int carID { get; set; }
        public int pickUpLocationID { get; set; }
        public int dropOffLocationID { get; set; }
        public int age { get; set; }
        public int driverLisenceYear { get; set; }
        public string description { get; set; }
    }
}
