﻿namespace GMS.Objects.STD
{
    public class STDArmsUDT
    {
        public int ArmID { get; set; } = 0;

        public int StudyID { get; set; } = 0;

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int TargetEnrollment { get; set; } = 0;

        public string DoseLevel { get; set; } = string.Empty;
    }
}
