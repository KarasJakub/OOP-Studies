namespace LAB04
{
    internal class Rectangle : Shape
    {
        public Rectangle(double x, double y, double height, double width) : base(x, y, height, width)
        {
        }

        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine($"prostokat o wspolrzednych x={X}, y+{Y}, o dlugosci {Width} i wysokosci {Height}\n");
        }
    }
}
