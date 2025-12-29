namespace GMS.DBModels.STD
{
    /// <summary>
    /// STDGetMonitorList
    /// </summary>
    public class STDGetMonitorList : STDMonitor
    {

        ///// <summary>
        ///// StudioName
        ///// </summary>
        //public string StudioName { get; set; }

        //public int StudyId { get; set; }

        public int Id { get; set; }

        public string SponsorName { get; set; } = "";

        public int SponsorId { get; set; }

        public int UserName { get; set; }

        public bool Active { get; set; }

    }

}
