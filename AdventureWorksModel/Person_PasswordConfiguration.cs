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

    // Password
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Person_PasswordConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Person_Password>
    {
        public Person_PasswordConfiguration()
            : this("Person")
        {
        }

        public Person_PasswordConfiguration(string schema)
        {
            Property(x => x.PasswordHash).IsUnicode(false);
            Property(x => x.PasswordSalt).IsUnicode(false);

        }
    }

}
// </auto-generated>
