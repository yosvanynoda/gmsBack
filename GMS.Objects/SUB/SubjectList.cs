﻿namespace GMS.Objects.SUB
{
    public class SubjectList
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
    }
}
