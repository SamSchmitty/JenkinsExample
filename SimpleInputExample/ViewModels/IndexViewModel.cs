using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleInputExample.ViewModels;

public class IndexViewModel : PageModel
{
    /// <summary>
    /// Input for the page
    /// </summary>
    public int DivisibleByTwoInput { get; set; } = 0;

    /// <summary>
    /// Validation message sent to display on the page
    /// </summary>
    public string Message { get; set; } = "";
}
