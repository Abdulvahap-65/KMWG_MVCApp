using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

[assembly: Microsoft.Xrm.Sdk.Client.ProxyTypesAssemblyAttribute()]
namespace DynamicsCRM.Entity.Context
{

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum abd1_cityState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}

	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("abd1_city")]
	public partial class abd1_city : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public abd1_city() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "abd1_city";
		
		public const int EntityTypeCode = 10398;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd1_cityid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.abd1_cityId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd1_cityid")]
		public System.Nullable<System.Guid> abd1_cityId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("abd1_cityid");
			}
			set
			{
				this.OnPropertyChanging("abd1_cityId");
				this.SetAttributeValue("abd1_cityid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("abd1_cityId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd1_countryname")]
		public string abd1_countryname
		{
			get
			{
				return this.GetAttributeValue<string>("abd1_countryname");
			}
			set
			{
				this.OnPropertyChanging("abd1_countryname");
				this.SetAttributeValue("abd1_countryname", value);
				this.OnPropertyChanged("abd1_countryname");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd1_iscapital")]
		public System.Nullable<bool> abd1_iscapital
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("abd1_iscapital");
			}
			set
			{
				this.OnPropertyChanging("abd1_iscapital");
				this.SetAttributeValue("abd1_iscapital", value);
				this.OnPropertyChanged("abd1_iscapital");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd1_name")]
		public string abd1_name
		{
			get
			{
				return this.GetAttributeValue<string>("abd1_name");
			}
			set
			{
				this.OnPropertyChanging("abd1_name");
				this.SetAttributeValue("abd1_name", value);
				this.OnPropertyChanged("abd1_name");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd1_platenumber")]
		public string abd1_platenumber
		{
			get
			{
				return this.GetAttributeValue<string>("abd1_platenumber");
			}
			set
			{
				this.OnPropertyChanging("abd1_platenumber");
				this.SetAttributeValue("abd1_platenumber", value);
				this.OnPropertyChanged("abd1_platenumber");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd1_population")]
		public System.Nullable<int> abd1_population
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("abd1_population");
			}
			set
			{
				this.OnPropertyChanging("abd1_population");
				this.SetAttributeValue("abd1_population", value);
				this.OnPropertyChanged("abd1_population");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd1_zipcode")]
		public System.Nullable<int> abd1_zipcode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("abd1_zipcode");
			}
			set
			{
				this.OnPropertyChanging("abd1_zipcode");
				this.SetAttributeValue("abd1_zipcode", value);
				this.OnPropertyChanged("abd1_zipcode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Owner Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier for the team that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Status of the City
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<abd1_cityState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((abd1_cityState)(System.Enum.ToObject(typeof(abd1_cityState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("statecode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statecode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the City
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue statuscode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("statuscode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("statuscode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
	}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum abd2_customerState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}

	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("abd2_customer")]
	public partial class abd2_customer : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public abd2_customer() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "abd2_customer";
		
		public const int EntityTypeCode = 10399;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd2_customerid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.abd2_customerId = value;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd2_address")]
		public string abd2_address
		{
			get
			{
				return this.GetAttributeValue<string>("abd2_address");
			}
			set
			{
				this.OnPropertyChanging("abd2_address");
				this.SetAttributeValue("abd2_address", value);
				this.OnPropertyChanged("abd2_address");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd2_age")]
		public System.Nullable<int> abd2_age
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("abd2_age");
			}
			set
			{
				this.OnPropertyChanging("abd2_age");
				this.SetAttributeValue("abd2_age", value);
				this.OnPropertyChanged("abd2_age");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd2_birthdate")]
		public System.Nullable<System.DateTime> abd2_birthdate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("abd2_birthdate");
			}
			set
			{
				this.OnPropertyChanging("abd2_birthdate");
				this.SetAttributeValue("abd2_birthdate", value);
				this.OnPropertyChanged("abd2_birthdate");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd2_customerid")]
		public System.Nullable<System.Guid> abd2_customerId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("abd2_customerid");
			}
			set
			{
				this.OnPropertyChanging("abd2_customerId");
				this.SetAttributeValue("abd2_customerid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("abd2_customerId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd2_email")]
		public string abd2_email
		{
			get
			{
				return this.GetAttributeValue<string>("abd2_email");
			}
			set
			{
				this.OnPropertyChanging("abd2_email");
				this.SetAttributeValue("abd2_email", value);
				this.OnPropertyChanged("abd2_email");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd2_name")]
		public string abd2_name
		{
			get
			{
				return this.GetAttributeValue<string>("abd2_name");
			}
			set
			{
				this.OnPropertyChanging("abd2_name");
				this.SetAttributeValue("abd2_name", value);
				this.OnPropertyChanged("abd2_name");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd2_permission")]
		public System.Nullable<bool> abd2_permission
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("abd2_permission");
			}
			set
			{
				this.OnPropertyChanging("abd2_permission");
				this.SetAttributeValue("abd2_permission", value);
				this.OnPropertyChanged("abd2_permission");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd2_phone")]
		public string abd2_phone
		{
			get
			{
				return this.GetAttributeValue<string>("abd2_phone");
			}
			set
			{
				this.OnPropertyChanging("abd2_phone");
				this.SetAttributeValue("abd2_phone", value);
				this.OnPropertyChanged("abd2_phone");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd2_surname")]
		public string abd2_surname
		{
			get
			{
				return this.GetAttributeValue<string>("abd2_surname");
			}
			set
			{
				this.OnPropertyChanging("abd2_surname");
				this.SetAttributeValue("abd2_surname", value);
				this.OnPropertyChanged("abd2_surname");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Owner Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier for the team that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Status of the Customer
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<abd2_customerState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((abd2_customerState)(System.Enum.ToObject(typeof(abd2_customerState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("statecode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statecode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Customer
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue statuscode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("statuscode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("statuscode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
	}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum abd4_identitiyState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}

	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("abd4_identitiy")]
	public partial class abd4_identitiy : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public abd4_identitiy() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "abd4_identitiy";
		
		public const int EntityTypeCode = 10401;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd4_identitiyid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.abd4_identitiyId = value;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd4_dateofbirth")]
		public System.Nullable<System.DateTime> abd4_dateofbirth
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("abd4_dateofbirth");
			}
			set
			{
				this.OnPropertyChanging("abd4_dateofbirth");
				this.SetAttributeValue("abd4_dateofbirth", value);
				this.OnPropertyChanged("abd4_dateofbirth");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd4_documentno")]
		public string abd4_documentno
		{
			get
			{
				return this.GetAttributeValue<string>("abd4_documentno");
			}
			set
			{
				this.OnPropertyChanging("abd4_documentno");
				this.SetAttributeValue("abd4_documentno", value);
				this.OnPropertyChanged("abd4_documentno");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd4_fathersname")]
		public string abd4_fathersname
		{
			get
			{
				return this.GetAttributeValue<string>("abd4_fathersname");
			}
			set
			{
				this.OnPropertyChanging("abd4_fathersname");
				this.SetAttributeValue("abd4_fathersname", value);
				this.OnPropertyChanged("abd4_fathersname");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd4_gender")]
		public string abd4_gender
		{
			get
			{
				return this.GetAttributeValue<string>("abd4_gender");
			}
			set
			{
				this.OnPropertyChanging("abd4_gender");
				this.SetAttributeValue("abd4_gender", value);
				this.OnPropertyChanged("abd4_gender");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd4_identitiyid")]
		public System.Nullable<System.Guid> abd4_identitiyId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("abd4_identitiyid");
			}
			set
			{
				this.OnPropertyChanging("abd4_identitiyId");
				this.SetAttributeValue("abd4_identitiyid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("abd4_identitiyId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd4_issuedby")]
		public string abd4_issuedby
		{
			get
			{
				return this.GetAttributeValue<string>("abd4_issuedby");
			}
			set
			{
				this.OnPropertyChanging("abd4_issuedby");
				this.SetAttributeValue("abd4_issuedby", value);
				this.OnPropertyChanged("abd4_issuedby");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd4_mothersname")]
		public string abd4_mothersname
		{
			get
			{
				return this.GetAttributeValue<string>("abd4_mothersname");
			}
			set
			{
				this.OnPropertyChanging("abd4_mothersname");
				this.SetAttributeValue("abd4_mothersname", value);
				this.OnPropertyChanged("abd4_mothersname");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd4_name")]
		public string abd4_name
		{
			get
			{
				return this.GetAttributeValue<string>("abd4_name");
			}
			set
			{
				this.OnPropertyChanging("abd4_name");
				this.SetAttributeValue("abd4_name", value);
				this.OnPropertyChanged("abd4_name");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd4_nationality")]
		public string abd4_nationality
		{
			get
			{
				return this.GetAttributeValue<string>("abd4_nationality");
			}
			set
			{
				this.OnPropertyChanging("abd4_nationality");
				this.SetAttributeValue("abd4_nationality", value);
				this.OnPropertyChanged("abd4_nationality");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd4_nocumentno")]
		public string abd4_nocumentno
		{
			get
			{
				return this.GetAttributeValue<string>("abd4_nocumentno");
			}
			set
			{
				this.OnPropertyChanging("abd4_nocumentno");
				this.SetAttributeValue("abd4_nocumentno", value);
				this.OnPropertyChanged("abd4_nocumentno");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd4_surname")]
		public string abd4_surname
		{
			get
			{
				return this.GetAttributeValue<string>("abd4_surname");
			}
			set
			{
				this.OnPropertyChanging("abd4_surname");
				this.SetAttributeValue("abd4_surname", value);
				this.OnPropertyChanged("abd4_surname");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd4_tridentityno")]
		public string abd4_tridentityno
		{
			get
			{
				return this.GetAttributeValue<string>("abd4_tridentityno");
			}
			set
			{
				this.OnPropertyChanging("abd4_tridentityno");
				this.SetAttributeValue("abd4_tridentityno", value);
				this.OnPropertyChanged("abd4_tridentityno");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd4_validuntil")]
		public System.Nullable<System.DateTime> abd4_validuntil
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("abd4_validuntil");
			}
			set
			{
				this.OnPropertyChanging("abd4_validuntil");
				this.SetAttributeValue("abd4_validuntil", value);
				this.OnPropertyChanged("abd4_validuntil");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Unique identifier for the organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Status of the Identitiy
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<abd4_identitiyState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((abd4_identitiyState)(System.Enum.ToObject(typeof(abd4_identitiyState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("statecode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statecode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Identitiy
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue statuscode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("statuscode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("statuscode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
	}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum abd5_drivinglicenceState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}

	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("abd5_drivinglicence")]
	public partial class abd5_drivinglicence : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public abd5_drivinglicence() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "abd5_drivinglicence";
		
		public const int EntityTypeCode = 10402;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd5_drivinglicenceid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.abd5_drivinglicenceId = value;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd5_bloodgroup")]
		public string abd5_bloodgroup
		{
			get
			{
				return this.GetAttributeValue<string>("abd5_bloodgroup");
			}
			set
			{
				this.OnPropertyChanging("abd5_bloodgroup");
				this.SetAttributeValue("abd5_bloodgroup", value);
				this.OnPropertyChanged("abd5_bloodgroup");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd5_dateofbirth")]
		public System.Nullable<System.DateTime> abd5_dateofbirth
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("abd5_dateofbirth");
			}
			set
			{
				this.OnPropertyChanging("abd5_dateofbirth");
				this.SetAttributeValue("abd5_dateofbirth", value);
				this.OnPropertyChanged("abd5_dateofbirth");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd5_dateofissue")]
		public System.Nullable<System.DateTime> abd5_dateofissue
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("abd5_dateofissue");
			}
			set
			{
				this.OnPropertyChanging("abd5_dateofissue");
				this.SetAttributeValue("abd5_dateofissue", value);
				this.OnPropertyChanged("abd5_dateofissue");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd5_devicesandprosthesesused")]
		public string abd5_devicesandprosthesesused
		{
			get
			{
				return this.GetAttributeValue<string>("abd5_devicesandprosthesesused");
			}
			set
			{
				this.OnPropertyChanging("abd5_devicesandprosthesesused");
				this.SetAttributeValue("abd5_devicesandprosthesesused", value);
				this.OnPropertyChanged("abd5_devicesandprosthesesused");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd5_drivinglicenceid")]
		public System.Nullable<System.Guid> abd5_drivinglicenceId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("abd5_drivinglicenceid");
			}
			set
			{
				this.OnPropertyChanging("abd5_drivinglicenceId");
				this.SetAttributeValue("abd5_drivinglicenceid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("abd5_drivinglicenceId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd5_fathersname")]
		public string abd5_fathersname
		{
			get
			{
				return this.GetAttributeValue<string>("abd5_fathersname");
			}
			set
			{
				this.OnPropertyChanging("abd5_fathersname");
				this.SetAttributeValue("abd5_fathersname", value);
				this.OnPropertyChanged("abd5_fathersname");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd5_issuedatprovince_country")]
		public string abd5_issuedatprovince_country
		{
			get
			{
				return this.GetAttributeValue<string>("abd5_issuedatprovince_country");
			}
			set
			{
				this.OnPropertyChanging("abd5_issuedatprovince_country");
				this.SetAttributeValue("abd5_issuedatprovince_country", value);
				this.OnPropertyChanged("abd5_issuedatprovince_country");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd5_licencenumber")]
		public System.Nullable<int> abd5_licencenumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("abd5_licencenumber");
			}
			set
			{
				this.OnPropertyChanging("abd5_licencenumber");
				this.SetAttributeValue("abd5_licencenumber", value);
				this.OnPropertyChanged("abd5_licencenumber");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd5_mothersname")]
		public string abd5_mothersname
		{
			get
			{
				return this.GetAttributeValue<string>("abd5_mothersname");
			}
			set
			{
				this.OnPropertyChanging("abd5_mothersname");
				this.SetAttributeValue("abd5_mothersname", value);
				this.OnPropertyChanged("abd5_mothersname");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd5_name")]
		public string abd5_name
		{
			get
			{
				return this.GetAttributeValue<string>("abd5_name");
			}
			set
			{
				this.OnPropertyChanging("abd5_name");
				this.SetAttributeValue("abd5_name", value);
				this.OnPropertyChanged("abd5_name");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd5_neighborhood")]
		public string abd5_neighborhood
		{
			get
			{
				return this.GetAttributeValue<string>("abd5_neighborhood");
			}
			set
			{
				this.OnPropertyChanging("abd5_neighborhood");
				this.SetAttributeValue("abd5_neighborhood", value);
				this.OnPropertyChanged("abd5_neighborhood");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd5_placeofbirth")]
		public string abd5_placeofbirth
		{
			get
			{
				return this.GetAttributeValue<string>("abd5_placeofbirth");
			}
			set
			{
				this.OnPropertyChanging("abd5_placeofbirth");
				this.SetAttributeValue("abd5_placeofbirth", value);
				this.OnPropertyChanged("abd5_placeofbirth");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd5_province_county")]
		public string abd5_province_county
		{
			get
			{
				return this.GetAttributeValue<string>("abd5_province_county");
			}
			set
			{
				this.OnPropertyChanging("abd5_province_county");
				this.SetAttributeValue("abd5_province_county", value);
				this.OnPropertyChanged("abd5_province_county");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd5_signatureofcertificateholder")]
		public string abd5_signatureofcertificateholder
		{
			get
			{
				return this.GetAttributeValue<string>("abd5_signatureofcertificateholder");
			}
			set
			{
				this.OnPropertyChanging("abd5_signatureofcertificateholder");
				this.SetAttributeValue("abd5_signatureofcertificateholder", value);
				this.OnPropertyChanged("abd5_signatureofcertificateholder");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd5_surname")]
		public string abd5_surname
		{
			get
			{
				return this.GetAttributeValue<string>("abd5_surname");
			}
			set
			{
				this.OnPropertyChanging("abd5_surname");
				this.SetAttributeValue("abd5_surname", value);
				this.OnPropertyChanged("abd5_surname");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd5_tridentityno")]
		public string abd5_tridentityno
		{
			get
			{
				return this.GetAttributeValue<string>("abd5_tridentityno");
			}
			set
			{
				this.OnPropertyChanging("abd5_tridentityno");
				this.SetAttributeValue("abd5_tridentityno", value);
				this.OnPropertyChanged("abd5_tridentityno");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Unique identifier for the organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Status of the Driving Licence
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<abd5_drivinglicenceState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((abd5_drivinglicenceState)(System.Enum.ToObject(typeof(abd5_drivinglicenceState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("statecode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statecode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Driving Licence
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue statuscode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("statuscode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("statuscode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
	}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum abd6_tinnumbercardState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}

	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("abd6_tinnumbercard")]
	public partial class abd6_tinnumbercard : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public abd6_tinnumbercard() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "abd6_tinnumbercard";
		
		public const int EntityTypeCode = 10403;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd6_tinnumbercardid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.abd6_tinnumbercardId = value;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd6_financialofficename")]
		public string abd6_financialofficename
		{
			get
			{
				return this.GetAttributeValue<string>("abd6_financialofficename");
			}
			set
			{
				this.OnPropertyChanging("abd6_financialofficename");
				this.SetAttributeValue("abd6_financialofficename", value);
				this.OnPropertyChanged("abd6_financialofficename");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd6_issuedby")]
		public string abd6_issuedby
		{
			get
			{
				return this.GetAttributeValue<string>("abd6_issuedby");
			}
			set
			{
				this.OnPropertyChanging("abd6_issuedby");
				this.SetAttributeValue("abd6_issuedby", value);
				this.OnPropertyChanged("abd6_issuedby");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd6_name")]
		public string abd6_name
		{
			get
			{
				return this.GetAttributeValue<string>("abd6_name");
			}
			set
			{
				this.OnPropertyChanging("abd6_name");
				this.SetAttributeValue("abd6_name", value);
				this.OnPropertyChanged("abd6_name");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd6_surnametitle")]
		public string abd6_surnametitle
		{
			get
			{
				return this.GetAttributeValue<string>("abd6_surnametitle");
			}
			set
			{
				this.OnPropertyChanging("abd6_surnametitle");
				this.SetAttributeValue("abd6_surnametitle", value);
				this.OnPropertyChanged("abd6_surnametitle");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd6_taxoffice")]
		public string abd6_taxoffice
		{
			get
			{
				return this.GetAttributeValue<string>("abd6_taxoffice");
			}
			set
			{
				this.OnPropertyChanging("abd6_taxoffice");
				this.SetAttributeValue("abd6_taxoffice", value);
				this.OnPropertyChanged("abd6_taxoffice");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd6_taxpayeridentificationno")]
		public string abd6_taxpayeridentificationno
		{
			get
			{
				return this.GetAttributeValue<string>("abd6_taxpayeridentificationno");
			}
			set
			{
				this.OnPropertyChanging("abd6_taxpayeridentificationno");
				this.SetAttributeValue("abd6_taxpayeridentificationno", value);
				this.OnPropertyChanged("abd6_taxpayeridentificationno");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd6_tinnumbercardid")]
		public System.Nullable<System.Guid> abd6_tinnumbercardId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("abd6_tinnumbercardid");
			}
			set
			{
				this.OnPropertyChanging("abd6_tinnumbercardId");
				this.SetAttributeValue("abd6_tinnumbercardid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("abd6_tinnumbercardId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd6_vehicleplateno")]
		public string abd6_vehicleplateno
		{
			get
			{
				return this.GetAttributeValue<string>("abd6_vehicleplateno");
			}
			set
			{
				this.OnPropertyChanging("abd6_vehicleplateno");
				this.SetAttributeValue("abd6_vehicleplateno", value);
				this.OnPropertyChanged("abd6_vehicleplateno");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Unique identifier for the organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Status of the Tin Number Card
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<abd6_tinnumbercardState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((abd6_tinnumbercardState)(System.Enum.ToObject(typeof(abd6_tinnumbercardState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("statecode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statecode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Tin Number Card
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue statuscode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("statuscode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("statuscode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
	}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum abd7_ytustudentidentitycardState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}

	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("abd7_ytustudentidentitycard")]
	public partial class abd7_ytustudentidentitycard : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public abd7_ytustudentidentitycard() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "abd7_ytustudentidentitycard";
		
		public const int EntityTypeCode = 10404;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd7_ytustudentidentitycardid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.abd7_ytustudentidentitycardId = value;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd7_dateofgraduation")]
		public System.Nullable<System.DateTime> abd7_dateofgraduation
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("abd7_dateofgraduation");
			}
			set
			{
				this.OnPropertyChanging("abd7_dateofgraduation");
				this.SetAttributeValue("abd7_dateofgraduation", value);
				this.OnPropertyChanged("abd7_dateofgraduation");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd7_department")]
		public string abd7_department
		{
			get
			{
				return this.GetAttributeValue<string>("abd7_department");
			}
			set
			{
				this.OnPropertyChanging("abd7_department");
				this.SetAttributeValue("abd7_department", value);
				this.OnPropertyChanged("abd7_department");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd7_faculty")]
		public string abd7_faculty
		{
			get
			{
				return this.GetAttributeValue<string>("abd7_faculty");
			}
			set
			{
				this.OnPropertyChanging("abd7_faculty");
				this.SetAttributeValue("abd7_faculty", value);
				this.OnPropertyChanged("abd7_faculty");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd7_name")]
		public string abd7_name
		{
			get
			{
				return this.GetAttributeValue<string>("abd7_name");
			}
			set
			{
				this.OnPropertyChanging("abd7_name");
				this.SetAttributeValue("abd7_name", value);
				this.OnPropertyChanged("abd7_name");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd7_nationaidno")]
		public System.Nullable<int> abd7_nationaidno
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("abd7_nationaidno");
			}
			set
			{
				this.OnPropertyChanging("abd7_nationaidno");
				this.SetAttributeValue("abd7_nationaidno", value);
				this.OnPropertyChanged("abd7_nationaidno");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd7_studentno")]
		public string abd7_studentno
		{
			get
			{
				return this.GetAttributeValue<string>("abd7_studentno");
			}
			set
			{
				this.OnPropertyChanging("abd7_studentno");
				this.SetAttributeValue("abd7_studentno", value);
				this.OnPropertyChanged("abd7_studentno");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd7_surname")]
		public string abd7_surname
		{
			get
			{
				return this.GetAttributeValue<string>("abd7_surname");
			}
			set
			{
				this.OnPropertyChanging("abd7_surname");
				this.SetAttributeValue("abd7_surname", value);
				this.OnPropertyChanged("abd7_surname");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abd7_ytustudentidentitycardid")]
		public System.Nullable<System.Guid> abd7_ytustudentidentitycardId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("abd7_ytustudentidentitycardid");
			}
			set
			{
				this.OnPropertyChanging("abd7_ytustudentidentitycardId");
				this.SetAttributeValue("abd7_ytustudentidentitycardid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("abd7_ytustudentidentitycardId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Owner Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier for the team that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Status of the YTU Student Identity Card
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<abd7_ytustudentidentitycardState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((abd7_ytustudentidentitycardState)(System.Enum.ToObject(typeof(abd7_ytustudentidentitycardState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("statecode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statecode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the YTU Student Identity Card
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue statuscode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("statuscode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("statuscode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
	}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum AccountState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}

	/// <summary>
	/// Business that represents a customer or potential customer. The company that is billed in business transactions.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("account")]
	public partial class Account : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public Account() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "account";
		
		public const int EntityTypeCode = 1;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.AccountId = value;
			}
		}
		
		/// <summary>
		/// Select a category to indicate whether the customer account is standard or preferred.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountcategorycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue AccountCategoryCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountcategorycode");
			}
			set
			{
				this.OnPropertyChanging("AccountCategoryCode");
				this.SetAttributeValue("accountcategorycode", value);
				this.OnPropertyChanged("AccountCategoryCode");
			}
		}
		
		/// <summary>
		/// Select a classification code to indicate the potential value of the customer account based on the projected return on investment, cooperation level, sales cycle length or other criteria.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountclassificationcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue AccountClassificationCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountclassificationcode");
			}
			set
			{
				this.OnPropertyChanging("AccountClassificationCode");
				this.SetAttributeValue("accountclassificationcode", value);
				this.OnPropertyChanged("AccountClassificationCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
		public System.Nullable<System.Guid> AccountId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("accountid");
			}
			set
			{
				this.OnPropertyChanging("AccountId");
				this.SetAttributeValue("accountid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("AccountId");
			}
		}
		
		/// <summary>
		/// Type an ID number or code for the account to quickly search and identify the account in system views.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountnumber")]
		public string AccountNumber
		{
			get
			{
				return this.GetAttributeValue<string>("accountnumber");
			}
			set
			{
				this.OnPropertyChanging("AccountNumber");
				this.SetAttributeValue("accountnumber", value);
				this.OnPropertyChanged("AccountNumber");
			}
		}
		
		/// <summary>
		/// Select a rating to indicate the value of the customer account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountratingcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue AccountRatingCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountratingcode");
			}
			set
			{
				this.OnPropertyChanging("AccountRatingCode");
				this.SetAttributeValue("accountratingcode", value);
				this.OnPropertyChanged("AccountRatingCode");
			}
		}
		
		/// <summary>
		/// Unique identifier for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addressid")]
		public System.Nullable<System.Guid> Address1_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address1_addressid");
			}
			set
			{
				this.OnPropertyChanging("Address1_AddressId");
				this.SetAttributeValue("address1_addressid", value);
				this.OnPropertyChanged("Address1_AddressId");
			}
		}
		
		/// <summary>
		/// Select the primary address type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_AddressTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_addresstypecode");
			}
			set
			{
				this.OnPropertyChanging("Address1_AddressTypeCode");
				this.SetAttributeValue("address1_addresstypecode", value);
				this.OnPropertyChanged("Address1_AddressTypeCode");
			}
		}
		
		/// <summary>
		/// Type the city for the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_city")]
		public string Address1_City
		{
			get
			{
				return this.GetAttributeValue<string>("address1_city");
			}
			set
			{
				this.OnPropertyChanging("Address1_City");
				this.SetAttributeValue("address1_city", value);
				this.OnPropertyChanged("Address1_City");
			}
		}
		
		/// <summary>
		/// Shows the complete primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_composite")]
		public string Address1_Composite
		{
			get
			{
				return this.GetAttributeValue<string>("address1_composite");
			}
		}
		
		/// <summary>
		/// Type the country or region for the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_country")]
		public string Address1_Country
		{
			get
			{
				return this.GetAttributeValue<string>("address1_country");
			}
			set
			{
				this.OnPropertyChanging("Address1_Country");
				this.SetAttributeValue("address1_country", value);
				this.OnPropertyChanged("Address1_Country");
			}
		}
		
		/// <summary>
		/// Type the county for the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_county")]
		public string Address1_County
		{
			get
			{
				return this.GetAttributeValue<string>("address1_county");
			}
			set
			{
				this.OnPropertyChanging("Address1_County");
				this.SetAttributeValue("address1_county", value);
				this.OnPropertyChanged("Address1_County");
			}
		}
		
		/// <summary>
		/// Type the fax number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_fax")]
		public string Address1_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("address1_fax");
			}
			set
			{
				this.OnPropertyChanging("Address1_Fax");
				this.SetAttributeValue("address1_fax", value);
				this.OnPropertyChanged("Address1_Fax");
			}
		}
		
		/// <summary>
		/// Select the freight terms for the primary address to make sure shipping orders are processed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_freighttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_FreightTermsCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_freighttermscode");
			}
			set
			{
				this.OnPropertyChanging("Address1_FreightTermsCode");
				this.SetAttributeValue("address1_freighttermscode", value);
				this.OnPropertyChanged("Address1_FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Type the latitude value for the primary address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_latitude")]
		public System.Nullable<double> Address1_Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_latitude");
			}
			set
			{
				this.OnPropertyChanging("Address1_Latitude");
				this.SetAttributeValue("address1_latitude", value);
				this.OnPropertyChanged("Address1_Latitude");
			}
		}
		
		/// <summary>
		/// Type the first line of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line1")]
		public string Address1_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line1");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line1");
				this.SetAttributeValue("address1_line1", value);
				this.OnPropertyChanged("Address1_Line1");
			}
		}
		
		/// <summary>
		/// Type the second line of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line2")]
		public string Address1_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line2");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line2");
				this.SetAttributeValue("address1_line2", value);
				this.OnPropertyChanged("Address1_Line2");
			}
		}
		
		/// <summary>
		/// Type the third line of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line3")]
		public string Address1_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line3");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line3");
				this.SetAttributeValue("address1_line3", value);
				this.OnPropertyChanged("Address1_Line3");
			}
		}
		
		/// <summary>
		/// Type the longitude value for the primary address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_longitude")]
		public System.Nullable<double> Address1_Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_longitude");
			}
			set
			{
				this.OnPropertyChanging("Address1_Longitude");
				this.SetAttributeValue("address1_longitude", value);
				this.OnPropertyChanged("Address1_Longitude");
			}
		}
		
		/// <summary>
		/// Type a descriptive name for the primary address, such as Corporate Headquarters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_name")]
		public string Address1_Name
		{
			get
			{
				return this.GetAttributeValue<string>("address1_name");
			}
			set
			{
				this.OnPropertyChanging("Address1_Name");
				this.SetAttributeValue("address1_name", value);
				this.OnPropertyChanged("Address1_Name");
			}
		}
		
		/// <summary>
		/// Type the ZIP Code or postal code for the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postalcode")]
		public string Address1_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("address1_postalcode");
			}
			set
			{
				this.OnPropertyChanging("Address1_PostalCode");
				this.SetAttributeValue("address1_postalcode", value);
				this.OnPropertyChanged("Address1_PostalCode");
			}
		}
		
		/// <summary>
		/// Type the post office box number of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postofficebox")]
		public string Address1_PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("address1_postofficebox");
			}
			set
			{
				this.OnPropertyChanging("Address1_PostOfficeBox");
				this.SetAttributeValue("address1_postofficebox", value);
				this.OnPropertyChanged("Address1_PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Type the name of the main contact at the account's primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_primarycontactname")]
		public string Address1_PrimaryContactName
		{
			get
			{
				return this.GetAttributeValue<string>("address1_primarycontactname");
			}
			set
			{
				this.OnPropertyChanging("Address1_PrimaryContactName");
				this.SetAttributeValue("address1_primarycontactname", value);
				this.OnPropertyChanged("Address1_PrimaryContactName");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_ShippingMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_shippingmethodcode");
			}
			set
			{
				this.OnPropertyChanging("Address1_ShippingMethodCode");
				this.SetAttributeValue("address1_shippingmethodcode", value);
				this.OnPropertyChanged("Address1_ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// Type the state or province of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_stateorprovince")]
		public string Address1_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("address1_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("Address1_StateOrProvince");
				this.SetAttributeValue("address1_stateorprovince", value);
				this.OnPropertyChanged("Address1_StateOrProvince");
			}
		}
		
		/// <summary>
		/// Type the main phone number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone1")]
		public string Address1_Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone1");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone1");
				this.SetAttributeValue("address1_telephone1", value);
				this.OnPropertyChanged("Address1_Telephone1");
			}
		}
		
		/// <summary>
		/// Type a second phone number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone2")]
		public string Address1_Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone2");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone2");
				this.SetAttributeValue("address1_telephone2", value);
				this.OnPropertyChanged("Address1_Telephone2");
			}
		}
		
		/// <summary>
		/// Type a third phone number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone3")]
		public string Address1_Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone3");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone3");
				this.SetAttributeValue("address1_telephone3", value);
				this.OnPropertyChanged("Address1_Telephone3");
			}
		}
		
		/// <summary>
		/// Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_upszone")]
		public string Address1_UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("address1_upszone");
			}
			set
			{
				this.OnPropertyChanging("Address1_UPSZone");
				this.SetAttributeValue("address1_upszone", value);
				this.OnPropertyChanged("Address1_UPSZone");
			}
		}
		
		/// <summary>
		/// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_utcoffset")]
		public System.Nullable<int> Address1_UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address1_utcoffset");
			}
			set
			{
				this.OnPropertyChanging("Address1_UTCOffset");
				this.SetAttributeValue("address1_utcoffset", value);
				this.OnPropertyChanged("Address1_UTCOffset");
			}
		}
		
		/// <summary>
		/// Unique identifier for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addressid")]
		public System.Nullable<System.Guid> Address2_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address2_addressid");
			}
			set
			{
				this.OnPropertyChanging("Address2_AddressId");
				this.SetAttributeValue("address2_addressid", value);
				this.OnPropertyChanged("Address2_AddressId");
			}
		}
		
		/// <summary>
		/// Select the secondary address type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_AddressTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_addresstypecode");
			}
			set
			{
				this.OnPropertyChanging("Address2_AddressTypeCode");
				this.SetAttributeValue("address2_addresstypecode", value);
				this.OnPropertyChanged("Address2_AddressTypeCode");
			}
		}
		
		/// <summary>
		/// Type the city for the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_city")]
		public string Address2_City
		{
			get
			{
				return this.GetAttributeValue<string>("address2_city");
			}
			set
			{
				this.OnPropertyChanging("Address2_City");
				this.SetAttributeValue("address2_city", value);
				this.OnPropertyChanged("Address2_City");
			}
		}
		
		/// <summary>
		/// Shows the complete secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_composite")]
		public string Address2_Composite
		{
			get
			{
				return this.GetAttributeValue<string>("address2_composite");
			}
		}
		
		/// <summary>
		/// Type the country or region for the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_country")]
		public string Address2_Country
		{
			get
			{
				return this.GetAttributeValue<string>("address2_country");
			}
			set
			{
				this.OnPropertyChanging("Address2_Country");
				this.SetAttributeValue("address2_country", value);
				this.OnPropertyChanged("Address2_Country");
			}
		}
		
		/// <summary>
		/// Type the county for the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_county")]
		public string Address2_County
		{
			get
			{
				return this.GetAttributeValue<string>("address2_county");
			}
			set
			{
				this.OnPropertyChanging("Address2_County");
				this.SetAttributeValue("address2_county", value);
				this.OnPropertyChanged("Address2_County");
			}
		}
		
		/// <summary>
		/// Type the fax number associated with the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_fax")]
		public string Address2_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("address2_fax");
			}
			set
			{
				this.OnPropertyChanging("Address2_Fax");
				this.SetAttributeValue("address2_fax", value);
				this.OnPropertyChanged("Address2_Fax");
			}
		}
		
		/// <summary>
		/// Select the freight terms for the secondary address to make sure shipping orders are processed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_freighttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_FreightTermsCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_freighttermscode");
			}
			set
			{
				this.OnPropertyChanging("Address2_FreightTermsCode");
				this.SetAttributeValue("address2_freighttermscode", value);
				this.OnPropertyChanged("Address2_FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Type the latitude value for the secondary address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_latitude")]
		public System.Nullable<double> Address2_Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_latitude");
			}
			set
			{
				this.OnPropertyChanging("Address2_Latitude");
				this.SetAttributeValue("address2_latitude", value);
				this.OnPropertyChanged("Address2_Latitude");
			}
		}
		
		/// <summary>
		/// Type the first line of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line1")]
		public string Address2_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line1");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line1");
				this.SetAttributeValue("address2_line1", value);
				this.OnPropertyChanged("Address2_Line1");
			}
		}
		
		/// <summary>
		/// Type the second line of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line2")]
		public string Address2_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line2");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line2");
				this.SetAttributeValue("address2_line2", value);
				this.OnPropertyChanged("Address2_Line2");
			}
		}
		
		/// <summary>
		/// Type the third line of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line3")]
		public string Address2_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line3");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line3");
				this.SetAttributeValue("address2_line3", value);
				this.OnPropertyChanged("Address2_Line3");
			}
		}
		
		/// <summary>
		/// Type the longitude value for the secondary address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_longitude")]
		public System.Nullable<double> Address2_Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_longitude");
			}
			set
			{
				this.OnPropertyChanging("Address2_Longitude");
				this.SetAttributeValue("address2_longitude", value);
				this.OnPropertyChanged("Address2_Longitude");
			}
		}
		
		/// <summary>
		/// Type a descriptive name for the secondary address, such as Corporate Headquarters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_name")]
		public string Address2_Name
		{
			get
			{
				return this.GetAttributeValue<string>("address2_name");
			}
			set
			{
				this.OnPropertyChanging("Address2_Name");
				this.SetAttributeValue("address2_name", value);
				this.OnPropertyChanged("Address2_Name");
			}
		}
		
		/// <summary>
		/// Type the ZIP Code or postal code for the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postalcode")]
		public string Address2_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("address2_postalcode");
			}
			set
			{
				this.OnPropertyChanging("Address2_PostalCode");
				this.SetAttributeValue("address2_postalcode", value);
				this.OnPropertyChanged("Address2_PostalCode");
			}
		}
		
		/// <summary>
		/// Type the post office box number of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postofficebox")]
		public string Address2_PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("address2_postofficebox");
			}
			set
			{
				this.OnPropertyChanging("Address2_PostOfficeBox");
				this.SetAttributeValue("address2_postofficebox", value);
				this.OnPropertyChanged("Address2_PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Type the name of the main contact at the account's secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_primarycontactname")]
		public string Address2_PrimaryContactName
		{
			get
			{
				return this.GetAttributeValue<string>("address2_primarycontactname");
			}
			set
			{
				this.OnPropertyChanging("Address2_PrimaryContactName");
				this.SetAttributeValue("address2_primarycontactname", value);
				this.OnPropertyChanged("Address2_PrimaryContactName");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_ShippingMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_shippingmethodcode");
			}
			set
			{
				this.OnPropertyChanging("Address2_ShippingMethodCode");
				this.SetAttributeValue("address2_shippingmethodcode", value);
				this.OnPropertyChanged("Address2_ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// Type the state or province of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_stateorprovince")]
		public string Address2_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("address2_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("Address2_StateOrProvince");
				this.SetAttributeValue("address2_stateorprovince", value);
				this.OnPropertyChanged("Address2_StateOrProvince");
			}
		}
		
		/// <summary>
		/// Type the main phone number associated with the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone1")]
		public string Address2_Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone1");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone1");
				this.SetAttributeValue("address2_telephone1", value);
				this.OnPropertyChanged("Address2_Telephone1");
			}
		}
		
		/// <summary>
		/// Type a second phone number associated with the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone2")]
		public string Address2_Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone2");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone2");
				this.SetAttributeValue("address2_telephone2", value);
				this.OnPropertyChanged("Address2_Telephone2");
			}
		}
		
		/// <summary>
		/// Type a third phone number associated with the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone3")]
		public string Address2_Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone3");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone3");
				this.SetAttributeValue("address2_telephone3", value);
				this.OnPropertyChanged("Address2_Telephone3");
			}
		}
		
		/// <summary>
		/// Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_upszone")]
		public string Address2_UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("address2_upszone");
			}
			set
			{
				this.OnPropertyChanging("Address2_UPSZone");
				this.SetAttributeValue("address2_upszone", value);
				this.OnPropertyChanged("Address2_UPSZone");
			}
		}
		
		/// <summary>
		/// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_utcoffset")]
		public System.Nullable<int> Address2_UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address2_utcoffset");
			}
			set
			{
				this.OnPropertyChanging("Address2_UTCOffset");
				this.SetAttributeValue("address2_utcoffset", value);
				this.OnPropertyChanged("Address2_UTCOffset");
			}
		}
		
		/// <summary>
		/// For system use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30")]
		public Microsoft.Xrm.Sdk.Money Aging30
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30");
			}
		}
		
		/// <summary>
		/// The base currency equivalent of the aging 30 field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30_base")]
		public Microsoft.Xrm.Sdk.Money Aging30_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30_base");
			}
		}
		
		/// <summary>
		/// For system use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60")]
		public Microsoft.Xrm.Sdk.Money Aging60
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60");
			}
		}
		
		/// <summary>
		/// The base currency equivalent of the aging 60 field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60_base")]
		public Microsoft.Xrm.Sdk.Money Aging60_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60_base");
			}
		}
		
		/// <summary>
		/// For system use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90")]
		public Microsoft.Xrm.Sdk.Money Aging90
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90");
			}
		}
		
		/// <summary>
		/// The base currency equivalent of the aging 90 field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90_base")]
		public Microsoft.Xrm.Sdk.Money Aging90_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90_base");
			}
		}
		
		/// <summary>
		/// Select the legal designation or other business type of the account for contracts or reporting purposes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businesstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue BusinessTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("businesstypecode");
			}
			set
			{
				this.OnPropertyChanging("BusinessTypeCode");
				this.SetAttributeValue("businesstypecode", value);
				this.OnPropertyChanged("BusinessTypeCode");
			}
		}
		
		/// <summary>
		/// Shows who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Shows the external party who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedByExternalParty
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdbyexternalparty");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Shows who created the record on behalf of another user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Type the credit limit of the account. This is a useful reference when you address invoice and accounting issues with the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit")]
		public Microsoft.Xrm.Sdk.Money CreditLimit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit");
			}
			set
			{
				this.OnPropertyChanging("CreditLimit");
				this.SetAttributeValue("creditlimit", value);
				this.OnPropertyChanged("CreditLimit");
			}
		}
		
		/// <summary>
		/// Shows the credit limit converted to the system's default base currency for reporting purposes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit_base")]
		public Microsoft.Xrm.Sdk.Money CreditLimit_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit_base");
			}
		}
		
		/// <summary>
		/// Select whether the credit for the account is on hold. This is a useful reference while addressing the invoice and accounting issues with the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditonhold")]
		public System.Nullable<bool> CreditOnHold
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("creditonhold");
			}
			set
			{
				this.OnPropertyChanging("CreditOnHold");
				this.SetAttributeValue("creditonhold", value);
				this.OnPropertyChanged("CreditOnHold");
			}
		}
		
		/// <summary>
		/// Select the size category or range of the account for segmentation and reporting purposes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customersizecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue CustomerSizeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customersizecode");
			}
			set
			{
				this.OnPropertyChanging("CustomerSizeCode");
				this.SetAttributeValue("customersizecode", value);
				this.OnPropertyChanged("CustomerSizeCode");
			}
		}
		
		/// <summary>
		/// Select the category that best describes the relationship between the account and your organization.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customertypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue CustomerTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customertypecode");
			}
			set
			{
				this.OnPropertyChanging("CustomerTypeCode");
				this.SetAttributeValue("customertypecode", value);
				this.OnPropertyChanged("CustomerTypeCode");
			}
		}
		
		/// <summary>
		/// Choose the default price list associated with the account to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultpricelevelid")]
		public Microsoft.Xrm.Sdk.EntityReference DefaultPriceLevelId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultpricelevelid");
			}
			set
			{
				this.OnPropertyChanging("DefaultPriceLevelId");
				this.SetAttributeValue("defaultpricelevelid", value);
				this.OnPropertyChanged("DefaultPriceLevelId");
			}
		}
		
		/// <summary>
		/// Type additional information to describe the account, such as an excerpt from the company's website.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Select whether the account allows bulk email sent through campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but is excluded from email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkemail")]
		public System.Nullable<bool> DoNotBulkEMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotbulkemail");
			}
			set
			{
				this.OnPropertyChanging("DoNotBulkEMail");
				this.SetAttributeValue("donotbulkemail", value);
				this.OnPropertyChanged("DoNotBulkEMail");
			}
		}
		
		/// <summary>
		/// Select whether the account allows bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but will be excluded from the postal mail.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkpostalmail")]
		public System.Nullable<bool> DoNotBulkPostalMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotbulkpostalmail");
			}
			set
			{
				this.OnPropertyChanging("DoNotBulkPostalMail");
				this.SetAttributeValue("donotbulkpostalmail", value);
				this.OnPropertyChanged("DoNotBulkPostalMail");
			}
		}
		
		/// <summary>
		/// Select whether the account allows direct email sent from Microsoft Dynamics 365.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
		public System.Nullable<bool> DoNotEMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotemail");
			}
			set
			{
				this.OnPropertyChanging("DoNotEMail");
				this.SetAttributeValue("donotemail", value);
				this.OnPropertyChanged("DoNotEMail");
			}
		}
		
		/// <summary>
		/// Select whether the account allows faxes. If Do Not Allow is selected, the account will be excluded from fax activities distributed in marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
		public System.Nullable<bool> DoNotFax
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotfax");
			}
			set
			{
				this.OnPropertyChanging("DoNotFax");
				this.SetAttributeValue("donotfax", value);
				this.OnPropertyChanged("DoNotFax");
			}
		}
		
		/// <summary>
		/// Select whether the account allows phone calls. If Do Not Allow is selected, the account will be excluded from phone call activities distributed in marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
		public System.Nullable<bool> DoNotPhone
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotphone");
			}
			set
			{
				this.OnPropertyChanging("DoNotPhone");
				this.SetAttributeValue("donotphone", value);
				this.OnPropertyChanged("DoNotPhone");
			}
		}
		
		/// <summary>
		/// Select whether the account allows direct mail. If Do Not Allow is selected, the account will be excluded from letter activities distributed in marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
		public System.Nullable<bool> DoNotPostalMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail");
			}
			set
			{
				this.OnPropertyChanging("DoNotPostalMail");
				this.SetAttributeValue("donotpostalmail", value);
				this.OnPropertyChanged("DoNotPostalMail");
			}
		}
		
		/// <summary>
		/// Select whether the account accepts marketing materials, such as brochures or catalogs.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotsendmm")]
		public System.Nullable<bool> DoNotSendMM
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotsendmm");
			}
			set
			{
				this.OnPropertyChanging("DoNotSendMM");
				this.SetAttributeValue("donotsendmm", value);
				this.OnPropertyChanged("DoNotSendMM");
			}
		}
		
		/// <summary>
		/// Type the primary email address for the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress1")]
		public string EMailAddress1
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress1");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress1");
				this.SetAttributeValue("emailaddress1", value);
				this.OnPropertyChanged("EMailAddress1");
			}
		}
		
		/// <summary>
		/// Type the secondary email address for the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress2")]
		public string EMailAddress2
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress2");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress2");
				this.SetAttributeValue("emailaddress2", value);
				this.OnPropertyChanged("EMailAddress2");
			}
		}
		
		/// <summary>
		/// Type an alternate email address for the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress3")]
		public string EMailAddress3
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress3");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress3");
				this.SetAttributeValue("emailaddress3", value);
				this.OnPropertyChanged("EMailAddress3");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
		public byte[] EntityImage
		{
			get
			{
				return this.GetAttributeValue<byte[]>("entityimage");
			}
			set
			{
				this.OnPropertyChanging("EntityImage");
				this.SetAttributeValue("entityimage", value);
				this.OnPropertyChanged("EntityImage");
			}
		}
		
		/// <summary>
		///  
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
		public System.Nullable<long> EntityImage_Timestamp
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp");
			}
		}
		
		/// <summary>
		///  
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
		public string EntityImage_URL
		{
			get
			{
				return this.GetAttributeValue<string>("entityimage_url");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
		public System.Nullable<System.Guid> EntityImageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid");
			}
		}
		
		/// <summary>
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Type the fax number for the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fax")]
		public string Fax
		{
			get
			{
				return this.GetAttributeValue<string>("fax");
			}
			set
			{
				this.OnPropertyChanging("Fax");
				this.SetAttributeValue("fax", value);
				this.OnPropertyChanged("Fax");
			}
		}
		
		/// <summary>
		/// Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("followemail")]
		public System.Nullable<bool> FollowEmail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("followemail");
			}
			set
			{
				this.OnPropertyChanging("FollowEmail");
				this.SetAttributeValue("followemail", value);
				this.OnPropertyChanged("FollowEmail");
			}
		}
		
		/// <summary>
		/// Type the URL for the account's FTP site to enable users to access data and share documents.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ftpsiteurl")]
		public string FtpSiteURL
		{
			get
			{
				return this.GetAttributeValue<string>("ftpsiteurl");
			}
			set
			{
				this.OnPropertyChanging("FtpSiteURL");
				this.SetAttributeValue("ftpsiteurl", value);
				this.OnPropertyChanged("FtpSiteURL");
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Select the account's primary industry for use in marketing segmentation and demographic analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("industrycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue IndustryCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("industrycode");
			}
			set
			{
				this.OnPropertyChanging("IndustryCode");
				this.SetAttributeValue("industrycode", value);
				this.OnPropertyChanged("IndustryCode");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isprivate")]
		public System.Nullable<bool> IsPrivate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isprivate");
			}
		}
		
		/// <summary>
		/// Contains the date and time stamp of the last on hold time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastonholdtime")]
		public System.Nullable<System.DateTime> LastOnHoldTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastonholdtime");
			}
			set
			{
				this.OnPropertyChanging("LastOnHoldTime");
				this.SetAttributeValue("lastonholdtime", value);
				this.OnPropertyChanged("LastOnHoldTime");
			}
		}
		
		/// <summary>
		/// Shows the date when the account was last included in a marketing campaign or quick campaign.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastusedincampaign")]
		public System.Nullable<System.DateTime> LastUsedInCampaign
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastusedincampaign");
			}
			set
			{
				this.OnPropertyChanging("LastUsedInCampaign");
				this.SetAttributeValue("lastusedincampaign", value);
				this.OnPropertyChanged("LastUsedInCampaign");
			}
		}
		
		/// <summary>
		/// Type the market capitalization of the account to identify the company's equity, used as an indicator in financial performance analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketcap")]
		public Microsoft.Xrm.Sdk.Money MarketCap
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("marketcap");
			}
			set
			{
				this.OnPropertyChanging("MarketCap");
				this.SetAttributeValue("marketcap", value);
				this.OnPropertyChanged("MarketCap");
			}
		}
		
		/// <summary>
		/// Shows the market capitalization converted to the system's default base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketcap_base")]
		public Microsoft.Xrm.Sdk.Money MarketCap_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("marketcap_base");
			}
		}
		
		/// <summary>
		/// Whether is only for marketing
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketingonly")]
		public System.Nullable<bool> MarketingOnly
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("marketingonly");
			}
			set
			{
				this.OnPropertyChanging("MarketingOnly");
				this.SetAttributeValue("marketingonly", value);
				this.OnPropertyChanged("MarketingOnly");
			}
		}
		
		/// <summary>
		/// Shows the master account that the account was merged with.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
		public Microsoft.Xrm.Sdk.EntityReference MasterId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("masterid");
			}
		}
		
		/// <summary>
		/// Shows whether the account has been merged with another account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("merged")]
		public System.Nullable<bool> Merged
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("merged");
			}
		}
		
		/// <summary>
		/// Shows who last updated the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Shows the external party who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedByExternalParty
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedbyexternalparty");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Shows who created the record on behalf of another user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Reference to an other account to be used for billing (only to be used if billing account differs)
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_billingaccount")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_BillingAccount
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_billingaccount");
			}
			set
			{
				this.OnPropertyChanging("msdyn_BillingAccount");
				this.SetAttributeValue("msdyn_billingaccount", value);
				this.OnPropertyChanged("msdyn_BillingAccount");
			}
		}
		
		/// <summary>
		/// External Account ID from other systems.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_externalaccountid")]
		public string msdyn_externalaccountid
		{
			get
			{
				return this.GetAttributeValue<string>("msdyn_externalaccountid");
			}
			set
			{
				this.OnPropertyChanging("msdyn_externalaccountid");
				this.SetAttributeValue("msdyn_externalaccountid", value);
				this.OnPropertyChanged("msdyn_externalaccountid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_preferredresource")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_PreferredResource
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_preferredresource");
			}
			set
			{
				this.OnPropertyChanging("msdyn_PreferredResource");
				this.SetAttributeValue("msdyn_preferredresource", value);
				this.OnPropertyChanged("msdyn_PreferredResource");
			}
		}
		
		/// <summary>
		/// Default Sales Tax Code
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_salestaxcode")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_SalesTaxCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_salestaxcode");
			}
			set
			{
				this.OnPropertyChanging("msdyn_SalesTaxCode");
				this.SetAttributeValue("msdyn_salestaxcode", value);
				this.OnPropertyChanged("msdyn_SalesTaxCode");
			}
		}
		
		/// <summary>
		/// The Service Territory this account belongs to. This is used to optimize scheduling and routing
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_serviceterritory")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_ServiceTerritory
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_serviceterritory");
			}
			set
			{
				this.OnPropertyChanging("msdyn_ServiceTerritory");
				this.SetAttributeValue("msdyn_serviceterritory", value);
				this.OnPropertyChanged("msdyn_ServiceTerritory");
			}
		}
		
		/// <summary>
		/// Select whether the account is tax exempt.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_taxexempt")]
		public System.Nullable<bool> msdyn_TaxExempt
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_taxexempt");
			}
			set
			{
				this.OnPropertyChanging("msdyn_TaxExempt");
				this.SetAttributeValue("msdyn_taxexempt", value);
				this.OnPropertyChanged("msdyn_TaxExempt");
			}
		}
		
		/// <summary>
		/// Shows the government tax exempt number.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_taxexemptnumber")]
		public string msdyn_TaxExemptNumber
		{
			get
			{
				return this.GetAttributeValue<string>("msdyn_taxexemptnumber");
			}
			set
			{
				this.OnPropertyChanging("msdyn_TaxExemptNumber");
				this.SetAttributeValue("msdyn_taxexemptnumber", value);
				this.OnPropertyChanged("msdyn_TaxExemptNumber");
			}
		}
		
		/// <summary>
		/// Enter the travel charge to include on work orders. This value will be multiplied by the travel charge type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_travelcharge")]
		public Microsoft.Xrm.Sdk.Money msdyn_TravelCharge
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msdyn_travelcharge");
			}
			set
			{
				this.OnPropertyChanging("msdyn_TravelCharge");
				this.SetAttributeValue("msdyn_travelcharge", value);
				this.OnPropertyChanged("msdyn_TravelCharge");
			}
		}
		
		/// <summary>
		/// Value of the Travel Charge in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_travelcharge_base")]
		public Microsoft.Xrm.Sdk.Money msdyn_travelcharge_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msdyn_travelcharge_base");
			}
		}
		
		/// <summary>
		/// Specify how travel is charged for this account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_travelchargetype")]
		public Microsoft.Xrm.Sdk.OptionSetValue msdyn_TravelChargeType
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("msdyn_travelchargetype");
			}
			set
			{
				this.OnPropertyChanging("msdyn_TravelChargeType");
				this.SetAttributeValue("msdyn_travelchargetype", value);
				this.OnPropertyChanged("msdyn_TravelChargeType");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_workhourtemplate")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_workhourtemplate
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_workhourtemplate");
			}
			set
			{
				this.OnPropertyChanging("msdyn_workhourtemplate");
				this.SetAttributeValue("msdyn_workhourtemplate", value);
				this.OnPropertyChanged("msdyn_workhourtemplate");
			}
		}
		
		/// <summary>
		/// Shows the default instructions to show on new work orders.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_workorderinstructions")]
		public string msdyn_WorkOrderInstructions
		{
			get
			{
				return this.GetAttributeValue<string>("msdyn_workorderinstructions");
			}
			set
			{
				this.OnPropertyChanging("msdyn_WorkOrderInstructions");
				this.SetAttributeValue("msdyn_workorderinstructions", value);
				this.OnPropertyChanged("msdyn_WorkOrderInstructions");
			}
		}
		
		/// <summary>
		/// Type the company or business name.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_country")]
		public string new_Country
		{
			get
			{
				return this.GetAttributeValue<string>("new_country");
			}
			set
			{
				this.OnPropertyChanging("new_Country");
				this.SetAttributeValue("new_country", value);
				this.OnPropertyChanged("new_Country");
			}
		}
		
		/// <summary>
		/// Type the number of employees that work at the account for use in marketing segmentation and demographic analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberofemployees")]
		public System.Nullable<int> NumberOfEmployees
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("numberofemployees");
			}
			set
			{
				this.OnPropertyChanging("NumberOfEmployees");
				this.SetAttributeValue("numberofemployees", value);
				this.OnPropertyChanged("NumberOfEmployees");
			}
		}
		
		/// <summary>
		/// Shows how long, in minutes, that the record was on hold.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("onholdtime")]
		public System.Nullable<int> OnHoldTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("onholdtime");
			}
		}
		
		/// <summary>
		/// Number of open opportunities against an account and its child accounts.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opendeals")]
		public System.Nullable<int> OpenDeals
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("opendeals");
			}
		}
		
		/// <summary>
		/// Last Updated time of rollup field Open Deals.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opendeals_date")]
		public System.Nullable<System.DateTime> OpenDeals_Date
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("opendeals_date");
			}
		}
		
		/// <summary>
		/// State of rollup field Open Deals.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opendeals_state")]
		public System.Nullable<int> OpenDeals_State
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("opendeals_state");
			}
		}
		
		/// <summary>
		/// Sum of open revenue against an account and its child accounts.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("openrevenue")]
		public Microsoft.Xrm.Sdk.Money OpenRevenue
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("openrevenue");
			}
		}
		
		/// <summary>
		/// Value of the Open Revenue in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("openrevenue_base")]
		public Microsoft.Xrm.Sdk.Money OpenRevenue_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("openrevenue_base");
			}
		}
		
		/// <summary>
		/// Last Updated time of rollup field Open Revenue.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("openrevenue_date")]
		public System.Nullable<System.DateTime> OpenRevenue_Date
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("openrevenue_date");
			}
		}
		
		/// <summary>
		/// State of rollup field Open Revenue.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("openrevenue_state")]
		public System.Nullable<int> OpenRevenue_State
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("openrevenue_state");
			}
		}
		
		/// <summary>
		/// Shows the lead that the account was created from if the account was created by converting a lead in Microsoft Dynamics 365. This is used to relate the account to data on the originating lead for use in reporting and analytics.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingleadid")]
		public Microsoft.Xrm.Sdk.EntityReference OriginatingLeadId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("originatingleadid");
			}
			set
			{
				this.OnPropertyChanging("OriginatingLeadId");
				this.SetAttributeValue("originatingleadid", value);
				this.OnPropertyChanged("OriginatingLeadId");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Select the account's ownership structure, such as public or private.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownershipcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue OwnershipCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("ownershipcode");
			}
			set
			{
				this.OnPropertyChanging("OwnershipCode");
				this.SetAttributeValue("ownershipcode", value);
				this.OnPropertyChanged("OwnershipCode");
			}
		}
		
		/// <summary>
		/// Shows the business unit that the record owner belongs to.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier of the team who owns the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who owns the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Choose the parent account associated with this account to show parent and child businesses in reporting and analytics.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentAccountId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentaccountid");
			}
			set
			{
				this.OnPropertyChanging("ParentAccountId");
				this.SetAttributeValue("parentaccountid", value);
				this.OnPropertyChanged("ParentAccountId");
			}
		}
		
		/// <summary>
		/// For system use only. Legacy Microsoft Dynamics CRM 3.0 workflow data.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participatesinworkflow")]
		public System.Nullable<bool> ParticipatesInWorkflow
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("participatesinworkflow");
			}
			set
			{
				this.OnPropertyChanging("ParticipatesInWorkflow");
				this.SetAttributeValue("participatesinworkflow", value);
				this.OnPropertyChanged("ParticipatesInWorkflow");
			}
		}
		
		/// <summary>
		/// Select the payment terms to indicate when the customer needs to pay the total amount.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("paymenttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PaymentTermsCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("paymenttermscode");
			}
			set
			{
				this.OnPropertyChanging("PaymentTermsCode");
				this.SetAttributeValue("paymenttermscode", value);
				this.OnPropertyChanged("PaymentTermsCode");
			}
		}
		
		/// <summary>
		/// Select the preferred day of the week for service appointments.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmentdaycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredAppointmentDayCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmentdaycode");
			}
			set
			{
				this.OnPropertyChanging("PreferredAppointmentDayCode");
				this.SetAttributeValue("preferredappointmentdaycode", value);
				this.OnPropertyChanged("PreferredAppointmentDayCode");
			}
		}
		
		/// <summary>
		/// Select the preferred time of day for service appointments.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmenttimecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredAppointmentTimeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmenttimecode");
			}
			set
			{
				this.OnPropertyChanging("PreferredAppointmentTimeCode");
				this.SetAttributeValue("preferredappointmenttimecode", value);
				this.OnPropertyChanged("PreferredAppointmentTimeCode");
			}
		}
		
		/// <summary>
		/// Select the preferred method of contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredcontactmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredContactMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredcontactmethodcode");
			}
			set
			{
				this.OnPropertyChanging("PreferredContactMethodCode");
				this.SetAttributeValue("preferredcontactmethodcode", value);
				this.OnPropertyChanged("PreferredContactMethodCode");
			}
		}
		
		/// <summary>
		/// Choose the account's preferred service facility or equipment to make sure services are scheduled correctly for the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredequipmentid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredEquipmentId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredequipmentid");
			}
			set
			{
				this.OnPropertyChanging("PreferredEquipmentId");
				this.SetAttributeValue("preferredequipmentid", value);
				this.OnPropertyChanged("PreferredEquipmentId");
			}
		}
		
		/// <summary>
		/// Choose the account's preferred service for reference when you schedule service activities.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredserviceid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredServiceId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredserviceid");
			}
			set
			{
				this.OnPropertyChanging("PreferredServiceId");
				this.SetAttributeValue("preferredserviceid", value);
				this.OnPropertyChanged("PreferredServiceId");
			}
		}
		
		/// <summary>
		/// Choose the preferred service representative for reference when you schedule service activities for the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredsystemuserid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredSystemUserId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredsystemuserid");
			}
			set
			{
				this.OnPropertyChanging("PreferredSystemUserId");
				this.SetAttributeValue("preferredsystemuserid", value);
				this.OnPropertyChanged("PreferredSystemUserId");
			}
		}
		
		/// <summary>
		/// Choose the primary contact for the account to provide quick access to contact details.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarycontactid")]
		public Microsoft.Xrm.Sdk.EntityReference PrimaryContactId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("primarycontactid");
			}
			set
			{
				this.OnPropertyChanging("PrimaryContactId");
				this.SetAttributeValue("primarycontactid", value);
				this.OnPropertyChanged("PrimaryContactId");
			}
		}
		
		/// <summary>
		/// Primary Satori ID for Account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarysatoriid")]
		public string PrimarySatoriId
		{
			get
			{
				return this.GetAttributeValue<string>("primarysatoriid");
			}
			set
			{
				this.OnPropertyChanging("PrimarySatoriId");
				this.SetAttributeValue("primarysatoriid", value);
				this.OnPropertyChanged("PrimarySatoriId");
			}
		}
		
		/// <summary>
		/// Primary Twitter ID for Account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarytwitterid")]
		public string PrimaryTwitterId
		{
			get
			{
				return this.GetAttributeValue<string>("primarytwitterid");
			}
			set
			{
				this.OnPropertyChanging("PrimaryTwitterId");
				this.SetAttributeValue("primarytwitterid", value);
				this.OnPropertyChanged("PrimaryTwitterId");
			}
		}
		
		/// <summary>
		/// Shows the ID of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public System.Nullable<System.Guid> ProcessId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
			}
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
		
		/// <summary>
		/// Type the annual revenue for the account, used as an indicator in financial performance analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("revenue")]
		public Microsoft.Xrm.Sdk.Money Revenue
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("revenue");
			}
			set
			{
				this.OnPropertyChanging("Revenue");
				this.SetAttributeValue("revenue", value);
				this.OnPropertyChanged("Revenue");
			}
		}
		
		/// <summary>
		/// Shows the annual revenue converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("revenue_base")]
		public Microsoft.Xrm.Sdk.Money Revenue_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("revenue_base");
			}
		}
		
		/// <summary>
		/// Type the number of shares available to the public for the account. This number is used as an indicator in financial performance analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharesoutstanding")]
		public System.Nullable<int> SharesOutstanding
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("sharesoutstanding");
			}
			set
			{
				this.OnPropertyChanging("SharesOutstanding");
				this.SetAttributeValue("sharesoutstanding", value);
				this.OnPropertyChanged("SharesOutstanding");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to the account's address to designate the preferred carrier or other delivery option.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue ShippingMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("shippingmethodcode");
			}
			set
			{
				this.OnPropertyChanging("ShippingMethodCode");
				this.SetAttributeValue("shippingmethodcode", value);
				this.OnPropertyChanged("ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// Type the Standard Industrial Classification (SIC) code that indicates the account's primary industry of business, for use in marketing segmentation and demographic analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sic")]
		public string SIC
		{
			get
			{
				return this.GetAttributeValue<string>("sic");
			}
			set
			{
				this.OnPropertyChanging("SIC");
				this.SetAttributeValue("sic", value);
				this.OnPropertyChanged("SIC");
			}
		}
		
		/// <summary>
		/// Choose the service level agreement (SLA) that you want to apply to the Account record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slaid");
			}
			set
			{
				this.OnPropertyChanging("SLAId");
				this.SetAttributeValue("slaid", value);
				this.OnPropertyChanged("SLAId");
			}
		}
		
		/// <summary>
		/// Last SLA that was applied to this case. This field is for internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slainvokedid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAInvokedId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slainvokedid");
			}
		}
		
		/// <summary>
		/// Shows the ID of the stage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
		public System.Nullable<System.Guid> StageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
			}
			set
			{
				this.OnPropertyChanging("StageId");
				this.SetAttributeValue("stageid", value);
				this.OnPropertyChanged("StageId");
			}
		}
		
		/// <summary>
		/// Shows whether the account is active or inactive. Inactive accounts are read-only and can't be edited unless they are reactivated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<AccountState> StateCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((AccountState)(System.Enum.ToObject(typeof(AccountState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("StateCode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Select the account's status.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// Type the stock exchange at which the account is listed to track their stock and financial performance of the company.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stockexchange")]
		public string StockExchange
		{
			get
			{
				return this.GetAttributeValue<string>("stockexchange");
			}
			set
			{
				this.OnPropertyChanging("StockExchange");
				this.SetAttributeValue("stockexchange", value);
				this.OnPropertyChanged("StockExchange");
			}
		}
		
		/// <summary>
		/// Number of users or conversations followed the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamsfollowed")]
		public System.Nullable<int> TeamsFollowed
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("teamsfollowed");
			}
			set
			{
				this.OnPropertyChanging("TeamsFollowed");
				this.SetAttributeValue("teamsfollowed", value);
				this.OnPropertyChanged("TeamsFollowed");
			}
		}
		
		/// <summary>
		/// Type the main phone number for this account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone1")]
		public string Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("telephone1");
			}
			set
			{
				this.OnPropertyChanging("Telephone1");
				this.SetAttributeValue("telephone1", value);
				this.OnPropertyChanged("Telephone1");
			}
		}
		
		/// <summary>
		/// Type a second phone number for this account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone2")]
		public string Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("telephone2");
			}
			set
			{
				this.OnPropertyChanging("Telephone2");
				this.SetAttributeValue("telephone2", value);
				this.OnPropertyChanged("Telephone2");
			}
		}
		
		/// <summary>
		/// Type a third phone number for this account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone3")]
		public string Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("telephone3");
			}
			set
			{
				this.OnPropertyChanging("Telephone3");
				this.SetAttributeValue("telephone3", value);
				this.OnPropertyChanged("Telephone3");
			}
		}
		
		/// <summary>
		/// Select a region or territory for the account for use in segmentation and analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territorycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue TerritoryCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("territorycode");
			}
			set
			{
				this.OnPropertyChanging("TerritoryCode");
				this.SetAttributeValue("territorycode", value);
				this.OnPropertyChanged("TerritoryCode");
			}
		}
		
		/// <summary>
		/// Choose the sales region or territory for the account to make sure the account is assigned to the correct representative and for use in segmentation and analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territoryid")]
		public Microsoft.Xrm.Sdk.EntityReference TerritoryId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("territoryid");
			}
			set
			{
				this.OnPropertyChanging("TerritoryId");
				this.SetAttributeValue("territoryid", value);
				this.OnPropertyChanged("TerritoryId");
			}
		}
		
		/// <summary>
		/// Type the stock exchange symbol for the account to track financial performance of the company. You can click the code entered in this field to access the latest trading information from MSN Money.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tickersymbol")]
		public string TickerSymbol
		{
			get
			{
				return this.GetAttributeValue<string>("tickersymbol");
			}
			set
			{
				this.OnPropertyChanging("TickerSymbol");
				this.SetAttributeValue("tickersymbol", value);
				this.OnPropertyChanged("TickerSymbol");
			}
		}
		
		/// <summary>
		/// Total time spent for emails (read and write) and meetings by me in relation to account record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timespentbymeonemailandmeetings")]
		public string TimeSpentByMeOnEmailAndMeetings
		{
			get
			{
				return this.GetAttributeValue<string>("timespentbymeonemailandmeetings");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Choose the local currency for the record to make sure budgets are reported in the correct currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			set
			{
				this.OnPropertyChanging("TraversedPath");
				this.SetAttributeValue("traversedpath", value);
				this.OnPropertyChanged("TraversedPath");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version number of the account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// Type the account's website URL to get quick details about the company profile.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("websiteurl")]
		public string WebSiteURL
		{
			get
			{
				return this.GetAttributeValue<string>("websiteurl");
			}
			set
			{
				this.OnPropertyChanging("WebSiteURL");
				this.SetAttributeValue("websiteurl", value);
				this.OnPropertyChanged("WebSiteURL");
			}
		}
		
		/// <summary>
		/// Type the phonetic spelling of the company name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yominame")]
		public string YomiName
		{
			get
			{
				return this.GetAttributeValue<string>("yominame");
			}
			set
			{
				this.OnPropertyChanging("YomiName");
				this.SetAttributeValue("yominame", value);
				this.OnPropertyChanged("YomiName");
			}
		}
		
		/// <summary>
		/// 1:N account_master_account
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<Account> Referencedaccount_master_account
		{
			get
			{
				return this.GetRelatedEntities<Account>("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedaccount_master_account");
				this.SetRelatedEntities<Account>("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedaccount_master_account");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_account_account_BillingAccount
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<Account> Referencedmsdyn_account_account_BillingAccount
		{
			get
			{
				return this.GetRelatedEntities<Account>("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedmsdyn_account_account_BillingAccount");
				this.SetRelatedEntities<Account>("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedmsdyn_account_account_BillingAccount");
			}
		}
		
		/// <summary>
		/// 1:N account_parent_account
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<Account> Referencedaccount_parent_account
		{
			get
			{
				return this.GetRelatedEntities<Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedaccount_parent_account");
				this.SetRelatedEntities<Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedaccount_parent_account");
			}
		}
		
		/// <summary>
		/// 1:N contact_customer_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_accounts")]
		public System.Collections.Generic.IEnumerable<Contact> contact_customer_accounts
		{
			get
			{
				return this.GetRelatedEntities<Contact>("contact_customer_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("contact_customer_accounts");
				this.SetRelatedEntities<Contact>("contact_customer_accounts", null, value);
				this.OnPropertyChanged("contact_customer_accounts");
			}
		}
		
		/// <summary>
		/// 1:N account_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_activity_parties")]
		public System.Collections.Generic.IEnumerable<ActivityParty> account_activity_parties
		{
			get
			{
				return this.GetRelatedEntities<ActivityParty>("account_activity_parties", null);
			}
			set
			{
				this.OnPropertyChanging("account_activity_parties");
				this.SetRelatedEntities<ActivityParty>("account_activity_parties", null, value);
				this.OnPropertyChanged("account_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 account_master_account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public Account Referencingaccount_master_account
		{
			get
			{
				return this.GetRelatedEntity<Account>("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
		}
		
		/// <summary>
		/// N:1 msdyn_account_account_BillingAccount
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_billingaccount")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public Account Referencingmsdyn_account_account_BillingAccount
		{
			get
			{
				return this.GetRelatedEntity<Account>("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.OnPropertyChanging("Referencingmsdyn_account_account_BillingAccount");
				this.SetRelatedEntity<Account>("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingmsdyn_account_account_BillingAccount");
			}
		}
		
		/// <summary>
		/// N:1 account_parent_account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public Account Referencingaccount_parent_account
		{
			get
			{
				return this.GetRelatedEntity<Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.OnPropertyChanging("Referencingaccount_parent_account");
				this.SetRelatedEntity<Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingaccount_parent_account");
			}
		}
		
		/// <summary>
		/// N:1 account_primary_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarycontactid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_primary_contact")]
		public Contact account_primary_contact
		{
			get
			{
				return this.GetRelatedEntity<Contact>("account_primary_contact", null);
			}
			set
			{
				this.OnPropertyChanging("account_primary_contact");
				this.SetRelatedEntity<Contact>("account_primary_contact", null, value);
				this.OnPropertyChanged("account_primary_contact");
			}
		}
	}

	/// <summary>
	/// Person or group associated with an activity. An activity can have multiple activity parties.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("activityparty")]
	public partial class ActivityParty : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public ActivityParty() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "activityparty";
		
		public const int EntityTypeCode = 135;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitypartyid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ActivityPartyId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the activity associated with the activity party. (A "party" is any person who is associated with an activity.)
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		public Microsoft.Xrm.Sdk.EntityReference ActivityId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("activityid");
			}
			set
			{
				this.OnPropertyChanging("ActivityId");
				this.SetAttributeValue("activityid", value);
				this.OnPropertyChanged("ActivityId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the activity party.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitypartyid")]
		public System.Nullable<System.Guid> ActivityPartyId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("activitypartyid");
			}
			set
			{
				this.OnPropertyChanging("ActivityPartyId");
				this.SetAttributeValue("activitypartyid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ActivityPartyId");
			}
		}
		
		/// <summary>
		/// Email address to which an email is delivered, and which is associated with the target entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addressused")]
		public string AddressUsed
		{
			get
			{
				return this.GetAttributeValue<string>("addressused");
			}
			set
			{
				this.OnPropertyChanging("AddressUsed");
				this.SetAttributeValue("addressused", value);
				this.OnPropertyChanged("AddressUsed");
			}
		}
		
		/// <summary>
		/// Email address column number from associated party.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addressusedemailcolumnnumber")]
		public System.Nullable<int> AddressUsedEmailColumnNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("addressusedemailcolumnnumber");
			}
		}
		
		/// <summary>
		/// Information about whether to allow sending email to the activity party.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
		public System.Nullable<bool> DoNotEmail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotemail");
			}
		}
		
		/// <summary>
		/// Information about whether to allow sending faxes to the activity party.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
		public System.Nullable<bool> DoNotFax
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotfax");
			}
		}
		
		/// <summary>
		/// Information about whether to allow phone calls to the lead.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
		public System.Nullable<bool> DoNotPhone
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotphone");
			}
		}
		
		/// <summary>
		/// Information about whether to allow sending postal mail to the lead.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
		public System.Nullable<bool> DoNotPostalMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail");
			}
		}
		
		/// <summary>
		/// Amount of effort used by the resource in a service appointment activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effort")]
		public System.Nullable<double> Effort
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("effort");
			}
			set
			{
				this.OnPropertyChanging("Effort");
				this.SetAttributeValue("effort", value);
				this.OnPropertyChanged("Effort");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangeentryid")]
		public string ExchangeEntryId
		{
			get
			{
				return this.GetAttributeValue<string>("exchangeentryid");
			}
			set
			{
				this.OnPropertyChanging("ExchangeEntryId");
				this.SetAttributeValue("exchangeentryid", value);
				this.OnPropertyChanged("ExchangeEntryId");
			}
		}
		
		/// <summary>
		/// Type of instance of a recurring series.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("instancetypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue InstanceTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("instancetypecode");
			}
		}
		
		/// <summary>
		/// Information about whether the underlying entity record is deleted.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ispartydeleted")]
		public System.Nullable<bool> IsPartyDeleted
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ispartydeleted");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user or team who owns the activity_party.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public System.Nullable<System.Guid> OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public System.Nullable<System.Guid> OwningUser
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("owninguser");
			}
		}
		
		/// <summary>
		/// Role of the person in the activity, such as sender, to, cc, bcc, required, optional, organizer, regarding, or owner.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participationtypemask")]
		public Microsoft.Xrm.Sdk.OptionSetValue ParticipationTypeMask
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("participationtypemask");
			}
			set
			{
				this.OnPropertyChanging("ParticipationTypeMask");
				this.SetAttributeValue("participationtypemask", value);
				this.OnPropertyChanged("ParticipationTypeMask");
			}
		}
		
		/// <summary>
		/// Unique identifier of the party associated with the activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		public Microsoft.Xrm.Sdk.EntityReference PartyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("partyid");
			}
			set
			{
				this.OnPropertyChanging("PartyId");
				this.SetAttributeValue("partyid", value);
				this.OnPropertyChanged("PartyId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the resource specification for the activity party.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourcespecid")]
		public Microsoft.Xrm.Sdk.EntityReference ResourceSpecId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("resourcespecid");
			}
			set
			{
				this.OnPropertyChanging("ResourceSpecId");
				this.SetAttributeValue("resourcespecid", value);
				this.OnPropertyChanged("ResourceSpecId");
			}
		}
		
		/// <summary>
		/// Scheduled end time of the activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledend")]
		public System.Nullable<System.DateTime> ScheduledEnd
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledend");
			}
		}
		
		/// <summary>
		/// Scheduled start time of the activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledstart")]
		public System.Nullable<System.DateTime> ScheduledStart
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledstart");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// N:1 account_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_activity_parties")]
		public Account account_activity_parties
		{
			get
			{
				return this.GetRelatedEntity<Account>("account_activity_parties", null);
			}
			set
			{
				this.OnPropertyChanging("account_activity_parties");
				this.SetRelatedEntity<Account>("account_activity_parties", null, value);
				this.OnPropertyChanged("account_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 contact_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_activity_parties")]
		public Contact contact_activity_parties
		{
			get
			{
				return this.GetRelatedEntity<Contact>("contact_activity_parties", null);
			}
			set
			{
				this.OnPropertyChanging("contact_activity_parties");
				this.SetRelatedEntity<Contact>("contact_activity_parties", null, value);
				this.OnPropertyChanged("contact_activity_parties");
			}
		}
	}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum ContactState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}

	/// <summary>
	/// Person with whom a business unit has a relationship, such as customer, supplier, and colleague.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("contact")]
	public partial class Contact : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public Contact() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "contact";
		
		public const int EntityTypeCode = 2;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ContactId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the account with which the contact is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
		public Microsoft.Xrm.Sdk.EntityReference AccountId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("accountid");
			}
		}
		
		/// <summary>
		/// Select the contact's role within the company or sales process, such as decision maker, employee, or influencer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountrolecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue AccountRoleCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountrolecode");
			}
			set
			{
				this.OnPropertyChanging("AccountRoleCode");
				this.SetAttributeValue("accountrolecode", value);
				this.OnPropertyChanged("AccountRoleCode");
			}
		}
		
		/// <summary>
		/// Unique identifier for address 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addressid")]
		public System.Nullable<System.Guid> Address1_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address1_addressid");
			}
			set
			{
				this.OnPropertyChanging("Address1_AddressId");
				this.SetAttributeValue("address1_addressid", value);
				this.OnPropertyChanged("Address1_AddressId");
			}
		}
		
		/// <summary>
		/// Select the primary address type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_AddressTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_addresstypecode");
			}
			set
			{
				this.OnPropertyChanging("Address1_AddressTypeCode");
				this.SetAttributeValue("address1_addresstypecode", value);
				this.OnPropertyChanged("Address1_AddressTypeCode");
			}
		}
		
		/// <summary>
		/// Type the city for the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_city")]
		public string Address1_City
		{
			get
			{
				return this.GetAttributeValue<string>("address1_city");
			}
			set
			{
				this.OnPropertyChanging("Address1_City");
				this.SetAttributeValue("address1_city", value);
				this.OnPropertyChanged("Address1_City");
			}
		}
		
		/// <summary>
		/// Shows the complete primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_composite")]
		public string Address1_Composite
		{
			get
			{
				return this.GetAttributeValue<string>("address1_composite");
			}
		}
		
		/// <summary>
		/// Type the country or region for the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_country")]
		public string Address1_Country
		{
			get
			{
				return this.GetAttributeValue<string>("address1_country");
			}
			set
			{
				this.OnPropertyChanging("Address1_Country");
				this.SetAttributeValue("address1_country", value);
				this.OnPropertyChanged("Address1_Country");
			}
		}
		
		/// <summary>
		/// Type the county for the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_county")]
		public string Address1_County
		{
			get
			{
				return this.GetAttributeValue<string>("address1_county");
			}
			set
			{
				this.OnPropertyChanging("Address1_County");
				this.SetAttributeValue("address1_county", value);
				this.OnPropertyChanged("Address1_County");
			}
		}
		
		/// <summary>
		/// Type the fax number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_fax")]
		public string Address1_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("address1_fax");
			}
			set
			{
				this.OnPropertyChanging("Address1_Fax");
				this.SetAttributeValue("address1_fax", value);
				this.OnPropertyChanged("Address1_Fax");
			}
		}
		
		/// <summary>
		/// Select the freight terms for the primary address to make sure shipping orders are processed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_freighttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_FreightTermsCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_freighttermscode");
			}
			set
			{
				this.OnPropertyChanging("Address1_FreightTermsCode");
				this.SetAttributeValue("address1_freighttermscode", value);
				this.OnPropertyChanged("Address1_FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Type the latitude value for the primary address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_latitude")]
		public System.Nullable<double> Address1_Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_latitude");
			}
			set
			{
				this.OnPropertyChanging("Address1_Latitude");
				this.SetAttributeValue("address1_latitude", value);
				this.OnPropertyChanged("Address1_Latitude");
			}
		}
		
		/// <summary>
		/// Type the first line of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line1")]
		public string Address1_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line1");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line1");
				this.SetAttributeValue("address1_line1", value);
				this.OnPropertyChanged("Address1_Line1");
			}
		}
		
		/// <summary>
		/// Type the second line of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line2")]
		public string Address1_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line2");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line2");
				this.SetAttributeValue("address1_line2", value);
				this.OnPropertyChanged("Address1_Line2");
			}
		}
		
		/// <summary>
		/// Type the third line of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line3")]
		public string Address1_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line3");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line3");
				this.SetAttributeValue("address1_line3", value);
				this.OnPropertyChanged("Address1_Line3");
			}
		}
		
		/// <summary>
		/// Type the longitude value for the primary address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_longitude")]
		public System.Nullable<double> Address1_Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_longitude");
			}
			set
			{
				this.OnPropertyChanging("Address1_Longitude");
				this.SetAttributeValue("address1_longitude", value);
				this.OnPropertyChanged("Address1_Longitude");
			}
		}
		
		/// <summary>
		/// Type a descriptive name for the primary address, such as Corporate Headquarters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_name")]
		public string Address1_Name
		{
			get
			{
				return this.GetAttributeValue<string>("address1_name");
			}
			set
			{
				this.OnPropertyChanging("Address1_Name");
				this.SetAttributeValue("address1_name", value);
				this.OnPropertyChanged("Address1_Name");
			}
		}
		
		/// <summary>
		/// Type the ZIP Code or postal code for the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postalcode")]
		public string Address1_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("address1_postalcode");
			}
			set
			{
				this.OnPropertyChanging("Address1_PostalCode");
				this.SetAttributeValue("address1_postalcode", value);
				this.OnPropertyChanged("Address1_PostalCode");
			}
		}
		
		/// <summary>
		/// Type the post office box number of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postofficebox")]
		public string Address1_PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("address1_postofficebox");
			}
			set
			{
				this.OnPropertyChanging("Address1_PostOfficeBox");
				this.SetAttributeValue("address1_postofficebox", value);
				this.OnPropertyChanged("Address1_PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Type the name of the main contact at the account's primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_primarycontactname")]
		public string Address1_PrimaryContactName
		{
			get
			{
				return this.GetAttributeValue<string>("address1_primarycontactname");
			}
			set
			{
				this.OnPropertyChanging("Address1_PrimaryContactName");
				this.SetAttributeValue("address1_primarycontactname", value);
				this.OnPropertyChanged("Address1_PrimaryContactName");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_ShippingMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_shippingmethodcode");
			}
			set
			{
				this.OnPropertyChanging("Address1_ShippingMethodCode");
				this.SetAttributeValue("address1_shippingmethodcode", value);
				this.OnPropertyChanged("Address1_ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// Type the state or province of the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_stateorprovince")]
		public string Address1_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("address1_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("Address1_StateOrProvince");
				this.SetAttributeValue("address1_stateorprovince", value);
				this.OnPropertyChanged("Address1_StateOrProvince");
			}
		}
		
		/// <summary>
		/// Type the main phone number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone1")]
		public string Address1_Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone1");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone1");
				this.SetAttributeValue("address1_telephone1", value);
				this.OnPropertyChanged("Address1_Telephone1");
			}
		}
		
		/// <summary>
		/// Type a second phone number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone2")]
		public string Address1_Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone2");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone2");
				this.SetAttributeValue("address1_telephone2", value);
				this.OnPropertyChanged("Address1_Telephone2");
			}
		}
		
		/// <summary>
		/// Type a third phone number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone3")]
		public string Address1_Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone3");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone3");
				this.SetAttributeValue("address1_telephone3", value);
				this.OnPropertyChanged("Address1_Telephone3");
			}
		}
		
		/// <summary>
		/// Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_upszone")]
		public string Address1_UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("address1_upszone");
			}
			set
			{
				this.OnPropertyChanging("Address1_UPSZone");
				this.SetAttributeValue("address1_upszone", value);
				this.OnPropertyChanged("Address1_UPSZone");
			}
		}
		
		/// <summary>
		/// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_utcoffset")]
		public System.Nullable<int> Address1_UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address1_utcoffset");
			}
			set
			{
				this.OnPropertyChanging("Address1_UTCOffset");
				this.SetAttributeValue("address1_utcoffset", value);
				this.OnPropertyChanged("Address1_UTCOffset");
			}
		}
		
		/// <summary>
		/// Unique identifier for address 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addressid")]
		public System.Nullable<System.Guid> Address2_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address2_addressid");
			}
			set
			{
				this.OnPropertyChanging("Address2_AddressId");
				this.SetAttributeValue("address2_addressid", value);
				this.OnPropertyChanged("Address2_AddressId");
			}
		}
		
		/// <summary>
		/// Select the secondary address type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_AddressTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_addresstypecode");
			}
			set
			{
				this.OnPropertyChanging("Address2_AddressTypeCode");
				this.SetAttributeValue("address2_addresstypecode", value);
				this.OnPropertyChanged("Address2_AddressTypeCode");
			}
		}
		
		/// <summary>
		/// Type the city for the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_city")]
		public string Address2_City
		{
			get
			{
				return this.GetAttributeValue<string>("address2_city");
			}
			set
			{
				this.OnPropertyChanging("Address2_City");
				this.SetAttributeValue("address2_city", value);
				this.OnPropertyChanged("Address2_City");
			}
		}
		
		/// <summary>
		/// Shows the complete secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_composite")]
		public string Address2_Composite
		{
			get
			{
				return this.GetAttributeValue<string>("address2_composite");
			}
		}
		
		/// <summary>
		/// Type the country or region for the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_country")]
		public string Address2_Country
		{
			get
			{
				return this.GetAttributeValue<string>("address2_country");
			}
			set
			{
				this.OnPropertyChanging("Address2_Country");
				this.SetAttributeValue("address2_country", value);
				this.OnPropertyChanged("Address2_Country");
			}
		}
		
		/// <summary>
		/// Type the county for the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_county")]
		public string Address2_County
		{
			get
			{
				return this.GetAttributeValue<string>("address2_county");
			}
			set
			{
				this.OnPropertyChanging("Address2_County");
				this.SetAttributeValue("address2_county", value);
				this.OnPropertyChanged("Address2_County");
			}
		}
		
		/// <summary>
		/// Type the fax number associated with the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_fax")]
		public string Address2_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("address2_fax");
			}
			set
			{
				this.OnPropertyChanging("Address2_Fax");
				this.SetAttributeValue("address2_fax", value);
				this.OnPropertyChanged("Address2_Fax");
			}
		}
		
		/// <summary>
		/// Select the freight terms for the secondary address to make sure shipping orders are processed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_freighttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_FreightTermsCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_freighttermscode");
			}
			set
			{
				this.OnPropertyChanging("Address2_FreightTermsCode");
				this.SetAttributeValue("address2_freighttermscode", value);
				this.OnPropertyChanged("Address2_FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Type the latitude value for the secondary address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_latitude")]
		public System.Nullable<double> Address2_Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_latitude");
			}
			set
			{
				this.OnPropertyChanging("Address2_Latitude");
				this.SetAttributeValue("address2_latitude", value);
				this.OnPropertyChanged("Address2_Latitude");
			}
		}
		
		/// <summary>
		/// Type the first line of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line1")]
		public string Address2_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line1");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line1");
				this.SetAttributeValue("address2_line1", value);
				this.OnPropertyChanged("Address2_Line1");
			}
		}
		
		/// <summary>
		/// Type the second line of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line2")]
		public string Address2_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line2");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line2");
				this.SetAttributeValue("address2_line2", value);
				this.OnPropertyChanged("Address2_Line2");
			}
		}
		
		/// <summary>
		/// Type the third line of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line3")]
		public string Address2_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line3");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line3");
				this.SetAttributeValue("address2_line3", value);
				this.OnPropertyChanged("Address2_Line3");
			}
		}
		
		/// <summary>
		/// Type the longitude value for the secondary address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_longitude")]
		public System.Nullable<double> Address2_Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_longitude");
			}
			set
			{
				this.OnPropertyChanging("Address2_Longitude");
				this.SetAttributeValue("address2_longitude", value);
				this.OnPropertyChanged("Address2_Longitude");
			}
		}
		
		/// <summary>
		/// Type a descriptive name for the secondary address, such as Corporate Headquarters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_name")]
		public string Address2_Name
		{
			get
			{
				return this.GetAttributeValue<string>("address2_name");
			}
			set
			{
				this.OnPropertyChanging("Address2_Name");
				this.SetAttributeValue("address2_name", value);
				this.OnPropertyChanged("Address2_Name");
			}
		}
		
		/// <summary>
		/// Type the ZIP Code or postal code for the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postalcode")]
		public string Address2_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("address2_postalcode");
			}
			set
			{
				this.OnPropertyChanging("Address2_PostalCode");
				this.SetAttributeValue("address2_postalcode", value);
				this.OnPropertyChanged("Address2_PostalCode");
			}
		}
		
		/// <summary>
		/// Type the post office box number of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postofficebox")]
		public string Address2_PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("address2_postofficebox");
			}
			set
			{
				this.OnPropertyChanging("Address2_PostOfficeBox");
				this.SetAttributeValue("address2_postofficebox", value);
				this.OnPropertyChanged("Address2_PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Type the name of the main contact at the account's secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_primarycontactname")]
		public string Address2_PrimaryContactName
		{
			get
			{
				return this.GetAttributeValue<string>("address2_primarycontactname");
			}
			set
			{
				this.OnPropertyChanging("Address2_PrimaryContactName");
				this.SetAttributeValue("address2_primarycontactname", value);
				this.OnPropertyChanged("Address2_PrimaryContactName");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_ShippingMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_shippingmethodcode");
			}
			set
			{
				this.OnPropertyChanging("Address2_ShippingMethodCode");
				this.SetAttributeValue("address2_shippingmethodcode", value);
				this.OnPropertyChanged("Address2_ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// Type the state or province of the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_stateorprovince")]
		public string Address2_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("address2_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("Address2_StateOrProvince");
				this.SetAttributeValue("address2_stateorprovince", value);
				this.OnPropertyChanged("Address2_StateOrProvince");
			}
		}
		
		/// <summary>
		/// Type the main phone number associated with the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone1")]
		public string Address2_Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone1");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone1");
				this.SetAttributeValue("address2_telephone1", value);
				this.OnPropertyChanged("Address2_Telephone1");
			}
		}
		
		/// <summary>
		/// Type a second phone number associated with the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone2")]
		public string Address2_Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone2");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone2");
				this.SetAttributeValue("address2_telephone2", value);
				this.OnPropertyChanged("Address2_Telephone2");
			}
		}
		
		/// <summary>
		/// Type a third phone number associated with the secondary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone3")]
		public string Address2_Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone3");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone3");
				this.SetAttributeValue("address2_telephone3", value);
				this.OnPropertyChanged("Address2_Telephone3");
			}
		}
		
		/// <summary>
		/// Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_upszone")]
		public string Address2_UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("address2_upszone");
			}
			set
			{
				this.OnPropertyChanging("Address2_UPSZone");
				this.SetAttributeValue("address2_upszone", value);
				this.OnPropertyChanged("Address2_UPSZone");
			}
		}
		
		/// <summary>
		/// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_utcoffset")]
		public System.Nullable<int> Address2_UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address2_utcoffset");
			}
			set
			{
				this.OnPropertyChanging("Address2_UTCOffset");
				this.SetAttributeValue("address2_utcoffset", value);
				this.OnPropertyChanged("Address2_UTCOffset");
			}
		}
		
		/// <summary>
		/// Unique identifier for address 3.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_addressid")]
		public System.Nullable<System.Guid> Address3_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address3_addressid");
			}
			set
			{
				this.OnPropertyChanging("Address3_AddressId");
				this.SetAttributeValue("address3_addressid", value);
				this.OnPropertyChanged("Address3_AddressId");
			}
		}
		
		/// <summary>
		/// Select the third address type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address3_AddressTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address3_addresstypecode");
			}
			set
			{
				this.OnPropertyChanging("Address3_AddressTypeCode");
				this.SetAttributeValue("address3_addresstypecode", value);
				this.OnPropertyChanged("Address3_AddressTypeCode");
			}
		}
		
		/// <summary>
		/// Type the city for the 3rd address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_city")]
		public string Address3_City
		{
			get
			{
				return this.GetAttributeValue<string>("address3_city");
			}
			set
			{
				this.OnPropertyChanging("Address3_City");
				this.SetAttributeValue("address3_city", value);
				this.OnPropertyChanged("Address3_City");
			}
		}
		
		/// <summary>
		/// Shows the complete third address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_composite")]
		public string Address3_Composite
		{
			get
			{
				return this.GetAttributeValue<string>("address3_composite");
			}
		}
		
		/// <summary>
		/// the country or region for the 3rd address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_country")]
		public string Address3_Country
		{
			get
			{
				return this.GetAttributeValue<string>("address3_country");
			}
			set
			{
				this.OnPropertyChanging("Address3_Country");
				this.SetAttributeValue("address3_country", value);
				this.OnPropertyChanged("Address3_Country");
			}
		}
		
		/// <summary>
		/// Type the county for the third address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_county")]
		public string Address3_County
		{
			get
			{
				return this.GetAttributeValue<string>("address3_county");
			}
			set
			{
				this.OnPropertyChanging("Address3_County");
				this.SetAttributeValue("address3_county", value);
				this.OnPropertyChanged("Address3_County");
			}
		}
		
		/// <summary>
		/// Type the fax number associated with the third address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_fax")]
		public string Address3_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("address3_fax");
			}
			set
			{
				this.OnPropertyChanging("Address3_Fax");
				this.SetAttributeValue("address3_fax", value);
				this.OnPropertyChanged("Address3_Fax");
			}
		}
		
		/// <summary>
		/// Select the freight terms for the third address to make sure shipping orders are processed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_freighttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address3_FreightTermsCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address3_freighttermscode");
			}
			set
			{
				this.OnPropertyChanging("Address3_FreightTermsCode");
				this.SetAttributeValue("address3_freighttermscode", value);
				this.OnPropertyChanged("Address3_FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Type the latitude value for the third address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_latitude")]
		public System.Nullable<double> Address3_Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address3_latitude");
			}
			set
			{
				this.OnPropertyChanging("Address3_Latitude");
				this.SetAttributeValue("address3_latitude", value);
				this.OnPropertyChanged("Address3_Latitude");
			}
		}
		
		/// <summary>
		/// the first line of the 3rd address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_line1")]
		public string Address3_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("address3_line1");
			}
			set
			{
				this.OnPropertyChanging("Address3_Line1");
				this.SetAttributeValue("address3_line1", value);
				this.OnPropertyChanged("Address3_Line1");
			}
		}
		
		/// <summary>
		/// the second line of the 3rd address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_line2")]
		public string Address3_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("address3_line2");
			}
			set
			{
				this.OnPropertyChanging("Address3_Line2");
				this.SetAttributeValue("address3_line2", value);
				this.OnPropertyChanged("Address3_Line2");
			}
		}
		
		/// <summary>
		/// the third line of the 3rd address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_line3")]
		public string Address3_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("address3_line3");
			}
			set
			{
				this.OnPropertyChanging("Address3_Line3");
				this.SetAttributeValue("address3_line3", value);
				this.OnPropertyChanged("Address3_Line3");
			}
		}
		
		/// <summary>
		/// Type the longitude value for the third address for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_longitude")]
		public System.Nullable<double> Address3_Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address3_longitude");
			}
			set
			{
				this.OnPropertyChanging("Address3_Longitude");
				this.SetAttributeValue("address3_longitude", value);
				this.OnPropertyChanged("Address3_Longitude");
			}
		}
		
		/// <summary>
		/// Type a descriptive name for the third address, such as Corporate Headquarters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_name")]
		public string Address3_Name
		{
			get
			{
				return this.GetAttributeValue<string>("address3_name");
			}
			set
			{
				this.OnPropertyChanging("Address3_Name");
				this.SetAttributeValue("address3_name", value);
				this.OnPropertyChanged("Address3_Name");
			}
		}
		
		/// <summary>
		/// the ZIP Code or postal code for the 3rd address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_postalcode")]
		public string Address3_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("address3_postalcode");
			}
			set
			{
				this.OnPropertyChanging("Address3_PostalCode");
				this.SetAttributeValue("address3_postalcode", value);
				this.OnPropertyChanged("Address3_PostalCode");
			}
		}
		
		/// <summary>
		/// the post office box number of the 3rd address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_postofficebox")]
		public string Address3_PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("address3_postofficebox");
			}
			set
			{
				this.OnPropertyChanging("Address3_PostOfficeBox");
				this.SetAttributeValue("address3_postofficebox", value);
				this.OnPropertyChanged("Address3_PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Type the name of the main contact at the account's third address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_primarycontactname")]
		public string Address3_PrimaryContactName
		{
			get
			{
				return this.GetAttributeValue<string>("address3_primarycontactname");
			}
			set
			{
				this.OnPropertyChanging("Address3_PrimaryContactName");
				this.SetAttributeValue("address3_primarycontactname", value);
				this.OnPropertyChanged("Address3_PrimaryContactName");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address3_ShippingMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address3_shippingmethodcode");
			}
			set
			{
				this.OnPropertyChanging("Address3_ShippingMethodCode");
				this.SetAttributeValue("address3_shippingmethodcode", value);
				this.OnPropertyChanged("Address3_ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// the state or province of the third address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_stateorprovince")]
		public string Address3_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("address3_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("Address3_StateOrProvince");
				this.SetAttributeValue("address3_stateorprovince", value);
				this.OnPropertyChanged("Address3_StateOrProvince");
			}
		}
		
		/// <summary>
		/// Type the main phone number associated with the third address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_telephone1")]
		public string Address3_Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("address3_telephone1");
			}
			set
			{
				this.OnPropertyChanging("Address3_Telephone1");
				this.SetAttributeValue("address3_telephone1", value);
				this.OnPropertyChanged("Address3_Telephone1");
			}
		}
		
		/// <summary>
		/// Type a second phone number associated with the third address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_telephone2")]
		public string Address3_Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("address3_telephone2");
			}
			set
			{
				this.OnPropertyChanging("Address3_Telephone2");
				this.SetAttributeValue("address3_telephone2", value);
				this.OnPropertyChanged("Address3_Telephone2");
			}
		}
		
		/// <summary>
		/// Type a third phone number associated with the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_telephone3")]
		public string Address3_Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("address3_telephone3");
			}
			set
			{
				this.OnPropertyChanging("Address3_Telephone3");
				this.SetAttributeValue("address3_telephone3", value);
				this.OnPropertyChanged("Address3_Telephone3");
			}
		}
		
		/// <summary>
		/// Type the UPS zone of the third address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_upszone")]
		public string Address3_UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("address3_upszone");
			}
			set
			{
				this.OnPropertyChanging("Address3_UPSZone");
				this.SetAttributeValue("address3_upszone", value);
				this.OnPropertyChanged("Address3_UPSZone");
			}
		}
		
		/// <summary>
		/// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_utcoffset")]
		public System.Nullable<int> Address3_UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address3_utcoffset");
			}
			set
			{
				this.OnPropertyChanging("Address3_UTCOffset");
				this.SetAttributeValue("address3_utcoffset", value);
				this.OnPropertyChanged("Address3_UTCOffset");
			}
		}
		
		/// <summary>
		/// For system use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30")]
		public Microsoft.Xrm.Sdk.Money Aging30
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30");
			}
		}
		
		/// <summary>
		/// Shows the Aging 30 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30_base")]
		public Microsoft.Xrm.Sdk.Money Aging30_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30_base");
			}
		}
		
		/// <summary>
		/// For system use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60")]
		public Microsoft.Xrm.Sdk.Money Aging60
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60");
			}
		}
		
		/// <summary>
		/// Shows the Aging 60 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60_base")]
		public Microsoft.Xrm.Sdk.Money Aging60_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60_base");
			}
		}
		
		/// <summary>
		/// For system use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90")]
		public Microsoft.Xrm.Sdk.Money Aging90
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90");
			}
		}
		
		/// <summary>
		/// Shows the Aging 90 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90_base")]
		public Microsoft.Xrm.Sdk.Money Aging90_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90_base");
			}
		}
		
		/// <summary>
		/// Enter the date of the contact's wedding or service anniversary for use in customer gift programs or other communications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("anniversary")]
		public System.Nullable<System.DateTime> Anniversary
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("anniversary");
			}
			set
			{
				this.OnPropertyChanging("Anniversary");
				this.SetAttributeValue("anniversary", value);
				this.OnPropertyChanged("Anniversary");
			}
		}
		
		/// <summary>
		/// Type the contact's annual income for use in profiling and financial analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annualincome")]
		public Microsoft.Xrm.Sdk.Money AnnualIncome
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("annualincome");
			}
			set
			{
				this.OnPropertyChanging("AnnualIncome");
				this.SetAttributeValue("annualincome", value);
				this.OnPropertyChanged("AnnualIncome");
			}
		}
		
		/// <summary>
		/// Shows the Annual Income field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annualincome_base")]
		public Microsoft.Xrm.Sdk.Money AnnualIncome_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("annualincome_base");
			}
		}
		
		/// <summary>
		/// Type the name of the contact's assistant.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("assistantname")]
		public string AssistantName
		{
			get
			{
				return this.GetAttributeValue<string>("assistantname");
			}
			set
			{
				this.OnPropertyChanging("AssistantName");
				this.SetAttributeValue("assistantname", value);
				this.OnPropertyChanged("AssistantName");
			}
		}
		
		/// <summary>
		/// Type the phone number for the contact's assistant.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("assistantphone")]
		public string AssistantPhone
		{
			get
			{
				return this.GetAttributeValue<string>("assistantphone");
			}
			set
			{
				this.OnPropertyChanging("AssistantPhone");
				this.SetAttributeValue("assistantphone", value);
				this.OnPropertyChanged("AssistantPhone");
			}
		}
		
		/// <summary>
		/// Enter the contact's birthday for use in customer gift programs or other communications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("birthdate")]
		public System.Nullable<System.DateTime> BirthDate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("birthdate");
			}
			set
			{
				this.OnPropertyChanging("BirthDate");
				this.SetAttributeValue("birthdate", value);
				this.OnPropertyChanged("BirthDate");
			}
		}
		
		/// <summary>
		/// Type a second business phone number for this contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("business2")]
		public string Business2
		{
			get
			{
				return this.GetAttributeValue<string>("business2");
			}
			set
			{
				this.OnPropertyChanging("Business2");
				this.SetAttributeValue("business2", value);
				this.OnPropertyChanged("Business2");
			}
		}
		
		/// <summary>
		/// Stores Image of the Business Card
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businesscard")]
		public string BusinessCard
		{
			get
			{
				return this.GetAttributeValue<string>("businesscard");
			}
			set
			{
				this.OnPropertyChanging("BusinessCard");
				this.SetAttributeValue("businesscard", value);
				this.OnPropertyChanged("BusinessCard");
			}
		}
		
		/// <summary>
		/// Stores Business Card Control Properties.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businesscardattributes")]
		public string BusinessCardAttributes
		{
			get
			{
				return this.GetAttributeValue<string>("businesscardattributes");
			}
			set
			{
				this.OnPropertyChanging("BusinessCardAttributes");
				this.SetAttributeValue("businesscardattributes", value);
				this.OnPropertyChanged("BusinessCardAttributes");
			}
		}
		
		/// <summary>
		/// Type a callback phone number for this contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("callback")]
		public string Callback
		{
			get
			{
				return this.GetAttributeValue<string>("callback");
			}
			set
			{
				this.OnPropertyChanging("Callback");
				this.SetAttributeValue("callback", value);
				this.OnPropertyChanged("Callback");
			}
		}
		
		/// <summary>
		/// Type the names of the contact's children for reference in communications and client programs.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("childrensnames")]
		public string ChildrensNames
		{
			get
			{
				return this.GetAttributeValue<string>("childrensnames");
			}
			set
			{
				this.OnPropertyChanging("ChildrensNames");
				this.SetAttributeValue("childrensnames", value);
				this.OnPropertyChanged("ChildrensNames");
			}
		}
		
		/// <summary>
		/// Type the company phone of the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("company")]
		public string Company
		{
			get
			{
				return this.GetAttributeValue<string>("company");
			}
			set
			{
				this.OnPropertyChanging("Company");
				this.SetAttributeValue("company", value);
				this.OnPropertyChanged("Company");
			}
		}
		
		/// <summary>
		/// Unique identifier of the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
		public System.Nullable<System.Guid> ContactId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("contactid");
			}
			set
			{
				this.OnPropertyChanging("ContactId");
				this.SetAttributeValue("contactid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ContactId");
			}
		}
		
		/// <summary>
		/// Shows who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Shows the external party who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedByExternalParty
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdbyexternalparty");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Shows who created the record on behalf of another user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Type the credit limit of the contact for reference when you address invoice and accounting issues with the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit")]
		public Microsoft.Xrm.Sdk.Money CreditLimit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit");
			}
			set
			{
				this.OnPropertyChanging("CreditLimit");
				this.SetAttributeValue("creditlimit", value);
				this.OnPropertyChanged("CreditLimit");
			}
		}
		
		/// <summary>
		/// Shows the Credit Limit field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit_base")]
		public Microsoft.Xrm.Sdk.Money CreditLimit_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit_base");
			}
		}
		
		/// <summary>
		/// Select whether the contact is on a credit hold, for reference when addressing invoice and accounting issues.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditonhold")]
		public System.Nullable<bool> CreditOnHold
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("creditonhold");
			}
			set
			{
				this.OnPropertyChanging("CreditOnHold");
				this.SetAttributeValue("creditonhold", value);
				this.OnPropertyChanged("CreditOnHold");
			}
		}
		
		/// <summary>
		/// Select the size of the contact's company for segmentation and reporting purposes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customersizecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue CustomerSizeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customersizecode");
			}
			set
			{
				this.OnPropertyChanging("CustomerSizeCode");
				this.SetAttributeValue("customersizecode", value);
				this.OnPropertyChanged("CustomerSizeCode");
			}
		}
		
		/// <summary>
		/// Select the category that best describes the relationship between the contact and your organization.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customertypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue CustomerTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customertypecode");
			}
			set
			{
				this.OnPropertyChanging("CustomerTypeCode");
				this.SetAttributeValue("customertypecode", value);
				this.OnPropertyChanged("CustomerTypeCode");
			}
		}
		
		/// <summary>
		/// Choose the default price list associated with the contact to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultpricelevelid")]
		public Microsoft.Xrm.Sdk.EntityReference DefaultPriceLevelId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultpricelevelid");
			}
			set
			{
				this.OnPropertyChanging("DefaultPriceLevelId");
				this.SetAttributeValue("defaultpricelevelid", value);
				this.OnPropertyChanged("DefaultPriceLevelId");
			}
		}
		
		/// <summary>
		/// Type the department or business unit where the contact works in the parent company or business.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("department")]
		public string Department
		{
			get
			{
				return this.GetAttributeValue<string>("department");
			}
			set
			{
				this.OnPropertyChanging("Department");
				this.SetAttributeValue("department", value);
				this.OnPropertyChanged("Department");
			}
		}
		
		/// <summary>
		/// Type additional information to describe the contact, such as an excerpt from the company's website.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Select whether the contact accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkemail")]
		public System.Nullable<bool> DoNotBulkEMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotbulkemail");
			}
			set
			{
				this.OnPropertyChanging("DoNotBulkEMail");
				this.SetAttributeValue("donotbulkemail", value);
				this.OnPropertyChanged("DoNotBulkEMail");
			}
		}
		
		/// <summary>
		/// Select whether the contact accepts bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the letters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkpostalmail")]
		public System.Nullable<bool> DoNotBulkPostalMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotbulkpostalmail");
			}
			set
			{
				this.OnPropertyChanging("DoNotBulkPostalMail");
				this.SetAttributeValue("donotbulkpostalmail", value);
				this.OnPropertyChanged("DoNotBulkPostalMail");
			}
		}
		
		/// <summary>
		/// Select whether the contact allows direct email sent from Microsoft Dynamics 365. If Do Not Allow is selected, Microsoft Dynamics 365 will not send the email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
		public System.Nullable<bool> DoNotEMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotemail");
			}
			set
			{
				this.OnPropertyChanging("DoNotEMail");
				this.SetAttributeValue("donotemail", value);
				this.OnPropertyChanged("DoNotEMail");
			}
		}
		
		/// <summary>
		/// Select whether the contact allows faxes. If Do Not Allow is selected, the contact will be excluded from any fax activities distributed in marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
		public System.Nullable<bool> DoNotFax
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotfax");
			}
			set
			{
				this.OnPropertyChanging("DoNotFax");
				this.SetAttributeValue("donotfax", value);
				this.OnPropertyChanged("DoNotFax");
			}
		}
		
		/// <summary>
		/// Select whether the contact accepts phone calls. If Do Not Allow is selected, the contact will be excluded from any phone call activities distributed in marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
		public System.Nullable<bool> DoNotPhone
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotphone");
			}
			set
			{
				this.OnPropertyChanging("DoNotPhone");
				this.SetAttributeValue("donotphone", value);
				this.OnPropertyChanged("DoNotPhone");
			}
		}
		
		/// <summary>
		/// Select whether the contact allows direct mail. If Do Not Allow is selected, the contact will be excluded from letter activities distributed in marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
		public System.Nullable<bool> DoNotPostalMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail");
			}
			set
			{
				this.OnPropertyChanging("DoNotPostalMail");
				this.SetAttributeValue("donotpostalmail", value);
				this.OnPropertyChanged("DoNotPostalMail");
			}
		}
		
		/// <summary>
		/// Select whether the contact accepts marketing materials, such as brochures or catalogs. Contacts that opt out can be excluded from marketing initiatives.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotsendmm")]
		public System.Nullable<bool> DoNotSendMM
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotsendmm");
			}
			set
			{
				this.OnPropertyChanging("DoNotSendMM");
				this.SetAttributeValue("donotsendmm", value);
				this.OnPropertyChanged("DoNotSendMM");
			}
		}
		
		/// <summary>
		/// Select the contact's highest level of education for use in segmentation and analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("educationcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue EducationCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("educationcode");
			}
			set
			{
				this.OnPropertyChanging("EducationCode");
				this.SetAttributeValue("educationcode", value);
				this.OnPropertyChanged("EducationCode");
			}
		}
		
		/// <summary>
		/// Type the primary email address for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress1")]
		public string EMailAddress1
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress1");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress1");
				this.SetAttributeValue("emailaddress1", value);
				this.OnPropertyChanged("EMailAddress1");
			}
		}
		
		/// <summary>
		/// Type the secondary email address for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress2")]
		public string EMailAddress2
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress2");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress2");
				this.SetAttributeValue("emailaddress2", value);
				this.OnPropertyChanged("EMailAddress2");
			}
		}
		
		/// <summary>
		/// Type an alternate email address for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress3")]
		public string EMailAddress3
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress3");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress3");
				this.SetAttributeValue("emailaddress3", value);
				this.OnPropertyChanged("EMailAddress3");
			}
		}
		
		/// <summary>
		/// Type the employee ID or number for the contact for reference in orders, service cases, or other communications with the contact's organization.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("employeeid")]
		public string EmployeeId
		{
			get
			{
				return this.GetAttributeValue<string>("employeeid");
			}
			set
			{
				this.OnPropertyChanging("EmployeeId");
				this.SetAttributeValue("employeeid", value);
				this.OnPropertyChanged("EmployeeId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
		public byte[] EntityImage
		{
			get
			{
				return this.GetAttributeValue<byte[]>("entityimage");
			}
			set
			{
				this.OnPropertyChanging("EntityImage");
				this.SetAttributeValue("entityimage", value);
				this.OnPropertyChanged("EntityImage");
			}
		}
		
		/// <summary>
		///  
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
		public System.Nullable<long> EntityImage_Timestamp
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp");
			}
		}
		
		/// <summary>
		///  
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
		public string EntityImage_URL
		{
			get
			{
				return this.GetAttributeValue<string>("entityimage_url");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
		public System.Nullable<System.Guid> EntityImageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid");
			}
		}
		
		/// <summary>
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Identifier for an external user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("externaluseridentifier")]
		public string ExternalUserIdentifier
		{
			get
			{
				return this.GetAttributeValue<string>("externaluseridentifier");
			}
			set
			{
				this.OnPropertyChanging("ExternalUserIdentifier");
				this.SetAttributeValue("externaluseridentifier", value);
				this.OnPropertyChanged("ExternalUserIdentifier");
			}
		}
		
		/// <summary>
		/// Select the marital status of the contact for reference in follow-up phone calls and other communications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("familystatuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue FamilyStatusCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("familystatuscode");
			}
			set
			{
				this.OnPropertyChanging("FamilyStatusCode");
				this.SetAttributeValue("familystatuscode", value);
				this.OnPropertyChanged("FamilyStatusCode");
			}
		}
		
		/// <summary>
		/// Type the fax number for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fax")]
		public string Fax
		{
			get
			{
				return this.GetAttributeValue<string>("fax");
			}
			set
			{
				this.OnPropertyChanging("Fax");
				this.SetAttributeValue("fax", value);
				this.OnPropertyChanged("Fax");
			}
		}
		
		/// <summary>
		/// Type the contact's first name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstname")]
		public string FirstName
		{
			get
			{
				return this.GetAttributeValue<string>("firstname");
			}
			set
			{
				this.OnPropertyChanging("FirstName");
				this.SetAttributeValue("firstname", value);
				this.OnPropertyChanged("FirstName");
			}
		}
		
		/// <summary>
		/// Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("followemail")]
		public System.Nullable<bool> FollowEmail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("followemail");
			}
			set
			{
				this.OnPropertyChanging("FollowEmail");
				this.SetAttributeValue("followemail", value);
				this.OnPropertyChanged("FollowEmail");
			}
		}
		
		/// <summary>
		/// Type the URL for the contact's FTP site to enable users to access data and share documents.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ftpsiteurl")]
		public string FtpSiteUrl
		{
			get
			{
				return this.GetAttributeValue<string>("ftpsiteurl");
			}
			set
			{
				this.OnPropertyChanging("FtpSiteUrl");
				this.SetAttributeValue("ftpsiteurl", value);
				this.OnPropertyChanged("FtpSiteUrl");
			}
		}
		
		/// <summary>
		/// Combines and shows the contact's first and last names so that the full name can be displayed in views and reports.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fullname")]
		public string FullName
		{
			get
			{
				return this.GetAttributeValue<string>("fullname");
			}
		}
		
		/// <summary>
		/// Select the contact's gender to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("gendercode")]
		public Microsoft.Xrm.Sdk.OptionSetValue GenderCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("gendercode");
			}
			set
			{
				this.OnPropertyChanging("GenderCode");
				this.SetAttributeValue("gendercode", value);
				this.OnPropertyChanged("GenderCode");
			}
		}
		
		/// <summary>
		/// Type the passport number or other government ID for the contact for use in documents or reports.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("governmentid")]
		public string GovernmentId
		{
			get
			{
				return this.GetAttributeValue<string>("governmentid");
			}
			set
			{
				this.OnPropertyChanging("GovernmentId");
				this.SetAttributeValue("governmentid", value);
				this.OnPropertyChanged("GovernmentId");
			}
		}
		
		/// <summary>
		/// Select whether the contact has any children for reference in follow-up phone calls and other communications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("haschildrencode")]
		public Microsoft.Xrm.Sdk.OptionSetValue HasChildrenCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("haschildrencode");
			}
			set
			{
				this.OnPropertyChanging("HasChildrenCode");
				this.SetAttributeValue("haschildrencode", value);
				this.OnPropertyChanged("HasChildrenCode");
			}
		}
		
		/// <summary>
		/// Type a second home phone number for this contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("home2")]
		public string Home2
		{
			get
			{
				return this.GetAttributeValue<string>("home2");
			}
			set
			{
				this.OnPropertyChanging("Home2");
				this.SetAttributeValue("home2", value);
				this.OnPropertyChanged("Home2");
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Information about whether the contact was auto-created when promoting an email or an appointment.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isautocreate")]
		public System.Nullable<bool> IsAutoCreate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isautocreate");
			}
		}
		
		/// <summary>
		/// Select whether the contact exists in a separate accounting or other system, such as Microsoft Dynamics GP or another ERP database, for use in integration processes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isbackofficecustomer")]
		public System.Nullable<bool> IsBackofficeCustomer
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isbackofficecustomer");
			}
			set
			{
				this.OnPropertyChanging("IsBackofficeCustomer");
				this.SetAttributeValue("isbackofficecustomer", value);
				this.OnPropertyChanged("IsBackofficeCustomer");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isprivate")]
		public System.Nullable<bool> IsPrivate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isprivate");
			}
		}
		
		/// <summary>
		/// Type the job title of the contact to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("jobtitle")]
		public string JobTitle
		{
			get
			{
				return this.GetAttributeValue<string>("jobtitle");
			}
			set
			{
				this.OnPropertyChanging("JobTitle");
				this.SetAttributeValue("jobtitle", value);
				this.OnPropertyChanged("JobTitle");
			}
		}
		
		/// <summary>
		/// Type the contact's last name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastname")]
		public string LastName
		{
			get
			{
				return this.GetAttributeValue<string>("lastname");
			}
			set
			{
				this.OnPropertyChanging("LastName");
				this.SetAttributeValue("lastname", value);
				this.OnPropertyChanged("LastName");
			}
		}
		
		/// <summary>
		/// Contains the date and time stamp of the last on hold time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastonholdtime")]
		public System.Nullable<System.DateTime> LastOnHoldTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastonholdtime");
			}
			set
			{
				this.OnPropertyChanging("LastOnHoldTime");
				this.SetAttributeValue("lastonholdtime", value);
				this.OnPropertyChanged("LastOnHoldTime");
			}
		}
		
		/// <summary>
		/// Shows the date when the contact was last included in a marketing campaign or quick campaign.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastusedincampaign")]
		public System.Nullable<System.DateTime> LastUsedInCampaign
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastusedincampaign");
			}
			set
			{
				this.OnPropertyChanging("LastUsedInCampaign");
				this.SetAttributeValue("lastusedincampaign", value);
				this.OnPropertyChanged("LastUsedInCampaign");
			}
		}
		
		/// <summary>
		/// Select the primary marketing source that directed the contact to your organization.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadsourcecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue LeadSourceCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("leadsourcecode");
			}
			set
			{
				this.OnPropertyChanging("LeadSourceCode");
				this.SetAttributeValue("leadsourcecode", value);
				this.OnPropertyChanged("LeadSourceCode");
			}
		}
		
		/// <summary>
		/// Type the name of the contact's manager for use in escalating issues or other follow-up communications with the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("managername")]
		public string ManagerName
		{
			get
			{
				return this.GetAttributeValue<string>("managername");
			}
			set
			{
				this.OnPropertyChanging("ManagerName");
				this.SetAttributeValue("managername", value);
				this.OnPropertyChanged("ManagerName");
			}
		}
		
		/// <summary>
		/// Type the phone number for the contact's manager.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("managerphone")]
		public string ManagerPhone
		{
			get
			{
				return this.GetAttributeValue<string>("managerphone");
			}
			set
			{
				this.OnPropertyChanging("ManagerPhone");
				this.SetAttributeValue("managerphone", value);
				this.OnPropertyChanged("ManagerPhone");
			}
		}
		
		/// <summary>
		/// Whether is only for marketing
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketingonly")]
		public System.Nullable<bool> MarketingOnly
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("marketingonly");
			}
			set
			{
				this.OnPropertyChanging("MarketingOnly");
				this.SetAttributeValue("marketingonly", value);
				this.OnPropertyChanged("MarketingOnly");
			}
		}
		
		/// <summary>
		/// Unique identifier of the master contact for merge.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
		public Microsoft.Xrm.Sdk.EntityReference MasterId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("masterid");
			}
		}
		
		/// <summary>
		/// Shows whether the account has been merged with a master contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("merged")]
		public System.Nullable<bool> Merged
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("merged");
			}
		}
		
		/// <summary>
		/// Type the contact's middle name or initial to make sure the contact is addressed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("middlename")]
		public string MiddleName
		{
			get
			{
				return this.GetAttributeValue<string>("middlename");
			}
			set
			{
				this.OnPropertyChanging("MiddleName");
				this.SetAttributeValue("middlename", value);
				this.OnPropertyChanged("MiddleName");
			}
		}
		
		/// <summary>
		/// Type the mobile phone number for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilephone")]
		public string MobilePhone
		{
			get
			{
				return this.GetAttributeValue<string>("mobilephone");
			}
			set
			{
				this.OnPropertyChanging("MobilePhone");
				this.SetAttributeValue("mobilephone", value);
				this.OnPropertyChanged("MobilePhone");
			}
		}
		
		/// <summary>
		/// Shows who last updated the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Shows the external party who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedByExternalParty
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedbyexternalparty");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Shows who last updated the record on behalf of another user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Describes whether contact is opted out or not
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_gdproptout")]
		public System.Nullable<bool> msdyn_gdproptout
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_gdproptout");
			}
			set
			{
				this.OnPropertyChanging("msdyn_gdproptout");
				this.SetAttributeValue("msdyn_gdproptout", value);
				this.OnPropertyChanged("msdyn_gdproptout");
			}
		}
		
		/// <summary>
		/// Whether or not the contact belongs to the associated account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_orgchangestatus")]
		public Microsoft.Xrm.Sdk.OptionSetValue msdyn_orgchangestatus
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("msdyn_orgchangestatus");
			}
			set
			{
				this.OnPropertyChanging("msdyn_orgchangestatus");
				this.SetAttributeValue("msdyn_orgchangestatus", value);
				this.OnPropertyChanged("msdyn_orgchangestatus");
			}
		}
		
		/// <summary>
		/// Type the contact's nickname.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("nickname")]
		public string NickName
		{
			get
			{
				return this.GetAttributeValue<string>("nickname");
			}
			set
			{
				this.OnPropertyChanging("NickName");
				this.SetAttributeValue("nickname", value);
				this.OnPropertyChanged("NickName");
			}
		}
		
		/// <summary>
		/// Type the number of children the contact has for reference in follow-up phone calls and other communications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberofchildren")]
		public System.Nullable<int> NumberOfChildren
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("numberofchildren");
			}
			set
			{
				this.OnPropertyChanging("NumberOfChildren");
				this.SetAttributeValue("numberofchildren", value);
				this.OnPropertyChanged("NumberOfChildren");
			}
		}
		
		/// <summary>
		/// Shows how long, in minutes, that the record was on hold.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("onholdtime")]
		public System.Nullable<int> OnHoldTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("onholdtime");
			}
		}
		
		/// <summary>
		/// Shows the lead that the contact was created if the contact was created by converting a lead in Microsoft Dynamics 365. This is used to relate the contact to the data on the originating lead for use in reporting and analytics.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingleadid")]
		public Microsoft.Xrm.Sdk.EntityReference OriginatingLeadId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("originatingleadid");
			}
			set
			{
				this.OnPropertyChanging("OriginatingLeadId");
				this.SetAttributeValue("originatingleadid", value);
				this.OnPropertyChanged("OriginatingLeadId");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the business unit that owns the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier of the team who owns the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who owns the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Type the pager number for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pager")]
		public string Pager
		{
			get
			{
				return this.GetAttributeValue<string>("pager");
			}
			set
			{
				this.OnPropertyChanging("Pager");
				this.SetAttributeValue("pager", value);
				this.OnPropertyChanged("Pager");
			}
		}
		
		/// <summary>
		/// Unique identifier of the parent contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcontactid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentContactId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentcontactid");
			}
		}
		
		/// <summary>
		/// Select the parent account or parent contact for the contact to provide a quick link to additional details, such as financial information, activities, and opportunities.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcustomerid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentCustomerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentcustomerid");
			}
			set
			{
				this.OnPropertyChanging("ParentCustomerId");
				this.SetAttributeValue("parentcustomerid", value);
				this.OnPropertyChanged("ParentCustomerId");
			}
		}
		
		/// <summary>
		/// Shows whether the contact participates in workflow rules.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participatesinworkflow")]
		public System.Nullable<bool> ParticipatesInWorkflow
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("participatesinworkflow");
			}
			set
			{
				this.OnPropertyChanging("ParticipatesInWorkflow");
				this.SetAttributeValue("participatesinworkflow", value);
				this.OnPropertyChanged("ParticipatesInWorkflow");
			}
		}
		
		/// <summary>
		/// Select the payment terms to indicate when the customer needs to pay the total amount.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("paymenttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PaymentTermsCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("paymenttermscode");
			}
			set
			{
				this.OnPropertyChanging("PaymentTermsCode");
				this.SetAttributeValue("paymenttermscode", value);
				this.OnPropertyChanged("PaymentTermsCode");
			}
		}
		
		/// <summary>
		/// Select the preferred day of the week for service appointments.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmentdaycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredAppointmentDayCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmentdaycode");
			}
			set
			{
				this.OnPropertyChanging("PreferredAppointmentDayCode");
				this.SetAttributeValue("preferredappointmentdaycode", value);
				this.OnPropertyChanged("PreferredAppointmentDayCode");
			}
		}
		
		/// <summary>
		/// Select the preferred time of day for service appointments.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmenttimecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredAppointmentTimeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmenttimecode");
			}
			set
			{
				this.OnPropertyChanging("PreferredAppointmentTimeCode");
				this.SetAttributeValue("preferredappointmenttimecode", value);
				this.OnPropertyChanged("PreferredAppointmentTimeCode");
			}
		}
		
		/// <summary>
		/// Select the preferred method of contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredcontactmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredContactMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredcontactmethodcode");
			}
			set
			{
				this.OnPropertyChanging("PreferredContactMethodCode");
				this.SetAttributeValue("preferredcontactmethodcode", value);
				this.OnPropertyChanged("PreferredContactMethodCode");
			}
		}
		
		/// <summary>
		/// Choose the contact's preferred service facility or equipment to make sure services are scheduled correctly for the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredequipmentid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredEquipmentId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredequipmentid");
			}
			set
			{
				this.OnPropertyChanging("PreferredEquipmentId");
				this.SetAttributeValue("preferredequipmentid", value);
				this.OnPropertyChanged("PreferredEquipmentId");
			}
		}
		
		/// <summary>
		/// Choose the contact's preferred service to make sure services are scheduled correctly for the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredserviceid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredServiceId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredserviceid");
			}
			set
			{
				this.OnPropertyChanging("PreferredServiceId");
				this.SetAttributeValue("preferredserviceid", value);
				this.OnPropertyChanged("PreferredServiceId");
			}
		}
		
		/// <summary>
		/// Choose the regular or preferred customer service representative for reference when scheduling service activities for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredsystemuserid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredSystemUserId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredsystemuserid");
			}
			set
			{
				this.OnPropertyChanging("PreferredSystemUserId");
				this.SetAttributeValue("preferredsystemuserid", value);
				this.OnPropertyChanged("PreferredSystemUserId");
			}
		}
		
		/// <summary>
		/// Shows the ID of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public System.Nullable<System.Guid> ProcessId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
			}
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
		
		/// <summary>
		/// Type the salutation of the contact to make sure the contact is addressed correctly in sales calls, email messages, and marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salutation")]
		public string Salutation
		{
			get
			{
				return this.GetAttributeValue<string>("salutation");
			}
			set
			{
				this.OnPropertyChanging("Salutation");
				this.SetAttributeValue("salutation", value);
				this.OnPropertyChanged("Salutation");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue ShippingMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("shippingmethodcode");
			}
			set
			{
				this.OnPropertyChanging("ShippingMethodCode");
				this.SetAttributeValue("shippingmethodcode", value);
				this.OnPropertyChanged("ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// Choose the service level agreement (SLA) that you want to apply to the Contact record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slaid");
			}
			set
			{
				this.OnPropertyChanging("SLAId");
				this.SetAttributeValue("slaid", value);
				this.OnPropertyChanged("SLAId");
			}
		}
		
		/// <summary>
		/// Last SLA that was applied to this case. This field is for internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slainvokedid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAInvokedId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slainvokedid");
			}
		}
		
		/// <summary>
		/// Type the name of the contact's spouse or partner for reference during calls, events, or other communications with the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("spousesname")]
		public string SpousesName
		{
			get
			{
				return this.GetAttributeValue<string>("spousesname");
			}
			set
			{
				this.OnPropertyChanging("SpousesName");
				this.SetAttributeValue("spousesname", value);
				this.OnPropertyChanged("SpousesName");
			}
		}
		
		/// <summary>
		/// Shows the ID of the stage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
		public System.Nullable<System.Guid> StageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
			}
			set
			{
				this.OnPropertyChanging("StageId");
				this.SetAttributeValue("stageid", value);
				this.OnPropertyChanged("StageId");
			}
		}
		
		/// <summary>
		/// Shows whether the contact is active or inactive. Inactive contacts are read-only and can't be edited unless they are reactivated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<ContactState> StateCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((ContactState)(System.Enum.ToObject(typeof(ContactState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("StateCode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Select the contact's status.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subscriptionid")]
		public System.Nullable<System.Guid> SubscriptionId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("subscriptionid");
			}
			set
			{
				this.OnPropertyChanging("SubscriptionId");
				this.SetAttributeValue("subscriptionid", value);
				this.OnPropertyChanged("SubscriptionId");
			}
		}
		
		/// <summary>
		/// Type the suffix used in the contact's name, such as Jr. or Sr. to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("suffix")]
		public string Suffix
		{
			get
			{
				return this.GetAttributeValue<string>("suffix");
			}
			set
			{
				this.OnPropertyChanging("Suffix");
				this.SetAttributeValue("suffix", value);
				this.OnPropertyChanged("Suffix");
			}
		}
		
		/// <summary>
		/// Number of users or conversations followed the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamsfollowed")]
		public System.Nullable<int> TeamsFollowed
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("teamsfollowed");
			}
			set
			{
				this.OnPropertyChanging("TeamsFollowed");
				this.SetAttributeValue("teamsfollowed", value);
				this.OnPropertyChanged("TeamsFollowed");
			}
		}
		
		/// <summary>
		/// Type the main phone number for this contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone1")]
		public string Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("telephone1");
			}
			set
			{
				this.OnPropertyChanging("Telephone1");
				this.SetAttributeValue("telephone1", value);
				this.OnPropertyChanged("Telephone1");
			}
		}
		
		/// <summary>
		/// Type a second phone number for this contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone2")]
		public string Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("telephone2");
			}
			set
			{
				this.OnPropertyChanging("Telephone2");
				this.SetAttributeValue("telephone2", value);
				this.OnPropertyChanged("Telephone2");
			}
		}
		
		/// <summary>
		/// Type a third phone number for this contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone3")]
		public string Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("telephone3");
			}
			set
			{
				this.OnPropertyChanging("Telephone3");
				this.SetAttributeValue("telephone3", value);
				this.OnPropertyChanged("Telephone3");
			}
		}
		
		/// <summary>
		/// Select a region or territory for the contact for use in segmentation and analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territorycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue TerritoryCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("territorycode");
			}
			set
			{
				this.OnPropertyChanging("TerritoryCode");
				this.SetAttributeValue("territorycode", value);
				this.OnPropertyChanged("TerritoryCode");
			}
		}
		
		/// <summary>
		/// Total time spent for emails (read and write) and meetings by me in relation to the contact record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timespentbymeonemailandmeetings")]
		public string TimeSpentByMeOnEmailAndMeetings
		{
			get
			{
				return this.GetAttributeValue<string>("timespentbymeonemailandmeetings");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Choose the local currency for the record to make sure budgets are reported in the correct currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			set
			{
				this.OnPropertyChanging("TraversedPath");
				this.SetAttributeValue("traversedpath", value);
				this.OnPropertyChanged("TraversedPath");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version number of the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// Type the contact's professional or personal website or blog URL.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("websiteurl")]
		public string WebSiteUrl
		{
			get
			{
				return this.GetAttributeValue<string>("websiteurl");
			}
			set
			{
				this.OnPropertyChanging("WebSiteUrl");
				this.SetAttributeValue("websiteurl", value);
				this.OnPropertyChanged("WebSiteUrl");
			}
		}
		
		/// <summary>
		/// Type the phonetic spelling of the contact's first name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifirstname")]
		public string YomiFirstName
		{
			get
			{
				return this.GetAttributeValue<string>("yomifirstname");
			}
			set
			{
				this.OnPropertyChanging("YomiFirstName");
				this.SetAttributeValue("yomifirstname", value);
				this.OnPropertyChanged("YomiFirstName");
			}
		}
		
		/// <summary>
		/// Shows the combined Yomi first and last names of the contact so that the full phonetic name can be displayed in views and reports.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifullname")]
		public string YomiFullName
		{
			get
			{
				return this.GetAttributeValue<string>("yomifullname");
			}
		}
		
		/// <summary>
		/// Type the phonetic spelling of the contact's last name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomilastname")]
		public string YomiLastName
		{
			get
			{
				return this.GetAttributeValue<string>("yomilastname");
			}
			set
			{
				this.OnPropertyChanging("YomiLastName");
				this.SetAttributeValue("yomilastname", value);
				this.OnPropertyChanged("YomiLastName");
			}
		}
		
		/// <summary>
		/// Type the phonetic spelling of the contact's middle name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomimiddlename")]
		public string YomiMiddleName
		{
			get
			{
				return this.GetAttributeValue<string>("yomimiddlename");
			}
			set
			{
				this.OnPropertyChanging("YomiMiddleName");
				this.SetAttributeValue("yomimiddlename", value);
				this.OnPropertyChanged("YomiMiddleName");
			}
		}
		
		/// <summary>
		/// 1:N contact_master_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<Contact> Referencedcontact_master_contact
		{
			get
			{
				return this.GetRelatedEntities<Contact>("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedcontact_master_contact");
				this.SetRelatedEntities<Contact>("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedcontact_master_contact");
			}
		}
		
		/// <summary>
		/// 1:N contact_customer_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<Contact> Referencedcontact_customer_contacts
		{
			get
			{
				return this.GetRelatedEntities<Contact>("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedcontact_customer_contacts");
				this.SetRelatedEntities<Contact>("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedcontact_customer_contacts");
			}
		}
		
		/// <summary>
		/// 1:N contact_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_activity_parties")]
		public System.Collections.Generic.IEnumerable<ActivityParty> contact_activity_parties
		{
			get
			{
				return this.GetRelatedEntities<ActivityParty>("contact_activity_parties", null);
			}
			set
			{
				this.OnPropertyChanging("contact_activity_parties");
				this.SetRelatedEntities<ActivityParty>("contact_activity_parties", null, value);
				this.OnPropertyChanged("contact_activity_parties");
			}
		}
		
		/// <summary>
		/// 1:N account_primary_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_primary_contact")]
		public System.Collections.Generic.IEnumerable<Account> account_primary_contact
		{
			get
			{
				return this.GetRelatedEntities<Account>("account_primary_contact", null);
			}
			set
			{
				this.OnPropertyChanging("account_primary_contact");
				this.SetRelatedEntities<Account>("account_primary_contact", null, value);
				this.OnPropertyChanged("account_primary_contact");
			}
		}
		
		/// <summary>
		/// N:1 contact_master_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public Contact Referencingcontact_master_contact
		{
			get
			{
				return this.GetRelatedEntity<Contact>("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
		}
		
		/// <summary>
		/// N:1 contact_customer_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcustomerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_accounts")]
		public Account contact_customer_accounts
		{
			get
			{
				return this.GetRelatedEntity<Account>("contact_customer_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("contact_customer_accounts");
				this.SetRelatedEntity<Account>("contact_customer_accounts", null, value);
				this.OnPropertyChanged("contact_customer_accounts");
			}
		}
		
		/// <summary>
		/// N:1 contact_customer_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcustomerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public Contact Referencingcontact_customer_contacts
		{
			get
			{
				return this.GetRelatedEntity<Contact>("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.OnPropertyChanging("Referencingcontact_customer_contacts");
				this.SetRelatedEntity<Contact>("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingcontact_customer_contacts");
			}
		}
	}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum slck_countryState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}

	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("slck_country")]
	public partial class slck_country : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public slck_country() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "slck_country";
		
		public const int EntityTypeCode = 10397;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slck_countryid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.slck_countryId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Unique identifier for the organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slck_continent")]
		public string slck_continent
		{
			get
			{
				return this.GetAttributeValue<string>("slck_continent");
			}
			set
			{
				this.OnPropertyChanging("slck_continent");
				this.SetAttributeValue("slck_continent", value);
				this.OnPropertyChanged("slck_continent");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slck_countryid")]
		public System.Nullable<System.Guid> slck_countryId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("slck_countryid");
			}
			set
			{
				this.OnPropertyChanging("slck_countryId");
				this.SetAttributeValue("slck_countryid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("slck_countryId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slck_hemisphere")]
		public string slck_hemisphere
		{
			get
			{
				return this.GetAttributeValue<string>("slck_hemisphere");
			}
			set
			{
				this.OnPropertyChanging("slck_hemisphere");
				this.SetAttributeValue("slck_hemisphere", value);
				this.OnPropertyChanged("slck_hemisphere");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slck_name")]
		public string slck_name
		{
			get
			{
				return this.GetAttributeValue<string>("slck_name");
			}
			set
			{
				this.OnPropertyChanging("slck_name");
				this.SetAttributeValue("slck_name", value);
				this.OnPropertyChanged("slck_name");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slck_phonecode")]
		public string slck_phonecode
		{
			get
			{
				return this.GetAttributeValue<string>("slck_phonecode");
			}
			set
			{
				this.OnPropertyChanging("slck_phonecode");
				this.SetAttributeValue("slck_phonecode", value);
				this.OnPropertyChanged("slck_phonecode");
			}
		}
		
		/// <summary>
		/// Status of the Country
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<slck_countryState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((slck_countryState)(System.Enum.ToObject(typeof(slck_countryState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("statecode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statecode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Country
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue statuscode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("statuscode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("statuscode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
	}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum uzm_cityState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}

	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("uzm_city")]
	public partial class uzm_city : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public uzm_city() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "uzm_city";
		
		public const int EntityTypeCode = 10393;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_cityid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.uzm_cityId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Unique identifier for the organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Status of the City
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<uzm_cityState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((uzm_cityState)(System.Enum.ToObject(typeof(uzm_cityState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("statecode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statecode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the City
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue statuscode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("statuscode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("statuscode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_cityid")]
		public System.Nullable<System.Guid> uzm_cityId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("uzm_cityid");
			}
			set
			{
				this.OnPropertyChanging("uzm_cityId");
				this.SetAttributeValue("uzm_cityid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("uzm_cityId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_countryname")]
		public string uzm_countryname
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_countryname");
			}
			set
			{
				this.OnPropertyChanging("uzm_countryname");
				this.SetAttributeValue("uzm_countryname", value);
				this.OnPropertyChanged("uzm_countryname");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_iscapital")]
		public System.Nullable<bool> uzm_iscapital
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("uzm_iscapital");
			}
			set
			{
				this.OnPropertyChanging("uzm_iscapital");
				this.SetAttributeValue("uzm_iscapital", value);
				this.OnPropertyChanged("uzm_iscapital");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_name")]
		public string uzm_name
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_name");
			}
			set
			{
				this.OnPropertyChanging("uzm_name");
				this.SetAttributeValue("uzm_name", value);
				this.OnPropertyChanged("uzm_name");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_platenumber")]
		public string uzm_platenumber
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_platenumber");
			}
			set
			{
				this.OnPropertyChanging("uzm_platenumber");
				this.SetAttributeValue("uzm_platenumber", value);
				this.OnPropertyChanged("uzm_platenumber");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_population")]
		public System.Nullable<int> uzm_population
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("uzm_population");
			}
			set
			{
				this.OnPropertyChanging("uzm_population");
				this.SetAttributeValue("uzm_population", value);
				this.OnPropertyChanged("uzm_population");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_region")]
		public string uzm_region
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_region");
			}
			set
			{
				this.OnPropertyChanging("uzm_region");
				this.SetAttributeValue("uzm_region", value);
				this.OnPropertyChanged("uzm_region");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_zipcode")]
		public string uzm_zipcode
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_zipcode");
			}
			set
			{
				this.OnPropertyChanging("uzm_zipcode");
				this.SetAttributeValue("uzm_zipcode", value);
				this.OnPropertyChanged("uzm_zipcode");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N uzm_uzm_city_uzm_portaluser_BalOlduuehir
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("uzm_uzm_city_uzm_portaluser_BalOlduuehir")]
		public System.Collections.Generic.IEnumerable<uzm_portaluser> uzm_uzm_city_uzm_portaluser_BalOlduuehir
		{
			get
			{
				return this.GetRelatedEntities<uzm_portaluser>("uzm_uzm_city_uzm_portaluser_BalOlduuehir", null);
			}
			set
			{
				this.OnPropertyChanging("uzm_uzm_city_uzm_portaluser_BalOlduuehir");
				this.SetRelatedEntities<uzm_portaluser>("uzm_uzm_city_uzm_portaluser_BalOlduuehir", null, value);
				this.OnPropertyChanged("uzm_uzm_city_uzm_portaluser_BalOlduuehir");
			}
		}
		
		/// <summary>
		/// 1:N uzm_uzm_city_uzm_portaluser_cityid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("uzm_uzm_city_uzm_portaluser_cityid")]
		public System.Collections.Generic.IEnumerable<uzm_portaluser> uzm_uzm_city_uzm_portaluser_cityid
		{
			get
			{
				return this.GetRelatedEntities<uzm_portaluser>("uzm_uzm_city_uzm_portaluser_cityid", null);
			}
			set
			{
				this.OnPropertyChanging("uzm_uzm_city_uzm_portaluser_cityid");
				this.SetRelatedEntities<uzm_portaluser>("uzm_uzm_city_uzm_portaluser_cityid", null, value);
				this.OnPropertyChanged("uzm_uzm_city_uzm_portaluser_cityid");
			}
		}
	}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum uzm_companyState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}

	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("uzm_company")]
	public partial class uzm_company : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public uzm_company() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "uzm_company";
		
		public const int EntityTypeCode = 10410;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_companyid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.uzm_companyId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Owner Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier for the team that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Status of the Company
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<uzm_companyState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((uzm_companyState)(System.Enum.ToObject(typeof(uzm_companyState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("statecode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statecode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Company
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue statuscode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("statuscode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("statuscode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_companyid")]
		public System.Nullable<System.Guid> uzm_companyId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("uzm_companyid");
			}
			set
			{
				this.OnPropertyChanging("uzm_companyId");
				this.SetAttributeValue("uzm_companyid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("uzm_companyId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_employeeid")]
		public Microsoft.Xrm.Sdk.EntityReference uzm_employeeid
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("uzm_employeeid");
			}
			set
			{
				this.OnPropertyChanging("uzm_employeeid");
				this.SetAttributeValue("uzm_employeeid", value);
				this.OnPropertyChanged("uzm_employeeid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_iscategory")]
		public Microsoft.Xrm.Sdk.OptionSetValue uzm_iscategory
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("uzm_iscategory");
			}
			set
			{
				this.OnPropertyChanging("uzm_iscategory");
				this.SetAttributeValue("uzm_iscategory", value);
				this.OnPropertyChanged("uzm_iscategory");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_location")]
		public string uzm_location
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_location");
			}
			set
			{
				this.OnPropertyChanging("uzm_location");
				this.SetAttributeValue("uzm_location", value);
				this.OnPropertyChanged("uzm_location");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_name")]
		public string uzm_name
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_name");
			}
			set
			{
				this.OnPropertyChanging("uzm_name");
				this.SetAttributeValue("uzm_name", value);
				this.OnPropertyChanged("uzm_name");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_numberofemployee")]
		public System.Nullable<int> uzm_numberofemployee
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("uzm_numberofemployee");
			}
			set
			{
				this.OnPropertyChanging("uzm_numberofemployee");
				this.SetAttributeValue("uzm_numberofemployee", value);
				this.OnPropertyChanged("uzm_numberofemployee");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N uzm_uzm_company_uzm_customer_companyid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("uzm_uzm_company_uzm_customer_companyid")]
		public System.Collections.Generic.IEnumerable<uzm_customer> uzm_uzm_company_uzm_customer_companyid
		{
			get
			{
				return this.GetRelatedEntities<uzm_customer>("uzm_uzm_company_uzm_customer_companyid", null);
			}
			set
			{
				this.OnPropertyChanging("uzm_uzm_company_uzm_customer_companyid");
				this.SetRelatedEntities<uzm_customer>("uzm_uzm_company_uzm_customer_companyid", null, value);
				this.OnPropertyChanged("uzm_uzm_company_uzm_customer_companyid");
			}
		}
		
		/// <summary>
		/// N:1 uzm_uzm_employee_uzm_company_employeeid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_employeeid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("uzm_uzm_employee_uzm_company_employeeid")]
		public uzm_employee uzm_uzm_employee_uzm_company_employeeid
		{
			get
			{
				return this.GetRelatedEntity<uzm_employee>("uzm_uzm_employee_uzm_company_employeeid", null);
			}
			set
			{
				this.OnPropertyChanging("uzm_uzm_employee_uzm_company_employeeid");
				this.SetRelatedEntity<uzm_employee>("uzm_uzm_employee_uzm_company_employeeid", null, value);
				this.OnPropertyChanged("uzm_uzm_employee_uzm_company_employeeid");
			}
		}
	}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum uzm_countryState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}

	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("uzm_country")]
	public partial class uzm_country : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public uzm_country() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "uzm_country";
		
		public const int EntityTypeCode = 10406;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_countryid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.uzm_countryId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Owner Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier for the team that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Status of the Country
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<uzm_countryState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((uzm_countryState)(System.Enum.ToObject(typeof(uzm_countryState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("statecode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statecode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Country
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue statuscode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("statuscode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("statuscode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_continent")]
		public string uzm_continent
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_continent");
			}
			set
			{
				this.OnPropertyChanging("uzm_continent");
				this.SetAttributeValue("uzm_continent", value);
				this.OnPropertyChanged("uzm_continent");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_countryid")]
		public System.Nullable<System.Guid> uzm_countryId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("uzm_countryid");
			}
			set
			{
				this.OnPropertyChanging("uzm_countryId");
				this.SetAttributeValue("uzm_countryid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("uzm_countryId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_hemisphere")]
		public string uzm_hemisphere
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_hemisphere");
			}
			set
			{
				this.OnPropertyChanging("uzm_hemisphere");
				this.SetAttributeValue("uzm_hemisphere", value);
				this.OnPropertyChanged("uzm_hemisphere");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_name")]
		public string uzm_name
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_name");
			}
			set
			{
				this.OnPropertyChanging("uzm_name");
				this.SetAttributeValue("uzm_name", value);
				this.OnPropertyChanged("uzm_name");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_nationalityid")]
		public Microsoft.Xrm.Sdk.EntityReference uzm_nationalityid
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("uzm_nationalityid");
			}
			set
			{
				this.OnPropertyChanging("uzm_nationalityid");
				this.SetAttributeValue("uzm_nationalityid", value);
				this.OnPropertyChanged("uzm_nationalityid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_phonecode")]
		public string uzm_phonecode
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_phonecode");
			}
			set
			{
				this.OnPropertyChanging("uzm_phonecode");
				this.SetAttributeValue("uzm_phonecode", value);
				this.OnPropertyChanged("uzm_phonecode");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_population")]
		public System.Nullable<int> uzm_population
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("uzm_population");
			}
			set
			{
				this.OnPropertyChanging("uzm_population");
				this.SetAttributeValue("uzm_population", value);
				this.OnPropertyChanged("uzm_population");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// N:1 uzm_uzm_customer_uzm_country_nationalityid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_nationalityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("uzm_uzm_customer_uzm_country_nationalityid")]
		public uzm_customer uzm_uzm_customer_uzm_country_nationalityid
		{
			get
			{
				return this.GetRelatedEntity<uzm_customer>("uzm_uzm_customer_uzm_country_nationalityid", null);
			}
			set
			{
				this.OnPropertyChanging("uzm_uzm_customer_uzm_country_nationalityid");
				this.SetRelatedEntity<uzm_customer>("uzm_uzm_customer_uzm_country_nationalityid", null, value);
				this.OnPropertyChanged("uzm_uzm_customer_uzm_country_nationalityid");
			}
		}
	}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum uzm_customerState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}

	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("uzm_customer")]
	public partial class uzm_customer : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public uzm_customer() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "uzm_customer";
		
		public const int EntityTypeCode = 10407;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_customerid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.uzm_customerId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Owner Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier for the team that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Status of the Customer
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<uzm_customerState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((uzm_customerState)(System.Enum.ToObject(typeof(uzm_customerState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("statecode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statecode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Customer
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue statuscode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("statuscode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("statuscode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_address")]
		public string uzm_address
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_address");
			}
			set
			{
				this.OnPropertyChanging("uzm_address");
				this.SetAttributeValue("uzm_address", value);
				this.OnPropertyChanged("uzm_address");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_age")]
		public System.Nullable<int> uzm_age
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("uzm_age");
			}
			set
			{
				this.OnPropertyChanging("uzm_age");
				this.SetAttributeValue("uzm_age", value);
				this.OnPropertyChanged("uzm_age");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_companyid")]
		public Microsoft.Xrm.Sdk.EntityReference uzm_companyid
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("uzm_companyid");
			}
			set
			{
				this.OnPropertyChanging("uzm_companyid");
				this.SetAttributeValue("uzm_companyid", value);
				this.OnPropertyChanged("uzm_companyid");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_customerid")]
		public System.Nullable<System.Guid> uzm_customerId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("uzm_customerid");
			}
			set
			{
				this.OnPropertyChanging("uzm_customerId");
				this.SetAttributeValue("uzm_customerid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("uzm_customerId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_customernumber")]
		public string uzm_customernumber
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_customernumber");
			}
			set
			{
				this.OnPropertyChanging("uzm_customernumber");
				this.SetAttributeValue("uzm_customernumber", value);
				this.OnPropertyChanged("uzm_customernumber");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_dateofbirth")]
		public System.Nullable<System.DateTime> uzm_dateofbirth
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("uzm_dateofbirth");
			}
			set
			{
				this.OnPropertyChanging("uzm_dateofbirth");
				this.SetAttributeValue("uzm_dateofbirth", value);
				this.OnPropertyChanged("uzm_dateofbirth");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_email")]
		public string uzm_email
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_email");
			}
			set
			{
				this.OnPropertyChanging("uzm_email");
				this.SetAttributeValue("uzm_email", value);
				this.OnPropertyChanged("uzm_email");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_iscompanysector")]
		public Microsoft.Xrm.Sdk.OptionSetValue uzm_iscompanysector
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("uzm_iscompanysector");
			}
			set
			{
				this.OnPropertyChanging("uzm_iscompanysector");
				this.SetAttributeValue("uzm_iscompanysector", value);
				this.OnPropertyChanged("uzm_iscompanysector");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_iscurrentsituation")]
		public Microsoft.Xrm.Sdk.OptionSetValue uzm_iscurrentsituation
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("uzm_iscurrentsituation");
			}
			set
			{
				this.OnPropertyChanging("uzm_iscurrentsituation");
				this.SetAttributeValue("uzm_iscurrentsituation", value);
				this.OnPropertyChanged("uzm_iscurrentsituation");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_isdemandcategory")]
		public Microsoft.Xrm.Sdk.OptionSetValue uzm_isdemandcategory
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("uzm_isdemandcategory");
			}
			set
			{
				this.OnPropertyChanging("uzm_isdemandcategory");
				this.SetAttributeValue("uzm_isdemandcategory", value);
				this.OnPropertyChanged("uzm_isdemandcategory");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_iseducationstatus")]
		public Microsoft.Xrm.Sdk.OptionSetValue uzm_iseducationstatus
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("uzm_iseducationstatus");
			}
			set
			{
				this.OnPropertyChanging("uzm_iseducationstatus");
				this.SetAttributeValue("uzm_iseducationstatus", value);
				this.OnPropertyChanged("uzm_iseducationstatus");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_isgender")]
		public Microsoft.Xrm.Sdk.OptionSetValue uzm_isgender
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("uzm_isgender");
			}
			set
			{
				this.OnPropertyChanging("uzm_isgender");
				this.SetAttributeValue("uzm_isgender", value);
				this.OnPropertyChanged("uzm_isgender");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_ismaritalstatus")]
		public Microsoft.Xrm.Sdk.OptionSetValue uzm_ismaritalstatus
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("uzm_ismaritalstatus");
			}
			set
			{
				this.OnPropertyChanging("uzm_ismaritalstatus");
				this.SetAttributeValue("uzm_ismaritalstatus", value);
				this.OnPropertyChanged("uzm_ismaritalstatus");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_ispermission")]
		public System.Nullable<bool> uzm_ispermission
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("uzm_ispermission");
			}
			set
			{
				this.OnPropertyChanging("uzm_ispermission");
				this.SetAttributeValue("uzm_ispermission", value);
				this.OnPropertyChanged("uzm_ispermission");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_name")]
		public string uzm_name
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_name");
			}
			set
			{
				this.OnPropertyChanging("uzm_name");
				this.SetAttributeValue("uzm_name", value);
				this.OnPropertyChanged("uzm_name");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_nationalityid")]
		public Microsoft.Xrm.Sdk.EntityReference uzm_nationalityid
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("uzm_nationalityid");
			}
			set
			{
				this.OnPropertyChanging("uzm_nationalityid");
				this.SetAttributeValue("uzm_nationalityid", value);
				this.OnPropertyChanged("uzm_nationalityid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_phone")]
		public string uzm_phone
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_phone");
			}
			set
			{
				this.OnPropertyChanging("uzm_phone");
				this.SetAttributeValue("uzm_phone", value);
				this.OnPropertyChanged("uzm_phone");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_placeofbirth")]
		public string uzm_placeofbirth
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_placeofbirth");
			}
			set
			{
				this.OnPropertyChanging("uzm_placeofbirth");
				this.SetAttributeValue("uzm_placeofbirth", value);
				this.OnPropertyChanged("uzm_placeofbirth");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_profession")]
		public string uzm_profession
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_profession");
			}
			set
			{
				this.OnPropertyChanging("uzm_profession");
				this.SetAttributeValue("uzm_profession", value);
				this.OnPropertyChanged("uzm_profession");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_surname")]
		public string uzm_surname
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_surname");
			}
			set
			{
				this.OnPropertyChanging("uzm_surname");
				this.SetAttributeValue("uzm_surname", value);
				this.OnPropertyChanged("uzm_surname");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_tridentityno")]
		public string uzm_tridentityno
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_tridentityno");
			}
			set
			{
				this.OnPropertyChanging("uzm_tridentityno");
				this.SetAttributeValue("uzm_tridentityno", value);
				this.OnPropertyChanged("uzm_tridentityno");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_validuntil")]
		public System.Nullable<System.DateTime> uzm_validuntil
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("uzm_validuntil");
			}
			set
			{
				this.OnPropertyChanging("uzm_validuntil");
				this.SetAttributeValue("uzm_validuntil", value);
				this.OnPropertyChanged("uzm_validuntil");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_workplacecityid")]
		public Microsoft.Xrm.Sdk.EntityReference uzm_workplacecityid
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("uzm_workplacecityid");
			}
			set
			{
				this.OnPropertyChanging("uzm_workplacecityid");
				this.SetAttributeValue("uzm_workplacecityid", value);
				this.OnPropertyChanged("uzm_workplacecityid");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N uzm_uzm_customer_uzm_country_nationalityid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("uzm_uzm_customer_uzm_country_nationalityid")]
		public System.Collections.Generic.IEnumerable<uzm_country> uzm_uzm_customer_uzm_country_nationalityid
		{
			get
			{
				return this.GetRelatedEntities<uzm_country>("uzm_uzm_customer_uzm_country_nationalityid", null);
			}
			set
			{
				this.OnPropertyChanging("uzm_uzm_customer_uzm_country_nationalityid");
				this.SetRelatedEntities<uzm_country>("uzm_uzm_customer_uzm_country_nationalityid", null, value);
				this.OnPropertyChanged("uzm_uzm_customer_uzm_country_nationalityid");
			}
		}
		
		/// <summary>
		/// N:1 uzm_uzm_company_uzm_customer_companyid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_companyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("uzm_uzm_company_uzm_customer_companyid")]
		public uzm_company uzm_uzm_company_uzm_customer_companyid
		{
			get
			{
				return this.GetRelatedEntity<uzm_company>("uzm_uzm_company_uzm_customer_companyid", null);
			}
			set
			{
				this.OnPropertyChanging("uzm_uzm_company_uzm_customer_companyid");
				this.SetRelatedEntity<uzm_company>("uzm_uzm_company_uzm_customer_companyid", null, value);
				this.OnPropertyChanged("uzm_uzm_company_uzm_customer_companyid");
			}
		}
		
		/// <summary>
		/// N:1 uzm_uzm_nationality_uzm_customer_nationalityid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_nationalityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("uzm_uzm_nationality_uzm_customer_nationalityid")]
		public uzm_nationality uzm_uzm_nationality_uzm_customer_nationalityid
		{
			get
			{
				return this.GetRelatedEntity<uzm_nationality>("uzm_uzm_nationality_uzm_customer_nationalityid", null);
			}
			set
			{
				this.OnPropertyChanging("uzm_uzm_nationality_uzm_customer_nationalityid");
				this.SetRelatedEntity<uzm_nationality>("uzm_uzm_nationality_uzm_customer_nationalityid", null, value);
				this.OnPropertyChanged("uzm_uzm_nationality_uzm_customer_nationalityid");
			}
		}
		
		/// <summary>
		/// N:1 uzm_uzm_workplacecity_uzm_customer_workplacecityid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_workplacecityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("uzm_uzm_workplacecity_uzm_customer_workplacecityid")]
		public uzm_workplacecity uzm_uzm_workplacecity_uzm_customer_workplacecityid
		{
			get
			{
				return this.GetRelatedEntity<uzm_workplacecity>("uzm_uzm_workplacecity_uzm_customer_workplacecityid", null);
			}
			set
			{
				this.OnPropertyChanging("uzm_uzm_workplacecity_uzm_customer_workplacecityid");
				this.SetRelatedEntity<uzm_workplacecity>("uzm_uzm_workplacecity_uzm_customer_workplacecityid", null, value);
				this.OnPropertyChanged("uzm_uzm_workplacecity_uzm_customer_workplacecityid");
			}
		}
	}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum uzm_employeeState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}

	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("uzm_employee")]
	public partial class uzm_employee : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public uzm_employee() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "uzm_employee";
		
		public const int EntityTypeCode = 10411;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_employeeid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.uzm_employeeId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Owner Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier for the team that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Status of the Employee
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<uzm_employeeState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((uzm_employeeState)(System.Enum.ToObject(typeof(uzm_employeeState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("statecode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statecode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Employee
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue statuscode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("statuscode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("statuscode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_age")]
		public System.Nullable<int> uzm_age
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("uzm_age");
			}
			set
			{
				this.OnPropertyChanging("uzm_age");
				this.SetAttributeValue("uzm_age", value);
				this.OnPropertyChanged("uzm_age");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_employeeid")]
		public System.Nullable<System.Guid> uzm_employeeId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("uzm_employeeid");
			}
			set
			{
				this.OnPropertyChanging("uzm_employeeId");
				this.SetAttributeValue("uzm_employeeid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("uzm_employeeId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_isprofession")]
		public Microsoft.Xrm.Sdk.OptionSetValue uzm_isprofession
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("uzm_isprofession");
			}
			set
			{
				this.OnPropertyChanging("uzm_isprofession");
				this.SetAttributeValue("uzm_isprofession", value);
				this.OnPropertyChanged("uzm_isprofession");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_name")]
		public string uzm_name
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_name");
			}
			set
			{
				this.OnPropertyChanging("uzm_name");
				this.SetAttributeValue("uzm_name", value);
				this.OnPropertyChanged("uzm_name");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_surname")]
		public string uzm_surname
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_surname");
			}
			set
			{
				this.OnPropertyChanging("uzm_surname");
				this.SetAttributeValue("uzm_surname", value);
				this.OnPropertyChanged("uzm_surname");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N uzm_uzm_employee_uzm_company_employeeid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("uzm_uzm_employee_uzm_company_employeeid")]
		public System.Collections.Generic.IEnumerable<uzm_company> uzm_uzm_employee_uzm_company_employeeid
		{
			get
			{
				return this.GetRelatedEntities<uzm_company>("uzm_uzm_employee_uzm_company_employeeid", null);
			}
			set
			{
				this.OnPropertyChanging("uzm_uzm_employee_uzm_company_employeeid");
				this.SetRelatedEntities<uzm_company>("uzm_uzm_employee_uzm_company_employeeid", null, value);
				this.OnPropertyChanged("uzm_uzm_employee_uzm_company_employeeid");
			}
		}
	}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum uzm_nationalityState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}

	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("uzm_nationality")]
	public partial class uzm_nationality : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public uzm_nationality() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "uzm_nationality";
		
		public const int EntityTypeCode = 10408;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_nationalityid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.uzm_nationalityId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Owner Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier for the team that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Status of the Nationality
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<uzm_nationalityState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((uzm_nationalityState)(System.Enum.ToObject(typeof(uzm_nationalityState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("statecode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statecode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Nationality
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue statuscode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("statuscode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("statuscode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_name")]
		public string uzm_name
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_name");
			}
			set
			{
				this.OnPropertyChanging("uzm_name");
				this.SetAttributeValue("uzm_name", value);
				this.OnPropertyChanged("uzm_name");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_nationality")]
		public string Uzm_nationality
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_nationality");
			}
			set
			{
				this.OnPropertyChanging("uzm_nationality");
				this.SetAttributeValue("uzm_nationality", value);
				this.OnPropertyChanged("uzm_nationality");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_nationalityid")]
		public System.Nullable<System.Guid> uzm_nationalityId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("uzm_nationalityid");
			}
			set
			{
				this.OnPropertyChanging("uzm_nationalityId");
				this.SetAttributeValue("uzm_nationalityid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("uzm_nationalityId");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N uzm_uzm_nationality_uzm_customer_nationalityid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("uzm_uzm_nationality_uzm_customer_nationalityid")]
		public System.Collections.Generic.IEnumerable<uzm_customer> uzm_uzm_nationality_uzm_customer_nationalityid
		{
			get
			{
				return this.GetRelatedEntities<uzm_customer>("uzm_uzm_nationality_uzm_customer_nationalityid", null);
			}
			set
			{
				this.OnPropertyChanging("uzm_uzm_nationality_uzm_customer_nationalityid");
				this.SetRelatedEntities<uzm_customer>("uzm_uzm_nationality_uzm_customer_nationalityid", null, value);
				this.OnPropertyChanged("uzm_uzm_nationality_uzm_customer_nationalityid");
			}
		}
	}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum uzm_portaluserState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}

	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("uzm_portaluser")]
	public partial class uzm_portaluser : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public uzm_portaluser() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "uzm_portaluser";
		
		public const int EntityTypeCode = 10392;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_portaluserid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.uzm_portaluserId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Unique identifier for the organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Status of the Portal Kullanıcısı
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<uzm_portaluserState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((uzm_portaluserState)(System.Enum.ToObject(typeof(uzm_portaluserState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("statecode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statecode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Portal Kullanıcısı
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue statuscode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("statuscode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("statuscode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_balolduuehir")]
		public Microsoft.Xrm.Sdk.EntityReference uzm_BalOlduuehir
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("uzm_balolduuehir");
			}
			set
			{
				this.OnPropertyChanging("uzm_BalOlduuehir");
				this.SetAttributeValue("uzm_balolduuehir", value);
				this.OnPropertyChanged("uzm_BalOlduuehir");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_birthdate")]
		public System.Nullable<System.DateTime> uzm_birthdate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("uzm_birthdate");
			}
			set
			{
				this.OnPropertyChanging("uzm_birthdate");
				this.SetAttributeValue("uzm_birthdate", value);
				this.OnPropertyChanged("uzm_birthdate");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_cityid")]
		public Microsoft.Xrm.Sdk.EntityReference uzm_cityid
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("uzm_cityid");
			}
			set
			{
				this.OnPropertyChanging("uzm_cityid");
				this.SetAttributeValue("uzm_cityid", value);
				this.OnPropertyChanged("uzm_cityid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_emailaddress")]
		public string uzm_emailaddress
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_emailaddress");
			}
			set
			{
				this.OnPropertyChanging("uzm_emailaddress");
				this.SetAttributeValue("uzm_emailaddress", value);
				this.OnPropertyChanged("uzm_emailaddress");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_isgender")]
		public Microsoft.Xrm.Sdk.OptionSetValue uzm_isgender
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("uzm_isgender");
			}
			set
			{
				this.OnPropertyChanging("uzm_isgender");
				this.SetAttributeValue("uzm_isgender", value);
				this.OnPropertyChanged("uzm_isgender");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_name")]
		public string uzm_name
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_name");
			}
			set
			{
				this.OnPropertyChanging("uzm_name");
				this.SetAttributeValue("uzm_name", value);
				this.OnPropertyChanged("uzm_name");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_password")]
		public string uzm_password
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_password");
			}
			set
			{
				this.OnPropertyChanging("uzm_password");
				this.SetAttributeValue("uzm_password", value);
				this.OnPropertyChanged("uzm_password");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_phone")]
		public string uzm_phone
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_phone");
			}
			set
			{
				this.OnPropertyChanging("uzm_phone");
				this.SetAttributeValue("uzm_phone", value);
				this.OnPropertyChanged("uzm_phone");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_portaluserid")]
		public System.Nullable<System.Guid> uzm_portaluserId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("uzm_portaluserid");
			}
			set
			{
				this.OnPropertyChanging("uzm_portaluserId");
				this.SetAttributeValue("uzm_portaluserid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("uzm_portaluserId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_username")]
		public string uzm_username
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_username");
			}
			set
			{
				this.OnPropertyChanging("uzm_username");
				this.SetAttributeValue("uzm_username", value);
				this.OnPropertyChanged("uzm_username");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// N:1 uzm_uzm_city_uzm_portaluser_BalOlduuehir
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_balolduuehir")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("uzm_uzm_city_uzm_portaluser_BalOlduuehir")]
		public uzm_city uzm_uzm_city_uzm_portaluser_BalOlduuehir
		{
			get
			{
				return this.GetRelatedEntity<uzm_city>("uzm_uzm_city_uzm_portaluser_BalOlduuehir", null);
			}
			set
			{
				this.OnPropertyChanging("uzm_uzm_city_uzm_portaluser_BalOlduuehir");
				this.SetRelatedEntity<uzm_city>("uzm_uzm_city_uzm_portaluser_BalOlduuehir", null, value);
				this.OnPropertyChanged("uzm_uzm_city_uzm_portaluser_BalOlduuehir");
			}
		}
		
		/// <summary>
		/// N:1 uzm_uzm_city_uzm_portaluser_cityid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_cityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("uzm_uzm_city_uzm_portaluser_cityid")]
		public uzm_city uzm_uzm_city_uzm_portaluser_cityid
		{
			get
			{
				return this.GetRelatedEntity<uzm_city>("uzm_uzm_city_uzm_portaluser_cityid", null);
			}
			set
			{
				this.OnPropertyChanging("uzm_uzm_city_uzm_portaluser_cityid");
				this.SetRelatedEntity<uzm_city>("uzm_uzm_city_uzm_portaluser_cityid", null, value);
				this.OnPropertyChanged("uzm_uzm_city_uzm_portaluser_cityid");
			}
		}
	}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum uzm_workplacecityState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}

	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("uzm_workplacecity")]
	public partial class uzm_workplacecity : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public uzm_workplacecity() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "uzm_workplacecity";
		
		public const int EntityTypeCode = 10409;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_workplacecityid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.uzm_workplacecityId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Owner Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier for the team that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Status of the Workplace City
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<uzm_workplacecityState> statecode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((uzm_workplacecityState)(System.Enum.ToObject(typeof(uzm_workplacecityState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("statecode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("statecode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Workplace City
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue statuscode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("statuscode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("statuscode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_citydate")]
		public System.Nullable<System.DateTime> uzm_citydate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("uzm_citydate");
			}
			set
			{
				this.OnPropertyChanging("uzm_citydate");
				this.SetAttributeValue("uzm_citydate", value);
				this.OnPropertyChanged("uzm_citydate");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_iscapital")]
		public System.Nullable<bool> uzm_iscapital
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("uzm_iscapital");
			}
			set
			{
				this.OnPropertyChanging("uzm_iscapital");
				this.SetAttributeValue("uzm_iscapital", value);
				this.OnPropertyChanged("uzm_iscapital");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_isregion")]
		public Microsoft.Xrm.Sdk.OptionSetValue uzm_isregion
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("uzm_isregion");
			}
			set
			{
				this.OnPropertyChanging("uzm_isregion");
				this.SetAttributeValue("uzm_isregion", value);
				this.OnPropertyChanged("uzm_isregion");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_name")]
		public string uzm_name
		{
			get
			{
				return this.GetAttributeValue<string>("uzm_name");
			}
			set
			{
				this.OnPropertyChanging("uzm_name");
				this.SetAttributeValue("uzm_name", value);
				this.OnPropertyChanged("uzm_name");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_numberofcounty")]
		public System.Nullable<int> uzm_numberofcounty
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("uzm_numberofcounty");
			}
			set
			{
				this.OnPropertyChanging("uzm_numberofcounty");
				this.SetAttributeValue("uzm_numberofcounty", value);
				this.OnPropertyChanged("uzm_numberofcounty");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_population")]
		public System.Nullable<int> uzm_population
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("uzm_population");
			}
			set
			{
				this.OnPropertyChanging("uzm_population");
				this.SetAttributeValue("uzm_population", value);
				this.OnPropertyChanged("uzm_population");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uzm_workplacecityid")]
		public System.Nullable<System.Guid> uzm_workplacecityId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("uzm_workplacecityid");
			}
			set
			{
				this.OnPropertyChanging("uzm_workplacecityId");
				this.SetAttributeValue("uzm_workplacecityid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("uzm_workplacecityId");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N uzm_uzm_workplacecity_uzm_customer_workplacecityid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("uzm_uzm_workplacecity_uzm_customer_workplacecityid")]
		public System.Collections.Generic.IEnumerable<uzm_customer> uzm_uzm_workplacecity_uzm_customer_workplacecityid
		{
			get
			{
				return this.GetRelatedEntities<uzm_customer>("uzm_uzm_workplacecity_uzm_customer_workplacecityid", null);
			}
			set
			{
				this.OnPropertyChanging("uzm_uzm_workplacecity_uzm_customer_workplacecityid");
				this.SetRelatedEntities<uzm_customer>("uzm_uzm_workplacecity_uzm_customer_workplacecityid", null, value);
				this.OnPropertyChanged("uzm_uzm_workplacecity_uzm_customer_workplacecityid");
			}
		}
	}

	/// <summary>
	/// Represents a source of entities bound to a CRM service. It tracks and manages changes made to the retrieved entities.
	/// </summary>
	public partial class XrmServiceContext : Microsoft.Xrm.Sdk.Client.OrganizationServiceContext
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public XrmServiceContext(Microsoft.Xrm.Sdk.IOrganizationService service) : 
				base(service)
		{
		}

		/// <summary>
		/// Gets a binding to the set of all <see cref="abd1_city"/> entities.
		/// </summary>
		public System.Linq.IQueryable<abd1_city> abd1_citySet
		{
			get
			{
				return this.CreateQuery<abd1_city>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="abd2_customer"/> entities.
		/// </summary>
		public System.Linq.IQueryable<abd2_customer> abd2_customerSet
		{
			get
			{
				return this.CreateQuery<abd2_customer>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="abd4_identitiy"/> entities.
		/// </summary>
		public System.Linq.IQueryable<abd4_identitiy> abd4_identitiySet
		{
			get
			{
				return this.CreateQuery<abd4_identitiy>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="abd5_drivinglicence"/> entities.
		/// </summary>
		public System.Linq.IQueryable<abd5_drivinglicence> abd5_drivinglicenceSet
		{
			get
			{
				return this.CreateQuery<abd5_drivinglicence>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="abd6_tinnumbercard"/> entities.
		/// </summary>
		public System.Linq.IQueryable<abd6_tinnumbercard> abd6_tinnumbercardSet
		{
			get
			{
				return this.CreateQuery<abd6_tinnumbercard>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="abd7_ytustudentidentitycard"/> entities.
		/// </summary>
		public System.Linq.IQueryable<abd7_ytustudentidentitycard> abd7_ytustudentidentitycardSet
		{
			get
			{
				return this.CreateQuery<abd7_ytustudentidentitycard>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="Account"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Account> AccountSet
		{
			get
			{
				return this.CreateQuery<Account>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="ActivityParty"/> entities.
		/// </summary>
		public System.Linq.IQueryable<ActivityParty> ActivityPartySet
		{
			get
			{
				return this.CreateQuery<ActivityParty>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="Contact"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Contact> ContactSet
		{
			get
			{
				return this.CreateQuery<Contact>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="slck_country"/> entities.
		/// </summary>
		public System.Linq.IQueryable<slck_country> slck_countrySet
		{
			get
			{
				return this.CreateQuery<slck_country>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="uzm_city"/> entities.
		/// </summary>
		public System.Linq.IQueryable<uzm_city> uzm_citySet
		{
			get
			{
				return this.CreateQuery<uzm_city>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="uzm_company"/> entities.
		/// </summary>
		public System.Linq.IQueryable<uzm_company> uzm_companySet
		{
			get
			{
				return this.CreateQuery<uzm_company>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="uzm_country"/> entities.
		/// </summary>
		public System.Linq.IQueryable<uzm_country> uzm_countrySet
		{
			get
			{
				return this.CreateQuery<uzm_country>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="uzm_customer"/> entities.
		/// </summary>
		public System.Linq.IQueryable<uzm_customer> uzm_customerSet
		{
			get
			{
				return this.CreateQuery<uzm_customer>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="uzm_employee"/> entities.
		/// </summary>
		public System.Linq.IQueryable<uzm_employee> uzm_employeeSet
		{
			get
			{
				return this.CreateQuery<uzm_employee>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="uzm_nationality"/> entities.
		/// </summary>
		public System.Linq.IQueryable<uzm_nationality> uzm_nationalitySet
		{
			get
			{
				return this.CreateQuery<uzm_nationality>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="uzm_portaluser"/> entities.
		/// </summary>
		public System.Linq.IQueryable<uzm_portaluser> uzm_portaluserSet
		{
			get
			{
				return this.CreateQuery<uzm_portaluser>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="uzm_workplacecity"/> entities.
		/// </summary>
		public System.Linq.IQueryable<uzm_workplacecity> uzm_workplacecitySet
		{
			get
			{
				return this.CreateQuery<uzm_workplacecity>();
			}
		}
	}
}
