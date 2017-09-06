using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityDataAnnoCodesnippet.Models
{
    public class Author
    {
        [Key]
        public int Number { get; set; }

        public string Name { get; set; }

        [InverseProperty("CreatedAuthor")]
        public virtual ICollection<Blog> CreatedBlogs { get; set; }

        [InverseProperty("UpdatedAuthor")]
        public virtual ICollection<Blog> UpdatedBlogs { get; set; }
    }
}