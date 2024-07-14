﻿namespace ScottPlot.Interactivity.PlotResponses;

internal class KeyboardAutoscale(Key key) : KeyPressResponse(key, AutoScale)
{
    public static void AutoScale(Plot plot, Pixel pixel)
    {
        plot.Axes.AutoScale();
    }
}
