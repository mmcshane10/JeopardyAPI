using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using JeopardyAPI.Models;

namespace JeopardyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FillInTheBlankController : ControllerBase
    {
        private JeopardyAPIContext _db;

        public FillInTheBlankController(JeopardyAPIContext db)
        {
            _db = db;
        }

        // GET api/questions
        [HttpGet]
        public ActionResult<IEnumerable<FillInTheBlank>> Get()
        {
            return _db.FillInTheBlank.ToList();
        }

        // GET api/questions/5
        [HttpGet("{id}")]
        public ActionResult<FillInTheBlank> Get(int id)
        {
            return _db.FillInTheBlank.FirstOrDefault(entry => entry.Id == id);
        }
    }
}