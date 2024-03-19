namespace HealthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthRecordsController : ControllerBase
    {
        private static List<HealthRecord> _records = new List<HealthRecord>
        {
            //hard coding for now
            new HealthRecord{Id = 1, 
            PatientName = "Vishal",
            RecordDetails = "Annual Checkup",
            Date = DateTime.now
            };

            //Endpoint list - finalize this
            [HttpGet]
            public ActionResult<List<HealthRecord>> GtAll() => _records;

            [HttpGet("{id}")]
            public ActionResult<HealthRecord> GetById(int ind)
            {
                var record = _records.FirstOrDefault(x => x.Id == id);
                if(record == null) return NotFound();
                return record;
            }


        }
    }
}