﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.PlanEtude
{
    public class PlanEtudeCreateDto
    {
        
        public string CodeModule { get; set; }
        public string NumPanier { get; set; }
        public string CodeCl { get; set; }
        public string AnneeDeb { get; set; }
        public string AnneeFin { get; set; }
        public string Description { get; set; }
        public decimal? NbHeures { get; set; }
        public decimal? Coef { get; set; }
        public decimal NumSemestre { get; set; }
        public decimal? NumPeriodfe { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public DateTime? DateExamen { get; set; }
        public DateTime? DateRattrapage { get; set; }
        public decimal? NbHoraireRealises { get; set; }
        public string Acomptabiliser { get; set; }
        public string IdEns { get; set; }
        public string IdEns2 { get; set; }
        public decimal? NbHeuresEns { get; set; }
        public decimal? NbHeuresEns2 { get; set; }
        public string Surveillant { get; set; }
        public string HeureExam { get; set; }
        public string SalleExam { get; set; }
        public string Surveillant2 { get; set; }
        public string SalleExam2 { get; set; }
        public decimal? Periode { get; set; }
        public byte? Numpromotioncs { get; set; }
        public bool? ApCs { get; set; }
        public string SeanceUnique { get; set; }
        public string CodeUe { get; set; }
        public byte? NbEcts { get; set; }
        public string TypeEpreuve { get; set; }
        public decimal? Chargep1add { get; set; }
        public decimal? Chargep2add { get; set; }
        public long? CodePlan { get; set; }
        public decimal? Nbheuradd { get; set; }
        public string Salle { get; set; }
        public string ExisteCc { get; set; }
        public string ExisteTp { get; set; }
        public string CalculRat { get; set; }
        public string HeureRat { get; set; }
        public DateTime? DateRat { get; set; }
        public string DesignationNew { get; set; }
        public string Utilisateur { get; set; }
        public virtual EspModule CodeModuleNavigation { get; set; }
    }
}