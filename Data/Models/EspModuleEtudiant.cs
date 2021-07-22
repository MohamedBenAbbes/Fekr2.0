﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Models
{
    public partial class EspModuleEtudiant
    {
        public string IdEt { get; set; }
        public string CodeModule { get; set; }
        public string NumPanier { get; set; }
        public string CodeCl { get; set; }
        public string AnneeDeb { get; set; }
        public string AnneeFin { get; set; }
        public decimal? NumSession { get; set; }
        public decimal? MoyennePrincipale { get; set; }
        public decimal? MoyenneRat { get; set; }
        public string Situation { get; set; }
        public decimal? NbAbscence { get; set; }

        public virtual EspModule CodeModuleNavigation { get; set; }
        public virtual EspExamen EspExamen { get; set; }
        public virtual EspEtudiant IdEtNavigation { get; set; }
    }
}