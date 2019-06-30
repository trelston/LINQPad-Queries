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

    // vStoreWithDemographics
    [Table("vStoreWithDemographics", Schema = "Sales")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Sales_VStoreWithDemographic
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"BusinessEntityID", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Business entity ID")]
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"Name", Order = 2, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Key]
        [Display(Name = "Name")]
        public string Name { get; set; } // Name (Primary key) (length: 50)

        [Column(@"AnnualSales", Order = 3, TypeName = "money")]
        [DataType(DataType.Currency)]
        [Display(Name = "Annual sales")]
        public decimal? AnnualSales { get; set; } // AnnualSales

        [Column(@"AnnualRevenue", Order = 4, TypeName = "money")]
        [DataType(DataType.Currency)]
        [Display(Name = "Annual revenue")]
        public decimal? AnnualRevenue { get; set; } // AnnualRevenue

        [Column(@"BankName", Order = 5, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Bank name")]
        public string BankName { get; set; } // BankName (length: 50)

        [Column(@"BusinessType", Order = 6, TypeName = "nvarchar")]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Business type")]
        public string BusinessType { get; set; } // BusinessType (length: 5)

        [Column(@"YearOpened", Order = 7, TypeName = "int")]
        [Display(Name = "Year opened")]
        public int? YearOpened { get; set; } // YearOpened

        [Column(@"Specialty", Order = 8, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Specialty")]
        public string Specialty { get; set; } // Specialty (length: 50)

        [Column(@"SquareFeet", Order = 9, TypeName = "int")]
        [Display(Name = "Square feet")]
        public int? SquareFeet { get; set; } // SquareFeet

        [Column(@"Brands", Order = 10, TypeName = "nvarchar")]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Brands")]
        public string Brands { get; set; } // Brands (length: 30)

        [Column(@"Internet", Order = 11, TypeName = "nvarchar")]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Internet")]
        public string Internet { get; set; } // Internet (length: 30)

        [Column(@"NumberEmployees", Order = 12, TypeName = "int")]
        [Display(Name = "Number employees")]
        public int? NumberEmployees { get; set; } // NumberEmployees
    }

}
// </auto-generated>
