using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.CommentDtos
{
    public class ResultGetCommentsByBlogId
    {
        public int commentID { get; set; }
        public string name { get; set; }
        public DateTime createdDate { get; set; }
        public string description { get; set; }
        public int blogID { get; set; }
    }
}
