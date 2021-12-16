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

        public class OrdenesPaisComparer : IComparer<Ordenes>
        {
            public int Compare(Ordenes e1, Ordenes e2)
            {
                if (e1 == null || e2 == null)
                {
                    throw new ArgumentException("Error, debe seleccionar un país");
                }
                if(e1.Pais > e2.Pais)
                {
                    return 1;
                }
                else if(e1.Pais < e2.Pais)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}
