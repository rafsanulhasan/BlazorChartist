using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace BlazorChartist
{
    public class Series : ComponentBase, IDisposable
    {
        [Parameter] public string Name { get; set; }
        [Parameter] public IEnumerable<double> Values { get; set; }

        private readonly SeriesData data = new SeriesData();

        protected override void OnParametersSet()
        {
            data.Name = Name;
            data.Data = Values;
        }

        [CascadingParameter] public Chart OwnerChart { get; set; }

        protected override void OnInitialized()
            => OwnerChart.Data.Series.Add(data);

        public void Dispose()
            => OwnerChart.Data.Series.Remove(data);
    }
}