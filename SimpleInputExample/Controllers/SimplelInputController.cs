using Builders;
using Microsoft.AspNetCore.Mvc;
using SimpleInputExample.ViewModels;

namespace SimpleInputExample.Controllers
{
    public class SimpleInputController : Controller
    {
        private readonly SimpleBuilder _simpleBuilder;

        public SimpleInputController()
        {
            _simpleBuilder = new SimpleBuilder();
        }

        
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