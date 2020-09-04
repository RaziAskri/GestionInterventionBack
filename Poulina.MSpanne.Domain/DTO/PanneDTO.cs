using System;
using System.Collections.Generic;
using System.Text;

namespace Poulina.MSpanne.Domain.DTO
{
    public class PanneDTO
    {
        public Guid id_panne { get; set; }
        public string etat_panne { get; set; }
        public string description { get; set; }
        public string id_type_panne { get; set; }
        public string labelMachine { get; set; }
         public Guid id_machine { get; set; }

            }
}
