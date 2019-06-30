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

    // AddressType
    ///<summary>
    /// Types of addresses stored in the Address table.
    ///</summary>
    [Table("AddressType", Schema = "Person")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Person_AddressType
    {

        ///<summary>
        /// Primary key for AddressType records.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"AddressTypeID", Order = 1, TypeName = "int")]
        [Index(@"PK_AddressType_AddressTypeID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Address type ID")]
        public int AddressTypeId { get; set; } // AddressTypeID (Primary key)

        ///<summary>
        /// Address type description. For example, Billing, Home, or Shipping.
        ///</summary>
        [Column(@"Name", Order = 2, TypeName = "nvarchar")]
        [Index(@"AK_AddressType_Name", 1, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; } // Name (length: 50)

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        [Column(@"rowguid", Order = 3, TypeName = "uniqueidentifier")]
        [Index(@"AK_AddressType_rowguid", 1, IsUnique = true, IsClustered = false)]
        [Required]
        [Display(Name = "Rowguid")]
        public System.Guid Rowguid { get; set; } // rowguid

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 4, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation

        /// <summary>
        /// Child Person_BusinessEntityAddresses where [BusinessEntityAddress].[AddressTypeID] point to this entity (FK_BusinessEntityAddress_AddressType_AddressTypeID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Person_BusinessEntityAddress> Person_BusinessEntityAddresses { get; set; } // BusinessEntityAddress.FK_BusinessEntityAddress_AddressType_AddressTypeID

        public Person_AddressType()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Person_BusinessEntityAddresses = new System.Collections.Generic.List<Person_BusinessEntityAddress>();
        }
    }

}
// </auto-generated>
