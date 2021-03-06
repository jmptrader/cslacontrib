
using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using System.Configuration;
using System.IO;
using System.ComponentModel;
using System.Collections.Generic;
using Csla.Validation;
namespace Northwind.CSLA.Library
{
	/// <summary>
	///	Customer Generated by MyGeneration using the CSLA Object Mapping template
	/// </summary>
	[Serializable()]
	[TypeConverter(typeof(CustomerConverter))]
	public partial class Customer : BusinessBase<Customer>, IDisposable, IVEHasBrokenRules
	{
		#region Refresh
		private List<Customer> _RefreshCustomers = new List<Customer>();
		private List<CustomerCustomerCustomerDemo> _RefreshCustomerCustomerCustomerDemos = new List<CustomerCustomerCustomerDemo>();
		private List<CustomerOrder> _RefreshCustomerOrders = new List<CustomerOrder>();
		private void AddToRefreshList(List<Customer> refreshCustomers, List<CustomerCustomerCustomerDemo> refreshCustomerCustomerCustomerDemos, List<CustomerOrder> refreshCustomerOrders)
		{
			if (IsDirty)
				refreshCustomers.Add(this);
			if (_CustomerCustomerCustomerDemos != null && _CustomerCustomerCustomerDemos.IsDirty)
			{
				foreach (CustomerCustomerCustomerDemo tmp in _CustomerCustomerCustomerDemos)
				{
					if(tmp.IsDirty)refreshCustomerCustomerCustomerDemos.Add(tmp);
				}
			}
			if (_CustomerOrders != null && _CustomerOrders.IsDirty)
			{
				foreach (CustomerOrder tmp in _CustomerOrders)
				{
					if(tmp.IsDirty)refreshCustomerOrders.Add(tmp);
				}
			}
		}
		private void BuildRefreshList()
		{
			_RefreshCustomers = new List<Customer>();
			_RefreshCustomerCustomerCustomerDemos = new List<CustomerCustomerCustomerDemo>();
			_RefreshCustomerOrders = new List<CustomerOrder>();
			AddToRefreshList(_RefreshCustomers, _RefreshCustomerCustomerCustomerDemos, _RefreshCustomerOrders);
		}
		private void ProcessRefreshList()
		{
			foreach (Customer tmp in _RefreshCustomers)
			{
				CustomerInfo.Refresh(tmp);
			}
			foreach (CustomerCustomerCustomerDemo tmp in _RefreshCustomerCustomerCustomerDemos)
			{
				CustomerCustomerDemoInfo.Refresh(this, tmp);
			}
			foreach (CustomerOrder tmp in _RefreshCustomerOrders)
			{
				OrderInfo.Refresh(tmp);
			}
		}
		#endregion
		#region Collection
		protected static List<Customer> _AllList = new List<Customer>();
		private static Dictionary<string, Customer> _AllByPrimaryKey = new Dictionary<string, Customer>();
		private static void ConvertListToDictionary()
		{
			List<Customer> remove = new List<Customer>();
			foreach (Customer tmp in _AllList)
			{
				_AllByPrimaryKey[tmp.CustomerID.ToString()]=tmp; // Primary Key
				remove.Add(tmp);
			}
			foreach (Customer tmp in remove)
				_AllList.Remove(tmp);
		}
		public static Customer GetExistingByPrimaryKey(string customerID)
		{
			ConvertListToDictionary();
			string key = customerID.ToString();
			if (_AllByPrimaryKey.ContainsKey(key)) return _AllByPrimaryKey[key]; 
			return null;
		}
		#endregion
		#region Business Methods
		private string _ErrorMessage = string.Empty;
		public string ErrorMessage
		{
			get { return _ErrorMessage; }
		}
		private string _CustomerID = string.Empty;
		[System.ComponentModel.DataObjectField(true, true)]
		public string CustomerID
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _CustomerID;
			}
		}
		private string _CompanyName = string.Empty;
		public string CompanyName
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _CompanyName;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				CanWriteProperty(true);
				if (value == null) value = string.Empty;
				if (_CompanyName != value)
				{
					_CompanyName = value;
					PropertyHasChanged();
				}
			}
		}
		private string _ContactName = string.Empty;
		public string ContactName
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _ContactName;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				CanWriteProperty(true);
				if (value == null) value = string.Empty;
				if (_ContactName != value)
				{
					_ContactName = value;
					PropertyHasChanged();
				}
			}
		}
		private string _ContactTitle = string.Empty;
		public string ContactTitle
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _ContactTitle;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				CanWriteProperty(true);
				if (value == null) value = string.Empty;
				if (_ContactTitle != value)
				{
					_ContactTitle = value;
					PropertyHasChanged();
				}
			}
		}
		private string _Address = string.Empty;
		public string Address
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _Address;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				CanWriteProperty(true);
				if (value == null) value = string.Empty;
				if (_Address != value)
				{
					_Address = value;
					PropertyHasChanged();
				}
			}
		}
		private string _City = string.Empty;
		public string City
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _City;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				CanWriteProperty(true);
				if (value == null) value = string.Empty;
				if (_City != value)
				{
					_City = value;
					PropertyHasChanged();
				}
			}
		}
		private string _Region = string.Empty;
		public string Region
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _Region;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				CanWriteProperty(true);
				if (value == null) value = string.Empty;
				if (_Region != value)
				{
					_Region = value;
					PropertyHasChanged();
				}
			}
		}
		private string _PostalCode = string.Empty;
		public string PostalCode
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _PostalCode;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				CanWriteProperty(true);
				if (value == null) value = string.Empty;
				if (_PostalCode != value)
				{
					_PostalCode = value;
					PropertyHasChanged();
				}
			}
		}
		private string _Country = string.Empty;
		public string Country
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _Country;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				CanWriteProperty(true);
				if (value == null) value = string.Empty;
				if (_Country != value)
				{
					_Country = value;
					PropertyHasChanged();
				}
			}
		}
		private string _Phone = string.Empty;
		public string Phone
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _Phone;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				CanWriteProperty(true);
				if (value == null) value = string.Empty;
				if (_Phone != value)
				{
					_Phone = value;
					PropertyHasChanged();
				}
			}
		}
		private string _Fax = string.Empty;
		public string Fax
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _Fax;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				CanWriteProperty(true);
				if (value == null) value = string.Empty;
				if (_Fax != value)
				{
					_Fax = value;
					PropertyHasChanged();
				}
			}
		}
		private int _CustomerCustomerCustomerDemoCount = 0;
		/// <summary>
		/// Count of CustomerCustomerCustomerDemos for this Customer
		/// </summary>
		public int CustomerCustomerCustomerDemoCount
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _CustomerCustomerCustomerDemoCount;
			}
		}
		private CustomerCustomerCustomerDemos _CustomerCustomerCustomerDemos = null;
		/// <summary>
		/// Related Field
		/// </summary>
		[TypeConverter(typeof(CustomerCustomerCustomerDemosConverter))]
		public CustomerCustomerCustomerDemos CustomerCustomerCustomerDemos
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				if(_CustomerCustomerCustomerDemoCount > 0 && _CustomerCustomerCustomerDemos == null)
					_CustomerCustomerCustomerDemos = CustomerCustomerCustomerDemos.GetByCustomerID(CustomerID);
				else if(_CustomerCustomerCustomerDemos == null)
					_CustomerCustomerCustomerDemos = CustomerCustomerCustomerDemos.New();
				return _CustomerCustomerCustomerDemos;
			}
		}
		private int _CustomerOrderCount = 0;
		/// <summary>
		/// Count of CustomerOrders for this Customer
		/// </summary>
		public int CustomerOrderCount
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _CustomerOrderCount;
			}
		}
		private CustomerOrders _CustomerOrders = null;
		/// <summary>
		/// Related Field
		/// </summary>
		[TypeConverter(typeof(CustomerOrdersConverter))]
		public CustomerOrders CustomerOrders
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				if(_CustomerOrderCount > 0 && _CustomerOrders == null)
					_CustomerOrders = CustomerOrders.GetByCustomerID(CustomerID);
				else if(_CustomerOrders == null)
					_CustomerOrders = CustomerOrders.New();
				return _CustomerOrders;
			}
		}
		public override bool IsDirty
		{
			get { return base.IsDirty || (_CustomerCustomerCustomerDemos == null? false : _CustomerCustomerCustomerDemos.IsDirty) || (_CustomerOrders == null? false : _CustomerOrders.IsDirty); }
		}
		public override bool IsValid
		{
			get { return (IsNew && !IsDirty ? true : base.IsValid) && (_CustomerCustomerCustomerDemos == null? true : _CustomerCustomerCustomerDemos.IsValid) && (_CustomerOrders == null? true : _CustomerOrders.IsValid); }
		}
		// TODO: Replace base Customer.ToString function as necessary
		/// <summary>
		/// Overrides Base ToString
		/// </summary>
		/// <returns>A string representation of current Customer</returns>
		//public override string ToString()
		//{
		//  return base.ToString();
		//}
		// TODO: Check Customer.GetIdValue to assure that the ID returned is unique
		/// <summary>
		/// Overrides Base GetIdValue - Used internally by CSLA to determine equality
		/// </summary>
		/// <returns>A Unique ID for the current Customer</returns>
		protected override object GetIdValue()
		{
			return _CustomerID;
		}
		#endregion
		#region ValidationRules
		[NonSerialized]
		private bool _CheckingBrokenRules=false;
		public IVEHasBrokenRules HasBrokenRules
		{
			get {
				if(_CheckingBrokenRules)return null;
				if ((IsDirty || !IsNew) && BrokenRulesCollection.Count > 0) return this;
				try
				{
					_CheckingBrokenRules=true;
					IVEHasBrokenRules hasBrokenRules = null;
				if (_CustomerCustomerCustomerDemos != null && (hasBrokenRules = _CustomerCustomerCustomerDemos.HasBrokenRules) != null) return hasBrokenRules;
				if (_CustomerOrders != null && (hasBrokenRules = _CustomerOrders.HasBrokenRules) != null) return hasBrokenRules;
					return hasBrokenRules;
				}
				finally
				{
					_CheckingBrokenRules=false;
				}
			}
		}
		public BrokenRulesCollection BrokenRules
		{
			get
			{
				IVEHasBrokenRules hasBrokenRules = HasBrokenRules;
				if (this.Equals(hasBrokenRules)) return BrokenRulesCollection;
				return (hasBrokenRules != null ? hasBrokenRules.BrokenRules : null);
			}
		}
		protected override void AddBusinessRules()
		{
			ValidationRules.AddRule(
				Csla.Validation.CommonRules.StringRequired, "CustomerID");
			ValidationRules.AddRule(
				Csla.Validation.CommonRules.StringMaxLength,
				new Csla.Validation.CommonRules.MaxLengthRuleArgs("CustomerID", 5));
			ValidationRules.AddRule(
				Csla.Validation.CommonRules.StringRequired, "CompanyName");
			ValidationRules.AddRule(
				Csla.Validation.CommonRules.StringMaxLength,
				new Csla.Validation.CommonRules.MaxLengthRuleArgs("CompanyName", 40));
			ValidationRules.AddRule(
				Csla.Validation.CommonRules.StringMaxLength,
				new Csla.Validation.CommonRules.MaxLengthRuleArgs("ContactName", 30));
			ValidationRules.AddRule(
				Csla.Validation.CommonRules.StringMaxLength,
				new Csla.Validation.CommonRules.MaxLengthRuleArgs("ContactTitle", 30));
			ValidationRules.AddRule(
				Csla.Validation.CommonRules.StringMaxLength,
				new Csla.Validation.CommonRules.MaxLengthRuleArgs("Address", 60));
			ValidationRules.AddRule(
				Csla.Validation.CommonRules.StringMaxLength,
				new Csla.Validation.CommonRules.MaxLengthRuleArgs("City", 15));
			ValidationRules.AddRule(
				Csla.Validation.CommonRules.StringMaxLength,
				new Csla.Validation.CommonRules.MaxLengthRuleArgs("Region", 15));
			ValidationRules.AddRule(
				Csla.Validation.CommonRules.StringMaxLength,
				new Csla.Validation.CommonRules.MaxLengthRuleArgs("PostalCode", 10));
			ValidationRules.AddRule(
				Csla.Validation.CommonRules.StringMaxLength,
				new Csla.Validation.CommonRules.MaxLengthRuleArgs("Country", 15));
			ValidationRules.AddRule(
				Csla.Validation.CommonRules.StringMaxLength,
				new Csla.Validation.CommonRules.MaxLengthRuleArgs("Phone", 24));
			ValidationRules.AddRule(
				Csla.Validation.CommonRules.StringMaxLength,
				new Csla.Validation.CommonRules.MaxLengthRuleArgs("Fax", 24));
			//ValidationRules.AddDependantProperty("x", "y");
			_CustomerExtension.AddValidationRules(ValidationRules);
			// TODO:  Add other validation rules
		}
		protected override void AddInstanceBusinessRules()
		{
			_CustomerExtension.AddInstanceValidationRules(ValidationRules);
			// TODO:  Add other validation rules
		}
		// Sample data comparison validation rule
		//private bool StartDateGTEndDate(object target, Csla.Validation.RuleArgs e)
		//{
		//	if (_started > _ended)
		//	{
		//		e.Description = "Start date can't be after end date";
		//		return false;
		//	}
		//	else
		//		return true;
		//}
		#endregion
		#region Authorization Rules
		protected override void AddAuthorizationRules()
		{
			//TODO: Who can read/write which fields
			//AuthorizationRules.AllowRead(CustomerID, "<Role(s)>");
			//AuthorizationRules.AllowRead(CompanyName, "<Role(s)>");
			//AuthorizationRules.AllowRead(ContactName, "<Role(s)>");
			//AuthorizationRules.AllowRead(ContactTitle, "<Role(s)>");
			//AuthorizationRules.AllowRead(Address, "<Role(s)>");
			//AuthorizationRules.AllowRead(City, "<Role(s)>");
			//AuthorizationRules.AllowRead(Region, "<Role(s)>");
			//AuthorizationRules.AllowRead(PostalCode, "<Role(s)>");
			//AuthorizationRules.AllowRead(Country, "<Role(s)>");
			//AuthorizationRules.AllowRead(Phone, "<Role(s)>");
			//AuthorizationRules.AllowRead(Fax, "<Role(s)>");
			//AuthorizationRules.AllowWrite(CompanyName, "<Role(s)>");
			//AuthorizationRules.AllowWrite(ContactName, "<Role(s)>");
			//AuthorizationRules.AllowWrite(ContactTitle, "<Role(s)>");
			//AuthorizationRules.AllowWrite(Address, "<Role(s)>");
			//AuthorizationRules.AllowWrite(City, "<Role(s)>");
			//AuthorizationRules.AllowWrite(Region, "<Role(s)>");
			//AuthorizationRules.AllowWrite(PostalCode, "<Role(s)>");
			//AuthorizationRules.AllowWrite(Country, "<Role(s)>");
			//AuthorizationRules.AllowWrite(Phone, "<Role(s)>");
			//AuthorizationRules.AllowWrite(Fax, "<Role(s)>");
			_CustomerExtension.AddAuthorizationRules(AuthorizationRules);
		}
		protected override void AddInstanceAuthorizationRules()
		{
			//TODO: Who can read/write which fields
			_CustomerExtension.AddInstanceAuthorizationRules(AuthorizationRules);
		}
		public static bool CanAddObject()
		{
			// TODO: Can Add Authorization
			//return Csla.ApplicationContext.User.IsInRole("ProjectManager");
			return true;
		}
		public static bool CanGetObject()
		{
			// TODO: CanGet Authorization
			return true;
		}
		public static bool CanDeleteObject()
		{
			// TODO: CanDelete Authorization
			//bool result = false;
			//if (Csla.ApplicationContext.User.IsInRole("ProjectManager"))result = true;
			//if (Csla.ApplicationContext.User.IsInRole("Administrator"))result = true;
			//return result;
			return true;
		}
		public static bool CanEditObject()
		{
			// TODO: CanEdit Authorization
			//return Csla.ApplicationContext.User.IsInRole("ProjectManager");
			return true;
		}
		#endregion
		#region Factory Methods
		public int CurrentEditLevel
		{ get { return EditLevel; } }
		protected Customer()
		{/* require use of factory methods */
			_AllList.Add(this);
		}
		public void Dispose()
		{
			_AllList.Remove(this);
			_AllByPrimaryKey.Remove(CustomerID.ToString());
		}
		public static Customer New()
		{
			if (!CanAddObject())
				throw new System.Security.SecurityException("User not authorized to add a Customer");
			try
			{
				return DataPortal.Create<Customer>();
			}
			catch (Exception ex)
			{
				throw new DbCslaException("Error on Customer.New", ex);
			}
		}
		public static Customer New(string customerID, string companyName)
		{
			Customer tmp = Customer.New();
			tmp._CustomerID = customerID;
			tmp.CompanyName = companyName;
			return tmp;
		}
		public static Customer New(string customerID, string companyName, string contactName, string contactTitle, string address, string city, string region, string postalCode, string country, string phone, string fax)
		{
			Customer tmp = Customer.New();
			tmp._CustomerID = customerID;
			tmp.CompanyName = companyName;
			tmp.ContactName = contactName;
			tmp.ContactTitle = contactTitle;
			tmp.Address = address;
			tmp.City = city;
			tmp.Region = region;
			tmp.PostalCode = postalCode;
			tmp.Country = country;
			tmp.Phone = phone;
			tmp.Fax = fax;
			return tmp;
		}
		public static Customer MakeCustomer(string customerID, string companyName, string contactName, string contactTitle, string address, string city, string region, string postalCode, string country, string phone, string fax)
		{
			Customer tmp = Customer.New(customerID, companyName, contactName, contactTitle, address, city, region, postalCode, country, phone, fax);
			if (tmp.IsSavable)
				tmp = tmp.Save();
			else
			{
				Csla.Validation.BrokenRulesCollection brc = tmp.ValidationRules.GetBrokenRules();
				tmp._ErrorMessage = "Failed Validation:";
				foreach (Csla.Validation.BrokenRule br in brc)
				{
					tmp._ErrorMessage += "\r\n\tFailure: " + br.RuleName;
				}
			}
			return tmp;
		}
		public static Customer Get(string customerID)
		{
			if (!CanGetObject())
				throw new System.Security.SecurityException("User not authorized to view a Customer");
			try
			{
				Customer tmp = GetExistingByPrimaryKey(customerID);
				if (tmp == null)
				{
					tmp = DataPortal.Fetch<Customer>(new PKCriteria(customerID));
					_AllList.Add(tmp);
				}
				if (tmp.ErrorMessage == "No Record Found") tmp = null;
				return tmp;
			}
			catch (Exception ex)
			{
				throw new DbCslaException("Error on Customer.Get", ex);
			}
		}
		public static Customer Get(SafeDataReader dr)
		{
			if (dr.Read()) return new Customer(dr);
			return null;
		}
		internal Customer(SafeDataReader dr)
		{
			ReadData(dr);
		}
		public static void Delete(string customerID)
		{
			if (!CanDeleteObject())
				throw new System.Security.SecurityException("User not authorized to remove a Customer");
			try
			{
				DataPortal.Delete(new PKCriteria(customerID));
			}
			catch (Exception ex)
			{
				throw new DbCslaException("Error on Customer.Delete", ex);
			}
		}
		public override Customer Save()
		{
			if (IsDeleted && !CanDeleteObject())
				throw new System.Security.SecurityException("User not authorized to remove a Customer");
			else if (IsNew && !CanAddObject())
				throw new System.Security.SecurityException("User not authorized to add a Customer");
			else if (!CanEditObject())
				throw new System.Security.SecurityException("User not authorized to update a Customer");
			try
			{
				BuildRefreshList();
				Customer customer = base.Save();
				_AllList.Add(customer);//Refresh the item in AllList
				ProcessRefreshList();
				return customer;
			}
			catch (Exception ex)
			{
				throw new DbCslaException("Error on CSLA Save", ex);
			}
		}
		#endregion
		#region Data Access Portal
		[Serializable()]
		protected class PKCriteria
		{
			private string _CustomerID;
			public string CustomerID
			{ get { return _CustomerID; } }
			public PKCriteria(string customerID)
			{
				_CustomerID = customerID;
			}
		}
		// TODO: If Create needs to access DB - It should not be marked RunLocal
		[RunLocal()]
		private new void DataPortal_Create()
		{

			// Database Defaults

			// TODO: Add any defaults that are necessary
			ValidationRules.CheckRules();
		}
		private void ReadData(SafeDataReader dr)
		{
			Database.LogInfo("Customer.ReadData", GetHashCode());
			try
			{
				_CustomerID = dr.GetString("CustomerID");
				_CompanyName = dr.GetString("CompanyName");
				_ContactName = dr.GetString("ContactName");
				_ContactTitle = dr.GetString("ContactTitle");
				_Address = dr.GetString("Address");
				_City = dr.GetString("City");
				_Region = dr.GetString("Region");
				_PostalCode = dr.GetString("PostalCode");
				_Country = dr.GetString("Country");
				_Phone = dr.GetString("Phone");
				_Fax = dr.GetString("Fax");
				_CustomerCustomerCustomerDemoCount = dr.GetInt32("CustomerCustomerDemoCount");
				_CustomerOrderCount = dr.GetInt32("OrderCount");
				MarkOld();
			}
			catch (Exception ex)
			{
				Database.LogException("Customer.ReadData", ex);
				_ErrorMessage = ex.Message;
				throw new DbCslaException("Customer.ReadData", ex);
			}
		}
		private void DataPortal_Fetch(PKCriteria criteria)
		{
			Database.LogInfo("Customer.DataPortal_Fetch", GetHashCode());
			try
			{
				using (SqlConnection cn = Database.Northwind_SqlConnection)
				{
					ApplicationContext.LocalContext["cn"] = cn;
					using (SqlCommand cm = cn.CreateCommand())
					{
						cm.CommandType = CommandType.StoredProcedure;
						cm.CommandText = "getCustomer";
						cm.Parameters.AddWithValue("@CustomerID", criteria.CustomerID);
						using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
						{
							if (!dr.Read())
							{
								_ErrorMessage = "No Record Found";
								return;
							}
							ReadData(dr);
							// load child objects
							dr.NextResult();
							_CustomerCustomerCustomerDemos = CustomerCustomerCustomerDemos.Get(dr);
							// load child objects
							dr.NextResult();
							_CustomerOrders = CustomerOrders.Get(dr);
						}
					}
					// removing of item only needed for local data portal
					if (ApplicationContext.ExecutionLocation == ApplicationContext.ExecutionLocations.Client)
						ApplicationContext.LocalContext.Remove("cn");
				}
			}
			catch (Exception ex)
			{
				Database.LogException("Customer.DataPortal_Fetch", ex);
				_ErrorMessage = ex.Message;
				throw new DbCslaException("Customer.DataPortal_Fetch", ex);
			}
		}
		[Transactional(TransactionalTypes.TransactionScope)]
		protected override void DataPortal_Insert()
		{
			try
			{
				using (SqlConnection cn = Database.Northwind_SqlConnection)
				{
					ApplicationContext.LocalContext["cn"] = cn;
					SQLInsert();
					// removing of item only needed for local data portal
					if (ApplicationContext.ExecutionLocation == ApplicationContext.ExecutionLocations.Client)
						ApplicationContext.LocalContext.Remove("cn");
				}
			}
			catch (Exception ex)
			{
				Database.LogException("Customer.DataPortal_Insert", ex);
				_ErrorMessage = ex.Message;
				throw new DbCslaException("Customer.DataPortal_Insert", ex);
			}
			finally
			{
				Database.LogInfo("Customer.DataPortal_Insert", GetHashCode());
			}
		}
		[Transactional(TransactionalTypes.TransactionScope)]
		internal void SQLInsert()
		{
			if (!this.IsDirty) return;
			try
			{
				SqlConnection cn = (SqlConnection)ApplicationContext.LocalContext["cn"];
				using (SqlCommand cm = cn.CreateCommand())
				{
					cm.CommandType = CommandType.StoredProcedure;
					cm.CommandText = "addCustomer";
					// Input All Fields - Except Calculated Columns
					cm.Parameters.AddWithValue("@CustomerID", _CustomerID);
					cm.Parameters.AddWithValue("@CompanyName", _CompanyName);
					cm.Parameters.AddWithValue("@ContactName", _ContactName);
					cm.Parameters.AddWithValue("@ContactTitle", _ContactTitle);
					cm.Parameters.AddWithValue("@Address", _Address);
					cm.Parameters.AddWithValue("@City", _City);
					cm.Parameters.AddWithValue("@Region", _Region);
					cm.Parameters.AddWithValue("@PostalCode", _PostalCode);
					cm.Parameters.AddWithValue("@Country", _Country);
					cm.Parameters.AddWithValue("@Phone", _Phone);
					cm.Parameters.AddWithValue("@Fax", _Fax);
					// Output Calculated Columns
					// TODO: Define any additional output parameters
					cm.ExecuteNonQuery();
					// Save all values being returned from the Procedure
				}
				MarkOld();
				// update child objects
				if (_CustomerCustomerCustomerDemos != null) _CustomerCustomerCustomerDemos.Update(this);
				if (_CustomerOrders != null) _CustomerOrders.Update(this);
				Database.LogInfo("Customer.SQLInsert", GetHashCode());
			}
			catch (Exception ex)
			{
				Database.LogException("Customer.SQLInsert", ex);
				_ErrorMessage = ex.Message;
				throw new DbCslaException("Customer.SQLInsert", ex);
			}
		}
		[Transactional(TransactionalTypes.TransactionScope)]
		public static void Add(SqlConnection cn, string customerID, string companyName, string contactName, string contactTitle, string address, string city, string region, string postalCode, string country, string phone, string fax)
		{
			Database.LogInfo("Customer.Add", 0);
			try
			{
				using (SqlCommand cm = cn.CreateCommand())
				{
					cm.CommandType = CommandType.StoredProcedure;
					cm.CommandText = "addCustomer";
					// Input All Fields - Except Calculated Columns
					cm.Parameters.AddWithValue("@CustomerID", customerID);
					cm.Parameters.AddWithValue("@CompanyName", companyName);
					cm.Parameters.AddWithValue("@ContactName", contactName);
					cm.Parameters.AddWithValue("@ContactTitle", contactTitle);
					cm.Parameters.AddWithValue("@Address", address);
					cm.Parameters.AddWithValue("@City", city);
					cm.Parameters.AddWithValue("@Region", region);
					cm.Parameters.AddWithValue("@PostalCode", postalCode);
					cm.Parameters.AddWithValue("@Country", country);
					cm.Parameters.AddWithValue("@Phone", phone);
					cm.Parameters.AddWithValue("@Fax", fax);
					// Output Calculated Columns
					// TODO: Define any additional output parameters
					cm.ExecuteNonQuery();
					// Save all values being returned from the Procedure
			// No Timestamp value to return
				}
			}
			catch (Exception ex)
			{
				Database.LogException("Customer.Add", ex);
				throw new DbCslaException("Customer.Add", ex);
			}
		}
		[Transactional(TransactionalTypes.TransactionScope)]
		protected override void DataPortal_Update()
		{
			if (!IsDirty) return;	// If not dirty - nothing to do
			Database.LogInfo("Customer.DataPortal_Update", GetHashCode());
			try
			{
				using (SqlConnection cn = Database.Northwind_SqlConnection)
				{
					ApplicationContext.LocalContext["cn"] = cn;
					SQLUpdate();
					// removing of item only needed for local data portal
					if (ApplicationContext.ExecutionLocation == ApplicationContext.ExecutionLocations.Client)
						ApplicationContext.LocalContext.Remove("cn");
				}
			}
			catch (Exception ex)
			{
				Database.LogException("Customer.DataPortal_Update", ex);
				_ErrorMessage = ex.Message;
				if (!ex.Message.EndsWith("has been edited by another user.")) throw ex;
			}
		}
		[Transactional(TransactionalTypes.TransactionScope)]
		internal void SQLUpdate()
		{
			if (!IsDirty) return;	// If not dirty - nothing to do
			Database.LogInfo("Customer.SQLUpdate", GetHashCode());
			try
			{
				SqlConnection cn = (SqlConnection)ApplicationContext.LocalContext["cn"];
				if (base.IsDirty)
				{
					using (SqlCommand cm = cn.CreateCommand())
					{
						cm.CommandType = CommandType.StoredProcedure;
						cm.CommandText = "updateCustomer";
						// All Fields including Calculated Fields
						cm.Parameters.AddWithValue("@CustomerID", _CustomerID);
						cm.Parameters.AddWithValue("@CompanyName", _CompanyName);
						cm.Parameters.AddWithValue("@ContactName", _ContactName);
						cm.Parameters.AddWithValue("@ContactTitle", _ContactTitle);
						cm.Parameters.AddWithValue("@Address", _Address);
						cm.Parameters.AddWithValue("@City", _City);
						cm.Parameters.AddWithValue("@Region", _Region);
						cm.Parameters.AddWithValue("@PostalCode", _PostalCode);
						cm.Parameters.AddWithValue("@Country", _Country);
						cm.Parameters.AddWithValue("@Phone", _Phone);
						cm.Parameters.AddWithValue("@Fax", _Fax);
						// Output Calculated Columns
						// TODO: Define any additional output parameters
						cm.ExecuteNonQuery();
						// Save all values being returned from the Procedure
					}
				}
				MarkOld();
				// use the open connection to update child objects
				if (_CustomerCustomerCustomerDemos != null) _CustomerCustomerCustomerDemos.Update(this);
				if (_CustomerOrders != null) _CustomerOrders.Update(this);
			}
			catch (Exception ex)
			{
				Database.LogException("Customer.SQLUpdate", ex);
				_ErrorMessage = ex.Message;
				if (!ex.Message.EndsWith("has been edited by another user.")) throw ex;
			}
		}
		internal void Update()
		{
			if (!this.IsDirty) return;
			if (base.IsDirty)
			{
				SqlConnection cn = (SqlConnection)ApplicationContext.LocalContext["cn"];
				if (IsNew)
					Customer.Add(cn, _CustomerID, _CompanyName, _ContactName, _ContactTitle, _Address, _City, _Region, _PostalCode, _Country, _Phone, _Fax);
				else
					Customer.Update(cn, _CustomerID, _CompanyName, _ContactName, _ContactTitle, _Address, _City, _Region, _PostalCode, _Country, _Phone, _Fax);
				MarkOld();
			}
			if (_CustomerCustomerCustomerDemos != null) _CustomerCustomerCustomerDemos.Update(this);
			if (_CustomerOrders != null) _CustomerOrders.Update(this);
		}
		[Transactional(TransactionalTypes.TransactionScope)]
		public static void Update(SqlConnection cn, string customerID, string companyName, string contactName, string contactTitle, string address, string city, string region, string postalCode, string country, string phone, string fax)
		{
			Database.LogInfo("Customer.Update", 0);
			try
			{
				using (SqlCommand cm = cn.CreateCommand())
				{
					cm.CommandType = CommandType.StoredProcedure;
					cm.CommandText = "updateCustomer";
					// Input All Fields - Except Calculated Columns
					cm.Parameters.AddWithValue("@CustomerID", customerID);
					cm.Parameters.AddWithValue("@CompanyName", companyName);
					cm.Parameters.AddWithValue("@ContactName", contactName);
					cm.Parameters.AddWithValue("@ContactTitle", contactTitle);
					cm.Parameters.AddWithValue("@Address", address);
					cm.Parameters.AddWithValue("@City", city);
					cm.Parameters.AddWithValue("@Region", region);
					cm.Parameters.AddWithValue("@PostalCode", postalCode);
					cm.Parameters.AddWithValue("@Country", country);
					cm.Parameters.AddWithValue("@Phone", phone);
					cm.Parameters.AddWithValue("@Fax", fax);
					// Output Calculated Columns
					// TODO: Define any additional output parameters
					cm.ExecuteNonQuery();
					// Save all values being returned from the Procedure
				// No Timestamp value to return
				}
			}
			catch (Exception ex)
			{
				Database.LogException("Customer.Update", ex);
				throw new DbCslaException("Customer.Update", ex);
			}
		}
		[Transactional(TransactionalTypes.TransactionScope)]
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new PKCriteria(_CustomerID));
		}
		[Transactional(TransactionalTypes.TransactionScope)]
		private void DataPortal_Delete(PKCriteria criteria)
		{
			Database.LogInfo("Customer.DataPortal_Delete", GetHashCode());
			try
			{
				using (SqlConnection cn = Database.Northwind_SqlConnection)
				{
					using (SqlCommand cm = cn.CreateCommand())
					{
						cm.CommandType = CommandType.StoredProcedure;
						cm.CommandText = "deleteCustomer";
						cm.Parameters.AddWithValue("@CustomerID", criteria.CustomerID);
						cm.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{
				Database.LogException("Customer.DataPortal_Delete", ex);
				_ErrorMessage = ex.Message;
				throw new DbCslaException("Customer.DataPortal_Delete", ex);
			}
		}
		[Transactional(TransactionalTypes.TransactionScope)]
		public static void Remove(SqlConnection cn, string customerID)
		{
			Database.LogInfo("Customer.Remove", 0);
			try
			{
				using (SqlCommand cm = cn.CreateCommand())
				{
					cm.CommandType = CommandType.StoredProcedure;
					cm.CommandText = "deleteCustomer";
					// Input PK Fields
					cm.Parameters.AddWithValue("@CustomerID", customerID);
					// TODO: Define any additional output parameters
					cm.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				Database.LogException("Customer.Remove", ex);
				throw new DbCslaException("Customer.Remove", ex);
			}
		}
		#endregion
		#region Exists
		public static bool Exists(string customerID)
		{
			ExistsCommand result;
			try
			{
				result = DataPortal.Execute<ExistsCommand>(new ExistsCommand(customerID));
				return result.Exists;
			}
			catch (Exception ex)
			{
				throw new DbCslaException("Error on Customer.Exists", ex);
			}
		}
		[Serializable()]
		private class ExistsCommand : CommandBase
		{
			private string _CustomerID;
			private bool _exists;
			public bool Exists
			{
				get { return _exists; }
			}
			public ExistsCommand(string customerID)
			{
				_CustomerID = customerID;
			}
			protected override void DataPortal_Execute()
			{
				Database.LogInfo("Customer.DataPortal_Execute", GetHashCode());
				try
				{
					using (SqlConnection cn = Database.Northwind_SqlConnection)
					{
						cn.Open();
						using (SqlCommand cm = cn.CreateCommand())
						{
							cm.CommandType = CommandType.StoredProcedure;
							cm.CommandText = "existsCustomer";
							cm.Parameters.AddWithValue("@CustomerID", _CustomerID);
							int count = (int)cm.ExecuteScalar();
							_exists = (count > 0);
						}
					}
				}
				catch (Exception ex)
				{
					Database.LogException("Customer.DataPortal_Execute", ex);
					throw new DbCslaException("Customer.DataPortal_Execute", ex);
				}
			}
		}
		#endregion
		// Standard Default Code
		#region extension
		CustomerExtension _CustomerExtension = new CustomerExtension();
		[Serializable()]
		partial class CustomerExtension : extensionBase
		{
		}
		[Serializable()]
		class extensionBase
		{
			// Default Values
			// Authorization Rules
			public virtual void AddAuthorizationRules(Csla.Security.AuthorizationRules rules)
			{
				// Needs to be overriden to add new authorization rules
			}
			// Instance Authorization Rules
			public virtual void AddInstanceAuthorizationRules(Csla.Security.AuthorizationRules rules)
			{
				// Needs to be overriden to add new authorization rules
			}
			// Validation Rules
			public virtual void AddValidationRules(Csla.Validation.ValidationRules rules)
			{
				// Needs to be overriden to add new validation rules
			}
			// InstanceValidation Rules
			public virtual void AddInstanceValidationRules(Csla.Validation.ValidationRules rules)
			{
				// Needs to be overriden to add new validation rules
			}
		}
		#endregion
	} // Class
	#region Converter
	internal class CustomerConverter : ExpandableObjectConverter
	{
		public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destType)
		{
			if (destType == typeof(string) && value is Customer)
			{
				// Return the ToString value
				return ((Customer)value).ToString();
			}
			return base.ConvertTo(context, culture, value, destType);
		}
	}
	#endregion
} // Namespace


//// The following is a sample Extension File.  You can use it to create CustomerExt.cs
//using System;
//using System.Collections.Generic;
//using System.Text;
//using Csla;

//namespace Northwind.CSLA.Library
//{
//  public partial class Customer
//  {
//    partial class CustomerExtension : extensionBase
//    {
//      // TODO: Override automatic defaults
//      public new void AddAuthorizationRules(Csla.Security.AuthorizationRules rules)
//      {
//        //rules.AllowRead(Dbid, "<Role(s)>");
//      }
//      public new void AddInstanceAuthorizationRules(Csla.Security.AuthorizationRules rules)
//      {
//        //rules.AllowInstanceRead(Dbid, "<Role(s)>");
//      }
//      public new void AddValidationRules(Csla.Validation.ValidationRules rules)
//      {
//        rules.AddRule(
//          Csla.Validation.CommonRules.StringMaxLength,
//          new Csla.Validation.CommonRules.MaxLengthRuleArgs("Name", 100));
//      }
//      public new void AddInstanceValidationRules(Csla.Validation.ValidationRules rules)
//      {
//        rules.AddInstanceRule(/* Instance Validation Rule */);
//      }
//    }
//  }
//}
