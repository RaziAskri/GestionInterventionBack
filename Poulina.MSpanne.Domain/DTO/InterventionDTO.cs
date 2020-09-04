using System;
using System.Collections.Generic;
using System.Text;

namespace Poulina.MSpanne.Domain.DTO
{
   public class InterventionDTO
    {

        public Guid id_intervention { get; set; }
        public string date_intervention { get; set; }
        public string description_intervention { get; set; }
        public string duree { get; set; }
        public string etatIntervention { get; set; }
        public string dateFin { get; set; }
        public string descriptionPanne { get; set; }
        public string TypeInterventionLabel { get; set; }
        public string labelMachine { get; set; }
     
    }
}
