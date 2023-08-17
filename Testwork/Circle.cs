using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testwork
{
    internal class Circle: Figure
    {
        float radius;

        public Circle(float _radius)
        {
            this.radius = _radius;
        }

        public float Radius
        {
            get { return radius; }
        }

        public override float GetArea()
        {
            return (float)(Math.PI * Math.Pow(radius, 2));
        }
    }
}
