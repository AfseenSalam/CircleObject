﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObject
{
    class Circle
    {
        private double radius;
        public Circle(double _radius)
        {
            radius = _radius;
        }
        public double CalculateDiameter()
        {
            return 2 * radius;
        }
        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public void Grow()
        {
            Console.WriteLine("The circle is magically growing.");
            radius = 2 * radius;
        }
        public double GetRadius()
        {
            return radius;
        }
    }
}
