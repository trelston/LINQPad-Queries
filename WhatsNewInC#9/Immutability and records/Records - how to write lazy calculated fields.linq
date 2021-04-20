<Query Kind="Statements" />

// This example illustrates how to efficiently implement lazy calculated fields in records.

var p1 = new Point(2,3,"pixels");
Console.WriteLine(p1.DistanceFromOrigin);	// 3.605551275463989

var p2 = p1 with { Y = 4 };
Console.WriteLine(p2.DistanceFromOrigin);	// 4.47213595499958

// The cache is not cleared unless X or Y appears in the member intializer:
Point p3 = p2 with { Units = "mm" };
Console.WriteLine(p3.DistanceFromOrigin);	// (No recomputation)

record Point
{

	public Point(double x, double y, string units) => (X, Y, Units) = (x, y, units);

	double _x, _y;

	public double X
	{
		get { return _x; }
		init { _x = value; _distanceFromOrigin = null; }
	}

	public double Y
	{
		get { return _y; }
		init { _y = value; _distanceFromOrigin = null; }
	}

	public string Units { get; init; }

	double? _distanceFromOrigin;    //This holds the cached value

	//This property is recalculated only when it needs to be
	public double DistanceFromOrigin => _distanceFromOrigin ??= Math.Sqrt(X * X + Y * Y);

}