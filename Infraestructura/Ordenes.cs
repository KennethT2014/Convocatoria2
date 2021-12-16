using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura
{
    public class Ordenes
    {
        public int IdOrden { get; set; }
        public Enum Pais { get; set; }
        public Enum Ciudad { get; set; }
        public DateTime FechaOrden { get; set; }
        public List<Ordenes> Ordeness { get; set; } = new List<Ordenes>();
    }
}
