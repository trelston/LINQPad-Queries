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

    // ShoppingCartItem
    ///<summary>
    /// Contains online customer orders until the order is submitted or cancelled.
    ///</summary>
    [Table("ShoppingCartItem", Schema = "Sales")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Sales_ShoppingCartItem
    {

        ///<summary>
        /// Primary key for ShoppingCartItem records.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ShoppingCartItemID", Order = 1, TypeName = "int")]
        [Index(@"PK_ShoppingCartItem_ShoppingCartItemID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Shopping cart item ID")]
        public int ShoppingCartItemId { get; set; } // ShoppingCartItemID (Primary key)

        ///<summary>
        /// Shopping cart identification number.
        ///</summary>
        [Column(@"ShoppingCartID", Order = 2, TypeName = "nvarchar")]
        [Index(@"IX_ShoppingCartItem_ShoppingCartID_ProductID", 1, IsUnique = false, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Shopping cart ID")]
        public string ShoppingCartId { get; set; } // ShoppingCartID (length: 50)

        ///<summary>
        /// Product quantity ordered.
        ///</summary>
        [Column(@"Quantity", Order = 3, TypeName = "int")]
        [Required]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; } // Quantity

        ///<summary>
        /// Product ordered. Foreign key to Product.ProductID.
        ///</summary>
        [Column(@"ProductID", Order = 4, TypeName = "int")]
        [Index(@"IX_ShoppingCartItem_ShoppingCartID_ProductID", 2, IsUnique = false, IsClustered = false)]
        [Required]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; } // ProductID

        ///<summary>
        /// Date the time the record was created.
        ///</summary>
        [Column(@"DateCreated", Order = 5, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Date created")]
        public System.DateTime DateCreated { get; set; } // DateCreated

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 6, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys

        /// <summary>
        /// Parent Production_Product pointed by [ShoppingCartItem].([ProductId]) (FK_ShoppingCartItem_Product_ProductID)
        /// </summary>
        [ForeignKey("ProductId"), Required] public virtual Production_Product Production_Product { get; set; } // FK_ShoppingCartItem_Product_ProductID

        public Sales_ShoppingCartItem()
        {
            Quantity = 1;
            DateCreated = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>
