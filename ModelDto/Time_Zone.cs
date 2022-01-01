namespace IPClient.Shared.ModelDto
{
    public class Time_Zone
    {
        public string id { get; set; }
        public string current_time { get; set; }
        public int gmt_offset { get; set; }
        public string code { get; set; }
        public bool is_daylight_seving { get; set; }
    }
}