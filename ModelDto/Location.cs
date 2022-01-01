using System.Collections.Generic;

namespace IPClient.Shared.ModelDto
{
    public class Location
    {
        public string geoname_id { get; set; }
        public string capital { get; set; }
        public ICollection<Language> languages { get; set; }
        public string country_flag { get; set; }
        public string country_flag_emoji { get; set; }
        public string country_flag_emoji_unicode { get; set; }
        public int calling_code { get; set; }
        public bool is_eu { get; set; }
        public Time_Zone time_zone { get; set; }
    }
}