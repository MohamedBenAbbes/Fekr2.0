﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Models
{
    public partial class Comite
    {
        public Comite()
        {
            ComiteSpecialite = new HashSet<ComiteSpecialite>();
            EspEtudiant = new HashSet<EspEtudiant>();
        }

        public int IdGrp { get; set; }
        public string Salle { get; set; }
        public string Nom { get; set; }
        public string Dateethour { get; set; }
        public string NomSpecialite { get; set; }

        public virtual ICollection<ComiteSpecialite> ComiteSpecialite { get; set; }
        public virtual ICollection<EspEtudiant> EspEtudiant { get; set; }
    }
}