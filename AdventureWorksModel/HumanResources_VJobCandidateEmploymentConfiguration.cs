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

    // vJobCandidateEmployment
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class HumanResources_VJobCandidateEmploymentConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<HumanResources_VJobCandidateEmployment>
    {
        public HumanResources_VJobCandidateEmploymentConfiguration()
            : this("HumanResources")
        {
        }

        public HumanResources_VJobCandidateEmploymentConfiguration(string schema)
        {
            Property(x => x.Emp46StartDate).IsOptional();
            Property(x => x.Emp46EndDate).IsOptional();
            Property(x => x.Emp46OrgName).IsOptional();
            Property(x => x.Emp46JobTitle).IsOptional();
            Property(x => x.Emp46Responsibility).IsOptional();
            Property(x => x.Emp46FunctionCategory).IsOptional();
            Property(x => x.Emp46IndustryCategory).IsOptional();
            Property(x => x.Emp46Loc46CountryRegion).IsOptional();
            Property(x => x.Emp46Loc46State).IsOptional();
            Property(x => x.Emp46Loc46City).IsOptional();
        }
    }

}
// </auto-generated>
