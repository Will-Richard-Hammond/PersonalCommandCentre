using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PersonalCommandCentre.Data;
using PersonalCommandCentre.Models;

namespace PersonalCommandCentre.Pages.Tasks
{
    public class IndexModel : PageModel
    {
        private readonly PersonalCommandCentre.Data.ApplicationDbContext _context;

        public IndexModel(PersonalCommandCentre.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<TaskItem> TaskItem { get;set; } = default!;

        public async Task OnGetAsync()
        {
            TaskItem = await _context.Tasks.ToListAsync();
        }
    }
}
