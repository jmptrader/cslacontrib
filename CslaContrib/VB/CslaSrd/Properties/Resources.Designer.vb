'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
	Imports System
Namespace My


	''' <summary>
	'''   A strongly-typed resource class, for looking up localized strings, etc.
	''' </summary>
	' This class was auto-generated by the StronglyTypedResourceBuilder
	' class via a tool like ResGen or Visual Studio.
	' To add or remove a member, edit your .ResX file then rerun ResGen
	' with the /str option, or rebuild your VS project.
	<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()> _
	Friend Class Resources

		Private Shared resourceMan As Global.System.Resources.ResourceManager

		Private Shared resourceCulture As Global.System.Globalization.CultureInfo

		<Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")> _
		Friend Sub New()
		End Sub

		''' <summary>
		'''   Returns the cached ResourceManager instance used by this class.
		''' </summary>
		<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
		Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
			Get
				If Object.ReferenceEquals(resourceMan, Nothing) Then
					Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("CslaSrd.Properties.Resources", GetType(Resources).Assembly)
					resourceMan = temp
				End If
				Return resourceMan
			End Get
		End Property

		''' <summary>
		'''   Overrides the current thread's CurrentUICulture property for all
		'''   resource lookups using this strongly typed resource class.
		''' </summary>
		<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
		Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
			Get
				Return resourceCulture
			End Get
			Set
				resourceCulture = Value
			End Set
		End Property

		''' <summary>
		'''   Looks up a localized string similar to {ruleProperty} can not exceed {maxValue}..
		''' </summary>
		Friend Shared ReadOnly Property ruleIntegerMaxValue() As String
			Get
				Return ResourceManager.GetString("ruleIntegerMaxValue", resourceCulture)
			End Get
		End Property

		''' <summary>
		'''   Looks up a localized string similar to {ruleProperty} can not be less than {minValue}..
		''' </summary>
		Friend Shared ReadOnly Property ruleIntegerMinValue() As String
			Get
				Return ResourceManager.GetString("ruleIntegerMinValue", resourceCulture)
			End Get
		End Property

		''' <summary>
		'''   Looks up a localized string similar to {ruleProperty} must be unique..
		''' </summary>
		Friend Shared ReadOnly Property ruleNoDuplicates() As String
			Get
				Return ResourceManager.GetString("ruleNoDuplicates", resourceCulture)
			End Get
		End Property

		''' <summary>
		'''   Looks up a localized string similar to {ruleProperty} can not exceed {maxLength} characters..
		''' </summary>
		Friend Shared ReadOnly Property ruleStringMaxLength() As String
			Get
				Return ResourceManager.GetString("ruleStringMaxLength", resourceCulture)
			End Get
		End Property

		''' <summary>
		'''   Looks up a localized string similar to {ruleProperty} is required..
		''' </summary>
		Friend Shared ReadOnly Property ruleStringRequired() As String
			Get
				Return ResourceManager.GetString("ruleStringRequired", resourceCulture)
			End Get
		End Property

		''' <summary>
		'''   Looks up a localized string similar to String value can not be converted to a Boolean.
		''' </summary>
		Friend Shared ReadOnly Property StringToBoolException() As String
			Get
				Return ResourceManager.GetString("StringToBoolException", resourceCulture)
			End Get
		End Property

		''' <summary>
		'''   Looks up a localized string similar to String value can not be converted to a float.
		''' </summary>
		Friend Shared ReadOnly Property StringToFloatException() As String
			Get
				Return ResourceManager.GetString("StringToFloatException", resourceCulture)
			End Get
		End Property

		''' <summary>
		'''   Looks up a localized string similar to String value can not be converted to an Int16.
		''' </summary>
		Friend Shared ReadOnly Property StringToInt16Exception() As String
			Get
				Return ResourceManager.GetString("StringToInt16Exception", resourceCulture)
			End Get
		End Property

		''' <summary>
		'''   Looks up a localized string similar to String value can not be converted to an Int32.
		''' </summary>
		Friend Shared ReadOnly Property StringToInt32Exception() As String
			Get
				Return ResourceManager.GetString("StringToInt32Exception", resourceCulture)
			End Get
		End Property

		''' <summary>
		'''   Looks up a localized string similar to String value can not be converted to an Int64.
		''' </summary>
		Friend Shared ReadOnly Property StringToInt64Exception() As String
			Get
				Return ResourceManager.GetString("StringToInt64Exception", resourceCulture)
			End Get
		End Property

		''' <summary>
		'''   Looks up a localized string similar to Value is not a SmartBool.
		''' </summary>
		Friend Shared ReadOnly Property ValueNotSmartBoolException() As String
			Get
				Return ResourceManager.GetString("ValueNotSmartBoolException", resourceCulture)
			End Get
		End Property

		''' <summary>
		'''   Looks up a localized string similar to Value is nto a SmartFloat.
		''' </summary>
		Friend Shared ReadOnly Property ValueNotSmartFloatException() As String
			Get
				Return ResourceManager.GetString("ValueNotSmartFloatException", resourceCulture)
			End Get
		End Property

		''' <summary>
		'''   Looks up a localized string similar to Value is not a SmartInt16.
		''' </summary>
		Friend Shared ReadOnly Property ValueNotSmartInt16Exception() As String
			Get
				Return ResourceManager.GetString("ValueNotSmartInt16Exception", resourceCulture)
			End Get
		End Property

		''' <summary>
		'''   Looks up a localized string similar to Value is not a SmartInt32.
		''' </summary>
		Friend Shared ReadOnly Property ValueNotSmartInt32Exception() As String
			Get
				Return ResourceManager.GetString("ValueNotSmartInt32Exception", resourceCulture)
			End Get
		End Property

		''' <summary>
		'''   Looks up a localized string similar to Value is not a SmartInt64.
		''' </summary>
		Friend Shared ReadOnly Property ValueNotSmartInt64Exception() As String
			Get
				Return ResourceManager.GetString("ValueNotSmartInt64Exception", resourceCulture)
			End Get
		End Property
	End Class
End Namespace
