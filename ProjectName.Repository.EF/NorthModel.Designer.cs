﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("NorthwindModel", "FK_Employees_Employees", "Employees", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(ProjectName.Repository.EF.Employee), "Employees1", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ProjectName.Repository.EF.Employee), true)]

#endregion

namespace ProjectName.Repository.EF
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class NorthwindEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new NorthwindEntities object using the connection string found in the 'NorthwindEntities' section of the application configuration file.
        /// </summary>
        public NorthwindEntities() : base("name=NorthwindEntities", "NorthwindEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new NorthwindEntities object.
        /// </summary>
        public NorthwindEntities(string connectionString) : base(connectionString, "NorthwindEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new NorthwindEntities object.
        /// </summary>
        public NorthwindEntities(EntityConnection connection) : base(connection, "NorthwindEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Employee> Employees
        {
            get
            {
                if ((_Employees == null))
                {
                    _Employees = base.CreateObjectSet<Employee>("Employees");
                }
                return _Employees;
            }
        }
        private ObjectSet<Employee> _Employees;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Product> Products
        {
            get
            {
                if ((_Products == null))
                {
                    _Products = base.CreateObjectSet<Product>("Products");
                }
                return _Products;
            }
        }
        private ObjectSet<Product> _Products;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Employees EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmployees(Employee employee)
        {
            base.AddObject("Employees", employee);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Products EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProducts(Product product)
        {
            base.AddObject("Products", product);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="NorthwindModel", Name="Employee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Employee : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Employee object.
        /// </summary>
        /// <param name="employeeID">Initial value of the EmployeeID property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        public static Employee CreateEmployee(global::System.Int32 employeeID, global::System.String lastName, global::System.String firstName)
        {
            Employee employee = new Employee();
            employee.EmployeeID = employeeID;
            employee.LastName = lastName;
            employee.FirstName = firstName;
            return employee;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                if (_EmployeeID != value)
                {
                    OnEmployeeIDChanging(value);
                    ReportPropertyChanging("EmployeeID");
                    _EmployeeID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("EmployeeID");
                    OnEmployeeIDChanged();
                }
            }
        }
        private global::System.Int32 _EmployeeID;
        partial void OnEmployeeIDChanging(global::System.Int32 value);
        partial void OnEmployeeIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String TitleOfCourtesy
        {
            get
            {
                return _TitleOfCourtesy;
            }
            set
            {
                OnTitleOfCourtesyChanging(value);
                ReportPropertyChanging("TitleOfCourtesy");
                _TitleOfCourtesy = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("TitleOfCourtesy");
                OnTitleOfCourtesyChanged();
            }
        }
        private global::System.String _TitleOfCourtesy;
        partial void OnTitleOfCourtesyChanging(global::System.String value);
        partial void OnTitleOfCourtesyChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> BirthDate
        {
            get
            {
                return _BirthDate;
            }
            set
            {
                OnBirthDateChanging(value);
                ReportPropertyChanging("BirthDate");
                _BirthDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BirthDate");
                OnBirthDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _BirthDate;
        partial void OnBirthDateChanging(Nullable<global::System.DateTime> value);
        partial void OnBirthDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> HireDate
        {
            get
            {
                return _HireDate;
            }
            set
            {
                OnHireDateChanging(value);
                ReportPropertyChanging("HireDate");
                _HireDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("HireDate");
                OnHireDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _HireDate;
        partial void OnHireDateChanging(Nullable<global::System.DateTime> value);
        partial void OnHireDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Region
        {
            get
            {
                return _Region;
            }
            set
            {
                OnRegionChanging(value);
                ReportPropertyChanging("Region");
                _Region = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Region");
                OnRegionChanged();
            }
        }
        private global::System.String _Region;
        partial void OnRegionChanging(global::System.String value);
        partial void OnRegionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PostalCode
        {
            get
            {
                return _PostalCode;
            }
            set
            {
                OnPostalCodeChanging(value);
                ReportPropertyChanging("PostalCode");
                _PostalCode = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PostalCode");
                OnPostalCodeChanged();
            }
        }
        private global::System.String _PostalCode;
        partial void OnPostalCodeChanging(global::System.String value);
        partial void OnPostalCodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Country
        {
            get
            {
                return _Country;
            }
            set
            {
                OnCountryChanging(value);
                ReportPropertyChanging("Country");
                _Country = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Country");
                OnCountryChanged();
            }
        }
        private global::System.String _Country;
        partial void OnCountryChanging(global::System.String value);
        partial void OnCountryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String HomePhone
        {
            get
            {
                return _HomePhone;
            }
            set
            {
                OnHomePhoneChanging(value);
                ReportPropertyChanging("HomePhone");
                _HomePhone = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("HomePhone");
                OnHomePhoneChanged();
            }
        }
        private global::System.String _HomePhone;
        partial void OnHomePhoneChanging(global::System.String value);
        partial void OnHomePhoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Extension
        {
            get
            {
                return _Extension;
            }
            set
            {
                OnExtensionChanging(value);
                ReportPropertyChanging("Extension");
                _Extension = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Extension");
                OnExtensionChanged();
            }
        }
        private global::System.String _Extension;
        partial void OnExtensionChanging(global::System.String value);
        partial void OnExtensionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] Photo
        {
            get
            {
                return StructuralObject.GetValidValue(_Photo);
            }
            set
            {
                OnPhotoChanging(value);
                ReportPropertyChanging("Photo");
                _Photo = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Photo");
                OnPhotoChanged();
            }
        }
        private global::System.Byte[] _Photo;
        partial void OnPhotoChanging(global::System.Byte[] value);
        partial void OnPhotoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Notes
        {
            get
            {
                return _Notes;
            }
            set
            {
                OnNotesChanging(value);
                ReportPropertyChanging("Notes");
                _Notes = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Notes");
                OnNotesChanged();
            }
        }
        private global::System.String _Notes;
        partial void OnNotesChanging(global::System.String value);
        partial void OnNotesChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ReportsTo
        {
            get
            {
                return _ReportsTo;
            }
            set
            {
                OnReportsToChanging(value);
                ReportPropertyChanging("ReportsTo");
                _ReportsTo = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ReportsTo");
                OnReportsToChanged();
            }
        }
        private Nullable<global::System.Int32> _ReportsTo;
        partial void OnReportsToChanging(Nullable<global::System.Int32> value);
        partial void OnReportsToChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PhotoPath
        {
            get
            {
                return _PhotoPath;
            }
            set
            {
                OnPhotoPathChanging(value);
                ReportPropertyChanging("PhotoPath");
                _PhotoPath = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PhotoPath");
                OnPhotoPathChanged();
            }
        }
        private global::System.String _PhotoPath;
        partial void OnPhotoPathChanging(global::System.String value);
        partial void OnPhotoPathChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("NorthwindModel", "FK_Employees_Employees", "Employees1")]
        public EntityCollection<Employee> Employees1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Employee>("NorthwindModel.FK_Employees_Employees", "Employees1");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Employee>("NorthwindModel.FK_Employees_Employees", "Employees1", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("NorthwindModel", "FK_Employees_Employees", "Employees")]
        public Employee Employee1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("NorthwindModel.FK_Employees_Employees", "Employees").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("NorthwindModel.FK_Employees_Employees", "Employees").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Employee> Employee1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("NorthwindModel.FK_Employees_Employees", "Employees");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Employee>("NorthwindModel.FK_Employees_Employees", "Employees", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="NorthwindModel", Name="Product")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Product : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="productID">Initial value of the ProductID property.</param>
        /// <param name="productName">Initial value of the ProductName property.</param>
        /// <param name="discontinued">Initial value of the Discontinued property.</param>
        public static Product CreateProduct(global::System.Int32 productID, global::System.String productName, global::System.Boolean discontinued)
        {
            Product product = new Product();
            product.ProductID = productID;
            product.ProductName = productName;
            product.Discontinued = discontinued;
            return product;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ProductID
        {
            get
            {
                return _ProductID;
            }
            set
            {
                if (_ProductID != value)
                {
                    OnProductIDChanging(value);
                    ReportPropertyChanging("ProductID");
                    _ProductID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ProductID");
                    OnProductIDChanged();
                }
            }
        }
        private global::System.Int32 _ProductID;
        partial void OnProductIDChanging(global::System.Int32 value);
        partial void OnProductIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ProductName
        {
            get
            {
                return _ProductName;
            }
            set
            {
                OnProductNameChanging(value);
                ReportPropertyChanging("ProductName");
                _ProductName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ProductName");
                OnProductNameChanged();
            }
        }
        private global::System.String _ProductName;
        partial void OnProductNameChanging(global::System.String value);
        partial void OnProductNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> SupplierID
        {
            get
            {
                return _SupplierID;
            }
            set
            {
                OnSupplierIDChanging(value);
                ReportPropertyChanging("SupplierID");
                _SupplierID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SupplierID");
                OnSupplierIDChanged();
            }
        }
        private Nullable<global::System.Int32> _SupplierID;
        partial void OnSupplierIDChanging(Nullable<global::System.Int32> value);
        partial void OnSupplierIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> CategoryID
        {
            get
            {
                return _CategoryID;
            }
            set
            {
                OnCategoryIDChanging(value);
                ReportPropertyChanging("CategoryID");
                _CategoryID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CategoryID");
                OnCategoryIDChanged();
            }
        }
        private Nullable<global::System.Int32> _CategoryID;
        partial void OnCategoryIDChanging(Nullable<global::System.Int32> value);
        partial void OnCategoryIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String QuantityPerUnit
        {
            get
            {
                return _QuantityPerUnit;
            }
            set
            {
                OnQuantityPerUnitChanging(value);
                ReportPropertyChanging("QuantityPerUnit");
                _QuantityPerUnit = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("QuantityPerUnit");
                OnQuantityPerUnitChanged();
            }
        }
        private global::System.String _QuantityPerUnit;
        partial void OnQuantityPerUnitChanging(global::System.String value);
        partial void OnQuantityPerUnitChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> UnitPrice
        {
            get
            {
                return _UnitPrice;
            }
            set
            {
                OnUnitPriceChanging(value);
                ReportPropertyChanging("UnitPrice");
                _UnitPrice = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UnitPrice");
                OnUnitPriceChanged();
            }
        }
        private Nullable<global::System.Decimal> _UnitPrice;
        partial void OnUnitPriceChanging(Nullable<global::System.Decimal> value);
        partial void OnUnitPriceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> UnitsInStock
        {
            get
            {
                return _UnitsInStock;
            }
            set
            {
                OnUnitsInStockChanging(value);
                ReportPropertyChanging("UnitsInStock");
                _UnitsInStock = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UnitsInStock");
                OnUnitsInStockChanged();
            }
        }
        private Nullable<global::System.Int16> _UnitsInStock;
        partial void OnUnitsInStockChanging(Nullable<global::System.Int16> value);
        partial void OnUnitsInStockChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> UnitsOnOrder
        {
            get
            {
                return _UnitsOnOrder;
            }
            set
            {
                OnUnitsOnOrderChanging(value);
                ReportPropertyChanging("UnitsOnOrder");
                _UnitsOnOrder = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UnitsOnOrder");
                OnUnitsOnOrderChanged();
            }
        }
        private Nullable<global::System.Int16> _UnitsOnOrder;
        partial void OnUnitsOnOrderChanging(Nullable<global::System.Int16> value);
        partial void OnUnitsOnOrderChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> ReorderLevel
        {
            get
            {
                return _ReorderLevel;
            }
            set
            {
                OnReorderLevelChanging(value);
                ReportPropertyChanging("ReorderLevel");
                _ReorderLevel = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ReorderLevel");
                OnReorderLevelChanged();
            }
        }
        private Nullable<global::System.Int16> _ReorderLevel;
        partial void OnReorderLevelChanging(Nullable<global::System.Int16> value);
        partial void OnReorderLevelChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Discontinued
        {
            get
            {
                return _Discontinued;
            }
            set
            {
                OnDiscontinuedChanging(value);
                ReportPropertyChanging("Discontinued");
                _Discontinued = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Discontinued");
                OnDiscontinuedChanged();
            }
        }
        private global::System.Boolean _Discontinued;
        partial void OnDiscontinuedChanging(global::System.Boolean value);
        partial void OnDiscontinuedChanged();

        #endregion

    
    }

    #endregion

    
}
