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

    // Store
    ///<summary>
    /// Customers (resellers) of Adventure Works products.
    ///</summary>
    [Table("Store", Schema = "Sales")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Sales_Store
    {

        ///<summary>
        /// Primary key. Foreign key to Customer.BusinessEntityID.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"BusinessEntityID", Order = 1, TypeName = "int")]
        [Index(@"PK_Store_BusinessEntityID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Business entity ID")]
        [ForeignKey("Person_BusinessEntity")]
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        ///<summary>
        /// Name of the store.
        ///</summary>
        [Column(@"Name", Order = 2, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; } // Name (length: 50)

        ///<summary>
        /// ID of the sales person assigned to the customer. Foreign key to SalesPerson.BusinessEntityID.
        ///</summary>
        [Column(@"SalesPersonID", Order = 3, TypeName = "int")]
        [Index(@"IX_Store_SalesPersonID", 1, IsUnique = false, IsClustered = false)]
        [Display(Name = "Sales person ID")]
        public int? SalesPersonId { get; set; } // SalesPersonID

        ///<summary>
        /// Demographic informationg about the store such as the number of employees, annual sales and store type.
        ///</summary>
        [Column(@"Demographics", Order = 4, TypeName = "xml")]
        [Display(Name = "Demographics")]
        public string Demographics { get; set; } // Demographics

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        [Column(@"rowguid", Order = 5, TypeName = "uniqueidentifier")]
        [Index(@"AK_Store_rowguid", 1, IsUnique = true, IsClustered = false)]
        [Required]
        [Display(Name = "Rowguid")]
        public System.Guid Rowguid { get; set; } // rowguid

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 6, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation

        /// <summary>
        /// Child Sales_Customers where [Customer].[StoreID] point to this entity (FK_Customer_Store_StoreID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_Customer> Sales_Customers { get; set; } // Customer.FK_Customer_Store_StoreID

        // Foreign keys

        /// <summary>
        /// Parent Person_BusinessEntity pointed by [Store].([BusinessEntityId]) (FK_Store_BusinessEntity_BusinessEntityID)
        /// </summary>
        [ForeignKey("BusinessEntityId"), Required] public virtual Person_BusinessEntity Person_BusinessEntity { get; set; } // FK_Store_BusinessEntity_BusinessEntityID

        /// <summary>
        /// Parent Sales_SalesPerson pointed by [Store].([SalesPersonId]) (FK_Store_SalesPerson_SalesPersonID)
        /// </summary>
        [ForeignKey("SalesPersonId")] public virtual Sales_SalesPerson Sales_SalesPerson { get; set; } // FK_Store_SalesPerson_SalesPersonID

        public Sales_Store()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Sales_Customers = new System.Collections.Generic.List<Sales_Customer>();
        }
    }

}
// </auto-generated>