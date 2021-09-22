using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestICloneable.Models
{
    public class Point //: ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xPos, int yPos) { X = xPos; Y = yPos; }
        public Point() { }

        // Override Object.ToString().
        public override string ToString() => $"X = {X}; Y = {Y};";

        // Version 1
        // Return a copy of the current object.
        public object Clone() => new Point(this.X, this.Y);

        // Version 2
        // Copy each field of the Point member by member.
        //public object Clone() => this.MemberwiseClone();
    }
}
