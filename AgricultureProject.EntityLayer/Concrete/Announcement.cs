﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureProject.EntityLayer.Concrete
{
    public class Announcement
    {
        public int AnnouncementID { get; set; }
        public string? AnnouncementTitle { get; set; }
        public string? AnnouncementDescription { get; set; }
        public DateTime AnnouncementDate { get; set; }
        public bool AnnouncementStatus { get; set; }
    }
}
