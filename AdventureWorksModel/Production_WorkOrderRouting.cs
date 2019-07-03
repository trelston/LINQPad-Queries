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

    // WorkOrderRouting
    ///<summary>
    /// Work order details.
    ///</summary>
    [Table("WorkOrderRouting", Schema = "Production")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Production_WorkOrderRouting
    {

        ///<summary>
        /// Primary key. Foreign key to WorkOrder.WorkOrderID.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"WorkOrderID", Order = 1, TypeName = "int")]
        [Index(@"PK_WorkOrderRouting_WorkOrderID_ProductID_OperationSequence", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Work order ID")]
        public int WorkOrderId { get; set; } // WorkOrderID (Primary key)

        ///<summary>
        /// Primary key. Foreign key to Product.ProductID.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ProductID", Order = 2, TypeName = "int")]
        [Index(@"IX_WorkOrderRouting_ProductID", 1, IsUnique = false, IsClustered = false)]
        [Index(@"PK_WorkOrderRouting_WorkOrderID_ProductID_OperationSequence", 2, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; } // ProductID (Primary key)

        ///<summary>
        /// Primary key. Indicates the manufacturing process sequence.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"OperationSequence", Order = 3, TypeName = "smallint")]
        [Index(@"PK_WorkOrderRouting_WorkOrderID_ProductID_OperationSequence", 3, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Operation sequence")]
        public short OperationSequence { get; set; } // OperationSequence (Primary key)

        ///<summary>
        /// Manufacturing location where the part is processed. Foreign key to Location.LocationID.
        ///</summary>
        [Column(@"LocationID", Order = 4, TypeName = "smallint")]
        [Required]
        [Display(Name = "Location ID")]
        public short LocationId { get; set; } // LocationID

        ///<summary>
        /// Planned manufacturing start date.
        ///</summary>
        [Column(@"ScheduledStartDate", Order = 5, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Scheduled start date")]
        public System.DateTime ScheduledStartDate { get; set; } // ScheduledStartDate

        ///<summary>
        /// Planned manufacturing end date.
        ///</summary>
        [Column(@"ScheduledEndDate", Order = 6, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Scheduled end date")]
        public System.DateTime ScheduledEndDate { get; set; } // ScheduledEndDate

        ///<summary>
        /// Actual start date.
        ///</summary>
        [Column(@"ActualStartDate", Order = 7, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Actual start date")]
        public System.DateTime? ActualStartDate { get; set; } // ActualStartDate

        ///<summary>
        /// Actual end date.
        ///</summary>
        [Column(@"ActualEndDate", Order = 8, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Actual end date")]
        public System.DateTime? ActualEndDate { get; set; } // ActualEndDate

        ///<summary>
        /// Number of manufacturing hours used.
        ///</summary>
        [Column(@"ActualResourceHrs", Order = 9, TypeName = "decimal")]
        [Display(Name = "Actual resource hrs")]
        public decimal? ActualResourceHrs { get; set; } // ActualResourceHrs

        ///<summary>
        /// Estimated manufacturing cost.
        ///</summary>
        [Column(@"PlannedCost", Order = 10, TypeName = "money")]
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Planned cost")]
        public decimal PlannedCost { get; set; } // PlannedCost

        ///<summary>
        /// Actual manufacturing cost.
        ///</summary>
        [Column(@"ActualCost", Order = 11, TypeName = "money")]
        [DataType(DataType.Currency)]
        [Display(Name = "Actual cost")]
        public decimal? ActualCost { get; set; } // ActualCost

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 12, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys

        /// <summary>
        /// Parent Production_Location pointed by [WorkOrderRouting].([LocationId]) (FK_WorkOrderRouting_Location_LocationID)
        /// </summary>
        [ForeignKey("LocationId"), Required] public virtual Production_Location Production_Location { get; set; } // FK_WorkOrderRouting_Location_LocationID

        /// <summary>
        /// Parent Production_WorkOrder pointed by [WorkOrderRouting].([WorkOrderId]) (FK_WorkOrderRouting_WorkOrder_WorkOrderID)
        /// </summary>
        [ForeignKey("WorkOrderId"), Required] public virtual Production_WorkOrder Production_WorkOrder { get; set; } // FK_WorkOrderRouting_WorkOrder_WorkOrderID

        public Production_WorkOrderRouting()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>