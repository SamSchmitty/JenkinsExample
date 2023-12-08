using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleInputExample.ViewModels;

public class IndexViewModel : PageModel
{
    public int DivisibleByTwoInput { get; set; } = 0;
    public string Message { get; set; } = "";
}
