using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.TagCloudDtos
{
    public class ResultGetTagCloudByBlogIdDto
    {
        public int tagCloudID { get; set; }
        public string title { get; set; }
        public int blogID { get; set; }
    }
}
