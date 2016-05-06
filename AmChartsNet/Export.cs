namespace AmChartsNet
{
    public class Export
    {

        public bool? Enabled { get; set; }

        public ExportMenu Menu { get; set; }

        public class ExportMenu
        {
            public string ExportFormat { get; set; }
            public string Label { get; set; }
            public string Title { get; set; }
        }


    }
}