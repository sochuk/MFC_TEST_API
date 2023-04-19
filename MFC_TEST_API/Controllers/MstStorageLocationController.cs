using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MCF_TEST_API.Controllers
{
   
    [ApiController]
    [Route("api/[controller]")]
    public class MstStorageLocationController : Controller
    {
        private readonly MCFDBContext _dbContext;

        public MstStorageLocationController(MCFDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetMstStorageLocation()
        {
            return Ok(await _dbContext.MstStorageLocations.ToListAsync());
        }
    }
}

