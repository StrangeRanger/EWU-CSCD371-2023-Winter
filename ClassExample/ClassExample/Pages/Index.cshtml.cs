using ClassExample.Data;
using ClassExample.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ClassExample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _db;
        public IEnumerable<Person> People { get; set; }
        public int Count { get; set; }
        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public async Task OnGet()
        {
            IQueryable<Person> itsJustSQLPeople = _db.People
                .Where(p => p.Age > 12)
                .Skip(1)
                .Take(3);

            People = await itsJustSQLPeople.ToListAsync();
            Count = People.Count();
        }
    }
}