using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCSampleApp.Models.Entity;
using MVCSampleApp.Models.ViewModel;
using MVCSampleApp.Services;
using System.Diagnostics;

namespace MVCSampleApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;

        public HomeController(ILogger<HomeController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Confirm(UserViewModel userViewModel)
        {
            return View(userViewModel);
        }

        [HttpPost]
        public IActionResult Registar(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = new User();
                user.Name = userViewModel.Name;
                user.Age = userViewModel.Age;
                user.AccountNumber = userViewModel.AccountNumber;
                user.CMFNumber = userViewModel.CMFNumber;
                try
                {
                    _userService.addUser(user);
                    return View();
                }
                catch
                {
                    return View("Error");
                }
            }
            else
            {
                return View("Error");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}