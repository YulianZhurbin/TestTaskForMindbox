using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    abstract class Figure
    {
        public abstract string Name { get; }
        public abstract double Area { get; }
    }
}
