using System;
using System.Collections.Generic;
using System.Text;

namespace Poulina.MSpanne.Domain.DTO
{
    public class MachineDTO
    {
        public Guid id_machine { get; set; }
        public string label { get; set; }

        public string type_machine { get; set; }
        public string etat_machine { get; set; }
        public string id_fournisseur { get; set; }
    }
}
