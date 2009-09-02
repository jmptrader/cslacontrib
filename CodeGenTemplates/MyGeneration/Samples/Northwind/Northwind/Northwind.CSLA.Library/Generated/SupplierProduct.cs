
using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using System.Configuration;
using System.IO;
using System.ComponentModel;
using Csla.Validation;
namespace Northwind.CSLA.Library
{
	/// <summary>
	///	SupplierProduct Generated by MyGeneration using the CSLA Object Mapping template
	/// </summary>
	[Serializable()]
	[TypeConverter(typeof(SupplierProductConverter))]
	public partial class SupplierProduct : BusinessBase<SupplierProduct>, IVEHasBrokenRules
	{
		#region Business Methods
		private string _ErrorMessage = string.Empty;
		public string ErrorMessage
		{
			get { return _ErrorMessage; }
		}
		private int _ProductID;
		[System.ComponentModel.DataObjectField(true, true)]
		public int ProductID
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				if (_MyProduct != null) _ProductID = _MyProduct.ProductID;
				return _ProductID;
			}
		}
		private Product _MyProduct;
		[System.ComponentModel.DataObjectField(true, true)]
		public Product MyProduct
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				if (_MyProduct == null && _ProductID != 0) _MyProduct = Product.Get(_ProductID);
				return _MyProduct;
			}
		}
		private string _ProductName = string.Empty;
		public string ProductName
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _ProductName;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				CanWriteProperty(true);
				if (value == null) value = string.Empty;
				if (_ProductName != value)
				{
					_ProductName = value;
					PropertyHasChanged();
				}
			}
		}
		private int? _CategoryID;
		public int? CategoryID
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				if (_MyCategory != null) _CategoryID = _MyCategory.CategoryID;
				return _CategoryID;
			}
		}
		private Category _MyCategory;
		public Category MyCategory
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				if (_MyCategory == null && _CategoryID != null) _MyCategory = Category.Get((int)_CategoryID);
				return _MyCategory;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				CanWriteProperty(true);
				if (_MyCategory != value)
				{
					_MyCategory = value;
					_CategoryID = (value == null ? null : (int?) value.CategoryID);
					PropertyHasChanged();
				}
			}
		}
		private string _QuantityPerUnit = string.Empty;
		public string QuantityPerUnit
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _QuantityPerUnit;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				CanWriteProperty(true);
				if (value == null) value = string.Empty;
				if (_QuantityPerUnit != value)
				{
					_QuantityPerUnit = value;
					PropertyHasChanged();
				}
			}
		}
		private decimal? _UnitPrice;
		public decimal? UnitPrice
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _UnitPrice;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				CanWriteProperty(true);
				if (_UnitPrice != value)
				{
					_UnitPrice = value;
					PropertyHasChanged();
				}
			}
		}
		private Int16? _UnitsInStock;
		public Int16? UnitsInStock
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _UnitsInStock;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				CanWriteProperty(true);
				if (_UnitsInStock != value)
				{
					_UnitsInStock = value;
					PropertyHasChanged();
				}
			}
		}
		private Int16? _UnitsOnOrder;
		public Int16? UnitsOnOrder
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _UnitsOnOrder;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				CanWriteProperty(true);
				if (_UnitsOnOrder != value)
				{
					_UnitsOnOrder = value;
					PropertyHasChanged();
				}
			}
		}
		private Int16? _ReorderLevel;
		public Int16? ReorderLevel
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _ReorderLevel;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				CanWriteProperty(true);
				if (_ReorderLevel != value)
				{
					_ReorderLevel = value;
					PropertyHasChanged();
				}
			}
		}
		private bool _Discontinued;
		public bool Discontinued
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _Discontinued;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				CanWriteProperty(true);
				if (_Discontinued != value)
				{
					_Discontinued = value;
					PropertyHasChanged();
				}
			}
		}
		// TODO: Check SupplierProduct.GetIdValue to assure that the ID returned is unique
		/// <summary>
		/// Overrides Base GetIdValue - Used internally by CSLA to determine equality
		/// </summary>
		/// <returns>A Unique ID for the current SupplierProduct</returns>
		protected override object GetIdValue()
		{
			return _ProductID;
		}
		// TODO: Replace base SupplierProduct.ToString function as necessary
		/// <summary>
		/// Overrides Base ToString
		/// </summary>
		/// <returns>A string representation of current SupplierProduct</returns>
		//public override string ToString()
		//{
		//  return base.ToString();
		//}
		#endregion
		#region ValidationRules
		[NonSerialized]
		private bool _CheckingBrokenRules=false;
		public IVEHasBrokenRules HasBrokenRules
		{
			get
			{
				if(_CheckingBrokenRules)return null;
				if (BrokenRulesCollection.Count > 0) return this;
				try
				{
					_CheckingBrokenRules=true;
				 IVEHasBrokenRules hasBrokenRules = null;
				if (_MyCategory != null && (hasBrokenRules = _MyCategory.HasBrokenRules) != null) return hasBrokenRules;
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
				Csla.Validation.CommonRules.StringRequired, "ProductName");
			ValidationRules.AddRule(
				Csla.Validation.CommonRules.StringMaxLength,
				new Csla.Validation.CommonRules.MaxLengthRuleArgs("ProductName", 40));
			ValidationRules.AddRule(
				Csla.Validation.CommonRules.StringMaxLength,
				new Csla.Validation.CommonRules.MaxLengthRuleArgs("QuantityPerUnit", 20));
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
			//AuthorizationRules.AllowRead(ProductID, "<Role(s)>");
			//AuthorizationRules.AllowRead(ProductName, "<Role(s)>");
			//AuthorizationRules.AllowWrite(ProductName, "<Role(s)>");
			//AuthorizationRules.AllowRead(CategoryID, "<Role(s)>");
			//AuthorizationRules.AllowWrite(CategoryID, "<Role(s)>");
			//AuthorizationRules.AllowRead(QuantityPerUnit, "<Role(s)>");
			//AuthorizationRules.AllowWrite(QuantityPerUnit, "<Role(s)>");
			//AuthorizationRules.AllowRead(UnitPrice, "<Role(s)>");
			//AuthorizationRules.AllowWrite(UnitPrice, "<Role(s)>");
			//AuthorizationRules.AllowRead(UnitsInStock, "<Role(s)>");
			//AuthorizationRules.AllowWrite(UnitsInStock, "<Role(s)>");
			//AuthorizationRules.AllowRead(UnitsOnOrder, "<Role(s)>");
			//AuthorizationRules.AllowWrite(UnitsOnOrder, "<Role(s)>");
			//AuthorizationRules.AllowRead(ReorderLevel, "<Role(s)>");
			//AuthorizationRules.AllowWrite(ReorderLevel, "<Role(s)>");
			//AuthorizationRules.AllowRead(Discontinued, "<Role(s)>");
			//AuthorizationRules.AllowWrite(Discontinued, "<Role(s)>");
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
		internal static SupplierProduct New(string productName)
		{
			return new SupplierProduct(productName);
		}
		internal static SupplierProduct Get(SafeDataReader dr)
		{
			return new SupplierProduct(dr);
		}
		public SupplierProduct()
		{
			MarkAsChild();
			_ProductID = Product.NextProductID;
			_UnitPrice = _SupplierProductExtension.DefaultUnitPrice;
			_UnitsInStock = _SupplierProductExtension.DefaultUnitsInStock;
			_UnitsOnOrder = _SupplierProductExtension.DefaultUnitsOnOrder;
			_ReorderLevel = _SupplierProductExtension.DefaultReorderLevel;
			_Discontinued = _SupplierProductExtension.DefaultDiscontinued;
			ValidationRules.CheckRules();
		}
		private SupplierProduct(string productName)
		{
			MarkAsChild();
			// TODO: Add any initialization & defaults
			_UnitPrice = _SupplierProductExtension.DefaultUnitPrice;
			_UnitsInStock = _SupplierProductExtension.DefaultUnitsInStock;
			_UnitsOnOrder = _SupplierProductExtension.DefaultUnitsOnOrder;
			_ReorderLevel = _SupplierProductExtension.DefaultReorderLevel;
			_Discontinued = _SupplierProductExtension.DefaultDiscontinued;
			_ProductName  = productName;
			ValidationRules.CheckRules();
		}
		internal SupplierProduct(SafeDataReader dr)
		{
			MarkAsChild();
			Fetch(dr);
		}
		#endregion
		#region Data Access Portal
		private void Fetch(SafeDataReader dr)
		{
			Database.LogInfo("SupplierProduct.FetchDR", GetHashCode());
			try
			{
				_ProductID = dr.GetInt32("ProductID");
				_ProductName = dr.GetString("ProductName");
				_CategoryID = (int?)dr.GetValue("CategoryID");
				_QuantityPerUnit = dr.GetString("QuantityPerUnit");
				_UnitPrice = (decimal?)dr.GetValue("UnitPrice");
				_UnitsInStock = (Int16?)dr.GetValue("UnitsInStock");
				_UnitsOnOrder = (Int16?)dr.GetValue("UnitsOnOrder");
				_ReorderLevel = (Int16?)dr.GetValue("ReorderLevel");
				_Discontinued = dr.GetBoolean("Discontinued");
			}
			catch (Exception ex) // FKItem Fetch
			{
				Database.LogException("SupplierProduct.FetchDR", ex);
				throw new DbCslaException("SupplierProduct.Fetch", ex);
			}
			MarkOld();
		}
		internal void Insert(Supplier mySupplier)
		{
			// if we're not dirty then don't update the database
			if (!this.IsDirty) return;
			SqlConnection cn = (SqlConnection)ApplicationContext.LocalContext["cn"];
			Product.Add(cn, ref _ProductID, _ProductName, mySupplier, _MyCategory, _QuantityPerUnit, _UnitPrice, _UnitsInStock, _UnitsOnOrder, _ReorderLevel, _Discontinued);
			MarkOld();
		}
		internal void Update(Supplier mySupplier)
		{
			// if we're not dirty then don't update the database
			if (!this.IsDirty) return;
			SqlConnection cn = (SqlConnection)ApplicationContext.LocalContext["cn"];
			Product.Update(cn, ref _ProductID, _ProductName, mySupplier, _MyCategory, _QuantityPerUnit, _UnitPrice, _UnitsInStock, _UnitsOnOrder, _ReorderLevel, _Discontinued);
			MarkOld();
		}
		internal void DeleteSelf(Supplier mySupplier)
		{
			// if we're not dirty then don't update the database
			if (!this.IsDirty) return;
			// if we're new then don't update the database
			if (this.IsNew) return;
			SqlConnection cn = (SqlConnection)ApplicationContext.LocalContext["cn"];
			Product.Remove(cn, _ProductID);
			MarkNew();
		}
		#endregion
		// Standard Default Code
		#region extension
		SupplierProductExtension _SupplierProductExtension = new SupplierProductExtension();
		[Serializable()]
		partial class SupplierProductExtension : extensionBase
		{
		}
		[Serializable()]
		class extensionBase
		{
			// Default Values
			public virtual decimal? DefaultUnitPrice
			{
				get { return 0; }
			}
			public virtual Int16? DefaultUnitsInStock
			{
				get { return 0; }
			}
			public virtual Int16? DefaultUnitsOnOrder
			{
				get { return 0; }
			}
			public virtual Int16? DefaultReorderLevel
			{
				get { return 0; }
			}
			public virtual bool DefaultDiscontinued
			{
				get { return Convert.ToBoolean(0); }
			}
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
	internal class SupplierProductConverter : ExpandableObjectConverter
	{
		public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destType)
		{
			if (destType == typeof(string) && value is SupplierProduct)
			{
				// Return the ToString value
				return ((SupplierProduct)value).ToString();
			}
			return base.ConvertTo(context, culture, value, destType);
		}
	}
	#endregion
} // Namespace


//// The following is a sample Extension File.  You can use it to create SupplierProductExt.cs
//using System;
//using System.Collections.Generic;
//using System.Text;
//using Csla;

//namespace Northwind.CSLA.Library
//{
//  public partial class SupplierProduct
//  {
//    partial class SupplierProductExtension : extensionBase
//    {
//      // TODO: Override automatic defaults
//      public virtual decimal? DefaultUnitPrice
//      {
//        get { return 0; }
//      }
//      public virtual Int16? DefaultUnitsInStock
//      {
//        get { return 0; }
//      }
//      public virtual Int16? DefaultUnitsOnOrder
//      {
//        get { return 0; }
//      }
//      public virtual Int16? DefaultReorderLevel
//      {
//        get { return 0; }
//      }
//      public virtual bool DefaultDiscontinued
//      {
//        get { return 0; }
//      }
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