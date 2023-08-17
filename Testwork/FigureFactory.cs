using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testwork
{
    internal class FigureFactory
    {
        public Figure getFigure(FigureType figureType)
        {
            return figureType switch
            {
                FigureType.Circle => new Circle(5),
                FigureType.Triangle => new Triangle(3, 4, 5),
                _ => null,
            };
        }
    }
}
