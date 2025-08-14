using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BasicCRUD_._9_.Data;
using BasicCRUD_._9_.Model;

namespace BasicCRUD_._9_.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly BasicCRUD_._9_.Data.BasicCRUD__9_Context _context;

        public DetailsModel(BasicCRUD_._9_.Data.BasicCRUD__9_Context context)
        {
            _context = context;
        }

        public User User { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FirstOrDefaultAsync(m => m.Id == id);

            if (user is not null)
            {
                User = user;

                return Page();
            }

            return NotFound();
        }
    }
}
