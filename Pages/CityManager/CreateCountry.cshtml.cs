using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Pages.CityManager
{
    public class CreateCountryModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }

        public Country Country { get; set; }

        public void OnPost()
        {
            if (Input.CountryName[0] != Input.CountryCode[0])
            {
                ModelState.AddModelError("Input.CountryCode",
                "O código do país deve começar com a mesma letra do nome.");
            }

            if (!ModelState.IsValid)
                return;

            Country = new Country
            {
                CountryName = Input.CountryName,
                CountryCode = Input.CountryCode
            };
        }

        public class InputModel
        {
            [Required]
            public string CountryName { get; set; }

            [Required]
            [StringLength(2, MinimumLength = 2)]
            public string CountryCode { get; set; }
        }
    }

    public class Country
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
    }
}