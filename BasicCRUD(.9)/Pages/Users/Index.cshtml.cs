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
    public class IndexModel : PageModel
    {
        private readonly BasicCRUD_._9_.Data.BasicCRUD__9_Context _context;

        public IndexModel(BasicCRUD_._9_.Data.BasicCRUD__9_Context context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
