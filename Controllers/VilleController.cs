using Microsoft.AspNetCore.Mvc;
using testDataGrid.Context;

namespace testDataGrid.Controllers
{
    public class VilleController : Controller
    {
        private readonly TestDataGridDbContext _dbContext;

        public VilleController(TestDataGridDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        [Route("/Ville/{idPays}")]
        public IActionResult ListeVilles(int idPays)
        {
            return View();
        }
    }
}
