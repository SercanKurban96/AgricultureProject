using AgricultureProject.DataAccessLayer.Abstract;
using AgricultureProject.DataAccessLayer.Concrete;
using AgricultureProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureProject.DataAccessLayer.EntityFramework
{
    public class EfAnnouncementDAL : RepositoryDAL<Announcement>, IAnnouncementDAL
    {
        // Fonksiyonlar tanımlandıktan sonra BusinessLayer kısmından IAnnouncementServiceBL kısmına gidilir.
        public void AnnouncementStatusToFalse(int id)
        {
            using var c = new Context();
            Announcement p = c.Announcements.Find(id);
            p.AnnouncementStatus = false;
            c.SaveChanges();
        }

        public void AnnouncementStatusToTrue(int id)
        {
            using var c = new Context();
            Announcement p = c.Announcements.Find(id);
            p.AnnouncementStatus = true;
            c.SaveChanges();
        }
    }
}
