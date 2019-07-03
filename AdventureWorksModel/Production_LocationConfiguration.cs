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

    // Location
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Production_LocationConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Production_Location>
    {
        public Production_LocationConfiguration()
            : this("Production")
        {
        }

        public Production_LocationConfiguration(string schema)
        {
            Property(x => x.CostRate).HasPrecision(10,4);
            Property(x => x.Availability).HasPrecision(8,2);
        }
    }

}
// </auto-generated>