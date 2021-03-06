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

    // vSalesPerson
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Sales_VSalesPersonConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Sales_VSalesPerson>
    {
        public Sales_VSalesPersonConfiguration()
            : this("Sales")
        {
        }

        public Sales_VSalesPersonConfiguration(string schema)
        {
            Property(x => x.Title).IsOptional();
            Property(x => x.MiddleName).IsOptional();
            Property(x => x.Suffix).IsOptional();
            Property(x => x.PhoneNumber).IsOptional();
            Property(x => x.PhoneNumberType).IsOptional();
            Property(x => x.EmailAddress).IsOptional();
            Property(x => x.AddressLine2).IsOptional();
            Property(x => x.TerritoryName).IsOptional();
            Property(x => x.TerritoryGroup).IsOptional();
            Property(x => x.SalesQuota).IsOptional().HasPrecision(19,4);
            Property(x => x.SalesYtd).HasPrecision(19,4);
            Property(x => x.SalesLastYear).HasPrecision(19,4);
        }
    }

}
// </auto-generated>
