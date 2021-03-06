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

    // Store
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Sales_StoreConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Sales_Store>
    {
        public Sales_StoreConfiguration()
            : this("Sales")
        {
        }

        public Sales_StoreConfiguration(string schema)
        {
            Property(x => x.SalesPersonId).IsOptional();
            Property(x => x.Demographics).IsOptional();

        }
    }

}
// </auto-generated>
