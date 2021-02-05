using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projekti_GamesWebsite.Models
{
    public class Games
    {
        
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        public string Referenca { get; set; }
        [Required]
        public string Platform { get; set; }
        [Required]
        public string SKU { get; set; }
        [Required]
        public string Description { get; set; }
        public string Image { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        public List<string> Categories { get; set; }

    }
}