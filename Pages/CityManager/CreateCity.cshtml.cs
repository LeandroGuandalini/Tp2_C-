using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Pages.CityManager
{
    public class CreateCityModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }

        public string Message { get; set; }

        public void OnPost()
        {
            if (!ModelState.IsValid)
                return;

            Message = $"Cidade enviada: {Input.CityName}";
        }

        public class InputModel
        {
            [Required]
            [MinLength(3)]
            public string CityName { get; set; }
        }
    }
}