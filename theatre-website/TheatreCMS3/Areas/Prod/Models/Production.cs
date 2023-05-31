using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheatreCMS3.Areas.Prod.Models
{
    public class Production
    {
        public int ProductionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Playwright { get; set; }
        public int Runtime { get; set; }
        public DateTime OpeningDay { get; set; }
        public DateTime ClosingDay { get; set; }

        public DateTime ShowTimeEvening { get; set; }
        public DateTime? ShowTimeMatinee { get; set; }
        public int Season { get; set; }

        public bool WorldPremiere { get; set; }

        public string TicketLink { get; set; }
        public bool CurrentlyShowing { get; set; }

    }
}