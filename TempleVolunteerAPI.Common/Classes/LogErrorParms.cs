namespace TempleVolunteerAPI.Common
{
    public struct LogErrorParms
    {
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }
        public string FunctionName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
