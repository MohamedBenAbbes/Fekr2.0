﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Models
{
    public partial class EspRubrique
    {
        public EspRubrique()
        {
            EspAssRubEtIns = new HashSet<EspAssRubEtIns>();
        }

        public string CodeRub { get; set; }
        public string Libelle { get; set; }
        public string Signe { get; set; }
        public decimal? Taux { get; set; }
        public decimal? Valeur { get; set; }

        public virtual ICollection<EspAssRubEtIns> EspAssRubEtIns { get; set; }
    }
}