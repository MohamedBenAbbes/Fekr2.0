﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Models
{
    public partial class EspDispenseEtudiant
    {
        public string IdEt { get; set; }
        public string CodeModule { get; set; }
        public string AnneeDeb { get; set; }
        public bool Semestre { get; set; }
        public decimal Moyenne { get; set; }
        public string Observation { get; set; }
        public DateTime? DateDebutDispense { get; set; }
    }
}