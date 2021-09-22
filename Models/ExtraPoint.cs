using System;

namespace TestICloneable.Models
{
    public class ExtraPoint : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();
        public ExtraPoint(int xPos, int yPos, string petName)
        {
            X = xPos; Y = yPos;
            desc.PetName = petName;
        }

        public ExtraPoint(int xPos, int yPos)
        {
            X = xPos; Y = yPos;
        }

        public ExtraPoint() { }

        // Override Object.ToString().
        public override string ToString() => $"X = {X}; Y = {Y}; Name = {desc.PetName};\nID = {desc.PointID}\n";

        // Version 1
        // Return a copy of the current object.
        // public object Clone() => this.MemberwiseClone();

        // Version 2
        public object Clone()
        {
            // First get a shallow copy.
            ExtraPoint newPoint = (ExtraPoint)this.MemberwiseClone();

            // Then fill in the gaps.
            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;

            newPoint.desc = currentDesc;

            return newPoint;
        }
    }
}
