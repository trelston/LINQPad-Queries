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

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class FakeAdventureWorksDBContext : IAdventureWorksDBContext
    {
        public System.Data.Entity.DbSet<AwBuildVersion> AwBuildVersions { get; set; }
        public System.Data.Entity.DbSet<DatabaseLog> DatabaseLogs { get; set; }
        public System.Data.Entity.DbSet<ErrorLog> ErrorLogs { get; set; }
        public System.Data.Entity.DbSet<HumanResources_Department> HumanResources_Departments { get; set; }
        public System.Data.Entity.DbSet<HumanResources_Employee> HumanResources_Employees { get; set; }
        public System.Data.Entity.DbSet<HumanResources_EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistories { get; set; }
        public System.Data.Entity.DbSet<HumanResources_EmployeePayHistory> HumanResources_EmployeePayHistories { get; set; }
        public System.Data.Entity.DbSet<HumanResources_JobCandidate> HumanResources_JobCandidates { get; set; }
        public System.Data.Entity.DbSet<HumanResources_Shift> HumanResources_Shifts { get; set; }
        public System.Data.Entity.DbSet<HumanResources_VEmployee> HumanResources_VEmployees { get; set; }
        public System.Data.Entity.DbSet<HumanResources_VEmployeeDepartment> HumanResources_VEmployeeDepartments { get; set; }
        public System.Data.Entity.DbSet<HumanResources_VEmployeeDepartmentHistory> HumanResources_VEmployeeDepartmentHistories { get; set; }
        public System.Data.Entity.DbSet<HumanResources_VJobCandidate> HumanResources_VJobCandidates { get; set; }
        public System.Data.Entity.DbSet<HumanResources_VJobCandidateEducation> HumanResources_VJobCandidateEducations { get; set; }
        public System.Data.Entity.DbSet<HumanResources_VJobCandidateEmployment> HumanResources_VJobCandidateEmployments { get; set; }
        public System.Data.Entity.DbSet<Person_Address> Person_Addresses { get; set; }
        public System.Data.Entity.DbSet<Person_AddressType> Person_AddressTypes { get; set; }
        public System.Data.Entity.DbSet<Person_BusinessEntity> Person_BusinessEntities { get; set; }
        public System.Data.Entity.DbSet<Person_BusinessEntityAddress> Person_BusinessEntityAddresses { get; set; }
        public System.Data.Entity.DbSet<Person_BusinessEntityContact> Person_BusinessEntityContacts { get; set; }
        public System.Data.Entity.DbSet<Person_ContactType> Person_ContactTypes { get; set; }
        public System.Data.Entity.DbSet<Person_CountryRegion> Person_CountryRegions { get; set; }
        public System.Data.Entity.DbSet<Person_EmailAddress> Person_EmailAddresses { get; set; }
        public System.Data.Entity.DbSet<Person_Password> Person_Passwords { get; set; }
        public System.Data.Entity.DbSet<Person_Person> Person_People { get; set; }
        public System.Data.Entity.DbSet<Person_PersonPhone> Person_PersonPhones { get; set; }
        public System.Data.Entity.DbSet<Person_PhoneNumberType> Person_PhoneNumberTypes { get; set; }
        public System.Data.Entity.DbSet<Person_StateProvince> Person_StateProvinces { get; set; }
        public System.Data.Entity.DbSet<Person_VAdditionalContactInfo> Person_VAdditionalContactInfoes { get; set; }
        public System.Data.Entity.DbSet<Person_VStateProvinceCountryRegion> Person_VStateProvinceCountryRegions { get; set; }
        public System.Data.Entity.DbSet<Production_BillOfMaterial> Production_BillOfMaterials { get; set; }
        public System.Data.Entity.DbSet<Production_Culture> Production_Cultures { get; set; }
        public System.Data.Entity.DbSet<Production_Document> Production_Documents { get; set; }
        public System.Data.Entity.DbSet<Production_Illustration> Production_Illustrations { get; set; }
        public System.Data.Entity.DbSet<Production_Location> Production_Locations { get; set; }
        public System.Data.Entity.DbSet<Production_Product> Production_Products { get; set; }
        public System.Data.Entity.DbSet<Production_ProductCategory> Production_ProductCategories { get; set; }
        public System.Data.Entity.DbSet<Production_ProductCostHistory> Production_ProductCostHistories { get; set; }
        public System.Data.Entity.DbSet<Production_ProductDescription> Production_ProductDescriptions { get; set; }
        public System.Data.Entity.DbSet<Production_ProductDocument> Production_ProductDocuments { get; set; }
        public System.Data.Entity.DbSet<Production_ProductInventory> Production_ProductInventories { get; set; }
        public System.Data.Entity.DbSet<Production_ProductListPriceHistory> Production_ProductListPriceHistories { get; set; }
        public System.Data.Entity.DbSet<Production_ProductModel> Production_ProductModels { get; set; }
        public System.Data.Entity.DbSet<Production_ProductModelIllustration> Production_ProductModelIllustrations { get; set; }
        public System.Data.Entity.DbSet<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCultures { get; set; }
        public System.Data.Entity.DbSet<Production_ProductPhoto> Production_ProductPhotoes { get; set; }
        public System.Data.Entity.DbSet<Production_ProductProductPhoto> Production_ProductProductPhotoes { get; set; }
        public System.Data.Entity.DbSet<Production_ProductReview> Production_ProductReviews { get; set; }
        public System.Data.Entity.DbSet<Production_ProductSubcategory> Production_ProductSubcategories { get; set; }
        public System.Data.Entity.DbSet<Production_ScrapReason> Production_ScrapReasons { get; set; }
        public System.Data.Entity.DbSet<Production_TransactionHistory> Production_TransactionHistories { get; set; }
        public System.Data.Entity.DbSet<Production_TransactionHistoryArchive> Production_TransactionHistoryArchives { get; set; }
        public System.Data.Entity.DbSet<Production_UnitMeasure> Production_UnitMeasures { get; set; }
        public System.Data.Entity.DbSet<Production_VProductAndDescription> Production_VProductAndDescriptions { get; set; }
        public System.Data.Entity.DbSet<Production_VProductModelCatalogDescription> Production_VProductModelCatalogDescriptions { get; set; }
        public System.Data.Entity.DbSet<Production_VProductModelInstruction> Production_VProductModelInstructions { get; set; }
        public System.Data.Entity.DbSet<Production_WorkOrder> Production_WorkOrders { get; set; }
        public System.Data.Entity.DbSet<Production_WorkOrderRouting> Production_WorkOrderRoutings { get; set; }
        public System.Data.Entity.DbSet<Purchasing_ProductVendor> Purchasing_ProductVendors { get; set; }
        public System.Data.Entity.DbSet<Purchasing_PurchaseOrderDetail> Purchasing_PurchaseOrderDetails { get; set; }
        public System.Data.Entity.DbSet<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeaders { get; set; }
        public System.Data.Entity.DbSet<Purchasing_ShipMethod> Purchasing_ShipMethods { get; set; }
        public System.Data.Entity.DbSet<Purchasing_Vendor> Purchasing_Vendors { get; set; }
        public System.Data.Entity.DbSet<Purchasing_VVendorWithAddress> Purchasing_VVendorWithAddresses { get; set; }
        public System.Data.Entity.DbSet<Purchasing_VVendorWithContact> Purchasing_VVendorWithContacts { get; set; }
        public System.Data.Entity.DbSet<Sales_CountryRegionCurrency> Sales_CountryRegionCurrencies { get; set; }
        public System.Data.Entity.DbSet<Sales_CreditCard> Sales_CreditCards { get; set; }
        public System.Data.Entity.DbSet<Sales_Currency> Sales_Currencies { get; set; }
        public System.Data.Entity.DbSet<Sales_CurrencyRate> Sales_CurrencyRates { get; set; }
        public System.Data.Entity.DbSet<Sales_Customer> Sales_Customers { get; set; }
        public System.Data.Entity.DbSet<Sales_PersonCreditCard> Sales_PersonCreditCards { get; set; }
        public System.Data.Entity.DbSet<Sales_SalesOrderDetail> Sales_SalesOrderDetails { get; set; }
        public System.Data.Entity.DbSet<Sales_SalesOrderHeader> Sales_SalesOrderHeaders { get; set; }
        public System.Data.Entity.DbSet<Sales_SalesOrderHeaderSalesReason> Sales_SalesOrderHeaderSalesReasons { get; set; }
        public System.Data.Entity.DbSet<Sales_SalesPerson> Sales_SalesPersons { get; set; }
        public System.Data.Entity.DbSet<Sales_SalesPersonQuotaHistory> Sales_SalesPersonQuotaHistories { get; set; }
        public System.Data.Entity.DbSet<Sales_SalesReason> Sales_SalesReasons { get; set; }
        public System.Data.Entity.DbSet<Sales_SalesTaxRate> Sales_SalesTaxRates { get; set; }
        public System.Data.Entity.DbSet<Sales_SalesTerritory> Sales_SalesTerritories { get; set; }
        public System.Data.Entity.DbSet<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistories { get; set; }
        public System.Data.Entity.DbSet<Sales_ShoppingCartItem> Sales_ShoppingCartItems { get; set; }
        public System.Data.Entity.DbSet<Sales_SpecialOffer> Sales_SpecialOffers { get; set; }
        public System.Data.Entity.DbSet<Sales_SpecialOfferProduct> Sales_SpecialOfferProducts { get; set; }
        public System.Data.Entity.DbSet<Sales_Store> Sales_Stores { get; set; }
        public System.Data.Entity.DbSet<Sales_VIndividualCustomer> Sales_VIndividualCustomers { get; set; }
        public System.Data.Entity.DbSet<Sales_VPersonDemographic> Sales_VPersonDemographics { get; set; }
        public System.Data.Entity.DbSet<Sales_VSalesPerson> Sales_VSalesPersons { get; set; }
        public System.Data.Entity.DbSet<Sales_VSalesPersonSalesByFiscalYear> Sales_VSalesPersonSalesByFiscalYears { get; set; }
        public System.Data.Entity.DbSet<Sales_VStoreWithAddress> Sales_VStoreWithAddresses { get; set; }
        public System.Data.Entity.DbSet<Sales_VStoreWithContact> Sales_VStoreWithContacts { get; set; }
        public System.Data.Entity.DbSet<Sales_VStoreWithDemographic> Sales_VStoreWithDemographics { get; set; }

        public FakeAdventureWorksDBContext()
        {
            _changeTracker = null;
            _configuration = null;
            _database = null;

            AwBuildVersions = new FakeDbSet<AwBuildVersion>("SystemInformationId");
            DatabaseLogs = new FakeDbSet<DatabaseLog>("DatabaseLogId");
            ErrorLogs = new FakeDbSet<ErrorLog>("ErrorLogId");
            HumanResources_Departments = new FakeDbSet<HumanResources_Department>("DepartmentId");
            HumanResources_Employees = new FakeDbSet<HumanResources_Employee>("BusinessEntityId");
            HumanResources_EmployeeDepartmentHistories = new FakeDbSet<HumanResources_EmployeeDepartmentHistory>("BusinessEntityId", "StartDate", "DepartmentId", "ShiftId");
            HumanResources_EmployeePayHistories = new FakeDbSet<HumanResources_EmployeePayHistory>("BusinessEntityId", "RateChangeDate");
            HumanResources_JobCandidates = new FakeDbSet<HumanResources_JobCandidate>("JobCandidateId");
            HumanResources_Shifts = new FakeDbSet<HumanResources_Shift>("ShiftId");
            HumanResources_VEmployees = new FakeDbSet<HumanResources_VEmployee>("BusinessEntityId", "FirstName", "LastName", "JobTitle", "EmailPromotion", "AddressLine1", "City", "StateProvinceName", "PostalCode", "CountryRegionName");
            HumanResources_VEmployeeDepartments = new FakeDbSet<HumanResources_VEmployeeDepartment>("BusinessEntityId", "FirstName", "LastName", "JobTitle", "Department", "GroupName", "StartDate");
            HumanResources_VEmployeeDepartmentHistories = new FakeDbSet<HumanResources_VEmployeeDepartmentHistory>("BusinessEntityId", "FirstName", "LastName", "Shift", "Department", "GroupName", "StartDate");
            HumanResources_VJobCandidates = new FakeDbSet<HumanResources_VJobCandidate>("JobCandidateId", "ModifiedDate");
            HumanResources_VJobCandidateEducations = new FakeDbSet<HumanResources_VJobCandidateEducation>("JobCandidateId");
            HumanResources_VJobCandidateEmployments = new FakeDbSet<HumanResources_VJobCandidateEmployment>("JobCandidateId");
            Person_Addresses = new FakeDbSet<Person_Address>("AddressId");
            Person_AddressTypes = new FakeDbSet<Person_AddressType>("AddressTypeId");
            Person_BusinessEntities = new FakeDbSet<Person_BusinessEntity>("BusinessEntityId");
            Person_BusinessEntityAddresses = new FakeDbSet<Person_BusinessEntityAddress>("BusinessEntityId", "AddressId", "AddressTypeId");
            Person_BusinessEntityContacts = new FakeDbSet<Person_BusinessEntityContact>("BusinessEntityId", "PersonId", "ContactTypeId");
            Person_ContactTypes = new FakeDbSet<Person_ContactType>("ContactTypeId");
            Person_CountryRegions = new FakeDbSet<Person_CountryRegion>("CountryRegionCode");
            Person_EmailAddresses = new FakeDbSet<Person_EmailAddress>("BusinessEntityId", "EmailAddressId");
            Person_Passwords = new FakeDbSet<Person_Password>("BusinessEntityId");
            Person_People = new FakeDbSet<Person_Person>("BusinessEntityId");
            Person_PersonPhones = new FakeDbSet<Person_PersonPhone>("BusinessEntityId", "PhoneNumber", "PhoneNumberTypeId");
            Person_PhoneNumberTypes = new FakeDbSet<Person_PhoneNumberType>("PhoneNumberTypeId");
            Person_StateProvinces = new FakeDbSet<Person_StateProvince>("StateProvinceId");
            Person_VAdditionalContactInfoes = new FakeDbSet<Person_VAdditionalContactInfo>("BusinessEntityId", "FirstName", "LastName", "Rowguid", "ModifiedDate");
            Person_VStateProvinceCountryRegions = new FakeDbSet<Person_VStateProvinceCountryRegion>("StateProvinceId", "StateProvinceCode", "IsOnlyStateProvinceFlag", "StateProvinceName", "TerritoryId", "CountryRegionCode", "CountryRegionName");
            Production_BillOfMaterials = new FakeDbSet<Production_BillOfMaterial>("BillOfMaterialsId");
            Production_Cultures = new FakeDbSet<Production_Culture>("CultureId");
            Production_Documents = new FakeDbSet<Production_Document>("DocumentNode");
            Production_Illustrations = new FakeDbSet<Production_Illustration>("IllustrationId");
            Production_Locations = new FakeDbSet<Production_Location>("LocationId");
            Production_Products = new FakeDbSet<Production_Product>("ProductId");
            Production_ProductCategories = new FakeDbSet<Production_ProductCategory>("ProductCategoryId");
            Production_ProductCostHistories = new FakeDbSet<Production_ProductCostHistory>("ProductId", "StartDate");
            Production_ProductDescriptions = new FakeDbSet<Production_ProductDescription>("ProductDescriptionId");
            Production_ProductDocuments = new FakeDbSet<Production_ProductDocument>("ProductId", "DocumentNode");
            Production_ProductInventories = new FakeDbSet<Production_ProductInventory>("ProductId", "LocationId");
            Production_ProductListPriceHistories = new FakeDbSet<Production_ProductListPriceHistory>("ProductId", "StartDate");
            Production_ProductModels = new FakeDbSet<Production_ProductModel>("ProductModelId");
            Production_ProductModelIllustrations = new FakeDbSet<Production_ProductModelIllustration>("ProductModelId", "IllustrationId");
            Production_ProductModelProductDescriptionCultures = new FakeDbSet<Production_ProductModelProductDescriptionCulture>("ProductModelId", "ProductDescriptionId", "CultureId");
            Production_ProductPhotoes = new FakeDbSet<Production_ProductPhoto>("ProductPhotoId");
            Production_ProductProductPhotoes = new FakeDbSet<Production_ProductProductPhoto>("ProductId", "ProductPhotoId");
            Production_ProductReviews = new FakeDbSet<Production_ProductReview>("ProductReviewId");
            Production_ProductSubcategories = new FakeDbSet<Production_ProductSubcategory>("ProductSubcategoryId");
            Production_ScrapReasons = new FakeDbSet<Production_ScrapReason>("ScrapReasonId");
            Production_TransactionHistories = new FakeDbSet<Production_TransactionHistory>("TransactionId");
            Production_TransactionHistoryArchives = new FakeDbSet<Production_TransactionHistoryArchive>("TransactionId");
            Production_UnitMeasures = new FakeDbSet<Production_UnitMeasure>("UnitMeasureCode");
            Production_VProductAndDescriptions = new FakeDbSet<Production_VProductAndDescription>("ProductId", "Name", "ProductModel", "CultureId", "Description");
            Production_VProductModelCatalogDescriptions = new FakeDbSet<Production_VProductModelCatalogDescription>("ProductModelId", "Name", "Rowguid", "ModifiedDate");
            Production_VProductModelInstructions = new FakeDbSet<Production_VProductModelInstruction>("ProductModelId", "Name", "Rowguid", "ModifiedDate");
            Production_WorkOrders = new FakeDbSet<Production_WorkOrder>("WorkOrderId");
            Production_WorkOrderRoutings = new FakeDbSet<Production_WorkOrderRouting>("WorkOrderId", "ProductId", "OperationSequence");
            Purchasing_ProductVendors = new FakeDbSet<Purchasing_ProductVendor>("ProductId", "BusinessEntityId");
            Purchasing_PurchaseOrderDetails = new FakeDbSet<Purchasing_PurchaseOrderDetail>("PurchaseOrderId", "PurchaseOrderDetailId");
            Purchasing_PurchaseOrderHeaders = new FakeDbSet<Purchasing_PurchaseOrderHeader>("PurchaseOrderId");
            Purchasing_ShipMethods = new FakeDbSet<Purchasing_ShipMethod>("ShipMethodId");
            Purchasing_Vendors = new FakeDbSet<Purchasing_Vendor>("BusinessEntityId");
            Purchasing_VVendorWithAddresses = new FakeDbSet<Purchasing_VVendorWithAddress>("BusinessEntityId", "Name", "AddressType", "AddressLine1", "City", "StateProvinceName", "PostalCode", "CountryRegionName");
            Purchasing_VVendorWithContacts = new FakeDbSet<Purchasing_VVendorWithContact>("BusinessEntityId", "Name", "ContactType", "FirstName", "LastName", "EmailPromotion");
            Sales_CountryRegionCurrencies = new FakeDbSet<Sales_CountryRegionCurrency>("CountryRegionCode", "CurrencyCode");
            Sales_CreditCards = new FakeDbSet<Sales_CreditCard>("CreditCardId");
            Sales_Currencies = new FakeDbSet<Sales_Currency>("CurrencyCode");
            Sales_CurrencyRates = new FakeDbSet<Sales_CurrencyRate>("CurrencyRateId");
            Sales_Customers = new FakeDbSet<Sales_Customer>("CustomerId");
            Sales_PersonCreditCards = new FakeDbSet<Sales_PersonCreditCard>("BusinessEntityId", "CreditCardId");
            Sales_SalesOrderDetails = new FakeDbSet<Sales_SalesOrderDetail>("SalesOrderId", "SalesOrderDetailId");
            Sales_SalesOrderHeaders = new FakeDbSet<Sales_SalesOrderHeader>("SalesOrderId");
            Sales_SalesOrderHeaderSalesReasons = new FakeDbSet<Sales_SalesOrderHeaderSalesReason>("SalesOrderId", "SalesReasonId");
            Sales_SalesPersons = new FakeDbSet<Sales_SalesPerson>("BusinessEntityId");
            Sales_SalesPersonQuotaHistories = new FakeDbSet<Sales_SalesPersonQuotaHistory>("BusinessEntityId", "QuotaDate");
            Sales_SalesReasons = new FakeDbSet<Sales_SalesReason>("SalesReasonId");
            Sales_SalesTaxRates = new FakeDbSet<Sales_SalesTaxRate>("SalesTaxRateId");
            Sales_SalesTerritories = new FakeDbSet<Sales_SalesTerritory>("TerritoryId");
            Sales_SalesTerritoryHistories = new FakeDbSet<Sales_SalesTerritoryHistory>("BusinessEntityId", "StartDate", "TerritoryId");
            Sales_ShoppingCartItems = new FakeDbSet<Sales_ShoppingCartItem>("ShoppingCartItemId");
            Sales_SpecialOffers = new FakeDbSet<Sales_SpecialOffer>("SpecialOfferId");
            Sales_SpecialOfferProducts = new FakeDbSet<Sales_SpecialOfferProduct>("SpecialOfferId", "ProductId");
            Sales_Stores = new FakeDbSet<Sales_Store>("BusinessEntityId");
            Sales_VIndividualCustomers = new FakeDbSet<Sales_VIndividualCustomer>("BusinessEntityId", "FirstName", "LastName", "EmailPromotion", "AddressType", "AddressLine1", "City", "StateProvinceName", "PostalCode", "CountryRegionName");
            Sales_VPersonDemographics = new FakeDbSet<Sales_VPersonDemographic>("BusinessEntityId");
            Sales_VSalesPersons = new FakeDbSet<Sales_VSalesPerson>("BusinessEntityId", "FirstName", "LastName", "JobTitle", "EmailPromotion", "AddressLine1", "City", "StateProvinceName", "PostalCode", "CountryRegionName", "SalesYtd", "SalesLastYear");
            Sales_VSalesPersonSalesByFiscalYears = new FakeDbSet<Sales_VSalesPersonSalesByFiscalYear>("JobTitle", "SalesTerritory");
            Sales_VStoreWithAddresses = new FakeDbSet<Sales_VStoreWithAddress>("BusinessEntityId", "Name", "AddressType", "AddressLine1", "City", "StateProvinceName", "PostalCode", "CountryRegionName");
            Sales_VStoreWithContacts = new FakeDbSet<Sales_VStoreWithContact>("BusinessEntityId", "Name", "ContactType", "FirstName", "LastName", "EmailPromotion");
            Sales_VStoreWithDemographics = new FakeDbSet<Sales_VStoreWithDemographic>("BusinessEntityId", "Name");
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private System.Data.Entity.Infrastructure.DbChangeTracker _changeTracker;
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get { return _changeTracker; } }
        private System.Data.Entity.Infrastructure.DbContextConfiguration _configuration;
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get { return _configuration; } }
        private System.Data.Entity.Database _database;
        public System.Data.Entity.Database Database { get { return _database; } }
        public System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity)
        {
            throw new System.NotImplementedException();
        }
        public System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors()
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet Set(System.Type entityType)
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }


        // Stored Procedures
        public int HumanResources_UspUpdateEmployeeHireInfo(int? businessEntityId, string jobTitle, System.DateTime? hireDate, System.DateTime? rateChangeDate, decimal? rate, byte? payFrequency, bool? currentFlag)
        {

            return 0;
        }

        public int HumanResources_UspUpdateEmployeeLogin(int? businessEntityId, System.Data.Entity.Hierarchy.HierarchyId organizationNode, string loginId, string jobTitle, System.DateTime? hireDate, bool? currentFlag)
        {

            return 0;
        }

        public int HumanResources_UspUpdateEmployeePersonalInfo(int? businessEntityId, string nationalIdNumber, System.DateTime? birthDate, string maritalStatus, string gender)
        {

            return 0;
        }

        public System.Collections.Generic.List<UspGetBillOfMaterialsReturnModel> UspGetBillOfMaterials(int? startProductId, System.DateTime? checkDate)
        {
            int procResult;
            return UspGetBillOfMaterials(startProductId, checkDate, out procResult);
        }

        public System.Collections.Generic.List<UspGetBillOfMaterialsReturnModel> UspGetBillOfMaterials(int? startProductId, System.DateTime? checkDate, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<UspGetBillOfMaterialsReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetBillOfMaterialsReturnModel>> UspGetBillOfMaterialsAsync(int? startProductId, System.DateTime? checkDate)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(UspGetBillOfMaterials(startProductId, checkDate, out procResult));
        }

        public System.Collections.Generic.List<UspGetEmployeeManagersReturnModel> UspGetEmployeeManagers(int? businessEntityId)
        {
            int procResult;
            return UspGetEmployeeManagers(businessEntityId, out procResult);
        }

        public System.Collections.Generic.List<UspGetEmployeeManagersReturnModel> UspGetEmployeeManagers(int? businessEntityId, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<UspGetEmployeeManagersReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetEmployeeManagersReturnModel>> UspGetEmployeeManagersAsync(int? businessEntityId)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(UspGetEmployeeManagers(businessEntityId, out procResult));
        }

        public System.Collections.Generic.List<UspGetManagerEmployeesReturnModel> UspGetManagerEmployees(int? businessEntityId)
        {
            int procResult;
            return UspGetManagerEmployees(businessEntityId, out procResult);
        }

        public System.Collections.Generic.List<UspGetManagerEmployeesReturnModel> UspGetManagerEmployees(int? businessEntityId, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<UspGetManagerEmployeesReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetManagerEmployeesReturnModel>> UspGetManagerEmployeesAsync(int? businessEntityId)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(UspGetManagerEmployees(businessEntityId, out procResult));
        }

        public System.Collections.Generic.List<UspGetWhereUsedProductIdReturnModel> UspGetWhereUsedProductId(int? startProductId, System.DateTime? checkDate)
        {
            int procResult;
            return UspGetWhereUsedProductId(startProductId, checkDate, out procResult);
        }

        public System.Collections.Generic.List<UspGetWhereUsedProductIdReturnModel> UspGetWhereUsedProductId(int? startProductId, System.DateTime? checkDate, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<UspGetWhereUsedProductIdReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetWhereUsedProductIdReturnModel>> UspGetWhereUsedProductIdAsync(int? startProductId, System.DateTime? checkDate)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(UspGetWhereUsedProductId(startProductId, checkDate, out procResult));
        }

        public int UspLogError(out int? errorLogId)
        {
            errorLogId = default(int);

            return 0;
        }

        public int UspPrintError()
        {

            return 0;
        }

        public int UspSearchCandidateResumes(string searchString, bool? useInflectional, bool? useThesaurus, int? language)
        {

            return 0;
        }

    }
}
// </auto-generated>
