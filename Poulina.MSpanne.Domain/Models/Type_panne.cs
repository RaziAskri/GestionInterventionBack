using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;





namespace Ms_Panne.Domain.Poulina.MSpanne.Domain.Models
{
    public class Type_panne
    {
        [Key]
        public Guid id_type_panne { get; set; }
        public string label { get; set; }
        public int priorite { get; set; }


        public ICollection<Panne> Pannes { get; set; }


    }
}

