﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Models
{
    public partial class EspUp
    {
        public EspUp()
        {
            EspModule = new HashSet<EspModule>();
        }

        public string Up { get; set; }
        public string Designantion { get; set; }
        public string CodeDept { get; set; }

        public virtual ICollection<EspModule> EspModule { get; set; }
    }
}