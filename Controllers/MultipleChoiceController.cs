using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using JeopardyAPI.Models;

namespace JeopardyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultipleChoiceController : ControllerBase
    {
        private JeopardyAPIContext _db;

        public MultipleChoiceController(JeopardyAPIContext db)
        {
            _db = db;
        }

        // GET api/questions
        [HttpGet]
        public ActionResult<IEnumerable<MultipleChoice>> Get()
        {
            return _db.MultipleChoice.ToList();
        }

        // GET api/questions/5
        [HttpGet("{id}")]
        public ActionResult<MultipleChoice> Get(int id)
        {
            return _db.MultipleChoice.FirstOrDefault(entry => entry.MultipleChoiceId == id);
        }
    }
}