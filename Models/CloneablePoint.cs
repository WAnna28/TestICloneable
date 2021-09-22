using System;

namespace TestICloneable.Models
{
    public class PointDescription
    {
        public string PetName { get; set; }
        public Guid PointID { get; set; }
        public PointDescription()
        {
            PetName = "No-name";
            PointID = Guid.NewGuid();
        }
    }
}
