﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryModels.Tests.DistanceTest
{
    public class PolygonDistanceCalculatorTests
    {
        [Fact]
        public void GetDistanceBetweenPolygonAndPoint_Success()
        {
            //Arrage.
            Point point1 = new Point(0, 0);
            Point point2 = new Point(0, 3);
            Point point3 = new Point(5, 4);
            Point point4 = new Point(3, 2);
            Point point = new Point(2, 2);
            var points = new List<Point>();
            points.Add(point1);
            points.Add(point2);
            points.Add(point3);
            points.Add(point4);
            Polygon polygon = new Polygon(points);
            //Act. + Assert.
            Assert.Equal(0, PolygonDistanceCalculator.GetDistance(polygon, point));
        }
    }
}