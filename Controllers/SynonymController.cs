using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet("{id}")]
        public ActionResult<SynonymModel> Get(int id)
        {
            return _context.Synonyms.Find(id);
        }

        [HttpPost]
        public void Post(SynonymModel model)
        {
            //Determine the next ID
            var id = _context.Synonyms.Select(x => x.Id).Max() + 1; //In memory DB...that's why.
            model.Id = id;

            _context.Synonyms.Add(model);
            _context.SaveChanges();
        }

        [HttpPut]
        public void Put(SynonymModel model)
        {
            _context.Synonyms.Update(model);
            _context.SaveChanges();
        }

        [HttpDelete]
        public void Delete(SynonymModel model)
        {
            _context.Synonyms.Remove(model);
            _context.SaveChanges();
        }
    }
}
