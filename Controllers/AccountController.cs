using Microsoft.AspNetCore.Mvc;
using ValidationTurtorial.Interfaces;
using ValidationTurtorial.Models;

namespace ValidationTurtorial.Controllers
{
    public class AccountController : Controller
    {
        [BindProperty]
        public User User { get; set; } = null!;

        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create(User user)
        {
            if (!ModelState.IsValid) return View(user);
            _userService.AddUser(user);
            return RedirectToAction(actionName: "Index", controllerName: "Home");
        }
    }
}
