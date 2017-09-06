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
        // Jeg benytter "ForeignKey" her til at fortælle at klassen Navigation skal tag primary keyen "Id" fra "Page" til ForeignKey
        [Key, ForeignKey("Navigation")]
        public int Id { get; set; }

        [InverseProperty("Page")]
        public virtual Navigation Navigation { get; set; }

        public int? NavigationId { get; set; }
    }
}