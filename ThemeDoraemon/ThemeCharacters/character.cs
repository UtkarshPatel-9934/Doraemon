using System;
using System.ComponentModel.DataAnnotations;

namespace ThemeDoraemon.ThemeCharacters
{
    public class character
    {
        public int ID { get; set; }
        public string Character_Name { get; set; }
        public string Favorite_Colour { get; set; }
        public string Favorite_Food { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birth_Date { get; set; }
    }
}