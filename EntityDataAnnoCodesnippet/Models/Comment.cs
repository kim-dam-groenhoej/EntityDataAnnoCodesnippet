using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityDataAnnoCodesnippet.Models
{
    public class Comment
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual Post Post { get; set; }

        public int PostId { get; set; }
    }
}