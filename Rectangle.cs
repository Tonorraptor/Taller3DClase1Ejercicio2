using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DClase1Ejercicio2
{
    internal class Rectangle
    {
        private float h;
        private float b;

        public Rectangle(float h, float b)
        {
            this.h = h;
            this.b = b;
        }
        public virtual float GetArea()
        {
            return b * h;
        }
    }
}
