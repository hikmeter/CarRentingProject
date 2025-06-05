using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.ServiceDtos
{
    public class CreateServiceDto
    {
        public string title { get; set; }
        public string description { get; set; }
        public string iconUrl { get; set; }
    }
}
