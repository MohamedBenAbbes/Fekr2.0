﻿using AutoMapper;
using Data;
using Data.Enseignant;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Repository.Enseignant;
using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

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
        [HttpGet("{id}", Name = "GetEnseignant")]
        public ActionResult<EnseignantReadDto> GetEnseignant(string id)
        {
            var espEnseignant = _repository.GetEnseignant(id);

            if (espEnseignant == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<EnseignantReadDto>(espEnseignant));
        }

        [HttpPost]
        public ActionResult<EnseignantReadDto> CreateEnseignant(EnseignantCreateDto enseignantCreateDto)
        {
            var enseignantModel = _mapper.Map<EspEnseignant>(enseignantCreateDto);
            _repository.CreateEnseignant(enseignantModel);
            _repository.SaveChanges();
            var enseignantReadDto = _mapper.Map<EnseignantReadDto>(enseignantModel);
            return CreatedAtRoute(nameof(GetEnseignant),
            new { Id = enseignantReadDto.IdEns }, enseignantReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateEnseignant(string id, EnseignantUpdateDto enseignantUpdateDto)
        {
            var enseignantModelFromRepo = _repository.GetEnseignant(id);
            if (enseignantModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(enseignantUpdateDto, enseignantModelFromRepo);
            _repository.UpdateEnseignant(enseignantModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult PartialEnseignantUpdate(string id, JsonPatchDocument<EnseignantUpdateDto> patchDoc)
        {
            var enseignantModelFromRepo = _repository.GetEnseignant(id);
            if (enseignantModelFromRepo == null)
            {
                return NotFound();
            }
            var enseignantToPatch = _mapper.Map<EnseignantUpdateDto>(enseignantModelFromRepo);
            patchDoc.ApplyTo(enseignantToPatch, ModelState);
            if (!TryValidateModel(enseignantToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(enseignantToPatch, enseignantModelFromRepo);
            _repository.UpdateEnseignant(enseignantModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteEnseignant(string id)
        {
            var enseignantModelFromRepo = _repository.GetEnseignant(id);
            if (enseignantModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteEnseignant(enseignantModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}