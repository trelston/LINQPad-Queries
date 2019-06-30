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

    // BillOfMaterials
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Production_BillOfMaterialConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Production_BillOfMaterial>
    {
        public Production_BillOfMaterialConfiguration()
            : this("Production")
        {
        }

        public Production_BillOfMaterialConfiguration(string schema)
        {
            Property(x => x.ProductAssemblyId).IsOptional();
            Property(x => x.EndDate).IsOptional();
            Property(x => x.UnitMeasureCode).IsFixedLength();
            Property(x => x.PerAssemblyQty).HasPrecision(8,2);

        }
    }

}
// </auto-generated>
