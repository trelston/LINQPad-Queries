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

    // PersonPhone
    ///<summary>
    /// Telephone number and type of a person.
    ///</summary>
    [Table("PersonPhone", Schema = "Person")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Person_PersonPhone
    {

        ///<summary>
        /// Business entity identification number. Foreign key to Person.BusinessEntityID.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"BusinessEntityID", Order = 1, TypeName = "int")]
        [Index(@"PK_PersonPhone_BusinessEntityID_PhoneNumber_PhoneNumberTypeID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Business entity ID")]
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        ///<summary>
        /// Telephone number identification number.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"PhoneNumber", Order = 2, TypeName = "nvarchar")]
        [Index(@"IX_PersonPhone_PhoneNumber", 1, IsUnique = false, IsClustered = false)]
        [Index(@"PK_PersonPhone_BusinessEntityID_PhoneNumber_PhoneNumberTypeID", 2, IsUnique = true, IsClustered = true)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Key]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; } // PhoneNumber (Primary key) (length: 25)

        ///<summary>
        /// Kind of phone number. Foreign key to PhoneNumberType.PhoneNumberTypeID.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"PhoneNumberTypeID", Order = 3, TypeName = "int")]
        [Index(@"PK_PersonPhone_BusinessEntityID_PhoneNumber_PhoneNumberTypeID", 3, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Phone number type ID")]
        public int PhoneNumberTypeId { get; set; } // PhoneNumberTypeID (Primary key)

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
        /// Parent Person_Person pointed by [PersonPhone].([BusinessEntityId]) (FK_PersonPhone_Person_BusinessEntityID)
        /// </summary>
        [ForeignKey("BusinessEntityId"), Required] public virtual Person_Person Person_Person { get; set; } // FK_PersonPhone_Person_BusinessEntityID

        /// <summary>
        /// Parent Person_PhoneNumberType pointed by [PersonPhone].([PhoneNumberTypeId]) (FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID)
        /// </summary>
        [ForeignKey("PhoneNumberTypeId"), Required] public virtual Person_PhoneNumberType Person_PhoneNumberType { get; set; } // FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID

        public Person_PersonPhone()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>
