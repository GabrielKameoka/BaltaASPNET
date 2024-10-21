namespace BaltaASPNET.Pages;
using Microsoft.AspNetCore.Mvc.RazorPages;
public class index : PageModel
{
    private readonly ILogger<index> _logger;

    public index(ILogger<index> logger)
    {
        _logger = logger;
    }

    public List<Category> Categories { get; set; } = new();
    public async Task OnGet()
    { ;
        for (int i = 0; i <= 100; i++)
        {
            Categories.Add(
                item: new Category(i,
                Title: $"Categoria {i}",
                Price: i * 18.95M)
            );
        }
    }
    public void OnPost()
    {

    }
}

public record Category(int Id, string Title, decimal Price);