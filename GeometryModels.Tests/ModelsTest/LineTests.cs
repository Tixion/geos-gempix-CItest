﻿using GeometryModels;
using GeometryModels.Extensions;
using GeometryModels.GeometryPrimitiveIntersectors;
using GeometryModels.Models;

public class LineTests
{
	// Проверка на создание отрезка
	[Fact]
    public void Createline_Success()
    {
        //Arrage.
        Point point1 = new Point(1, 3);
        Point point2 = new Point(2, 3);
        Line line = new Line(point1, point2);
        //Act. + Assert.
        Assert.Equal(1, line.Point1.X);
    }

	// Проверка на вычисление длины отрезка
	[Fact]
    public void CalculatelineLength_Success()
    {
        //Arrage.
        Point point1 = new Point(0, 0);
        Point point2 = new Point(3, 4);
        Line line = new Line(point1, point2);
        //Act.
        double length = line.GetLength();
        //Assert.
        Assert.Equal(5, length);
    }

}
