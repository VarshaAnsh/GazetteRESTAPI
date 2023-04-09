namespace GazetteRESTAPI.Model
{
    public class NoticeData
    {
        public string Id { get; set; } = string.Empty;
        public List<LinkInformation> link { get; set; }
        public string title { get; set; } = string.Empty;
        public string updated { get; set; } = string.Empty;
        public string f_page_number { get; set; } = string.Empty;
        public string f_page_size { get; set;} = string.Empty;
        public string f_page_start { get; set; } = string.Empty;
        public string f_page_stop { get; set; } = string.Empty;

        public string f_total { get; set; } = string.Empty;
        public string f_total_errors { get; set; } = string.Empty;
        public string f_facets { get; set; } = string.Empty;
        
	
    }
}
