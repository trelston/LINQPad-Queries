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

    // SalesPersonQuotaHistory
    ///<summary>
    /// Sales performance tracking.
    ///</summary>
    [Table("SalesPersonQuotaHistory", Schema = "Sales")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Sales_SalesPersonQuotaHistory
    {

        ///<summary>
        /// Sales person identification number. Foreign key to SalesPerson.BusinessEntityID.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"BusinessEntityID", Order = 1, TypeName = "int")]
        [Index(@"PK_SalesPersonQuotaHistory_BusinessEntityID_QuotaDate", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Business entity ID")]
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        ///<summary>
        /// Sales quota date.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"QuotaDate", Order = 2, TypeName = "datetime")]
        [Index(@"PK_SalesPersonQuotaHistory_BusinessEntityID_QuotaDate", 2, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [DataType(DataType.DateTime)]
        [Display(Name = "Quota date")]
        public System.DateTime QuotaDate { get; set; } // QuotaDate (Primary key)

        ///<summary>
        /// Sales quota amount.
        ///</summary>
        [Column(@"SalesQuota", Order = 3, TypeName = "money")]
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Sales quota")]
        public decimal SalesQuota { get; set; } // SalesQuota

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        [Column(@"rowguid", Order = 4, TypeName = "uniqueidentifier")]
        [Index(@"AK_SalesPersonQuotaHistory_rowguid", 1, IsUnique = true, IsClustered = false)]
        [Required]
        [Display(Name = "Rowguid")]
        public System.Guid Rowguid { get; set; } // rowguid

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 5, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys

        /// <summary>
        /// Parent Sales_SalesPerson pointed by [SalesPersonQuotaHistory].([BusinessEntityId]) (FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID)
        /// </summary>
        [ForeignKey("BusinessEntityId"), Required] public virtual Sales_SalesPerson Sales_SalesPerson { get; set; } // FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID

        public Sales_SalesPersonQuotaHistory()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>
