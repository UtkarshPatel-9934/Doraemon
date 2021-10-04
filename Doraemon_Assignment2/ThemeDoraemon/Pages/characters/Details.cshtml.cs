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
    public class DetailsModel : PageModel
    {
        private readonly ThemeDoraemoncharacterContext _context;

        public DetailsModel(ThemeDoraemoncharacterContext context)
        {
            _context = context;
        }

        public character character { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            character = await _context.character.FirstOrDefaultAsync(m => m.ID == id);

            if (character == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
