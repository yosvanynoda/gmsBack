namespace GMS.DBModels.Helper
{
    public class BaseResult
    {
        public int Result { get; set; }

        public string ResultMessage { get; set; }

        public BaseResult()
        {
            ResultMessage = "";

            Result = 0;
        }
    }
}
