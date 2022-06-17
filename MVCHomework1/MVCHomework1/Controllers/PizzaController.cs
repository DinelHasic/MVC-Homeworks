using Microsoft.AspNetCore.Mvc;
using MVCHomework1.Models.Database;
using MVCHomework1.Models.Domain;

namespace MVCHomework1.Controllers
{
    [Route("pizza")]
    public class PizzaController : Controller
    {
        [Route("ListOrders")]
        public IActionResult Index()
        {
            List<Order> orders = PizzaDatabase.ORDERS;
            return View(orders);
        }

        [Route("details")]
        public IActionResult Details(int id)
        {
            Pizza pizza = PizzaDatabase.LIST_PIZZA.FirstOrDefault(x => x.Id == id);

            if (pizza is null)
            {
                return RedirectToAction("Error", "Home");
            }

            return View(pizza);
        }

        [Route("jsonData")]
        public IActionResult JsonData()
        {
            List<User> users = PizzaDatabase.USERS;
            return Json(users);
        }

        [Route("goHome")]
        public IActionResult GoHome()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
