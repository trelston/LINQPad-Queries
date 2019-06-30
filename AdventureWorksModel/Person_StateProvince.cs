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

    // StateProvince
    ///<summary>
    /// State and province lookup table.
    ///</summary>
    [Table("StateProvince", Schema = "Person")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Person_StateProvince
    {

        ///<summary>
        /// Primary key for StateProvince records.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"StateProvinceID", Order = 1, TypeName = "int")]
        [Index(@"PK_StateProvince_StateProvinceID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "State province ID")]
        public int StateProvinceId { get; set; } // StateProvinceID (Primary key)

        ///<summary>
        /// ISO standard state or province code.
        ///</summary>
        [Column(@"StateProvinceCode", Order = 2, TypeName = "nchar")]
        [Index(@"AK_StateProvince_StateProvinceCode_CountryRegionCode", 1, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "State province code")]
        public string StateProvinceCode { get; set; } // StateProvinceCode (length: 3)

        ///<summary>
        /// ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode.
        ///</summary>
        [Column(@"CountryRegionCode", Order = 3, TypeName = "nvarchar")]
        [Index(@"AK_StateProvince_StateProvinceCode_CountryRegionCode", 2, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Country region code")]
        public string CountryRegionCode { get; set; } // CountryRegionCode (length: 3)

        ///<summary>
        /// 0 = StateProvinceCode exists. 1 = StateProvinceCode unavailable, using CountryRegionCode.
        ///</summary>
        [Column(@"IsOnlyStateProvinceFlag", Order = 4, TypeName = "bit")]
        [Required]
        [Display(Name = "Is only state province flag")]
        public bool IsOnlyStateProvinceFlag { get; set; } // IsOnlyStateProvinceFlag

        ///<summary>
        /// State or province description.
        ///</summary>
        [Column(@"Name", Order = 5, TypeName = "nvarchar")]
        [Index(@"AK_StateProvince_Name", 1, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; } // Name (length: 50)

        ///<summary>
        /// ID of the territory in which the state or province is located. Foreign key to SalesTerritory.SalesTerritoryID.
        ///</summary>
        [Column(@"TerritoryID", Order = 6, TypeName = "int")]
        [Required]
        [Display(Name = "Territory ID")]
        public int TerritoryId { get; set; } // TerritoryID

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        [Column(@"rowguid", Order = 7, TypeName = "uniqueidentifier")]
        [Index(@"AK_StateProvince_rowguid", 1, IsUnique = true, IsClustered = false)]
        [Required]
        [Display(Name = "Rowguid")]
        public System.Guid Rowguid { get; set; } // rowguid

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 8, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation

        /// <summary>
        /// Child Person_Addresses where [Address].[StateProvinceID] point to this entity (FK_Address_StateProvince_StateProvinceID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Person_Address> Person_Addresses { get; set; } // Address.FK_Address_StateProvince_StateProvinceID
        /// <summary>
        /// Child Sales_SalesTaxRates where [SalesTaxRate].[StateProvinceID] point to this entity (FK_SalesTaxRate_StateProvince_StateProvinceID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_SalesTaxRate> Sales_SalesTaxRates { get; set; } // SalesTaxRate.FK_SalesTaxRate_StateProvince_StateProvinceID

        // Foreign keys

        /// <summary>
        /// Parent Person_CountryRegion pointed by [StateProvince].([CountryRegionCode]) (FK_StateProvince_CountryRegion_CountryRegionCode)
        /// </summary>
        [ForeignKey("CountryRegionCode"), Required] public virtual Person_CountryRegion Person_CountryRegion { get; set; } // FK_StateProvince_CountryRegion_CountryRegionCode

        /// <summary>
        /// Parent Sales_SalesTerritory pointed by [StateProvince].([TerritoryId]) (FK_StateProvince_SalesTerritory_TerritoryID)
        /// </summary>
        [ForeignKey("TerritoryId"), Required] public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; } // FK_StateProvince_SalesTerritory_TerritoryID

        public Person_StateProvince()
        {
            IsOnlyStateProvinceFlag = true;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Person_Addresses = new System.Collections.Generic.List<Person_Address>();
            Sales_SalesTaxRates = new System.Collections.Generic.List<Sales_SalesTaxRate>();
        }
    }

}
// </auto-generated>
