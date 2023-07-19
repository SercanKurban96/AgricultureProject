using AgricultureProject.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureProject.PresentationLayer.ViewComponents
{
    public class _DashboardOverviewPartial : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            // Takım arkadaşı sayısı
            ViewBag.teamCount = c.Teams.Count();

            // Hizmet sayısı
            ViewBag.serviceCount = c.Services.Count();

            // Mesaj sayısı
            ViewBag.messageCount = c.Contacts.Count();

            // Bu ay içindeki mesaj sayısı
            ViewBag.currentMonthMessage = c.Contacts.Where(x=>x.ContactDate.Month == DateTime.Now.Month).Count();

            // Aktif duyuru sayısı
            ViewBag.announcementTrue = c.Announcements.Where(x => x.AnnouncementStatus == true).Count();

            // Pasif duyuru sayısı
            ViewBag.announcementFalse = c.Announcements.Where(x => x.AnnouncementStatus == false).Count();

            // Ürün Pazarlama kişisini getirme
            ViewBag.productMarketing = c.Teams.Where(x => x.PersonTitle == "Ürün Pazarlama").Select(y => y.PersonName).FirstOrDefault();

            // Bakliyat Yönetimi kişisini getirme
            ViewBag.pulsesManagement = c.Teams.Where(x => x.PersonTitle == "Bakliyat Yönetimi").Select(y => y.PersonName).FirstOrDefault();

            // Süt Üreticisi kişisini getirme
            ViewBag.milkProducer = c.Teams.Where(x => x.PersonTitle == "Süt Üreticisi").Select(y => y.PersonName).FirstOrDefault();

            // Gübre Yönetimi kişisini getirme
            ViewBag.fertilizerManagement = c.Teams.Where(x => x.PersonTitle == "Gübre Yönetimi").Select(y => y.PersonName).FirstOrDefault();

            return View();
        }
    }
}
