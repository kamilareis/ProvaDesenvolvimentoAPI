using System;
using System.Collections.Generic;
using System.Linq;
using ProvaDesenvolvimentoAPI.Data;
using ProvaDesenvolvimentoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ProvaDesenvolvimentoAPI.Controllers
{
    [ApiController]
    [Route("api/filme")]
    public class FilmeController : ControllerBase
    {
        private readonly DataContext _context;

        //Construtor
        public FilmeController(DataContext context) => _context = context;

        //POST: api/filme/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Filme filme)
        {
            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return Created("", filme);
        }

        //GET: api/filme/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Filmes.ToList());
    }
}