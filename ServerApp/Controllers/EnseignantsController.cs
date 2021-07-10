﻿using AutoMapper;
using Data;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Repository.Enseignant;
using System.Collections.Generic;

namespace ServerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnseignantsController : ControllerBase
    {
        private readonly IEnseignantApiRepo _repository;
        private readonly IMapper _mapper;

        public EnseignantsController(IEnseignantApiRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET: api/Enseignants
        [HttpGet]
        public ActionResult<IEnumerable<EnseignantReadDto>> GetEspEnseignant()
        {
            var enseignants = _repository.GetAllEnseignants();
            return Ok(_mapper.Map<IEnumerable<EnseignantReadDto>>(enseignants));
        }

        // GET: api/Enseignants/5
        [HttpGet("{id}")]
        public ActionResult<EnseignantReadDto> GetEspEnseignant(string id)
        {
            var espEnseignant = _repository.GetEnseignant(id);

            if (espEnseignant == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ClasseReadDto>(espEnseignant));
        }

        //// PUT: api/Enseignants/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutEspEnseignant(string id, EspEnseignant espEnseignant)
        //{
        //    if (id != espEnseignant.IdEns)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(espEnseignant).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!EspEnseignantExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// DELETE: api/Enseignants/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteEspEnseignant(string id)
        //{
        //    var espEnseignant = await _context.EspEnseignant.FindAsync(id);
        //    if (espEnseignant == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.EspEnseignant.Remove(espEnseignant);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool EspEnseignantExists(string id)
        //{
        //    return _context.EspEnseignant.Any(e => e.IdEns == id);
        //}
    }
}