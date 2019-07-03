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
                .OpenSolutionAsync(@"C:\Users\funct\Downloads\TrelGithub\roslyn-sdk\Samples.sln").Result;
            Project project = solution.Projects.Single(x => x.Name == "AdventureWorks.ResourceAccess");
            _document = project.Documents.Single(x => x.Name == "HumanResources_Employee.cs");
        }

        private readonly Document _document;

        private class EmployeeSyntaxWalker : CSharpSyntaxWalker
        {
            public override void VisitPropertyDeclaration(PropertyDeclarationSyntax property)
            {
                string identifierValueText = property.Identifier.ValueText;
                object identifierValue = property.Identifier.Value;
                base.VisitPropertyDeclaration(property);
            }
        }

        [Fact]
        public void MyMethod()
        {
            Assert.Equal("HumanResources_Employee.cs", _document.Name);

            new EmployeeSyntaxWalker().Visit(_document.GetSyntaxRootAsync().Result);
        }
    }
}
