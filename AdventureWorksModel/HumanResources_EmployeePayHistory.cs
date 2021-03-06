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

    // EmployeePayHistory
    ///<summary>
    /// Employee pay history.
    ///</summary>
    [Table("EmployeePayHistory", Schema = "HumanResources")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class HumanResources_EmployeePayHistory
    {

        ///<summary>
        /// Employee identification number. Foreign key to Employee.BusinessEntityID.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"BusinessEntityID", Order = 1, TypeName = "int")]
        [Index(@"PK_EmployeePayHistory_BusinessEntityID_RateChangeDate", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Business entity ID")]
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        ///<summary>
        /// Date the change in pay is effective
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"RateChangeDate", Order = 2, TypeName = "datetime")]
        [Index(@"PK_EmployeePayHistory_BusinessEntityID_RateChangeDate", 2, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [DataType(DataType.DateTime)]
        [Display(Name = "Rate change date")]
        public System.DateTime RateChangeDate { get; set; } // RateChangeDate (Primary key)

        ///<summary>
        /// Salary hourly rate.
        ///</summary>
        [Column(@"Rate", Order = 3, TypeName = "money")]
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Rate")]
        public decimal Rate { get; set; } // Rate

        ///<summary>
        /// 1 = Salary received monthly, 2 = Salary received biweekly
        ///</summary>
        [Column(@"PayFrequency", Order = 4, TypeName = "tinyint")]
        [Required]
        [Display(Name = "Pay frequency")]
        public byte PayFrequency { get; set; } // PayFrequency

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
        /// Parent HumanResources_Employee pointed by [EmployeePayHistory].([BusinessEntityId]) (FK_EmployeePayHistory_Employee_BusinessEntityID)
        /// </summary>
        [ForeignKey("BusinessEntityId"), Required] public virtual HumanResources_Employee HumanResources_Employee { get; set; } // FK_EmployeePayHistory_Employee_BusinessEntityID

        public HumanResources_EmployeePayHistory()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>
