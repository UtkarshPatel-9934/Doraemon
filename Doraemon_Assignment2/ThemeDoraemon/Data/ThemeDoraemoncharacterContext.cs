using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ThemeDoraemon.ThemeCharacters;

    public class ThemeDoraemoncharacterContext : DbContext
    {
        public ThemeDoraemoncharacterContext (DbContextOptions<ThemeDoraemoncharacterContext> options)
            : base(options)
        {
        }

        public DbSet<ThemeDoraemon.ThemeCharacters.character> character { get; set; }
    }
