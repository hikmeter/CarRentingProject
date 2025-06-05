using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.AuthorDtos
{
    public class ResultGetAuthorByBlogIdDto
    {
        public int blogID { get; set; }
        public string authorName { get; set; }
        public string authorDescription { get; set; }
        public string authorImageUrl { get; set; }
        public int authorID { get; set; }
    }
}
