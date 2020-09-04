using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;





namespace Ms_Panne.Domain.Poulina.MSpanne.Domain.Models
{
    public class Type_intervention
    {
        [Key]
        public Guid id_type_intervention { get; set; }
        public string etat_intervention { get; set; }
        public string type_intervention { get; set; }
        public ICollection<Intervention> Interventions { get; set; }


    }
}
