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

    // ProductModelProductDescriptionCulture
    ///<summary>
    /// Cross-reference table mapping product descriptions and the language the description is written in.
    ///</summary>
    [Table("ProductModelProductDescriptionCulture", Schema = "Production")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Production_ProductModelProductDescriptionCulture
    {

        ///<summary>
        /// Primary key. Foreign key to ProductModel.ProductModelID.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ProductModelID", Order = 1, TypeName = "int")]
        [Index(@"PK_ProductModelProductDescriptionCulture_ProductModelID_ProductDescriptionID_CultureID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Product model ID")]
        public int ProductModelId { get; set; } // ProductModelID (Primary key)

        ///<summary>
        /// Primary key. Foreign key to ProductDescription.ProductDescriptionID.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ProductDescriptionID", Order = 2, TypeName = "int")]
        [Index(@"PK_ProductModelProductDescriptionCulture_ProductModelID_ProductDescriptionID_CultureID", 2, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Product description ID")]
        public int ProductDescriptionId { get; set; } // ProductDescriptionID (Primary key)

        ///<summary>
        /// Culture identification number. Foreign key to Culture.CultureID.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"CultureID", Order = 3, TypeName = "nchar")]
        [Index(@"PK_ProductModelProductDescriptionCulture_ProductModelID_ProductDescriptionID_CultureID", 3, IsUnique = true, IsClustered = true)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(6)]
        [StringLength(6)]
        [Key]
        [Display(Name = "Culture ID")]
        public string CultureId { get; set; } // CultureID (Primary key) (length: 6)

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 4, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys

        /// <summary>
        /// Parent Production_Culture pointed by [ProductModelProductDescriptionCulture].([CultureId]) (FK_ProductModelProductDescriptionCulture_Culture_CultureID)
        /// </summary>
        [ForeignKey("CultureId"), Required] public virtual Production_Culture Production_Culture { get; set; } // FK_ProductModelProductDescriptionCulture_Culture_CultureID

        /// <summary>
        /// Parent Production_ProductDescription pointed by [ProductModelProductDescriptionCulture].([ProductDescriptionId]) (FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID)
        /// </summary>
        [ForeignKey("ProductDescriptionId"), Required] public virtual Production_ProductDescription Production_ProductDescription { get; set; } // FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID

        /// <summary>
        /// Parent Production_ProductModel pointed by [ProductModelProductDescriptionCulture].([ProductModelId]) (FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID)
        /// </summary>
        [ForeignKey("ProductModelId"), Required] public virtual Production_ProductModel Production_ProductModel { get; set; } // FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID

        public Production_ProductModelProductDescriptionCulture()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>
