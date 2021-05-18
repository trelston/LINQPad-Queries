<Query Kind="Statements" />

var numbers = new int[] {1,2,3,4,5};
string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim" };

 // Create array which is 5 elements larger than Int32.MaxValue
var largeArr = Enumerable.Range(0, Int32.MaxValue).Concat(Enumerable.Range(0, 5));


//Aggregation(simple)
//Performs a specified operation to each element in a collection while carrying the result forward
var result = numbers.Aggregate ((x, y) => x * y);
result.Dump();

//Aggregation(seed)
//Performs a specified operation to each element in a collection, while carrying the result forward
result = numbers.Aggregate(10, (a, b) => a + b);
result.Dump();

//Average
//Computes the average value for a numeric collections
numbers.Average().Dump();

// Returns the number of elements in a collection.
names.Count().Dump();

//LongCount
// Returns the number of elements in collections larger than Int32.MaxValue.
//largeArr.LongCount().Dump();
