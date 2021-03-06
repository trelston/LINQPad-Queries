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

    // Employee
    ///<summary>
    /// Employee information such as salary, department, and title.
    ///</summary>
    [Table("Employee", Schema = "HumanResources")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class HumanResources_Employee
    {

        ///<summary>
        /// Primary key for Employee records.  Foreign key to BusinessEntity.BusinessEntityID.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"BusinessEntityID", Order = 1, TypeName = "int")]
        [Index(@"PK_Employee_BusinessEntityID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Business entity ID")]
        [ForeignKey("Person_Person")]
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        ///<summary>
        /// Unique national identification number such as a social security number.
        ///</summary>
        [Column(@"NationalIDNumber", Order = 2, TypeName = "nvarchar")]
        [Index(@"AK_Employee_NationalIDNumber", 1, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "National idn umber")]
        public string NationalIdNumber { get; set; } // NationalIDNumber (length: 15)

        ///<summary>
        /// Network login.
        ///</summary>
        [Column(@"LoginID", Order = 3, TypeName = "nvarchar")]
        [Index(@"AK_Employee_LoginID", 1, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Login ID")]
        public string LoginId { get; set; } // LoginID (length: 256)

        ///<summary>
        /// Where the employee is located in corporate hierarchy.
        ///</summary>
        [Column(@"OrganizationNode", Order = 4, TypeName = "hierarchyid")]
        [Index(@"IX_Employee_OrganizationNode", 1, IsUnique = false, IsClustered = false)]
        [Index(@"IX_Employee_OrganizationLevel_OrganizationNode", 2, IsUnique = false, IsClustered = false)]
        [Display(Name = "Organization node")]
        public System.Data.Entity.Hierarchy.HierarchyId OrganizationNode { get; set; } // OrganizationNode

        ///<summary>
        /// The depth of the employee in the corporate hierarchy.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(@"OrganizationLevel", Order = 5, TypeName = "smallint")]
        [Index(@"IX_Employee_OrganizationLevel_OrganizationNode", 1, IsUnique = false, IsClustered = false)]
        [Display(Name = "Organization level")]
        public short? OrganizationLevel { get; private set; } // OrganizationLevel

        ///<summary>
        /// Work title such as Buyer or Sales Representative.
        ///</summary>
        [Column(@"JobTitle", Order = 6, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Job title")]
        public string JobTitle { get; set; } // JobTitle (length: 50)

        ///<summary>
        /// Date of birth.
        ///</summary>
        [Column(@"BirthDate", Order = 7, TypeName = "date")]
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Birth date")]
        public System.DateTime BirthDate { get; set; } // BirthDate

        ///<summary>
        /// M = Married, S = Single
        ///</summary>
        [Column(@"MaritalStatus", Order = 8, TypeName = "nchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Marital status")]
        public string MaritalStatus { get; set; } // MaritalStatus (length: 1)

        ///<summary>
        /// M = Male, F = Female
        ///</summary>
        [Column(@"Gender", Order = 9, TypeName = "nchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Gender")]
        public string Gender { get; set; } // Gender (length: 1)

        ///<summary>
        /// Employee hired on this date.
        ///</summary>
        [Column(@"HireDate", Order = 10, TypeName = "date")]
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Hire date")]
        public System.DateTime HireDate { get; set; } // HireDate

        ///<summary>
        /// Job classification. 0 = Hourly, not exempt from collective bargaining. 1 = Salaried, exempt from collective bargaining.
        ///</summary>
        [Column(@"SalariedFlag", Order = 11, TypeName = "bit")]
        [Required]
        [Display(Name = "Salaried flag")]
        public bool SalariedFlag { get; set; } // SalariedFlag

        ///<summary>
        /// Number of available vacation hours.
        ///</summary>
        [Column(@"VacationHours", Order = 12, TypeName = "smallint")]
        [Required]
        [Display(Name = "Vacation hours")]
        public short VacationHours { get; set; } // VacationHours

        ///<summary>
        /// Number of available sick leave hours.
        ///</summary>
        [Column(@"SickLeaveHours", Order = 13, TypeName = "smallint")]
        [Required]
        [Display(Name = "Sick leave hours")]
        public short SickLeaveHours { get; set; } // SickLeaveHours

        ///<summary>
        /// 0 = Inactive, 1 = Active
        ///</summary>
        [Column(@"CurrentFlag", Order = 14, TypeName = "bit")]
        [Required]
        [Display(Name = "Current flag")]
        public bool CurrentFlag { get; set; } // CurrentFlag

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        [Column(@"rowguid", Order = 15, TypeName = "uniqueidentifier")]
        [Index(@"AK_Employee_rowguid", 1, IsUnique = true, IsClustered = false)]
        [Required]
        [Display(Name = "Rowguid")]
        public System.Guid Rowguid { get; set; } // rowguid

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 16, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) HumanResources_Employee pointed by [SalesPerson].[BusinessEntityID] (FK_SalesPerson_Employee_BusinessEntityID)
        /// </summary>
        public virtual Sales_SalesPerson Sales_SalesPerson { get; set; } // SalesPerson.FK_SalesPerson_Employee_BusinessEntityID
        /// <summary>
        /// Child HumanResources_EmployeeDepartmentHistories where [EmployeeDepartmentHistory].[BusinessEntityID] point to this entity (FK_EmployeeDepartmentHistory_Employee_BusinessEntityID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<HumanResources_EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistories { get; set; } // EmployeeDepartmentHistory.FK_EmployeeDepartmentHistory_Employee_BusinessEntityID
        /// <summary>
        /// Child HumanResources_EmployeePayHistories where [EmployeePayHistory].[BusinessEntityID] point to this entity (FK_EmployeePayHistory_Employee_BusinessEntityID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<HumanResources_EmployeePayHistory> HumanResources_EmployeePayHistories { get; set; } // EmployeePayHistory.FK_EmployeePayHistory_Employee_BusinessEntityID
        /// <summary>
        /// Child HumanResources_JobCandidates where [JobCandidate].[BusinessEntityID] point to this entity (FK_JobCandidate_Employee_BusinessEntityID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<HumanResources_JobCandidate> HumanResources_JobCandidates { get; set; } // JobCandidate.FK_JobCandidate_Employee_BusinessEntityID
        /// <summary>
        /// Child Production_Documents where [Document].[Owner] point to this entity (FK_Document_Employee_Owner)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_Document> Production_Documents { get; set; } // Document.FK_Document_Employee_Owner
        /// <summary>
        /// Child Purchasing_PurchaseOrderHeaders where [PurchaseOrderHeader].[EmployeeID] point to this entity (FK_PurchaseOrderHeader_Employee_EmployeeID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeaders { get; set; } // PurchaseOrderHeader.FK_PurchaseOrderHeader_Employee_EmployeeID

        // Foreign keys

        /// <summary>
        /// Parent Person_Person pointed by [Employee].([BusinessEntityId]) (FK_Employee_Person_BusinessEntityID)
        /// </summary>
        [ForeignKey("BusinessEntityId"), Required] public virtual Person_Person Person_Person { get; set; } // FK_Employee_Person_BusinessEntityID

        public HumanResources_Employee()
        {
            SalariedFlag = true;
            VacationHours = 0;
            SickLeaveHours = 0;
            CurrentFlag = true;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Production_Documents = new System.Collections.Generic.List<Production_Document>();
            HumanResources_EmployeeDepartmentHistories = new System.Collections.Generic.List<HumanResources_EmployeeDepartmentHistory>();
            HumanResources_EmployeePayHistories = new System.Collections.Generic.List<HumanResources_EmployeePayHistory>();
            HumanResources_JobCandidates = new System.Collections.Generic.List<HumanResources_JobCandidate>();
            Purchasing_PurchaseOrderHeaders = new System.Collections.Generic.List<Purchasing_PurchaseOrderHeader>();
        }
    }

}
// </auto-generated>
