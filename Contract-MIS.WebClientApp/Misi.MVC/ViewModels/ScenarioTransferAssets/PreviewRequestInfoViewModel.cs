﻿using System;
using System.Collections.Generic;
using Misi.MVC.Filters;

namespace Misi.MVC.ViewModels.ScenarioTransferAssets
{
    public class PreviewRequestInfoViewModel
    {
        [LocalizedDisplayName("Item", NameResourceType = typeof (Resources.SharedResource))]
        public int Item { get; set; }

        [LocalizedDisplayName("ServiceId", NameResourceType = typeof (Resources.SharedResource))]
        public string ServiceId { get; set; }

        [LocalizedDisplayName("TicketId", NameResourceType = typeof (Resources.SharedResource))]
        public string TicketId { get; set; }

        [LocalizedDisplayName("RequestedBy", NameResourceType = typeof (Resources.SharedResource))]
        public string RequestBy { get; set; }

        [LocalizedDisplayName("IssuedBy", NameResourceType = typeof (Resources.SharedResource))]
        public string IssuedBy { get; set; }

        [LocalizedDisplayName("IssuedDate", NameResourceType = typeof (Resources.SharedResource))]
        public DateTime IssuedDate { get; set; }

        [LocalizedDisplayName("SnOrIdNumber", NameResourceType = typeof (Resources.SharedResource))]
        public string SnOrIdNumber { get; set; }

        [LocalizedDisplayName("Company", NameResourceType = typeof(Resources.SharedResource))]
        public string Company { get; set; }

        [LocalizedDisplayName("Location", NameResourceType = typeof(Resources.SharedResource))]
        public string Location { get; set; }

        [LocalizedDisplayName("Email", NameResourceType = typeof(Resources.SharedResource))]
        public string Email { get; set; }

        [LocalizedDisplayName("RequestedDate", NameResourceType = typeof(Resources.SharedResource))]
        public DateTime RequestedDate { get; set; }

        [LocalizedDisplayName("RequestedVia", NameResourceType = typeof(Resources.SharedResource))]
        public string RequestedVia { get; set; }

        //part of Ticket Category
        [LocalizedDisplayName("TicketCategory", NameResourceType = typeof(Resources.SharedResource))]
        public string TicketCategory { get; set; }

        //part of Ticket Category
        [LocalizedDisplayName("DetailCategory", NameResourceType = typeof(Resources.SharedResource))]
        public string DetailCategory { get; set; }
  

        [LocalizedDisplayName("RequestMemo", NameResourceType = typeof (Resources.SharedResource))]
        public string RequestMemo { get; set; }

        public IEnumerable<PreviewRoutingInfoLineViewModel> PreviewRoutingInfoLineViewModels { get; set; }
    }
}