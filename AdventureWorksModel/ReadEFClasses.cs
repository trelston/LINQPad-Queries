using System.Linq;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using Xunit;

namespace AdventureWorks.ResourceAccess.Tests
{
    public class ReadEFClasses
    {
        public ReadEFClasses()
        {
            MSBuildLocator.RegisterDefaults();
            MSBuildWorkspace workspace = MSBuildWorkspace.Create();
            Solution solution = workspace
                .OpenSolutionAsync(@"C:\Users\367463\Source\Repos\roslyn-sdk\Samples.sln").Result;
            Project project = solution.Projects.Single(x => x.Name == "AdventureWorks.ResourceAccess");
            _document = project.Documents.Single(x => x.Name == "HumanResources_Employee.cs");
            _semanticModel = _document.GetSemanticModelAsync().Result;
        }

        private readonly Document _document;
        public readonly SemanticModel _semanticModel;

        private class EmployeeSyntaxWalker : CSharpSyntaxWalker
        {
            public SemanticModel SemanticModel { get; set; }

            public override void VisitPropertyDeclaration(PropertyDeclarationSyntax property)
            {
                string identifierValueText = property.Identifier.ValueText;
                IPropertySymbol type =  SemanticModel.GetDeclaredSymbol(property);

                foreach (AttributeListSyntax attributeList in property.AttributeLists)
                {
                    foreach (AttributeSyntax attribute in attributeList.Attributes)
                    {
                        string text = ((IdentifierNameSyntax)attribute.Name).Identifier.ValueText;

                        foreach (AttributeArgumentSyntax item in attribute.ArgumentList.Arguments)
                        {
                            new AttributeArgumentWalker
                            {
                                SemanticModel = SemanticModel
                            }.Visit(item);
                        }
                    }
                }

                base.VisitPropertyDeclaration(property);
            }
        }

        private class AttributeArgumentWalker : CSharpSyntaxWalker
        {
            public SemanticModel SemanticModel { get; set; }

            public override void VisitAttributeArgument(AttributeArgumentSyntax node)
            {
                if (node.Expression is MemberAccessExpressionSyntax)
                {
                    SymbolInfo text = SemanticModel.GetSymbolInfo(((MemberAccessExpressionSyntax)node.Expression).Expression);
                }

                if (node.Expression is VariableDeclarationSyntax)
                {

                }

                if (node.Expression is LiteralExpressionSyntax)
                {
                    ISymbol symbol = SemanticModel.GetDeclaredSymbol((AttributeArgumentSyntax)node);
                    string test = node.Expression.GetFirstToken().ValueText;
                }

                base.VisitAttributeArgument(node);
            }
        }

        [Fact]
        public void MyMethod()
        {
            Assert.Equal("HumanResources_Employee.cs", _document.Name);
            EmployeeSyntaxWalker walker = new EmployeeSyntaxWalker()
            {
                SemanticModel = _semanticModel
            };
            walker.Visit(_document.GetSyntaxRootAsync().Result);
        }
    }
}
