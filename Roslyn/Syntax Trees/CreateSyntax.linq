<Query Kind="Program">
  <NuGetReference>Microsoft.CodeAnalysis.CSharp</NuGetReference>
  <Namespace>Microsoft.CodeAnalysis</Namespace>
  <Namespace>Microsoft.CodeAnalysis.CSharp</Namespace>
  <Namespace>Microsoft.CodeAnalysis.CSharp.Syntax</Namespace>
  <Namespace>Microsoft.CodeAnalysis.Text</Namespace>
</Query>

void Main()
{
	var tree = CSharpSyntaxTree.ParseText("class Foo { void Bar() {}  }");
	var node = tree.GetRoot();
	node.Dump();
	
	var voidToken = SyntaxFactory.Token(SyntaxKind.VoidKeyword);
	var voidType = SyntaxFactory.PredefinedType(voidToken);
	var barMethod = SyntaxFactory.MethodDeclaration(voidType, "Bar")
										.WithBody(SyntaxFactory.Block());
	var classMembers = SyntaxFactory.List<MemberDeclarationSyntax>(new [] { barMethod });
	
	var fooClass = SyntaxFactory.ClassDeclaration("Foo")
										.WithMembers(classMembers)
										.NormalizeWhitespace();
										
	fooClass.Dump();
}

// Define other methods and classes here
