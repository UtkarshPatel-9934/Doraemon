using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThemeDoraemon.ThemeCharacters;

namespace ThemeDoraemon.Pages.characters
{
    public class EditModel : PageModel
    {
        private readonly ThemeDoraemoncharacterContext _context;

        public EditModel(ThemeDoraemoncharacterContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(character).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!characterExists(character.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool characterExists(int id)
        {
            return _context.character.Any(e => e.ID == id);
        }
    }
}
