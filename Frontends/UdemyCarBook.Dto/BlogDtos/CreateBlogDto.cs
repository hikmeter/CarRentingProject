﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.BlogDtos
{
    public class CreateBlogDto
    {
        public string title { get; set; }
        public string authorName { get; set; }
        public string authorDescription { get; set; }
        public string authorImageUrl { get; set; }
        public object categoryName { get; set; }
        public int authorID { get; set; }
        public string coverImageUrl { get; set; }
        public DateTime createdDate { get; set; }
        public int categoryID { get; set; }
        public string description { get; set; }
    }
}
