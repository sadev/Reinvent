﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SynonymService.DataContext;
using SynonymService.Models;
using SynonymService.Utils;

namespace SynonymService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly SynonymDBContext _context;

        public SearchController(SynonymDBContext context)
        {
            _context = context;
        }

        [HttpGet("{keyword}")]
        public IEnumerable<string> Get(string keyword)
        {
            var result = new List<string>();
            var synonyms = GraphUtils.ConvertToNodes(_context.Synonyms.ToList());
            var entryNode = new Node(keyword);

            GraphUtils.GetSynonyms(entryNode, synonyms, ref result);

            return result;
        }
    }
}
