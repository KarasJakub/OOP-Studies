﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Circle : Shape
    {
        public Circle(double x, double y, double radius) : base(x, y, radius, radius)
        {
        }

        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine("Rysujemy koło coś tam");
        }
    }
}