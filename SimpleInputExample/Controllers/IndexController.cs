using Builders;
using Microsoft.AspNetCore.Mvc;
using SimpleInputExample.ViewModels;

namespace SimpleInputExample.Controllers
{
    public class IndexController : Controller
    {
        private readonly SimpleBuilder _simpleBuilder;

        public IndexController()
        {
            _simpleBuilder = new SimpleBuilder();
        }

        [HttpGet]
        public IActionResult Index()
        {
            // using the default values set in the ViewModel class.
            IndexViewModel model = new IndexViewModel();
            return View(model);
        }

        [HttpPost]
        public bool IsInputDivisibleByTwo(int input)
        {
            return _simpleBuilder.IsInputDivisibleByTwo(input);
        }
    }
}