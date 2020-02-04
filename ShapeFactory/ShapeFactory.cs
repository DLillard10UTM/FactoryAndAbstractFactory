using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeFactory
{

 /*
  *  Author: Danny Lillard
  *  Date: 2/3/2020
  *  Description: Makes the needed shapes asked from Program.main().
 */
    class ShapeFactory
    {
        public enum ShapeType { LINE, CIRCLE, RECTANGLE, TRIANGLE };
        public IGeometricShape getShape(ShapeType shape)
        {
            //This switch stament checks the num input from Program.main(), and creates the corresponding shape.
            switch (shape)
            {
                case ShapeType.LINE:
                    return new Line();
                case ShapeType.CIRCLE:
                    return new Circle();
                case ShapeType.RECTANGLE:
                    return new Rectangle();
                default:
                    return null;

            }
        }
    }
}
