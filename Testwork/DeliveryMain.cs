Testwork.FigureFactory factory = new Testwork.FigureFactory();

Testwork.Figure figure = factory.getFigure(Testwork.FigureType.Triangle);

if (figure is Testwork.Triangle)
{
    Testwork.Triangle triangle = (Testwork.Triangle)figure;
    Console.WriteLine($"{triangle.DefineTriangle()}. Стороны треугольника {triangle.sideA}, {triangle.sideB}, {triangle.sideC}. Площадь равна = {triangle.GetArea()}");
}

Testwork.Figure figure1 = factory.getFigure(Testwork.FigureType.Circle);

if(figure1 is Testwork.Circle)
{
    Testwork.Circle circle = (Testwork.Circle)figure1;
    Console.WriteLine($"Площадь круга = { circle.GetArea()} c радиусом = {circle.Radius}");
}



