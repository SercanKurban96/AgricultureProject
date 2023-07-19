using AgricultureProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureProject.BusinessLayer.Abstract
{
    public interface IAnnouncementServiceBL : IGenericServiceBL<Announcement>
    {
        // Metotlar tanımlandıktan sonra AnnouncementManagerBL kısmına gidilir.
        void AnnouncementStatusToTrue(int id);
        void AnnouncementStatusToFalse(int id);
    }
}
