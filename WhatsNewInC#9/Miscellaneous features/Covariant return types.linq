<Query Kind="Statements">
  <RuntimeVersion>5.0</RuntimeVersion>
</Query>

// In C# 9, you can now return a more specific type when overriding a method.

class A
{
	public virtual A Clone() => new A();
}

class B : A
{
	public override B Clone() => new B();
}