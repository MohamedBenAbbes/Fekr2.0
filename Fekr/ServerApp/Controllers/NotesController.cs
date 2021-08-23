﻿using AutoMapper;
using Data.Notes;
using Domain.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Service.Repository.Notes;
using System.Collections.Generic;

namespace ServerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INotesApiRepo _repository;
        private readonly IMapper _mapper;

        public NotesController(INotesApiRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET: api/NotesApi
        [HttpGet]
        public ActionResult<IEnumerable<NoteReadDto>> GetAllEspNotes()
        {
            var modules = _repository.GetAllNotes();
            return Ok(_mapper.Map<IEnumerable<NoteReadDto>>(modules));
        }

        // GET: api/NotesApi/5
        [HttpGet("{id}", Name = "GetNote")]
        public ActionResult<NoteReadDto> GetNote(string id)
        {
            var espNote = _repository.GetNotesById(id);

            if (espNote == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<NoteReadDto>(espNote));
        }

        [HttpPost]
        public ActionResult<NoteReadDto> CreateNote(NoteCreateDto moduleCreateDto)
        {
            var moduleModel = _mapper.Map<ANote>(moduleCreateDto);
            _repository.CreateNotes(moduleModel);
            _repository.SaveChanges();
            var moduleReadDto = _mapper.Map<NoteReadDto>(moduleModel);
            return CreatedAtRoute(nameof(GetNote),
            new { Id = moduleReadDto.IdEt }, moduleReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateNote(string id, NoteUpdateDto moduleUpdateDto)
        {
            var moduleModelFromRepo = _repository.GetNotesById(id);
            if (moduleModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(moduleUpdateDto, moduleModelFromRepo);
            _repository.UpdateNotes(moduleModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult PartialNoteUpdate(string id, JsonPatchDocument<NoteUpdateDto> patchDoc)
        {
            var moduleModelFromRepo = _repository.GetNotesById(id);
            if (moduleModelFromRepo == null)
            {
                return NotFound();
            }
            var moduleToPatch = _mapper.Map<NoteUpdateDto>(moduleModelFromRepo);
            patchDoc.ApplyTo(moduleToPatch, ModelState);
            if (!TryValidateModel(moduleToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(moduleToPatch, moduleModelFromRepo);
            _repository.UpdateNotes(moduleModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteNote(string id)
        {
            var moduleModelFromRepo = _repository.GetNotesById(id);
            if (moduleModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteNotes(moduleModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}