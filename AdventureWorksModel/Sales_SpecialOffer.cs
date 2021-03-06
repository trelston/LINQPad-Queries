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

    // SpecialOffer
    ///<summary>
    /// Sale discounts lookup table.
    ///</summary>
    [Table("SpecialOffer", Schema = "Sales")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Sales_SpecialOffer
    {

        ///<summary>
        /// Primary key for SpecialOffer records.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"SpecialOfferID", Order = 1, TypeName = "int")]
        [Index(@"PK_SpecialOffer_SpecialOfferID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Special offer ID")]
        public int SpecialOfferId { get; set; } // SpecialOfferID (Primary key)

        ///<summary>
        /// Discount description.
        ///</summary>
        [Column(@"Description", Order = 2, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Description")]
        public string Description { get; set; } // Description (length: 255)

        ///<summary>
        /// Discount precentage.
        ///</summary>
        [Column(@"DiscountPct", Order = 3, TypeName = "smallmoney")]
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Discount pct")]
        public decimal DiscountPct { get; set; } // DiscountPct

        ///<summary>
        /// Discount type category.
        ///</summary>
        [Column(@"Type", Order = 4, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Type")]
        public string Type { get; set; } // Type (length: 50)

        ///<summary>
        /// Group the discount applies to such as Reseller or Customer.
        ///</summary>
        [Column(@"Category", Order = 5, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Category")]
        public string Category { get; set; } // Category (length: 50)

        ///<summary>
        /// Discount start date.
        ///</summary>
        [Column(@"StartDate", Order = 6, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Start date")]
        public System.DateTime StartDate { get; set; } // StartDate

        ///<summary>
        /// Discount end date.
        ///</summary>
        [Column(@"EndDate", Order = 7, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "End date")]
        public System.DateTime EndDate { get; set; } // EndDate

        ///<summary>
        /// Minimum discount percent allowed.
        ///</summary>
        [Column(@"MinQty", Order = 8, TypeName = "int")]
        [Required]
        [Display(Name = "Min qty")]
        public int MinQty { get; set; } // MinQty

        ///<summary>
        /// Maximum discount percent allowed.
        ///</summary>
        [Column(@"MaxQty", Order = 9, TypeName = "int")]
        [Display(Name = "Max qty")]
        public int? MaxQty { get; set; } // MaxQty

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        [Column(@"rowguid", Order = 10, TypeName = "uniqueidentifier")]
        [Index(@"AK_SpecialOffer_rowguid", 1, IsUnique = true, IsClustered = false)]
        [Required]
        [Display(Name = "Rowguid")]
        public System.Guid Rowguid { get; set; } // rowguid

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 11, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation

        /// <summary>
        /// Child Sales_SpecialOfferProducts where [SpecialOfferProduct].[SpecialOfferID] point to this entity (FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_SpecialOfferProduct> Sales_SpecialOfferProducts { get; set; } // SpecialOfferProduct.FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID

        public Sales_SpecialOffer()
        {
            DiscountPct = 0.00m;
            MinQty = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Sales_SpecialOfferProducts = new System.Collections.Generic.List<Sales_SpecialOfferProduct>();
        }
    }

}
// </auto-generated>
