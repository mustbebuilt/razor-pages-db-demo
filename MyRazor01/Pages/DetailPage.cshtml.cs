using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRazor01.Model;

namespace MyRazor01.Pages
{
    public class DetailPageModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        public Film FilmById { get; set; }


        public DetailPageModel(ApplicationDbContext db)

        {

            _db = db;

        }
        public void OnGet(int Id)
        {
            FilmById = _db.Films.Find(Id);
        }
    }
}