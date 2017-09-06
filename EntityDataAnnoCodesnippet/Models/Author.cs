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

        // Denne skal sættes på når der er relation til denne "Author" 2 eller flere gange fra "Blog"
        // Navnenet i InverseProperty er den property i "blog" - den høre til
        [InverseProperty("CreatedAuthor")]
        public virtual ICollection<Blog> CreatedBlogs { get; set; }

        // Denne skal sættes på når der er relation til denne "Author" 2 eller flere gange fra "Blog"
        // Navnenet i InverseProperty er den property i "blog" - den høre til
        [InverseProperty("UpdatedAuthor")]
        public virtual ICollection<Blog> UpdatedBlogs { get; set; }
    }
}