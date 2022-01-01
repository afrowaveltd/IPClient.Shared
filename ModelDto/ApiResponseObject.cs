namespace IPClient.Shared.ModelDto
{
    public class ApiResponseObject
    {
        public string ip { get; set; } // Returns the IP address as requested.
        public string type { get; set; } // Returns IPv4 or IPv6, depending on type of the requested IP address.
        public string continent_code { get; set; }
        public string continent_name { get; set; }
        public string country_code { get; set; }
        public string country_name { get; set; }
        public string region_name { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public Location location { get; set; }
        public Time_Zone time_zone { get; set; }
        public Currency currency { get; set; }
        public Connection connection { get; set; }
    }
}