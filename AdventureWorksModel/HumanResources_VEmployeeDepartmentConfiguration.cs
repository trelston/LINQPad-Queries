// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureWorks.ResourceAccess.Model
{

    // vEmployeeDepartment
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class HumanResources_VEmployeeDepartmentConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<HumanResources_VEmployeeDepartment>
    {
        public HumanResources_VEmployeeDepartmentConfiguration()
            : this("HumanResources")
        {
        }

        public HumanResources_VEmployeeDepartmentConfiguration(string schema)
        {
            Property(x => x.Title).IsOptional();
            Property(x => x.MiddleName).IsOptional();
            Property(x => x.Suffix).IsOptional();
        }
    }

}
// </auto-generated>
