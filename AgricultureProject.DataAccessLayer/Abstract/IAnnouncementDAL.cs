using AgricultureProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureProject.DataAccessLayer.Abstract
{
    public interface IAnnouncementDAL : IRepositoryDAL<Announcement>
    {
        // Aktif - Pasif yapma işlemi

        void AnnouncementStatusToTrue(int id);
        void AnnouncementStatusToFalse(int id);

        // Metotlar tanımlandıktan sonra EntityFramework klasörüne gidilir.
    }
}
