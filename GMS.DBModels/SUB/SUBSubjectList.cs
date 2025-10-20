﻿namespace GMS.DBModels.SUB
{
    /// <summary>
    /// SUBGeneralData
    /// </summary>
    public class SUBSubjectList
    {
        public int SubjectId { get; set; }

        public DateTime DateCreated { get; set; }

        public string CurrentStatus { get; set; } = string.Empty;

        public int StudyId { get; set; }

        public string StudyName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime SubjectDOB { get; set; }

        public string RandomCode { get; set; }

        public DateTime RamdoDate { get; set; }

        public int VolunteerId { get; set; }

        public string SubjectCode { get; set; }


    }
}
