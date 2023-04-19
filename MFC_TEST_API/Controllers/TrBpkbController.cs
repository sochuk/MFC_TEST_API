using MCF_TEST_API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MCF_TEST_API.Controllers
{
    [Route("api/[controller]")]
    public class TrBpkbController : Controller
    {
        private readonly MCFDBContext _dbContext;

        public TrBpkbController(MCFDBContext dbContext)
        {
            this._dbContext = dbContext;
        }
        // GET: api/values
        [HttpPost]
        public async Task<IActionResult> AddContact(TrBpkbRequest trBpkb)
        {
            var mstStorageLocation = _dbContext.MstStorageLocations.FirstOrDefault(a => a.LocationId == trBpkb.LocationId);
            var _trBpkb = new TrBpkb()
            {
                AgreementNumber = trBpkb.AgreementNumber,
                BpkbNo = trBpkb.BpkbNo,
                BranchId = trBpkb.BranchId,
                BpkbDate = trBpkb.BpkbDate,
                FakturNo = trBpkb.FakturNo,
                FakturDate = trBpkb.FakturDate,
                LocationId = mstStorageLocation,
                BpkbDateIn = trBpkb.BpkbDateIn
            };
            await _dbContext.TrBpkbs.AddAsync(_trBpkb);
            await _dbContext.SaveChangesAsync();
            return Ok(_trBpkb);
        }

        public class TrBpkbRequest 
	    {
            public string AgreementNumber { get; set; }
            public string BpkbNo { get; set; }
            public string BranchId { get; set; }
            public DateTime BpkbDate { get; set; }
            public string FakturNo { get; set; }
            public DateTime FakturDate { get; set; }
            public string LocationId { get; set; }
            public DateTime BpkbDateIn { get; set; }
        }
    }
}

