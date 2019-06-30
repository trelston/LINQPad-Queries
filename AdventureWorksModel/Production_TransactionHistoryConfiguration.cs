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

    // TransactionHistory
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Production_TransactionHistoryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Production_TransactionHistory>
    {
        public Production_TransactionHistoryConfiguration()
            : this("Production")
        {
        }

        public Production_TransactionHistoryConfiguration(string schema)
        {
            Property(x => x.TransactionType).IsFixedLength();
            Property(x => x.ActualCost).HasPrecision(19,4);

        }
    }

}
// </auto-generated>
