using System;
using System.Security.Cryptography.X509Certificates;

namespace Open_Lab_01._04
{
    public class Triangle
    {
        public double Area(double foundation, double height)
        {
            double area = foundation * height / 2;
            return area;
        }
    }
}