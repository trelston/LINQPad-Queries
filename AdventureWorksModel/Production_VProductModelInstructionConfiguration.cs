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

    // vProductModelInstructions
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Production_VProductModelInstructionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Production_VProductModelInstruction>
    {
        public Production_VProductModelInstructionConfiguration()
            : this("Production")
        {
        }

        public Production_VProductModelInstructionConfiguration(string schema)
        {
            Property(x => x.Instructions).IsOptional();
            Property(x => x.LocationId).IsOptional();
            Property(x => x.SetupHours).IsOptional().HasPrecision(9,4);
            Property(x => x.MachineHours).IsOptional().HasPrecision(9,4);
            Property(x => x.LaborHours).IsOptional().HasPrecision(9,4);
            Property(x => x.LotSize).IsOptional();
            Property(x => x.Step).IsOptional();
        }
    }

}
// </auto-generated>
