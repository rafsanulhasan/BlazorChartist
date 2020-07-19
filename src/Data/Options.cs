namespace BlazorChartist
{
    public class AxisY
    {
        public bool? OnlyInteger { get; set; } = true;
        public double? Offset { get; set; } = 120;
        public bool? ShowGrid { get; set; } = false;
    }

    public class AxisX
    {
        public bool? ShowLabel { get; set; } = true;
        public bool? ShowGrid { get; set; } = false;
    }

    public class Options
    {
        public int? Width { get; set; }
        public int? Height { get; set; }
        public int? Low { get; set; } = 0;
        public bool? FullWidth { get; set; } = true;
        public bool? ShowPoint { get; set; } = false;
        public AxisY AxisY { get; set; } = new AxisY();
        public AxisX AxisX { get; set; } = new AxisX();
    }
}