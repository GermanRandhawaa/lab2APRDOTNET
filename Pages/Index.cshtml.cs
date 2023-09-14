using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using lab2.Models; // Adjust the namespace if necessary

namespace lab2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public int GetSign { get; set; }
        public string ZodiacSign { get; set; }
        public string ZodiacImageName {get; set;}

        public void OnGet()
        {

        }

       public void OnPost()
{
    if (ModelState.IsValid)
    {
        if (GetSign >= 1900 && GetSign <= 2024)
        {
            ZodiacSign = Utils.GetZodiac(GetSign);
            
            ZodiacImageName = ZodiacSign.ToLower() + ".png";
        }
        else
        {
            // Display an error message or take appropriate action
            ZodiacSign = ("Year should be between 1900 and 2024.");
        }
    }
}


        
    }

}