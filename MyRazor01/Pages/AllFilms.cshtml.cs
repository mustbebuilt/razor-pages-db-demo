using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRazor01.Model;

namespace MyRazor01.Pages
{
    public class AllFilmsModel : PageModel

    {

        private readonly ApplicationDbContext _db;

        public AllFilmsModel(ApplicationDbContext db)

        {

            _db = db;

        }
        public List<Film> AllFilms { get; set; }


      


        public void OnGet()
        {
            AllFilms = _db.Films.ToList();
        }
    }
}