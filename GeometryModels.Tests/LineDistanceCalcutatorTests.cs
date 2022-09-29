﻿using GeometryModels;
using System;

public class LineDistanceCalcutatorTests
{
    [Fact]
    public void DistanceBetweenPointAndline_Success()
    {
        //Arrage.
        Point point1 = new Point(2,3);
        Point point2 = new Point(7,3);
        Point point3 = new Point(5,0);
        //Act.
        Line line = new Line(point1, point2);
        //Assert.
        Assert.Equal(3, LineDistanceCalculator.GetDistance(point3, line));
    }
}
