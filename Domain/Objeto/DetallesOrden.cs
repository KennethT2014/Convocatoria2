using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Objeto
{
    public class DetallesOrden
    {
        public int IdOrden { get; set; }
        public int IdDetalle { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Descuento { get; set; }

        public class ProductoNombreComparer : IComparer<Ordenes>
        {
            public int Compare(Ordenes x, Ordenes y)
            {

                throw new NotImplementedException();
            }
        }
    }
}
