﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Models
{
    public partial class EspExamen
    {
        public EspExamen()
        {
            EspModuleEtudiant = new HashSet<EspModuleEtudiant>();
        }

        public decimal NumSession { get; set; }
        public string AnneeDeb { get; set; }
        public string AnneeFin { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }

        public virtual EspSaisonUniversitaire AnneeDebNavigation { get; set; }
        public virtual ICollection<EspModuleEtudiant> EspModuleEtudiant { get; set; }
    }
}