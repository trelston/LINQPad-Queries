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

    // WorkOrder
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Production_WorkOrderConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Production_WorkOrder>
    {
        public Production_WorkOrderConfiguration()
            : this("Production")
        {
        }

        public Production_WorkOrderConfiguration(string schema)
        {
            Property(x => x.EndDate).IsOptional();
            Property(x => x.ScrapReasonId).IsOptional();

        }
    }

}
// </auto-generated>
