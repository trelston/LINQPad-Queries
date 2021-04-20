<Query Kind="Statements" />

// The relational pattern lets you use <,>, <= and >= in patterns.

string GetWeightCategory (decimal bmi) => bmi switch
	{
		< 18.5m => "underweight",
		< 25m => "normal",
		< 30m => "overweight",
		_ => "obese"
	};
	
// You can also use the relational pattern in simple expressions,
// althought it is not very useful on its own...

int x = 150;
(x is > 100).Dump($"{x} is greater than 100");