using System;
using System.Collections.Generic;

namespace AmChartsNet
{
    /// <summary>
    /// Creates a cursor for the chart which follows the mouse movements. 
    /// In case of AmSerialChart charts it shows the balloons of hovered data points.
    /// </summary>
    public class ChartCursor
    {

        public int? Adjustment { get; set; }
        public int? AnimationDuration { get; set; }
        public bool? AvoidBalloonOverlapping { get; set; }
        public string BalloonPointerOrientation { get; set; }
        public bool? BulletsEnabled { get; set; }
        public int? BulletSize { get; set; }
        public int? CategoryBalloonAlpha { get; set; }
        public string CategoryBalloonColor { get; set; }
        public string CategoryBalloonDateFormat { get; set; }
        public bool? CategoryBalloonEnabled { get; set; }
        public string CategoryBalloonFunction { get; set; }
        public string CategoryBalloonText { get; set; }
        public string Color { get; set; }
        public int? CursorAlpha { get; set; }
        public string CursorColor { get; set; }
        public string CursorPosition { get; set; }
        public bool? Enabled { get; set; }
        public bool? FullWidth { get; set; }
        public int? GraphBulletAlpha { get; set; }
        public int? GraphBulletSize { get; set; }
        public bool? LeaveAfterTouch { get; set; }
        public bool? LeaveCursor { get; set; }
        public AmGraph LimitToGraph { get; set; }
        public List<Object> Listeners { get; set; }
        public bool? OneBalloonOnly { get; set; }
        public bool? Pan { get; set; }
        public int? SelectionAlpha { get; set; }
        public bool? SelectWithoutZooming { get; set; }
        public bool? ShowNextAvailable { get; set; }
        public int? TabIndex { get; set; }
        public bool? ValueBalloonsEnabled { get; set; }
        public int? ValueLineAlpha { get; set; }
        public bool? ValueLineBalloonEnabled { get; set; }
        public bool? ValueLineEnabled { get; set; }
        public bool? ValueZoomable { get; set; }
        public bool? Zoomable { get; set; }
        public bool? Zooming { get; set; }


    }
}