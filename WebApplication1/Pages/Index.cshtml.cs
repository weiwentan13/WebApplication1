using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            using (StreamReader r = new StreamReader("./wwwroot/json/data.json"))
            {
                string json = r.ReadToEnd();
                TempData["data"] = JsonConvert.SerializeObject(json);
            }

            using (StreamReader r = new StreamReader("./wwwroot/json/data2.json"))
            {
                string json = r.ReadToEnd();
                TempData["data2"] = JsonConvert.SerializeObject(json);
            }
            return Page();
        }
    }
}