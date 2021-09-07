using System;
using System.Collections.Generic;
using UnityEngine;

public class BuildingASilhouette : MonoBehaviour
{
    [SerializeField] private List<LineRenderer> functionGraphs;
    [SerializeField] private double step;

    public void BuildGraphs()
    {
        PlotAFunctionGraph(-2, 2, functionGraphs[0], x => (Math.Exp(x) + Math.Exp(-x)) / 2);
        PlotAFunctionGraph(-2, 2, functionGraphs[1], x => -(Math.Exp(x) + Math.Exp(-x)) / 2);
        PlotAFunctionGraph(-2, 2, functionGraphs[2], x => (Math.Exp(x) - Math.Exp(-x)) / 2);
        PlotAFunctionGraph(-2, 2, functionGraphs[3], x => -(Math.Exp(x) - Math.Exp(-x)) / 2);

        PlotAFunctionGraph(-4, 4, functionGraphs[4], x => (Math.Exp(x) - Math.Exp(-x)) / (Math.Exp(x) + Math.Exp(-x)));
        PlotAFunctionGraph(-4, 4, functionGraphs[5], x => -((Math.Exp(x) - Math.Exp(-x)) / (Math.Exp(x) + Math.Exp(-x))));
        PlotAFunctionGraph(-4, 4, functionGraphs[6], x => 2 / (Math.Exp(x) + Math.Exp(-x)));
        PlotAFunctionGraph(-4, 4, functionGraphs[7], x => 2 / -(Math.Exp(x) + Math.Exp(-x)));
    }

    private void PlotAFunctionGraph(double xStart, double xEnd, LineRenderer functionGraph, Func<double, double> FunctionValue)
    {
        int pointNumber = 0;
        double x = xStart;
        double y = 0;

        while (x != xEnd - step)
        {
            y = FunctionValue(x);
            functionGraph.positionCount++;
            functionGraph.SetPosition(pointNumber, new Vector2((float)x, (float)y));
            pointNumber++;
            x -= step;
        }
    }
}
