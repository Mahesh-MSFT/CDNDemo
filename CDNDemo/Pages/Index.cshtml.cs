using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CDNDemo.Pages
{
    public class IndexModel : PageModel
    {
        public int starttime { get; set; }
        public int endtime { get; set; }
        public void OnGet()
        {
            starttime = DateTime.Now.Millisecond;
            endtime = DateTime.Now.Millisecond;
        }

        public void OnPost()
        {
            starttime = DateTime.Now.Millisecond;

            ViewData["Image1Path"] = "/images/ws1.jpg";
            ViewData["Image2Path"] = "/images/ws2.jpg";
            ViewData["Image3Path"] = "/images/ws3.jpg";
            ViewData["Image4Path"] = "/images/ws4.jpg";
            ViewData["Image5Path"] = "/images/ws5.jpg";
            ViewData["Image6Path"] = "/images/ws6.jpg";

            endtime = DateTime.Now.Millisecond;
        }
    }
}
