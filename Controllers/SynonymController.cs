using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SynonymService.DataContext;
using SynonymService.Models;

namespace SynonymService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SynonymController : ControllerBase
    {
        private readonly SynonymDBContext _context;

        public SynonymController(SynonymDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<SynonymModel>> Get()
        {
            return _context.Synonyms.ToList();
        }

        // GET: api/Synonym/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Synonym
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Synonym/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
