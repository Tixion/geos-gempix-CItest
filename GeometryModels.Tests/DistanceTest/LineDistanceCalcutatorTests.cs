﻿using GeometryModels;
using GeometryModels.Extensions;
using GeometryModels.GeometryPrimitiveIntersectors;
using GeometryModels.Models;
using GeometryModels.Visitors.DistanceCalculators.ModelsDistanceCalculator;

public class LineDistanceCalcutatorTests
{
    [Fact]
    public void GetDistanceBetweenPointAndline_Success()
    {
        //Arrage.
        Point point1 = new Point(2,3);
        Point point2 = new Point(7,3);
        Point point3 = new Point(5,0);
        //Act.
        Line line = new Line(point1, point2);
        //Assert.
        Assert.Equal(3, DistanceExtencion.GetDistance(line, point3));
    }

    [Theory]
    [InlineData(1, 1, 2, 1, 0, 0, 3, 0)]
    [InlineData(0, 0, 0, 3, 4, 0, 4, 3)]
    public void IsLineIntersection_Success(double x11, double y11, double x12, double y12,
                                                    double x21, double y21, double x22, double y22)
    {
        //Arrage.
        Line line1 = new Line(new Point(x11, y11), new Point(x12, y12));
        Line line2 = new Line(new Point(x21, y21), new Point(x22, y22));
        //Act. + Assert.
        Assert.False(LineIntersector.Intersects(line1, line2));
    }

    [Fact]
    public void IsIntersection_Success()
    {
        //Arrage.
        Line line1 = new Line(new Point(1, 1), new Point(3, -2));
        Line line2 = new Line(new Point(4, 3), new Point(-2, -4));
        //Act. + Assert.
        Assert.True(LineIntersector.Intersects(line1, line2));
    }

    /*
    [Theory]
    [InlineData(1, 1, 1, 2, 1, 0, 0, 3, 0)]
    [InlineData(4, 0, 0, 0, 3, 4, 0, 5, 3)]
    public void GetDistanceBetweenTwoLines_Success(double expected, double x11, double y11, double x12, double y12,
                                                    double x21, double y21, double x22, double y22)
    {
        //Arrage.
        Line line1 = new Line(new Point(x11,y11), new Point(x12,y12));
        Line line2 = new Line(new Point(x21,y21), new Point(x22,y22));
        //Act. + Assert.
        Assert.Equal(expected, LineDistanceCalculator.GetDistance(line1,line2));
    }
    */
}
