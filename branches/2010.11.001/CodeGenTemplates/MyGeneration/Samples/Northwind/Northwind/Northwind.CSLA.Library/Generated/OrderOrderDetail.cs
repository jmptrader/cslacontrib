
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
	///	OrderOrderDetail Generated by MyGeneration using the CSLA Object Mapping template
	/// </summary>
	[Serializable()]
	[TypeConverter(typeof(OrderOrderDetailConverter))]
	public partial class OrderOrderDetail : BusinessBase<OrderOrderDetail>, IVEHasBrokenRules
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
		private decimal _UnitPrice;
		public decimal UnitPrice
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
		private Int16 _Quantity;
		public Int16 Quantity
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _Quantity;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				CanWriteProperty(true);
				if (_Quantity != value)
				{
					_Quantity = value;
					PropertyHasChanged();
				}
			}
		}
		private float _Discount;
		public float Discount
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _Discount;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				CanWriteProperty(true);
				if (_Discount != value)
				{
					_Discount = value;
					PropertyHasChanged();
				}
			}
		}
		private string _Product_ProductName = string.Empty;
		public string Product_ProductName
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _Product_ProductName;
			}
		}
		private int? _Product_SupplierID;
		public int? Product_SupplierID
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _Product_SupplierID;
			}
		}
		private int? _Product_CategoryID;
		public int? Product_CategoryID
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _Product_CategoryID;
			}
		}
		private string _Product_QuantityPerUnit = string.Empty;
		public string Product_QuantityPerUnit
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _Product_QuantityPerUnit;
			}
		}
		private decimal? _Product_UnitPrice;
		public decimal? Product_UnitPrice
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _Product_UnitPrice;
			}
		}
		private Int16? _Product_UnitsInStock;
		public Int16? Product_UnitsInStock
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _Product_UnitsInStock;
			}
		}
		private Int16? _Product_UnitsOnOrder;
		public Int16? Product_UnitsOnOrder
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _Product_UnitsOnOrder;
			}
		}
		private Int16? _Product_ReorderLevel;
		public Int16? Product_ReorderLevel
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _Product_ReorderLevel;
			}
		}
		private bool _Product_Discontinued;
		public bool Product_Discontinued
		{
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				CanReadProperty(true);
				return _Product_Discontinued;
			}
		}
		// TODO: Check OrderOrderDetail.GetIdValue to assure that the ID returned is unique
		/// <summary>
		/// Overrides Base GetIdValue - Used internally by CSLA to determine equality
		/// </summary>
		/// <returns>A Unique ID for the current OrderOrderDetail</returns>
		protected override object GetIdValue()
		{
			return _ProductID;
		}
		// TODO: Replace base OrderOrderDetail.ToString function as necessary
		/// <summary>
		/// Overrides Base ToString
		/// </summary>
		/// <returns>A string representation of current OrderOrderDetail</returns>
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
			//AuthorizationRules.AllowRead(UnitPrice, "<Role(s)>");
			//AuthorizationRules.AllowWrite(UnitPrice, "<Role(s)>");
			//AuthorizationRules.AllowRead(Quantity, "<Role(s)>");
			//AuthorizationRules.AllowWrite(Quantity, "<Role(s)>");
			//AuthorizationRules.AllowRead(Discount, "<Role(s)>");
			//AuthorizationRules.AllowWrite(Discount, "<Role(s)>");
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
		internal static OrderOrderDetail New(Product myProduct)
		{
			return new OrderOrderDetail(myProduct);
		}
		internal static OrderOrderDetail Get(SafeDataReader dr)
		{
			return new OrderOrderDetail(dr);
		}
		public OrderOrderDetail()
		{
			MarkAsChild();

			_UnitPrice = _OrderOrderDetailExtension.DefaultUnitPrice;
			_Quantity = _OrderOrderDetailExtension.DefaultQuantity;
			_Discount = _OrderOrderDetailExtension.DefaultDiscount;
			ValidationRules.CheckRules();
		}
		private OrderOrderDetail(Product myProduct)
		{
			MarkAsChild();
			// TODO: Add any initialization & defaults
			_UnitPrice = _OrderOrderDetailExtension.DefaultUnitPrice;
			_Quantity = _OrderOrderDetailExtension.DefaultQuantity;
			_Discount = _OrderOrderDetailExtension.DefaultDiscount;
			_MyProduct  = myProduct;
			ValidationRules.CheckRules();
		}
		internal OrderOrderDetail(SafeDataReader dr)
		{
			MarkAsChild();
			Fetch(dr);
		}
		#endregion
		#region Data Access Portal
		private void Fetch(SafeDataReader dr)
		{
			Database.LogInfo("OrderOrderDetail.FetchDR", GetHashCode());
			try
			{
				_ProductID = dr.GetInt32("ProductID");
				_UnitPrice = dr.GetDecimal("UnitPrice");
				_Quantity = dr.GetInt16("Quantity");
				_Discount = dr.GetFloat("Discount");
				_Product_ProductName = dr.GetString("Product_ProductName");
				_Product_SupplierID = (int?)dr.GetValue("Product_SupplierID");
				_Product_CategoryID = (int?)dr.GetValue("Product_CategoryID");
				_Product_QuantityPerUnit = dr.GetString("Product_QuantityPerUnit");
				_Product_UnitPrice = (decimal?)dr.GetValue("Product_UnitPrice");
				_Product_UnitsInStock = (Int16?)dr.GetValue("Product_UnitsInStock");
				_Product_UnitsOnOrder = (Int16?)dr.GetValue("Product_UnitsOnOrder");
				_Product_ReorderLevel = (Int16?)dr.GetValue("Product_ReorderLevel");
				_Product_Discontinued = dr.GetBoolean("Product_Discontinued");
			}
			catch (Exception ex) // FKItem Fetch
			{
				Database.LogException("OrderOrderDetail.FetchDR", ex);
				throw new DbCslaException("OrderOrderDetail.Fetch", ex);
			}
			MarkOld();
		}
		internal void Insert(Order myOrder)
		{
			// if we're not dirty then don't update the database
			if (!this.IsDirty) return;
			SqlConnection cn = (SqlConnection)ApplicationContext.LocalContext["cn"];
			OrderDetail.Add(cn, myOrder, _MyProduct, _UnitPrice, _Quantity, _Discount);
			MarkOld();
		}
		internal void Update(Order myOrder)
		{
			// if we're not dirty then don't update the database
			if (!this.IsDirty) return;
			SqlConnection cn = (SqlConnection)ApplicationContext.LocalContext["cn"];
			OrderDetail.Update(cn, myOrder, _MyProduct, _UnitPrice, _Quantity, _Discount);
			MarkOld();
		}
		internal void DeleteSelf(Order myOrder)
		{
			// if we're not dirty then don't update the database
			if (!this.IsDirty) return;
			// if we're new then don't update the database
			if (this.IsNew) return;
			SqlConnection cn = (SqlConnection)ApplicationContext.LocalContext["cn"];
			OrderDetail.Remove(cn, myOrder.OrderID, _ProductID);
			MarkNew();
		}
		#endregion
		// Standard Default Code
		#region extension
		OrderOrderDetailExtension _OrderOrderDetailExtension = new OrderOrderDetailExtension();
		[Serializable()]
		partial class OrderOrderDetailExtension : extensionBase
		{
		}
		[Serializable()]
		class extensionBase
		{
			// Default Values
			public virtual decimal DefaultUnitPrice
			{
				get { return 0; }
			}
			public virtual Int16 DefaultQuantity
			{
				get { return 1; }
			}
			public virtual float DefaultDiscount
			{
				get { return 0; }
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
	internal class OrderOrderDetailConverter : ExpandableObjectConverter
	{
		public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destType)
		{
			if (destType == typeof(string) && value is OrderOrderDetail)
			{
				// Return the ToString value
				return ((OrderOrderDetail)value).ToString();
			}
			return base.ConvertTo(context, culture, value, destType);
		}
	}
	#endregion
} // Namespace


//// The following is a sample Extension File.  You can use it to create OrderOrderDetailExt.cs
//using System;
//using System.Collections.Generic;
//using System.Text;
//using Csla;

//namespace Northwind.CSLA.Library
//{
//  public partial class OrderOrderDetail
//  {
//    partial class OrderOrderDetailExtension : extensionBase
//    {
//      // TODO: Override automatic defaults
//      public virtual decimal DefaultUnitPrice
//      {
//        get { return 0; }
//      }
//      public virtual Int16 DefaultQuantity
//      {
//        get { return 1; }
//      }
//      public virtual float DefaultDiscount
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
