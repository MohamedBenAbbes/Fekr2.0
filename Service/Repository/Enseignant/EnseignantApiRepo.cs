﻿using Data;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service.Repository.Enseignant
{
    public class EnseignantApiRepo : IEnseignantApiRepo
    {
        private readonly Oracle1Context _context;
        public EnseignantApiRepo(Oracle1Context context)
        {
            _context = context;
        }
        public void DeleteEnseignant(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EspEnseignant> GetAllEnseignants()
        {
            return _context.EspEnseignant.ToList();
        }

        public EspEnseignant GetEnseignant(string id)
        {
            throw new NotImplementedException();
        }

        public void PostEnseignant(EspEnseignant enseignant)
        {
            throw new NotImplementedException();
        }

        public void PutEnseignant(string id, EspEnseignant enseignant)
        {
            throw new NotImplementedException();
        }
    }
}
