using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ms_Panne.Domain.Poulina.MSpanne.Domain.Models
{
   public class Interne
    {
        [Key]
        public Guid id_interne { get; set; }
        public Guid matricule { get; set; }
        public Guid id_intervention { get; set; }

    }
}
