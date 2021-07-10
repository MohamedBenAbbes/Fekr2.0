﻿using Data;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service.Repository.Etudiant
{
    public class EtudiantApiRepo : IEtudiantApiRepo
    {
        private readonly Oracle1Context _context;

        public EtudiantApiRepo(Oracle1Context context)
        {
            _context = context;
        }

        public IEnumerable<EspEtudiant> GetAllEtudiant()
        {
            return _context.EspEtudiant.ToList();
        }

        public EspEtudiant GetEtudiant(string id)
        {
            return _context.EspEtudiant.FirstOrDefault(p => p.IdEt == id);
        }

        public void CreateEtudiant(EspEtudiant etudiant)
        {
            if (etudiant == null)
            {
                throw new ArgumentNullException(nameof(etudiant));
            }
            _context.EspEtudiant.Add(etudiant);
        }

        private bool EspEtudiantExists(string id)
        {
            return _context.EspEtudiant.Any(e => e.IdEt == id);
        }

        public void UpdateEtudiant(EspEtudiant espEtudiant)
        {
        }

        public void DeleteEtudiant(string id)
        {
            _context.EspEtudiant.Remove(new EspEtudiant() { IdEt = id });
            _context.SaveChanges();
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}