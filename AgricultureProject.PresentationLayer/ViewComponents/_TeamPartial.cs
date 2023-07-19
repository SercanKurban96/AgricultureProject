using AgricultureProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureProject.PresentationLayer.ViewComponents
{
    public class _TeamPartial : ViewComponent
    {
        private readonly ITeamServiceBL _teamService;

        public _TeamPartial(ITeamServiceBL teamService)
        {
            _teamService = teamService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _teamService.TGetListAll();
            return View(values);
        }
    }
}
