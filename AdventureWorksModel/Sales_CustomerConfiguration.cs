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

    // Customer
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Sales_CustomerConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Sales_Customer>
    {
        public Sales_CustomerConfiguration()
            : this("Sales")
        {
        }

        public Sales_CustomerConfiguration(string schema)
        {
            Property(x => x.PersonId).IsOptional();
            Property(x => x.StoreId).IsOptional();
            Property(x => x.TerritoryId).IsOptional();
            Property(x => x.AccountNumber).IsUnicode(false);

        }
    }

}
// </auto-generated>