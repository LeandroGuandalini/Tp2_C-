using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace WebApplication2.Pages.CityManager
{
    public class MultiCountriesModel : PageModel
    {
        [BindProperty]
        public List<InputModel> Countries { get; set; }

        public List<InputModel> SubmittedCountries { get; set; }

        public void OnGet()
        {
            Countries = new List<InputModel>();

            for (int i = 0; i < 5; i++)
                Countries.Add(new InputModel());
        }

        public void OnPost()
        {
            SubmittedCountries = Countries;
        }

        public class InputModel
        {
            public string CountryName { get; set; }
            public string CountryCode { get; set; }
        }
    }
}