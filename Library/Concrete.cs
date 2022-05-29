﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
    public class Concrete
    {
        public int NumberOfSides { get; set; }

        public int SideLength { get; set; }

        public Concrete (int sides, int length)
        {
            NumberOfSides = sides;  
            SideLength = length;    
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength; 
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();    
        }
    }
}
