using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;


namespace EntityDataAnnoCodesnippet.Models
{
    public class Navigation
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }
        public virtual Navigation Parent { get; set; }

        public virtual ICollection<Navigation> Children { get; set; }

        [InverseProperty("Navigation")]
        public virtual Page Page {
            get;
            set;
        }

        public int? PageId { get; set; }
    }
}