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

    // vProductAndDescription
    [Table("vProductAndDescription", Schema = "Production")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Production_VProductAndDescription
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ProductID", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; } // ProductID (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"Name", Order = 2, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Key]
        [Display(Name = "Name")]
        public string Name { get; set; } // Name (Primary key) (length: 50)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ProductModel", Order = 3, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Key]
        [Display(Name = "Product model")]
        public string ProductModel { get; set; } // ProductModel (Primary key) (length: 50)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"CultureID", Order = 4, TypeName = "nchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(6)]
        [StringLength(6)]
        [Key]
        [Display(Name = "Culture ID")]
        public string CultureId { get; set; } // CultureID (Primary key) (length: 6)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"Description", Order = 5, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(400)]
        [StringLength(400)]
        [Key]
        [Display(Name = "Description")]
        public string Description { get; set; } // Description (Primary key) (length: 400)
    }

}
// </auto-generated>
