﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class OCircle : OShape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
