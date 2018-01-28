using System;

namespace GTAnoRP.Data.Attributes
{
    public class BlipTypeAttribute : Attribute
    {
        public int BlipId { get; }

        public BlipTypeAttribute(int blipId)
        {
            BlipId = blipId;
        }
    }
}
