using System;

namespace ShapeFactory
{

/*
 *  Author: Danny Lillard
 *  Date: 2/3/2020
 *  Description: Main driver for ShapeFactory, tells the factory which object the client wants.
 */    
    class Program
    {
        static void Main(string[] args)
        {
            //This is the object that will make the shapes.
            ShapeFactory fact = new ShapeFactory();
            //This is a shape, at first the shape will be line.
            IGeometricShape shape = fact.getShape((ShapeFactory.ShapeType)0);
            shape.draw();

            for (int i = 1; i < Enum.GetValues(typeof(ShapeFactory.ShapeType)).Length; i++)
            {
                shape = fact.getShape((ShapeFactory.ShapeType)i);
                //if shape name does not exist.
                if(shape == null)
                {
                    Console.WriteLine("SHAPE " + (ShapeFactory.ShapeType)i + " NOT FOUND.");

                }
                else
                shape.draw();
            }
        }
    }
}
