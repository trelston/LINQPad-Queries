<Query Kind="Program" />

void Main()
{
	var address = new Address { State = "WA" };
	ComputeSalesTax(address, 100).Dump();
}

// You can define other methods, fields, classes and namespaces here
static decimal ComputeSalesTax(Address location, decimal SalesPrice) =>
	location switch
	{
		{State: "WA" } => SalesPrice * 0.06M,
		{State: "MN" } => SalesPrice * 0.75M,
		{State: "MI" } => SalesPrice * 0.05M,
		_ => 0M
	};


class Address
{
	public string State;
}