﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Models
{
    public partial class EspDispClass
    {
        public long Id { get; set; }
        public long Iduser { get; set; }
        public string Motifdisp { get; set; }
        public string Codsal { get; set; }
        public long? Codjour { get; set; }
        public string Codseance { get; set; }
        public long? Idsem { get; set; }
        public long? Idsemaine { get; set; }

        public virtual Classe CodsalNavigation { get; set; }
    }
}