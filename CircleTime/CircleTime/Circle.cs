using System;
using System.Collections.Generic;
using System.Text;

namespace CircleTime
{
    //The job of this class is to store the data about the circle
    class Circle
    {
        //Below is defined the Radius property
        public double Radius { get; set; }

        //Below is the constructor for the Circle Class
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        //This method calculates the circle's circumference
        public double CalculateCircumference()
        {
            //for the value of pi using the .Math class
            double CirCirc = 2 * Math.PI * Radius;
            return CirCirc;
        }

        //This method calculates the Area of the circle
        public double CalculateArea()
        {
            //for the value of pi using the .Math class
            double AreaCirc = Math.PI * Radius * Radius;
            return AreaCirc;
        }
    }
}
