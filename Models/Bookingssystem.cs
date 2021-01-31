using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class Bookingssystem
    {
        public int Id { get; set; }
        [DisplayName("Fullständigt namn")]
        public string FullName { get; set; }
        [DisplayName("E-postadress")]
        public string Mail { get; set; }
        [DisplayName("Mobilnummer")]
        public string MobilNumber { get; set; }
        [DisplayName("Tjänst")]
        public string Service { get; set; }
        [DisplayName("Utvalt datum")]
        public string Date { get; set; }
        [DisplayName("Utvald Tid")]
        public string Time { get; set; }
    }
}
