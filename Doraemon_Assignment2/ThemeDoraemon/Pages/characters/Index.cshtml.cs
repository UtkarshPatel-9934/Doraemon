using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThemeDoraemon.ThemeCharacters;

namespace ThemeDoraemon.Pages.characters
{
    public class IndexModel : PageModel
    {
        private readonly ThemeDoraemoncharacterContext _context;

        public IndexModel(ThemeDoraemoncharacterContext context)
        {
            _context = context;
        }

        public IList<character> character { get;set; }

        public async Task OnGetAsync()
        {
            character = await _context.character.ToListAsync();
        }
    }
}
