using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Linq;

namespace WebApplication2.Pages.CityManager
{
    public class ViewNotesModel : PageModel
    {
        public string[] Files { get; set; }

        public string Content { get; set; }

        public void OnGet()
        {
            var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files");

            if (Directory.Exists(folder))
                Files = Directory.GetFiles(folder).Select(Path.GetFileName).ToArray();
        }

        public void OnGetRead(string fileName)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files", fileName);

            if (System.IO.File.Exists(path))
                Content = System.IO.File.ReadAllText(path);

            OnGet();
        }
    }
}