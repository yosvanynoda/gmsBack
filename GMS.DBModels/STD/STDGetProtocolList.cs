namespace GMS.DBModels.STD
{
    /// <summary>
    /// STDGetProtocolList
    /// </summary>
    public class STDGetProtocolList : STDProtocol
    {
        /// <summary>
        /// StudioName
        /// </summary>
        public string StudioName { get; set; }

        public STDGetProtocolList()
        {
            StudioName = "";
        }

    }

}
