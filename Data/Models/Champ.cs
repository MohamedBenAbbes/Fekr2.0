﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Models
{
    public partial class Champ
    {
        public string CodeStr { get; set; }
        public string CodeNome { get; set; }
        public string CodeChamp { get; set; }
        public string ChaCodeStr { get; set; }
        public string Valeur { get; set; }

        public virtual ChampStr C { get; set; }
        public virtual CodeNomenclature Code { get; set; }
    }
}