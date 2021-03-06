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

    // DatabaseLog
    ///<summary>
    /// Audit table tracking all DDL changes made to the AdventureWorks database. Data is captured by the database trigger ddlDatabaseTriggerLog.
    ///</summary>
    [Table("DatabaseLog", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class DatabaseLog
    {

        ///<summary>
        /// Primary key for DatabaseLog records.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"DatabaseLogID", Order = 1, TypeName = "int")]
        [Index(@"PK_DatabaseLog_DatabaseLogID", 1, IsUnique = true, IsClustered = false)]
        [Required]
        [Key]
        [Display(Name = "Database log ID")]
        public int DatabaseLogId { get; set; } // DatabaseLogID (Primary key)

        ///<summary>
        /// The date and time the DDL change occurred.
        ///</summary>
        [Column(@"PostTime", Order = 2, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Post time")]
        public System.DateTime PostTime { get; set; } // PostTime

        ///<summary>
        /// The user who implemented the DDL change.
        ///</summary>
        [Column(@"DatabaseUser", Order = 3, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Database user")]
        public string DatabaseUser { get; set; } // DatabaseUser (length: 128)

        ///<summary>
        /// The type of DDL statement that was executed.
        ///</summary>
        [Column(@"Event", Order = 4, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Event")]
        public string Event { get; set; } // Event (length: 128)

        ///<summary>
        /// The schema to which the changed object belongs.
        ///</summary>
        [Column(@"Schema", Order = 5, TypeName = "nvarchar")]
        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Schema")]
        public string Schema { get; set; } // Schema (length: 128)

        ///<summary>
        /// The object that was changed by the DDL statment.
        ///</summary>
        [Column(@"Object", Order = 6, TypeName = "nvarchar")]
        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Object")]
        public string Object { get; set; } // Object (length: 128)

        ///<summary>
        /// The exact Transact-SQL statement that was executed.
        ///</summary>
        [Column(@"TSQL", Order = 7, TypeName = "nvarchar(max)")]
        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Tsql")]
        public string Tsql { get; set; } // TSQL

        ///<summary>
        /// The raw XML data generated by database trigger.
        ///</summary>
        [Column(@"XmlEvent", Order = 8, TypeName = "xml")]
        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Xml event")]
        public string XmlEvent { get; set; } // XmlEvent
    }

}
// </auto-generated>
