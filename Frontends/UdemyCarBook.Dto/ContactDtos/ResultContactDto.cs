﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.ContactDtos
{
    public class ResultContactDto
    {
        public int contactID { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        public DateTime sendDate { get; set; }
    }
}
