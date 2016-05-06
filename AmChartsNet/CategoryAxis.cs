using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AmChartsNet
{
    /// <summary>
    /// Extension for AxisBase, gets automatically populated if none has been specified.
    /// </summary>
    public class CategoryAxis : AxisBase
    {

        public bool? AutoWrap { get; set; }
        public string CategoryFunction { get; set; }
        public string ClassNameField { get; set; }
        public bool? EqualSpacing { get; set; }
        public string ForceShowField { get; set; }

        [JsonConverter(typeof(StringEnumConverter), true)]
        public GridPosition? GridPosition { get; set; }

        public string LabelColorField { get; set; }
        public string LabelFunction { get; set; }
        public string MinPeriod { get; set; }
        public bool? ParseDates { get; set; }
        public bool? StartOnAxis { get; set; }

        [JsonConverter(typeof(StringEnumConverter), true)]
        public TickPosition? TickPosition { get; set; }

        public bool? TwoLineMode { get; set; }
        public string WidthField { get; set; }

    }
}