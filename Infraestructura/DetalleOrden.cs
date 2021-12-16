using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura
{
    public class DetalleOrden
    {
        public Ordenes[] Ordeness;
        public DetalleOrden[] DetalleOrdenes;
        public DetalleOrden() { }

        public void Add(Ordenes ordenes)
        {
            if(Ordeness == null)
            {
                Ordeness = new Ordenes[1];
                Ordeness[0] = ordenes;
                return;
            }
            Ordenes[] tmp = new Ordenes[Ordeness.Length + 1];
            Array.Copy(Ordeness, tmp, Ordeness.Length);

            tmp[tmp.Length - 1] = ordenes;
            Ordeness = tmp;
        }

        public Ordenes[] GetOrdeness()
        {
            return Ordeness;
        }

        public void Add(DetalleOrden detalleorden)
        {
            if(DetalleOrdenes == null)
            {
                DetalleOrdenes = new DetalleOrden[1];
                DetalleOrdenes[0] = detalleorden;
                return;
            }
            DetalleOrden[] tmp = new DetalleOrden[DetalleOrdenes.Length + 1];
            Array.Copy(DetalleOrdenes, tmp, DetalleOrdenes.Length);

            tmp[tmp.Length - 1] = detalleorden;
            DetalleOrdenes = tmp;
        }

        public DetalleOrden[] GetDetalleOrdenes()
        {
            return DetalleOrdenes;
        }

        public decimal GetPrecioMaximo()
        {
            decimal max = 0;
            foreach (DetalleOrden e in DetalleOrdenes)
            {
                if()
                if(e.Precio > max)
                {
                    max = e.Precio;
                }
            }
            return max;
        }
    }
}
