﻿namespace ScottPlot.Interactivity.PlotResponses;

public class SingleClickContextMenu(MouseButton button) : SingleClickResponse(button, LaunchContextMenu)
{
    public static void LaunchContextMenu(Plot plot, Pixel pixel)
    {
        plot.PlotControl?.ShowContextMenu(pixel);
    }
}

