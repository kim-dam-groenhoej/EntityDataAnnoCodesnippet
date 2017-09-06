using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityDataAnnoCodesnippet.Models
{
    public class Page
    {
        [Key, ForeignKey("Navigation")]
        public int Id { get; set; }

        [InverseProperty("Page")]
        public virtual Navigation Navigation { get; set; }

        public int? NavigationId { get; set; }
    }
}