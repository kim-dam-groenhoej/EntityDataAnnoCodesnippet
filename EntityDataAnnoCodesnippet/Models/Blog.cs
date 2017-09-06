using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace EntityDataAnnoCodesnippet.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string BloggerName { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public BlogDetails BlogDetail { get; set; }

       
        [ForeignKey("CreatedAuthorNumber")]
        public virtual Author CreatedAuthor { get; set; }

        [ForeignKey("UpdatedAuthorNumber")]
        public virtual Author UpdatedAuthor { get; set; }

        public int CreatedAuthorNumber { get; set; }

        public int? UpdatedAuthorNumber { get; set; }
    }
    
}