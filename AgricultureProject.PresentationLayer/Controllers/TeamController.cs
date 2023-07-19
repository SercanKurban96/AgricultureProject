using AgricultureProject.BusinessLayer.Abstract;
using AgricultureProject.BusinessLayer.ValidationRules;
using AgricultureProject.EntityLayer.Concrete;
using AgricultureProject.PresentationLayer.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AgricultureProject.PresentationLayer.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamServiceBL _teamService;

        public TeamController(ITeamServiceBL teamService)
        {
            _teamService = teamService;
        }

        TeamValidator tv = new TeamValidator();

        public IActionResult Index()
        {
            var values = _teamService.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTeam()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTeam(Team team)
        {            
            ValidationResult result = tv.Validate(team);

            if (result.IsValid)
            {
                _teamService.TInsert(team);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteTeam(int id)
        {
            var team = _teamService.TGetByID(id);
            _teamService.TDelete(team);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditTeam(int id)
        {
            var team = _teamService.TGetByID(id);
            return View(team);
        }
        [HttpPost]
        public IActionResult EditTeam(Team team)
        {
            ValidationResult result = tv.Validate(team);

            if (result.IsValid)
            {
                _teamService.TUpdate(team);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();            
        }
    }
}
