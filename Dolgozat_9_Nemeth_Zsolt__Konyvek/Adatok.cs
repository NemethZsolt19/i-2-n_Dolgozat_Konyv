using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvek
{
    public class Adatok
    {
        public string Title;
        public string Author;
        public int Year;
        public int Pages;

        public Adatok(string title, string author, int year, int pages)
        {
            Title = title;
            Author = author;
            Year = year;
            Pages = pages;
        }

        public override string? ToString()
        {
            return Author+": "+Title+" (Kiadási éve: "+Year+", "+Pages+" oldal.)";
        }
    }
}
