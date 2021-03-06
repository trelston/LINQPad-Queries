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

    public interface IAdventureWorksDBContext : System.IDisposable
    {
        System.Data.Entity.DbSet<AwBuildVersion> AwBuildVersions { get; set; } // AWBuildVersion
        System.Data.Entity.DbSet<DatabaseLog> DatabaseLogs { get; set; } // DatabaseLog
        System.Data.Entity.DbSet<ErrorLog> ErrorLogs { get; set; } // ErrorLog
        System.Data.Entity.DbSet<HumanResources_Department> HumanResources_Departments { get; set; } // Department
        System.Data.Entity.DbSet<HumanResources_Employee> HumanResources_Employees { get; set; } // Employee
        System.Data.Entity.DbSet<HumanResources_EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistories { get; set; } // EmployeeDepartmentHistory
        System.Data.Entity.DbSet<HumanResources_EmployeePayHistory> HumanResources_EmployeePayHistories { get; set; } // EmployeePayHistory
        System.Data.Entity.DbSet<HumanResources_JobCandidate> HumanResources_JobCandidates { get; set; } // JobCandidate
        System.Data.Entity.DbSet<HumanResources_Shift> HumanResources_Shifts { get; set; } // Shift
        System.Data.Entity.DbSet<HumanResources_VEmployee> HumanResources_VEmployees { get; set; } // vEmployee
        System.Data.Entity.DbSet<HumanResources_VEmployeeDepartment> HumanResources_VEmployeeDepartments { get; set; } // vEmployeeDepartment
        System.Data.Entity.DbSet<HumanResources_VEmployeeDepartmentHistory> HumanResources_VEmployeeDepartmentHistories { get; set; } // vEmployeeDepartmentHistory
        System.Data.Entity.DbSet<HumanResources_VJobCandidate> HumanResources_VJobCandidates { get; set; } // vJobCandidate
        System.Data.Entity.DbSet<HumanResources_VJobCandidateEducation> HumanResources_VJobCandidateEducations { get; set; } // vJobCandidateEducation
        System.Data.Entity.DbSet<HumanResources_VJobCandidateEmployment> HumanResources_VJobCandidateEmployments { get; set; } // vJobCandidateEmployment
        System.Data.Entity.DbSet<Person_Address> Person_Addresses { get; set; } // Address
        System.Data.Entity.DbSet<Person_AddressType> Person_AddressTypes { get; set; } // AddressType
        System.Data.Entity.DbSet<Person_BusinessEntity> Person_BusinessEntities { get; set; } // BusinessEntity
        System.Data.Entity.DbSet<Person_BusinessEntityAddress> Person_BusinessEntityAddresses { get; set; } // BusinessEntityAddress
        System.Data.Entity.DbSet<Person_BusinessEntityContact> Person_BusinessEntityContacts { get; set; } // BusinessEntityContact
        System.Data.Entity.DbSet<Person_ContactType> Person_ContactTypes { get; set; } // ContactType
        System.Data.Entity.DbSet<Person_CountryRegion> Person_CountryRegions { get; set; } // CountryRegion
        System.Data.Entity.DbSet<Person_EmailAddress> Person_EmailAddresses { get; set; } // EmailAddress
        System.Data.Entity.DbSet<Person_Password> Person_Passwords { get; set; } // Password
        System.Data.Entity.DbSet<Person_Person> Person_People { get; set; } // Person
        System.Data.Entity.DbSet<Person_PersonPhone> Person_PersonPhones { get; set; } // PersonPhone
        System.Data.Entity.DbSet<Person_PhoneNumberType> Person_PhoneNumberTypes { get; set; } // PhoneNumberType
        System.Data.Entity.DbSet<Person_StateProvince> Person_StateProvinces { get; set; } // StateProvince
        System.Data.Entity.DbSet<Person_VAdditionalContactInfo> Person_VAdditionalContactInfoes { get; set; } // vAdditionalContactInfo
        System.Data.Entity.DbSet<Person_VStateProvinceCountryRegion> Person_VStateProvinceCountryRegions { get; set; } // vStateProvinceCountryRegion
        System.Data.Entity.DbSet<Production_BillOfMaterial> Production_BillOfMaterials { get; set; } // BillOfMaterials
        System.Data.Entity.DbSet<Production_Culture> Production_Cultures { get; set; } // Culture
        System.Data.Entity.DbSet<Production_Document> Production_Documents { get; set; } // Document
        System.Data.Entity.DbSet<Production_Illustration> Production_Illustrations { get; set; } // Illustration
        System.Data.Entity.DbSet<Production_Location> Production_Locations { get; set; } // Location
        System.Data.Entity.DbSet<Production_Product> Production_Products { get; set; } // Product
        System.Data.Entity.DbSet<Production_ProductCategory> Production_ProductCategories { get; set; } // ProductCategory
        System.Data.Entity.DbSet<Production_ProductCostHistory> Production_ProductCostHistories { get; set; } // ProductCostHistory
        System.Data.Entity.DbSet<Production_ProductDescription> Production_ProductDescriptions { get; set; } // ProductDescription
        System.Data.Entity.DbSet<Production_ProductDocument> Production_ProductDocuments { get; set; } // ProductDocument
        System.Data.Entity.DbSet<Production_ProductInventory> Production_ProductInventories { get; set; } // ProductInventory
        System.Data.Entity.DbSet<Production_ProductListPriceHistory> Production_ProductListPriceHistories { get; set; } // ProductListPriceHistory
        System.Data.Entity.DbSet<Production_ProductModel> Production_ProductModels { get; set; } // ProductModel
        System.Data.Entity.DbSet<Production_ProductModelIllustration> Production_ProductModelIllustrations { get; set; } // ProductModelIllustration
        System.Data.Entity.DbSet<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCultures { get; set; } // ProductModelProductDescriptionCulture
        System.Data.Entity.DbSet<Production_ProductPhoto> Production_ProductPhotoes { get; set; } // ProductPhoto
        System.Data.Entity.DbSet<Production_ProductProductPhoto> Production_ProductProductPhotoes { get; set; } // ProductProductPhoto
        System.Data.Entity.DbSet<Production_ProductReview> Production_ProductReviews { get; set; } // ProductReview
        System.Data.Entity.DbSet<Production_ProductSubcategory> Production_ProductSubcategories { get; set; } // ProductSubcategory
        System.Data.Entity.DbSet<Production_ScrapReason> Production_ScrapReasons { get; set; } // ScrapReason
        System.Data.Entity.DbSet<Production_TransactionHistory> Production_TransactionHistories { get; set; } // TransactionHistory
        System.Data.Entity.DbSet<Production_TransactionHistoryArchive> Production_TransactionHistoryArchives { get; set; } // TransactionHistoryArchive
        System.Data.Entity.DbSet<Production_UnitMeasure> Production_UnitMeasures { get; set; } // UnitMeasure
        System.Data.Entity.DbSet<Production_VProductAndDescription> Production_VProductAndDescriptions { get; set; } // vProductAndDescription
        System.Data.Entity.DbSet<Production_VProductModelCatalogDescription> Production_VProductModelCatalogDescriptions { get; set; } // vProductModelCatalogDescription
        System.Data.Entity.DbSet<Production_VProductModelInstruction> Production_VProductModelInstructions { get; set; } // vProductModelInstructions
        System.Data.Entity.DbSet<Production_WorkOrder> Production_WorkOrders { get; set; } // WorkOrder
        System.Data.Entity.DbSet<Production_WorkOrderRouting> Production_WorkOrderRoutings { get; set; } // WorkOrderRouting
        System.Data.Entity.DbSet<Purchasing_ProductVendor> Purchasing_ProductVendors { get; set; } // ProductVendor
        System.Data.Entity.DbSet<Purchasing_PurchaseOrderDetail> Purchasing_PurchaseOrderDetails { get; set; } // PurchaseOrderDetail
        System.Data.Entity.DbSet<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeaders { get; set; } // PurchaseOrderHeader
        System.Data.Entity.DbSet<Purchasing_ShipMethod> Purchasing_ShipMethods { get; set; } // ShipMethod
        System.Data.Entity.DbSet<Purchasing_Vendor> Purchasing_Vendors { get; set; } // Vendor
        System.Data.Entity.DbSet<Purchasing_VVendorWithAddress> Purchasing_VVendorWithAddresses { get; set; } // vVendorWithAddresses
        System.Data.Entity.DbSet<Purchasing_VVendorWithContact> Purchasing_VVendorWithContacts { get; set; } // vVendorWithContacts
        System.Data.Entity.DbSet<Sales_CountryRegionCurrency> Sales_CountryRegionCurrencies { get; set; } // CountryRegionCurrency
        System.Data.Entity.DbSet<Sales_CreditCard> Sales_CreditCards { get; set; } // CreditCard
        System.Data.Entity.DbSet<Sales_Currency> Sales_Currencies { get; set; } // Currency
        System.Data.Entity.DbSet<Sales_CurrencyRate> Sales_CurrencyRates { get; set; } // CurrencyRate
        System.Data.Entity.DbSet<Sales_Customer> Sales_Customers { get; set; } // Customer
        System.Data.Entity.DbSet<Sales_PersonCreditCard> Sales_PersonCreditCards { get; set; } // PersonCreditCard
        System.Data.Entity.DbSet<Sales_SalesOrderDetail> Sales_SalesOrderDetails { get; set; } // SalesOrderDetail
        System.Data.Entity.DbSet<Sales_SalesOrderHeader> Sales_SalesOrderHeaders { get; set; } // SalesOrderHeader
        System.Data.Entity.DbSet<Sales_SalesOrderHeaderSalesReason> Sales_SalesOrderHeaderSalesReasons { get; set; } // SalesOrderHeaderSalesReason
        System.Data.Entity.DbSet<Sales_SalesPerson> Sales_SalesPersons { get; set; } // SalesPerson
        System.Data.Entity.DbSet<Sales_SalesPersonQuotaHistory> Sales_SalesPersonQuotaHistories { get; set; } // SalesPersonQuotaHistory
        System.Data.Entity.DbSet<Sales_SalesReason> Sales_SalesReasons { get; set; } // SalesReason
        System.Data.Entity.DbSet<Sales_SalesTaxRate> Sales_SalesTaxRates { get; set; } // SalesTaxRate
        System.Data.Entity.DbSet<Sales_SalesTerritory> Sales_SalesTerritories { get; set; } // SalesTerritory
        System.Data.Entity.DbSet<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistories { get; set; } // SalesTerritoryHistory
        System.Data.Entity.DbSet<Sales_ShoppingCartItem> Sales_ShoppingCartItems { get; set; } // ShoppingCartItem
        System.Data.Entity.DbSet<Sales_SpecialOffer> Sales_SpecialOffers { get; set; } // SpecialOffer
        System.Data.Entity.DbSet<Sales_SpecialOfferProduct> Sales_SpecialOfferProducts { get; set; } // SpecialOfferProduct
        System.Data.Entity.DbSet<Sales_Store> Sales_Stores { get; set; } // Store
        System.Data.Entity.DbSet<Sales_VIndividualCustomer> Sales_VIndividualCustomers { get; set; } // vIndividualCustomer
        System.Data.Entity.DbSet<Sales_VPersonDemographic> Sales_VPersonDemographics { get; set; } // vPersonDemographics
        System.Data.Entity.DbSet<Sales_VSalesPerson> Sales_VSalesPersons { get; set; } // vSalesPerson
        System.Data.Entity.DbSet<Sales_VSalesPersonSalesByFiscalYear> Sales_VSalesPersonSalesByFiscalYears { get; set; } // vSalesPersonSalesByFiscalYears
        System.Data.Entity.DbSet<Sales_VStoreWithAddress> Sales_VStoreWithAddresses { get; set; } // vStoreWithAddresses
        System.Data.Entity.DbSet<Sales_VStoreWithContact> Sales_VStoreWithContacts { get; set; } // vStoreWithContacts
        System.Data.Entity.DbSet<Sales_VStoreWithDemographic> Sales_VStoreWithDemographics { get; set; } // vStoreWithDemographics

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();

        // Stored Procedures
        int HumanResources_UspUpdateEmployeeHireInfo(int? businessEntityId, string jobTitle, System.DateTime? hireDate, System.DateTime? rateChangeDate, decimal? rate, byte? payFrequency, bool? currentFlag);
        // HumanResources_UspUpdateEmployeeHireInfoAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int HumanResources_UspUpdateEmployeeLogin(int? businessEntityId, System.Data.Entity.Hierarchy.HierarchyId organizationNode, string loginId, string jobTitle, System.DateTime? hireDate, bool? currentFlag);
        // HumanResources_UspUpdateEmployeeLoginAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int HumanResources_UspUpdateEmployeePersonalInfo(int? businessEntityId, string nationalIdNumber, System.DateTime? birthDate, string maritalStatus, string gender);
        // HumanResources_UspUpdateEmployeePersonalInfoAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        System.Collections.Generic.List<UspGetBillOfMaterialsReturnModel> UspGetBillOfMaterials(int? startProductId, System.DateTime? checkDate);
        System.Collections.Generic.List<UspGetBillOfMaterialsReturnModel> UspGetBillOfMaterials(int? startProductId, System.DateTime? checkDate, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetBillOfMaterialsReturnModel>> UspGetBillOfMaterialsAsync(int? startProductId, System.DateTime? checkDate);

        System.Collections.Generic.List<UspGetEmployeeManagersReturnModel> UspGetEmployeeManagers(int? businessEntityId);
        System.Collections.Generic.List<UspGetEmployeeManagersReturnModel> UspGetEmployeeManagers(int? businessEntityId, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetEmployeeManagersReturnModel>> UspGetEmployeeManagersAsync(int? businessEntityId);

        System.Collections.Generic.List<UspGetManagerEmployeesReturnModel> UspGetManagerEmployees(int? businessEntityId);
        System.Collections.Generic.List<UspGetManagerEmployeesReturnModel> UspGetManagerEmployees(int? businessEntityId, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetManagerEmployeesReturnModel>> UspGetManagerEmployeesAsync(int? businessEntityId);

        System.Collections.Generic.List<UspGetWhereUsedProductIdReturnModel> UspGetWhereUsedProductId(int? startProductId, System.DateTime? checkDate);
        System.Collections.Generic.List<UspGetWhereUsedProductIdReturnModel> UspGetWhereUsedProductId(int? startProductId, System.DateTime? checkDate, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetWhereUsedProductIdReturnModel>> UspGetWhereUsedProductIdAsync(int? startProductId, System.DateTime? checkDate);

        int UspLogError(out int? errorLogId);
        // UspLogErrorAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspPrintError();
        // UspPrintErrorAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspSearchCandidateResumes(string searchString, bool? useInflectional, bool? useThesaurus, int? language);
        // UspSearchCandidateResumesAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

    }

}
// </auto-generated>
