# amcharts-csharp-wrapper
A C# wrapper for the JavaScript amCharts library

This is work in progress and only has classes which I have required to date.  Feel free to add/fix things which I have missed.
I still have to add other charts to the wrapper as currently it supports Maps only.

TIP: If you wish to make use of a variable such as an SVG element already created in the page you can supply it surrounded by double curly braces eg: ```{{targetSVG}}``` and it will be rendered in json without quotes.

##Basic usage

### Model
In your Model create a property of type AmMap.

```
public AmMap Map { get; set; }
```
### View
Ensure you have the required amchart javascript libraries included as if you were manually writing the code.

Ensure you have an html element in place where the chart should be rendered.

```
<div id="map" style="width: 100%; height: 800px;"></div>
```

Include the javascript code to draw the chart.
```
<script>
    $(function() {
        var map = AmCharts.makeChart("map", 
            @Html.Raw(JsonConvert.SerializeObject(Model.Map, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver(), NullValueHandling = NullValueHandling.Ignore }))
        );
    });
</script>
```
### Controller

```c#
model.Map = new AmMap
{
    BackgroundZoomsToTop = true,
    LinesAboveImages = true,
    AreasSettings = new AreasSettings
    {
        UnlistedAreasAlpha = 0.1,
        UnlistedAreasColor = "#000000"
    },
    DataProvider = new MapData
    {
        Map = "worldLow",
        ZoomLevel = 3.5,
        ZoomLatitude = 49.1712,
        ZoomLongitude = -20.1341,
        Images = new List<MapImage>
        {
            new MapImage
            {
                Id = "germany",
                Title = "Germany",
                Latitude = 51,
                Longitude = 9,
                SvgPath = "{{targetSVG}}",
                Scale = 1
            }
        }
    },
    ImagesSettings = new ImagesSettings
    {
        Color = "#CC0000",
        RollOverColor = "#CC0000",
        SelectedColor = "#000000"
    },
    LinesSettings = new LinesSettings
    {
        Arc = -0.7, // this makes lines curved. Use value from -1 to 1
        Arrow = ArrowPosition.Middle,
        Color = "#CC0000",
        Alpha = 0.4,
        ArrowAlpha = 1,
        ArrowSize = 4
    },
    ZoomControl = new ZoomControl
    {
        GridHeight = 100,
        DraggerAlpha = 1,
        GridAlpha = 0.2
    }
};
```