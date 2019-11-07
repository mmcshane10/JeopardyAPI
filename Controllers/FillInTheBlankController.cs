using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using JeopardyAPI.Models;
using Microsoft.EntityFrameworkCore;

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

        //POST api/fillintheblank
        [HttpPost]
        public void Post([FromBody] FillInTheBlank newQuestion)
        {
            _db.FillInTheBlank.Add(newQuestion);
            _db.SaveChanges();
        }

        [HttpPut]
        public void Put([FromBody] FillInTheBlank newQuestion)
        {
            _db.Entry(newQuestion).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}