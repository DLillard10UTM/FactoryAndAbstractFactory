using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeFactory
{

/*
 *  Author: Danny Lillard
 *  Date: 2/3/2020
 *  Description: Interface file with classes that define the shapes, and their functionality.
 */
    interface IGeometricShape
    {
        //Draw is a function that is used by each part of this interface to say the object has been printed.
        public abstract void draw(); 
    }

    class Line : IGeometricShape
    {
        public void draw()
        {
            Console.WriteLine("Line was printed.");
        }
    }

    class Circle : IGeometricShape
    {
        public void draw()
        {
            Console.WriteLine("Circle was printed.");
        }
    }

    class Rectangle : IGeometricShape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle was printed.");
        }
    }
}
