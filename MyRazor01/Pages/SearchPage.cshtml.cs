using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRazor01.Model;

namespace MyRazor01.Pages
{
    public class SearchPageModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Film> FoundFilms { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }


        public SearchPageModel(ApplicationDbContext db)

        {

            _db = db;

        }


        public void OnGet()
        {
            var films = from m in _db.Films

                        select m;

            if (!string.IsNullOrEmpty(SearchString))

            {

                films = films.Where(s => s.FilmTitle.Contains(SearchString));

            }



            FoundFilms = films.ToList();

        }
    }
}