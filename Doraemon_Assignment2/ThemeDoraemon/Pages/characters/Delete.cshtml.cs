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
    public class DeleteModel : PageModel
    {
        private readonly ThemeDoraemoncharacterContext _context;

        public DeleteModel(ThemeDoraemoncharacterContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            character = await _context.character.FindAsync(id);

            if (character != null)
            {
                _context.character.Remove(character);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
