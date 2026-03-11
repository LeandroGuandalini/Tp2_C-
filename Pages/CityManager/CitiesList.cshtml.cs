using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace WebApplication2.Pages.CityManager
{
    public class CitiesListModel : PageModel
    {
        public List<string> Cities { get; set; } = new List<string>
        {
            "Rio",
            "São Paulo",
            "Brasília"
        };
    }
}