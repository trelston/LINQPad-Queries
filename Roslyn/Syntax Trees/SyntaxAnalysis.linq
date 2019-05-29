<Query Kind="Program">
  <NuGetReference>Microsoft.CodeAnalysis.CSharp</NuGetReference>
  <Namespace>Microsoft.CodeAnalysis</Namespace>
  <Namespace>Microsoft.CodeAnalysis.CSharp</Namespace>
  <Namespace>Microsoft.CodeAnalysis.CSharp.Syntax</Namespace>
  <Namespace>Microsoft.CodeAnalysis.Text</Namespace>
</Query>

void Main()
{
	var tree = CSharpSyntaxTree.ParseText("class Foo { void Bar () {} } ");
	var node = (CompilationUnitSyntax)tree.GetRoot();
	
	//1. Using the object model
	foreach (var member in node.Members)
	{
		if (member.Kind() == SyntaxKind.ClassDeclaration)
		{
			var @class = (ClassDeclarationSyntax)member;
			
			foreach (var member2 in @class.Members)
			{
				if (member2.Kind() == SyntaxKind.MethodDeclaration)
				{
					var method = (MethodDeclarationSyntax)member2;
					//do stuff
				}
			}
		}
	}
	
	//2. Using LINQ query methods
	var bars = from member in node.Members.OfType<ClassDeclarationSyntax>()
				from member2 in member.Members.OfType<MethodDeclarationSyntax>()
				where member2.Identifier.Text == "Bar"
				select member2;
	
	bars.Dump();
	
	//3. Using visitors
	new MyVisitor().Visit(node);
	
}

class MyVisitor : CSharpSyntaxWalker
{
	public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
	{
		if (node.Identifier.Text == "Bar")
		{
			//do stuff
		}
		
		base.VisitMethodDeclaration(node);		
	}
}
