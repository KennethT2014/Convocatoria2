using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Objeto
{
    public class Ordenes
    {
        public int IdOrden { get; set; }
        public Enum Pais { get; set; }
        public Enum Ciudad { get; set; }
        public DateTime fechaOrden { get; set; }

    }
}
