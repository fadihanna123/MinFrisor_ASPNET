using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [DisplayName("Rubrik")]
        public string Title { get; set; }
        [DisplayName("Författare")]
        public string Author { get; set; }
        [DisplayName("Innehåll")]
        public string Content { get; set; }
        [DisplayName("Datum och tid")]
        public DateTime Date { get; set; }

        public Blog()
        {
            this.Date = DateTime.UtcNow;
        }


    }


}
