using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {

            ViewBag.one = _context.Leagues.Where(one => one.Name.Contains("Women")).ToList();

            ViewBag.two = _context.Leagues.Where(two => two.Sport.Contains("Hockey")).ToList();

            ViewBag.three = _context.Leagues.Where(three => three.Sport != "Football").ToList();

            ViewBag.four = _context.Leagues.Where(four => four.Name.Contains("Conference")).ToList();

            ViewBag.five = _context.Leagues.Where(five => five.Name.Contains("Atlantic")).ToList();

            ViewBag.six = _context.Teams.Where(six => six.Location.Contains("Dallas")).ToList();

            ViewBag.seven = _context.Teams.Where(seven => seven.TeamName.Contains("Raptors")).ToList();

            ViewBag.eight = _context.Teams.Where(eight => eight.Location.Contains("City")).ToList();

            ViewBag.nine = _context.Teams.ToList().Where(nine => nine.TeamName[0] == 'T');

            ViewBag.ten = _context.Teams.OrderBy(ten => ten.Location).ToList();

            ViewBag.eleven = _context.Teams.OrderByDescending(eleven => eleven.TeamName).ToList();

            ViewBag.twelve = _context.Players.Where(twelve => twelve.LastName.Contains("Cooper")).ToList();

            ViewBag.thirteen = _context.Players.Where(thirteen => thirteen.FirstName == "Joshua").ToList();

            ViewBag.fourteen = _context.Players.Where(fourteen => fourteen.LastName == "Cooper" && fourteen.FirstName != "Joshua").ToList();

            ViewBag.fifteen = _context.Players.Where(fifteen => fifteen.FirstName == "Alexander" || fifteen.FirstName == "Wyatt").ToList();

            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}