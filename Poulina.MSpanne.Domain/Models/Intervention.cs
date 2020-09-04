using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;





namespace Ms_Panne.Domain.Poulina.MSpanne.Domain.Models
{
    public class Intervention
    {
        [Key]
        public Guid id_intervention { get; set; }
        public string date_intervention { get; set; }
        public string description_intervention { get; set; }
        public string duree { get; set; }
        public string etatIntervention { get; set; }
        public string dateFin { get; set; }
        public Guid id_panne { get; set; }
        public Panne Panne { get; set; }
        public Guid idTypeIntervention { get; set; }
        public Type_intervention Type_intervention  { get; set; }


    
      



    }
}

