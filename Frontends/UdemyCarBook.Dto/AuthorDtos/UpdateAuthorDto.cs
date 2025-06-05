using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.AuthorDtos
{
    public class UpdateAuthorDto
    {
        public int authorID { get; set; }
        public string name { get; set; }
        public string imageUrl { get; set; }
        public string description { get; set; }
    }
}
