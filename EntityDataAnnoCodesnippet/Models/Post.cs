using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityDataAnnoCodesnippet.Models
{
    [Table("BlogPost")]
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Column("amount", TypeName="decimal")]
        public int Amount { get; set; }

        // Denne property kommer ikke i databasen. Featuren kan stadig bruges i C#
        [NotMapped]
        public bool IsInStock {
            get
            {
                return this.Amount > 0;
            }
        }

        public string Title { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }

        public string Content { get; set; }

        // Stadnard værdi i databasen, så den ikke ka være null
        [DefaultValue(true)]
        public bool IsActive { get; set; }
       
        public int BlogId { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}