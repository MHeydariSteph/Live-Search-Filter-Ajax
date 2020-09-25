using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Live_Search_Filter_Ajax.Modals;

namespace Live_Search_Filter_Ajax.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContnextClass _adb;

        public IndexModel(ApplicationDBContnextClass adb)
        {
            _adb = adb;
        }
        public IEnumerable<DispClass> results { get; set; }

        public void OnGet()
        {
            results = _adb.Dispute.ToList();
        }
    }
}

