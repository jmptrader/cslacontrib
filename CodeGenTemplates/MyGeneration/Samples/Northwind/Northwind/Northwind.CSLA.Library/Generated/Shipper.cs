
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
	///	Shipper Generated by MyGeneration using the CSLA Object Mapping template
	/// </summary>
	[Serializable()]
	[TypeConverter(typeof(ShipperConverter))]
	public partial class Shipper : BusinessBase<Shipper>, IDisposable, IVEHasBrokenRules
	{
		#region Refresh
		private List<Shipper> _RefreshShippers = new List<Shipper>();
		private List<ShipperOrder> _RefreshShipperOrders = new List<ShipperOrder>();
		private void AddToRefreshList(List<Shipper> refreshShippers, List<ShipperOrder> refreshShipperOrders)
		{
			if (IsDirty)
				refreshShippers.Add(this);
			if (_ShipperOrders != null && _ShipperOrders.IsDirty)
			{
				foreach (ShipperOrder tmp in _ShipperOrders)
				{
					if(tmp.IsDirty)refreshShipperOrders.Add(tmp);
				}
			}
		}
		private void BuildRefreshList()
		{
			_RefreshShippers = new List<Shipper>();
			_RefreshShipperOrders = new List<ShipperOrder>();
			AddToRefreshList(_RefreshShippers, _RefreshShipperOrders);
		}
		private void ProcessRefreshList()
		{
			foreach (Shipper tmp in _RefreshShippers)
			{
				ShipperInfo.Refresh(tmp);
			}
			foreach (ShipperOrder tmp in _RefreshShipperOrders)
			{
				OrderInfo.Refresh(tmp);
			}
		}
		#endregion
		#region Collection
		protected static List<Shipper> _AllList = new List<Shipper>();
		private static Dictionary<string, Shipper> _AllByPrimaryKey = new Dictionary<string, Shipper>();
		private static void ConvertListToDictionary()
		{
			List<Shipper> remove = new List<Shipper>();
			foreach (Shipper tmp in _AllList)
			{
				_AllByPrimaryKey[tmp.ShipperID.ToString()]=tmp; // Primary Key
				remove.Add(tmp);
			}
			foreach (Shipper tmp in remove)
				_AllList.Remove(tmp);
		}
		public static Shipper GetExistingByPrimaryKey(int shipperID)
		{
			ConvertListToDictionary();
			string key = shipperID.ToString();
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
		private static int _nextShipperID = -1;
		public static int NextShipperID
		{
			get { return _nextShipperID--; }
		}
		private int _ShipperID;
		[System.ComponentModel.DataObjectField(true, true)]
		public int ShipperID
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _ShipperID;
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
		private int _ShipperOrderCount = 0;
		/// <summary>
		/// Count of ShipperOrders for this Shipper
		/// </summary>
		public int ShipperOrderCount
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _ShipperOrderCount;
			}
		}
		private ShipperOrders _ShipperOrders = null;
		/// <summary>
		/// Related Field
		/// </summary>
		[TypeConverter(typeof(ShipperOrdersConverter))]
		public ShipperOrders ShipperOrders
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				if(_ShipperOrderCount > 0 && _ShipperOrders == null)
					_ShipperOrders = ShipperOrders.GetByShipVia(ShipperID);
				else if(_ShipperOrders == null)
					_ShipperOrders = ShipperOrders.New();
				return _ShipperOrders;
			}
		}
		public override bool IsDirty
		{
			get { return base.IsDirty || (_ShipperOrders == null? false : _ShipperOrders.IsDirty); }
		}
		public override bool IsValid
		{
			get { return (IsNew && !IsDirty ? true : base.IsValid) && (_ShipperOrders == null? true : _ShipperOrders.IsValid); }
		}
		// TODO: Replace base Shipper.ToString function as necessary
		/// <summary>
		/// Overrides Base ToString
		/// </summary>
		/// <returns>A string representation of current Shipper</returns>
		//public override string ToString()
		//{
		//  return base.ToString();
		//}
		// TODO: Check Shipper.GetIdValue to assure that the ID returned is unique
		/// <summary>
		/// Overrides Base GetIdValue - Used internally by CSLA to determine equality
		/// </summary>
		/// <returns>A Unique ID for the current Shipper</returns>
		protected override object GetIdValue()
		{
			return _ShipperID;
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
				if (_ShipperOrders != null && (hasBrokenRules = _ShipperOrders.HasBrokenRules) != null) return hasBrokenRules;
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
				Csla.Validation.CommonRules.StringRequired, "CompanyName");
			ValidationRules.AddRule(
				Csla.Validation.CommonRules.StringMaxLength,
				new Csla.Validation.CommonRules.MaxLengthRuleArgs("CompanyName", 40));
			ValidationRules.AddRule(
				Csla.Validation.CommonRules.StringMaxLength,
				new Csla.Validation.CommonRules.MaxLengthRuleArgs("Phone", 24));
			//ValidationRules.AddDependantProperty("x", "y");
			_ShipperExtension.AddValidationRules(ValidationRules);
			// TODO:  Add other validation rules
		}
		protected override void AddInstanceBusinessRules()
		{
			_ShipperExtension.AddInstanceValidationRules(ValidationRules);
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
			//AuthorizationRules.AllowRead(ShipperID, "<Role(s)>");
			//AuthorizationRules.AllowRead(CompanyName, "<Role(s)>");
			//AuthorizationRules.AllowRead(Phone, "<Role(s)>");
			//AuthorizationRules.AllowWrite(CompanyName, "<Role(s)>");
			//AuthorizationRules.AllowWrite(Phone, "<Role(s)>");
			_ShipperExtension.AddAuthorizationRules(AuthorizationRules);
		}
		protected override void AddInstanceAuthorizationRules()
		{
			//TODO: Who can read/write which fields
			_ShipperExtension.AddInstanceAuthorizationRules(AuthorizationRules);
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
		protected Shipper()
		{/* require use of factory methods */
			_AllList.Add(this);
		}
		public void Dispose()
		{
			_AllList.Remove(this);
			_AllByPrimaryKey.Remove(ShipperID.ToString());
		}
		public static Shipper New()
		{
			if (!CanAddObject())
				throw new System.Security.SecurityException("User not authorized to add a Shipper");
			try
			{
				return DataPortal.Create<Shipper>();
			}
			catch (Exception ex)
			{
				throw new DbCslaException("Error on Shipper.New", ex);
			}
		}
		public static Shipper New(string companyName)
		{
			Shipper tmp = Shipper.New();
			tmp.CompanyName = companyName;
			return tmp;
		}
		public static Shipper New(string companyName, string phone)
		{
			Shipper tmp = Shipper.New();
			tmp.CompanyName = companyName;
			tmp.Phone = phone;
			return tmp;
		}
		public static Shipper MakeShipper(string companyName, string phone)
		{
			Shipper tmp = Shipper.New(companyName, phone);
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
		public static Shipper Get(int shipperID)
		{
			if (!CanGetObject())
				throw new System.Security.SecurityException("User not authorized to view a Shipper");
			try
			{
				Shipper tmp = GetExistingByPrimaryKey(shipperID);
				if (tmp == null)
				{
					tmp = DataPortal.Fetch<Shipper>(new PKCriteria(shipperID));
					_AllList.Add(tmp);
				}
				if (tmp.ErrorMessage == "No Record Found") tmp = null;
				return tmp;
			}
			catch (Exception ex)
			{
				throw new DbCslaException("Error on Shipper.Get", ex);
			}
		}
		public static Shipper Get(SafeDataReader dr)
		{
			if (dr.Read()) return new Shipper(dr);
			return null;
		}
		internal Shipper(SafeDataReader dr)
		{
			ReadData(dr);
		}
		public static void Delete(int shipperID)
		{
			if (!CanDeleteObject())
				throw new System.Security.SecurityException("User not authorized to remove a Shipper");
			try
			{
				DataPortal.Delete(new PKCriteria(shipperID));
			}
			catch (Exception ex)
			{
				throw new DbCslaException("Error on Shipper.Delete", ex);
			}
		}
		public override Shipper Save()
		{
			if (IsDeleted && !CanDeleteObject())
				throw new System.Security.SecurityException("User not authorized to remove a Shipper");
			else if (IsNew && !CanAddObject())
				throw new System.Security.SecurityException("User not authorized to add a Shipper");
			else if (!CanEditObject())
				throw new System.Security.SecurityException("User not authorized to update a Shipper");
			try
			{
				BuildRefreshList();
				Shipper shipper = base.Save();
				_AllList.Add(shipper);//Refresh the item in AllList
				ProcessRefreshList();
				return shipper;
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
			private int _ShipperID;
			public int ShipperID
			{ get { return _ShipperID; } }
			public PKCriteria(int shipperID)
			{
				_ShipperID = shipperID;
			}
		}
		// TODO: If Create needs to access DB - It should not be marked RunLocal
		[RunLocal()]
		private new void DataPortal_Create()
		{
			_ShipperID = NextShipperID;
			// Database Defaults

			// TODO: Add any defaults that are necessary
			ValidationRules.CheckRules();
		}
		private void ReadData(SafeDataReader dr)
		{
			Database.LogInfo("Shipper.ReadData", GetHashCode());
			try
			{
				_ShipperID = dr.GetInt32("ShipperID");
				_CompanyName = dr.GetString("CompanyName");
				_Phone = dr.GetString("Phone");
				_ShipperOrderCount = dr.GetInt32("OrderCount");
				MarkOld();
			}
			catch (Exception ex)
			{
				Database.LogException("Shipper.ReadData", ex);
				_ErrorMessage = ex.Message;
				throw new DbCslaException("Shipper.ReadData", ex);
			}
		}
		private void DataPortal_Fetch(PKCriteria criteria)
		{
			Database.LogInfo("Shipper.DataPortal_Fetch", GetHashCode());
			try
			{
				using (SqlConnection cn = Database.Northwind_SqlConnection)
				{
					ApplicationContext.LocalContext["cn"] = cn;
					using (SqlCommand cm = cn.CreateCommand())
					{
						cm.CommandType = CommandType.StoredProcedure;
						cm.CommandText = "getShipper";
						cm.Parameters.AddWithValue("@ShipperID", criteria.ShipperID);
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
							_ShipperOrders = ShipperOrders.Get(dr);
						}
					}
					// removing of item only needed for local data portal
					if (ApplicationContext.ExecutionLocation == ApplicationContext.ExecutionLocations.Client)
						ApplicationContext.LocalContext.Remove("cn");
				}
			}
			catch (Exception ex)
			{
				Database.LogException("Shipper.DataPortal_Fetch", ex);
				_ErrorMessage = ex.Message;
				throw new DbCslaException("Shipper.DataPortal_Fetch", ex);
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
				Database.LogException("Shipper.DataPortal_Insert", ex);
				_ErrorMessage = ex.Message;
				throw new DbCslaException("Shipper.DataPortal_Insert", ex);
			}
			finally
			{
				Database.LogInfo("Shipper.DataPortal_Insert", GetHashCode());
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
					cm.CommandText = "addShipper";
					// Input All Fields - Except Calculated Columns
					cm.Parameters.AddWithValue("@CompanyName", _CompanyName);
					cm.Parameters.AddWithValue("@Phone", _Phone);
					// Output Calculated Columns
					SqlParameter param_ShipperID = new SqlParameter("@newShipperID", SqlDbType.Int);
					param_ShipperID.Direction = ParameterDirection.Output;
					cm.Parameters.Add(param_ShipperID);
					// TODO: Define any additional output parameters
					cm.ExecuteNonQuery();
					// Save all values being returned from the Procedure
					_ShipperID = (int)cm.Parameters["@newShipperID"].Value;
				}
				MarkOld();
				// update child objects
				if (_ShipperOrders != null) _ShipperOrders.Update(this);
				Database.LogInfo("Shipper.SQLInsert", GetHashCode());
			}
			catch (Exception ex)
			{
				Database.LogException("Shipper.SQLInsert", ex);
				_ErrorMessage = ex.Message;
				throw new DbCslaException("Shipper.SQLInsert", ex);
			}
		}
		[Transactional(TransactionalTypes.TransactionScope)]
		public static void Add(SqlConnection cn, ref int shipperID, string companyName, string phone)
		{
			Database.LogInfo("Shipper.Add", 0);
			try
			{
				using (SqlCommand cm = cn.CreateCommand())
				{
					cm.CommandType = CommandType.StoredProcedure;
					cm.CommandText = "addShipper";
					// Input All Fields - Except Calculated Columns
					cm.Parameters.AddWithValue("@CompanyName", companyName);
					cm.Parameters.AddWithValue("@Phone", phone);
					// Output Calculated Columns
					SqlParameter param_ShipperID = new SqlParameter("@newShipperID", SqlDbType.Int);
					param_ShipperID.Direction = ParameterDirection.Output;
					cm.Parameters.Add(param_ShipperID);
					// TODO: Define any additional output parameters
					cm.ExecuteNonQuery();
					// Save all values being returned from the Procedure
					shipperID = (int)cm.Parameters["@newShipperID"].Value;
			// No Timestamp value to return
				}
			}
			catch (Exception ex)
			{
				Database.LogException("Shipper.Add", ex);
				throw new DbCslaException("Shipper.Add", ex);
			}
		}
		[Transactional(TransactionalTypes.TransactionScope)]
		protected override void DataPortal_Update()
		{
			if (!IsDirty) return;	// If not dirty - nothing to do
			Database.LogInfo("Shipper.DataPortal_Update", GetHashCode());
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
				Database.LogException("Shipper.DataPortal_Update", ex);
				_ErrorMessage = ex.Message;
				if (!ex.Message.EndsWith("has been edited by another user.")) throw ex;
			}
		}
		[Transactional(TransactionalTypes.TransactionScope)]
		internal void SQLUpdate()
		{
			if (!IsDirty) return;	// If not dirty - nothing to do
			Database.LogInfo("Shipper.SQLUpdate", GetHashCode());
			try
			{
				SqlConnection cn = (SqlConnection)ApplicationContext.LocalContext["cn"];
				if (base.IsDirty)
				{
					using (SqlCommand cm = cn.CreateCommand())
					{
						cm.CommandType = CommandType.StoredProcedure;
						cm.CommandText = "updateShipper";
						// All Fields including Calculated Fields
						cm.Parameters.AddWithValue("@ShipperID", _ShipperID);
						cm.Parameters.AddWithValue("@CompanyName", _CompanyName);
						cm.Parameters.AddWithValue("@Phone", _Phone);
						// Output Calculated Columns
						// TODO: Define any additional output parameters
						cm.ExecuteNonQuery();
						// Save all values being returned from the Procedure
					}
				}
				MarkOld();
				// use the open connection to update child objects
				if (_ShipperOrders != null) _ShipperOrders.Update(this);
			}
			catch (Exception ex)
			{
				Database.LogException("Shipper.SQLUpdate", ex);
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
					Shipper.Add(cn, ref _ShipperID, _CompanyName, _Phone);
				else
					Shipper.Update(cn, ref _ShipperID, _CompanyName, _Phone);
				MarkOld();
			}
			if (_ShipperOrders != null) _ShipperOrders.Update(this);
		}
		[Transactional(TransactionalTypes.TransactionScope)]
		public static void Update(SqlConnection cn, ref int shipperID, string companyName, string phone)
		{
			Database.LogInfo("Shipper.Update", 0);
			try
			{
				using (SqlCommand cm = cn.CreateCommand())
				{
					cm.CommandType = CommandType.StoredProcedure;
					cm.CommandText = "updateShipper";
					// Input All Fields - Except Calculated Columns
					cm.Parameters.AddWithValue("@ShipperID", shipperID);
					cm.Parameters.AddWithValue("@CompanyName", companyName);
					cm.Parameters.AddWithValue("@Phone", phone);
					// Output Calculated Columns
					// TODO: Define any additional output parameters
					cm.ExecuteNonQuery();
					// Save all values being returned from the Procedure
				// No Timestamp value to return
				}
			}
			catch (Exception ex)
			{
				Database.LogException("Shipper.Update", ex);
				throw new DbCslaException("Shipper.Update", ex);
			}
		}
		[Transactional(TransactionalTypes.TransactionScope)]
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new PKCriteria(_ShipperID));
		}
		[Transactional(TransactionalTypes.TransactionScope)]
		private void DataPortal_Delete(PKCriteria criteria)
		{
			Database.LogInfo("Shipper.DataPortal_Delete", GetHashCode());
			try
			{
				using (SqlConnection cn = Database.Northwind_SqlConnection)
				{
					using (SqlCommand cm = cn.CreateCommand())
					{
						cm.CommandType = CommandType.StoredProcedure;
						cm.CommandText = "deleteShipper";
						cm.Parameters.AddWithValue("@ShipperID", criteria.ShipperID);
						cm.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{
				Database.LogException("Shipper.DataPortal_Delete", ex);
				_ErrorMessage = ex.Message;
				throw new DbCslaException("Shipper.DataPortal_Delete", ex);
			}
		}
		[Transactional(TransactionalTypes.TransactionScope)]
		public static void Remove(SqlConnection cn, int shipperID)
		{
			Database.LogInfo("Shipper.Remove", 0);
			try
			{
				using (SqlCommand cm = cn.CreateCommand())
				{
					cm.CommandType = CommandType.StoredProcedure;
					cm.CommandText = "deleteShipper";
					// Input PK Fields
					cm.Parameters.AddWithValue("@ShipperID", shipperID);
					// TODO: Define any additional output parameters
					cm.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				Database.LogException("Shipper.Remove", ex);
				throw new DbCslaException("Shipper.Remove", ex);
			}
		}
		#endregion
		#region Exists
		public static bool Exists(int shipperID)
		{
			ExistsCommand result;
			try
			{
				result = DataPortal.Execute<ExistsCommand>(new ExistsCommand(shipperID));
				return result.Exists;
			}
			catch (Exception ex)
			{
				throw new DbCslaException("Error on Shipper.Exists", ex);
			}
		}
		[Serializable()]
		private class ExistsCommand : CommandBase
		{
			private int _ShipperID;
			private bool _exists;
			public bool Exists
			{
				get { return _exists; }
			}
			public ExistsCommand(int shipperID)
			{
				_ShipperID = shipperID;
			}
			protected override void DataPortal_Execute()
			{
				Database.LogInfo("Shipper.DataPortal_Execute", GetHashCode());
				try
				{
					using (SqlConnection cn = Database.Northwind_SqlConnection)
					{
						cn.Open();
						using (SqlCommand cm = cn.CreateCommand())
						{
							cm.CommandType = CommandType.StoredProcedure;
							cm.CommandText = "existsShipper";
							cm.Parameters.AddWithValue("@ShipperID", _ShipperID);
							int count = (int)cm.ExecuteScalar();
							_exists = (count > 0);
						}
					}
				}
				catch (Exception ex)
				{
					Database.LogException("Shipper.DataPortal_Execute", ex);
					throw new DbCslaException("Shipper.DataPortal_Execute", ex);
				}
			}
		}
		#endregion
		// Standard Default Code
		#region extension
		ShipperExtension _ShipperExtension = new ShipperExtension();
		[Serializable()]
		partial class ShipperExtension : extensionBase
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
	internal class ShipperConverter : ExpandableObjectConverter
	{
		public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destType)
		{
			if (destType == typeof(string) && value is Shipper)
			{
				// Return the ToString value
				return ((Shipper)value).ToString();
			}
			return base.ConvertTo(context, culture, value, destType);
		}
	}
	#endregion
} // Namespace


//// The following is a sample Extension File.  You can use it to create ShipperExt.cs
//using System;
//using System.Collections.Generic;
//using System.Text;
//using Csla;

//namespace Northwind.CSLA.Library
//{
//  public partial class Shipper
//  {
//    partial class ShipperExtension : extensionBase
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