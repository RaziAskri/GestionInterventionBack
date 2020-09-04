using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;





namespace Ms_Panne.Domain.Poulina.MSpanne.Domain.Models
{
    public class Panne
    {
        [Key]
        public Guid id_panne { get; set; }
        public string etat_panne { get; set; }
        public string description { get; set; }
        public Guid id_type_panne { get; set; }
        public Guid id_machine { get; set; }
        public Type_panne Type_panne { get; set; }
   
        public ICollection<Intervention> Interventions { get; set; }





    }
}
