namespace LAB04
{
    internal class Triangle : Shape
    {
        public Triangle(double x, double y, double height, double width) : base(x, y, height, width)
        {
        }

        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine($"p x={X}, y+{Y}, o dlugosci {Width} i wysokosci {Height}\n");
        }
    }
}
