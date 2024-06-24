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
    [BindProperty]
    public int DivisibleByTwoInput { get; set; } = 0;

    /// <summary>
    /// Validation message sent to display on the page
    /// </summary>
    public string Message { get; set; } = "";

    public IActionResult OnGet(string? message, int? divisibleByTwoInput)
    {
        if (divisibleByTwoInput == null)
        {
            divisibleByTwoInput = 0;
        }
        if (message == null)
        {
            message = "";
        }
        Message = message;
        DivisibleByTwoInput = divisibleByTwoInput.Value;
        return Page();
    }


    public async Task<IActionResult> OnPost(int divisibleByTwoInput)
    {
        DivisibleByTwoInput = divisibleByTwoInput;
        if (_simpleBuilder.IsInputDivisibleByTwo(divisibleByTwoInput))
        {
            Message = "Congrats! Divisible by 2!";
        }
        else
        {
            Message = "Sorry, not divisible by 2.";
        }
        return RedirectToPage("./Index", new { message = Message, divisibleByTwoInput = DivisibleByTwoInput });
    }
}
