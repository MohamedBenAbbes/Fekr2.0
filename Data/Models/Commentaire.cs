﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Models
{
    public partial class Commentaire
    {
        public int IdCommentaire { get; set; }
        public string CommentaireText { get; set; }
        public int Absence { get; set; }
        public string EtdIdEt { get; set; }

        public virtual EspEtudiant EtdIdEtNavigation { get; set; }
    }
}