﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Models
{
    public partial class CodeNomenclature
    {
        public CodeNomenclature()
        {
            Champ = new HashSet<Champ>();
        }

        public string CodeStr { get; set; }
        public string CodeNome { get; set; }
        public string LibNome { get; set; }

        public virtual StrNome CodeStrNavigation { get; set; }
        public virtual ICollection<Champ> Champ { get; set; }
    }
}