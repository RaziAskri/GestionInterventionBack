using System;
using System.Collections.Generic;
using System.Text;

namespace Poulina.MSpanne.Domain.DTO
{
    public class NbrPanneDTO
    {
        public Guid id_machine { get; set; }
        public string label { get; set; }
        public int nbrPannes { get; set; }

    }
}
