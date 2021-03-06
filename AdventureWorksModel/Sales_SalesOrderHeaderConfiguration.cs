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

    // SalesOrderHeader
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Sales_SalesOrderHeaderConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Sales_SalesOrderHeader>
    {
        public Sales_SalesOrderHeaderConfiguration()
            : this("Sales")
        {
        }

        public Sales_SalesOrderHeaderConfiguration(string schema)
        {
            Property(x => x.ShipDate).IsOptional();
            Property(x => x.PurchaseOrderNumber).IsOptional();
            Property(x => x.AccountNumber).IsOptional();
            Property(x => x.SalesPersonId).IsOptional();
            Property(x => x.TerritoryId).IsOptional();
            Property(x => x.CreditCardId).IsOptional();
            Property(x => x.CreditCardApprovalCode).IsOptional().IsUnicode(false);
            Property(x => x.CurrencyRateId).IsOptional();
            Property(x => x.SubTotal).HasPrecision(19,4);
            Property(x => x.TaxAmt).HasPrecision(19,4);
            Property(x => x.Freight).HasPrecision(19,4);
            Property(x => x.TotalDue).HasPrecision(19,4);
            Property(x => x.Comment).IsOptional();

        }
    }

}
// </auto-generated>
