using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testwork
{
    internal class Triangle : Figure
    {
        private float A, B, C;

        public Triangle(int _a, int _b, int _c)
        {
            if (_a + _b > _c && _a + _c > _b && _c + _b > _a)
            {

                this.A = _a > 0 ? _a : throw new ArgumentException("значение должно быть больше 0");
                this.B = _b > 0 ? _b : throw new ArgumentException("значение должно быть больше 0"); 
                this.C = _c > 0 ? _c : throw new ArgumentException("значение должно быть больше 0");
            }
            else
                throw new Exception("треугольник невозможно построить");
        }

        public float sideA
        {
            get { return A; }
        }
        public float sideB
        {
            get { return B; }
        }
        public float sideC
        {
            get { return C; }
        }

        public override float GetArea()
        {
            float p = (A + B + C) / 2;
            float area = (float)Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return area;

        }

        public string DefineTriangle()
        {
            if(Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2))
            {
                return "Треугольник прямоугольный";
            }

            if (Math.Pow(C, 2) + Math.Pow(B, 2) == Math.Pow(A, 2))
            {
                return "Треугольник прямоугольный";
            }

            if (Math.Pow(A, 2) + Math.Pow(C, 2) == Math.Pow(B, 2))
            {
                return "Треугольник прямоугольный";
            }

            return "Треугольник не является прямоугольным";
        }
    }
}
    
