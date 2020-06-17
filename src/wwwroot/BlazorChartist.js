var BlazorChartist = {
    createChart: function(elem) {
        new Chartist.Line(elem, {
            labels: ['Mon', 'Tue', 'Wed', 'Thu', 'Fri'],
            series: [[5, 2, 4, 2, 0]]
        });
    }
}