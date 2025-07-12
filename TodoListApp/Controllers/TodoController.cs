using Microsoft.AspNetCore.Mvc;

namespace TodoListApp.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult AddTask()
        {
            return View();
        }
    }
}
