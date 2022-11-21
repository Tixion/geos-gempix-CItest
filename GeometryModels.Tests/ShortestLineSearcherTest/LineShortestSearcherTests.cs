﻿using GeometryModels.Models;
using GeometryModels.Visitors.ShortestLineSearchers.ModelsShortestLineSearcher;

namespace GeometryModels.Tests.ShortestLineSearcherTest
{
	public class LineShortestSearcherTests
	{
		[Fact]
		public static void GetShortestLineBetweenLineAndPoint()
		{
			//Arrage.
			Line line = new Line(new Point(0,0), new Point(3,3));
			Point point = new Point(0,2);
			//Act.
			Line shortLine = LineShortestLineSearcher.GetShortestLine(line, point);
			//Assert.
			Assert.Equal(2, shortLine.GetLength());
		}
	}
}