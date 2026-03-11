using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.IO;

namespace WebApplication2.Pages.CityManager
{
    public class SaveNoteModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }

        public string FileName { get; set; }

        public class InputModel
        {
            public string Content { get; set; }
        }

        public void OnPost()
        {
            var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files");

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            FileName = $"note-{DateTime.Now.Ticks}.txt";

            var path = Path.Combine(folder, FileName);

            System.IO.File.WriteAllText(path, Input.Content);
        }
    }
}