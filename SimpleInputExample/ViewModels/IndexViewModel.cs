using Builders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleInputExample.ViewModels;

public class IndexViewModel : PageModel
{

    private readonly SimpleBuilder _simpleBuilder;

    public IndexViewModel()
    {
        _simpleBuilder = new SimpleBuilder();
    }

    /// <summary>
    /// Input for the page
    /// </summary>
    public int DivisibleByTwoInput { get; set; } = 0;

    /// <summary>
    /// Validation message sent to display on the page
    /// </summary>
    public string Message { get; set; } = "";

    public void OnGet()
    {
        if (_simpleBuilder.IsInputDivisibleByTwo(DivisibleByTwoInput))
        {
            Message = "Congrats! Divisible by 2!";
        }
        else
        {
            Message = "Sorry, not divisible by 2.";
        }
        // return ViewResult{};
    }
}
