﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3623
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqQueries
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="PruProfile")]
	public partial class PruProfileDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttblpersoninfo(tblpersoninfo instance);
    partial void Updatetblpersoninfo(tblpersoninfo instance);
    partial void Deletetblpersoninfo(tblpersoninfo instance);
    #endregion
		
		public PruProfileDataContext() : 
				base(global::LinqQueries.Properties.Settings.Default.PruProfileConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PruProfileDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PruProfileDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PruProfileDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PruProfileDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TblKeyName> TblKeyNames
		{
			get
			{
				return this.GetTable<TblKeyName>();
			}
		}
		
		public System.Data.Linq.Table<TblKeyValue> TblKeyValues
		{
			get
			{
				return this.GetTable<TblKeyValue>();
			}
		}
		
		public System.Data.Linq.Table<tblpersoninfo> tblpersoninfos
		{
			get
			{
				return this.GetTable<tblpersoninfo>();
			}
		}
		
		[Function(Name="dbo.usp_AdminCopyUser")]
		public int usp_AdminCopyUser([Parameter(Name="AppName", DbType="Char(2)")] string appName, [Parameter(DbType="Char(7)")] string srcPersonId, [Parameter(DbType="Char(7)")] string destPersonId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), appName, srcPersonId, destPersonId);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.usp_AdminDeleteUserInfo")]
		public int usp_AdminDeleteUserInfo([Parameter(Name="AppName", DbType="Char(2)")] string appName, [Parameter(Name="PersonId", DbType="Char(7)")] string personId, [Parameter(Name="KeyName", DbType="VarChar(255)")] string keyName, [Parameter(Name="KeyValue", DbType="VarChar(255)")] string keyValue)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), appName, personId, keyName, keyValue);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.usp_AdminGetUserInfo")]
		public ISingleResult<usp_AdminGetUserInfoResult> usp_AdminGetUserInfo([Parameter(Name="AppName", DbType="Char(2)")] string appName, [Parameter(Name="PersonId", DbType="Char(7)")] string personId, [Parameter(Name="KeyName", DbType="VarChar(255)")] string keyName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), appName, personId, keyName);
			return ((ISingleResult<usp_AdminGetUserInfoResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.usp_AdminInsertUserInfo")]
		public int usp_AdminInsertUserInfo([Parameter(Name="AppName", DbType="Char(2)")] string appName, [Parameter(Name="PersonId", DbType="Char(7)")] string personId, [Parameter(Name="KeyName", DbType="VarChar(255)")] string keyName, [Parameter(Name="KeyNewValue", DbType="VarChar(255)")] string keyNewValue)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), appName, personId, keyName, keyNewValue);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.usp_AdminUpdateUserInfo")]
		public int usp_AdminUpdateUserInfo([Parameter(Name="AppName", DbType="Char(2)")] string appName, [Parameter(Name="PersonId", DbType="Char(7)")] string personId, [Parameter(Name="KeyName", DbType="VarChar(255)")] string keyName, [Parameter(Name="KeyNewValue", DbType="VarChar(255)")] string keyNewValue, [Parameter(Name="KeyOldValue", DbType="VarChar(255)")] string keyOldValue)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), appName, personId, keyName, keyNewValue, keyOldValue);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.usp_DeleteAppInfo")]
		public int usp_DeleteAppInfo([Parameter(Name="AppName", DbType="Char(2)")] string appName, [Parameter(Name="KeyName", DbType="VarChar(255)")] string keyName, [Parameter(Name="KeyValue", DbType="VarChar(255)")] string keyValue)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), appName, keyName, keyValue);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.usp_DeletePersonInfo")]
		public int usp_DeletePersonInfo([Parameter(Name="AppName", DbType="Char(2)")] string appName, [Parameter(Name="PersonId", DbType="Char(7)")] string personId, [Parameter(Name="KeyName", DbType="VarChar(255)")] string keyName, [Parameter(Name="KeyValue", DbType="VarChar(255)")] string keyValue)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), appName, personId, keyName, keyValue);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.usp_GetAllAppInfo")]
		public ISingleResult<usp_GetAllAppInfoResult> usp_GetAllAppInfo([Parameter(Name="AppName", DbType="Char(2)")] string appName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), appName);
			return ((ISingleResult<usp_GetAllAppInfoResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.usp_GetPersonInfo")]
		public ISingleResult<usp_GetPersonInfoResult> usp_GetPersonInfo([Parameter(Name="AppName", DbType="Char(2)")] string appName, [Parameter(Name="PersonId", DbType="Char(7)")] string personId, [Parameter(Name="KeyName", DbType="VarChar(255)")] string keyName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), appName, personId, keyName);
			return ((ISingleResult<usp_GetPersonInfoResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.usp_InsertAppInfo")]
		public int usp_InsertAppInfo([Parameter(Name="AppName", DbType="Char(2)")] string appName, [Parameter(Name="KeyName", DbType="VarChar(255)")] string keyName, [Parameter(Name="KeyNewValue", DbType="VarChar(255)")] string keyNewValue)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), appName, keyName, keyNewValue);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.usp_InsertPersonInfo")]
		public int usp_InsertPersonInfo([Parameter(Name="AppName", DbType="Char(2)")] string appName, [Parameter(Name="PersonId", DbType="Char(7)")] string personId, [Parameter(Name="KeyName", DbType="VarChar(255)")] string keyName, [Parameter(Name="KeyValue", DbType="VarChar(255)")] string keyValue)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), appName, personId, keyName, keyValue);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.usp_IsAdmin")]
		public int usp_IsAdmin([Parameter(Name="AppName", DbType="Char(2)")] string appName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), appName);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.usp_IsDBO")]
		public int usp_IsDBO([Parameter(Name="AppName", DbType="Char(2)")] string appName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), appName);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.usp_SetLastLoginInfo")]
		public int usp_SetLastLoginInfo([Parameter(DbType="VarChar(7)")] string strUserId, [Parameter(DbType="VarChar(26)")] string strLastLogin)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), strUserId, strLastLogin);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.usp_UpdateAppInfo")]
		public int usp_UpdateAppInfo([Parameter(Name="AppName", DbType="Char(2)")] string appName, [Parameter(Name="KeyName", DbType="VarChar(255)")] string keyName, [Parameter(Name="KeyNewValue", DbType="VarChar(255)")] string keyNewValue, [Parameter(Name="KeyOldValue", DbType="VarChar(255)")] string keyOldValue)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), appName, keyName, keyNewValue, keyOldValue);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.usp_UpdatePersonInfo")]
		public int usp_UpdatePersonInfo([Parameter(Name="AppName", DbType="Char(2)")] string appName, [Parameter(Name="PersonId", DbType="Char(7)")] string personId, [Parameter(Name="KeyName", DbType="VarChar(255)")] string keyName, [Parameter(Name="KeyNewValue", DbType="VarChar(255)")] string keyNewValue, [Parameter(Name="KeyOldValue", DbType="VarChar(255)")] string keyOldValue)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), appName, personId, keyName, keyNewValue, keyOldValue);
			return ((int)(result.ReturnValue));
		}
	}
	
	[Table(Name="dbo.TblKeyName")]
	public partial class TblKeyName
	{
		
		private string _PruAppName;
		
		private int _PruKeyId;
		
		private string _PruKeyName;
		
		public TblKeyName()
		{
		}
		
		[Column(Storage="_PruAppName", DbType="Char(2)")]
		public string PruAppName
		{
			get
			{
				return this._PruAppName;
			}
			set
			{
				if ((this._PruAppName != value))
				{
					this._PruAppName = value;
				}
			}
		}
		
		[Column(Storage="_PruKeyId", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int PruKeyId
		{
			get
			{
				return this._PruKeyId;
			}
			set
			{
				if ((this._PruKeyId != value))
				{
					this._PruKeyId = value;
				}
			}
		}
		
		[Column(Storage="_PruKeyName", DbType="VarChar(255)")]
		public string PruKeyName
		{
			get
			{
				return this._PruKeyName;
			}
			set
			{
				if ((this._PruKeyName != value))
				{
					this._PruKeyName = value;
				}
			}
		}
	}
	
	[Table(Name="dbo.TblKeyValue")]
	public partial class TblKeyValue
	{
		
		private string _PruAppName;
		
		private System.Nullable<int> _PruKeyId;
		
		private string _PruUserId;
		
		private string _PruKeyValue;
		
		public TblKeyValue()
		{
		}
		
		[Column(Storage="_PruAppName", DbType="Char(2)")]
		public string PruAppName
		{
			get
			{
				return this._PruAppName;
			}
			set
			{
				if ((this._PruAppName != value))
				{
					this._PruAppName = value;
				}
			}
		}
		
		[Column(Storage="_PruKeyId", DbType="Int")]
		public System.Nullable<int> PruKeyId
		{
			get
			{
				return this._PruKeyId;
			}
			set
			{
				if ((this._PruKeyId != value))
				{
					this._PruKeyId = value;
				}
			}
		}
		
		[Column(Storage="_PruUserId", DbType="Char(7)")]
		public string PruUserId
		{
			get
			{
				return this._PruUserId;
			}
			set
			{
				if ((this._PruUserId != value))
				{
					this._PruUserId = value;
				}
			}
		}
		
		[Column(Storage="_PruKeyValue", DbType="VarChar(255)")]
		public string PruKeyValue
		{
			get
			{
				return this._PruKeyValue;
			}
			set
			{
				if ((this._PruKeyValue != value))
				{
					this._PruKeyValue = value;
				}
			}
		}
	}
	
	[Table(Name="dbo.tblpersoninfo")]
	public partial class tblpersoninfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _First_name;
		
		private string _Last_name;
		
		private string _UserId;
		
		private string _CaseMgrId;
		
		private string _UserRole;
		
		private string _UserTeam;
		
		private string _Location;
		
		private string _PIWDVersion;
		
		private string _LastLogin;
		
		private string _LastModified_User;
		
		private System.Nullable<System.DateTime> _LastModified_Time;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFirst_nameChanging(string value);
    partial void OnFirst_nameChanged();
    partial void OnLast_nameChanging(string value);
    partial void OnLast_nameChanged();
    partial void OnUserIdChanging(string value);
    partial void OnUserIdChanged();
    partial void OnCaseMgrIdChanging(string value);
    partial void OnCaseMgrIdChanged();
    partial void OnUserRoleChanging(string value);
    partial void OnUserRoleChanged();
    partial void OnUserTeamChanging(string value);
    partial void OnUserTeamChanged();
    partial void OnLocationChanging(string value);
    partial void OnLocationChanged();
    partial void OnPIWDVersionChanging(string value);
    partial void OnPIWDVersionChanged();
    partial void OnLastLoginChanging(string value);
    partial void OnLastLoginChanged();
    partial void OnLastModified_UserChanging(string value);
    partial void OnLastModified_UserChanged();
    partial void OnLastModified_TimeChanging(System.Nullable<System.DateTime> value);
    partial void OnLastModified_TimeChanged();
    #endregion
		
		public tblpersoninfo()
		{
			OnCreated();
		}
		
		[Column(Storage="_First_name", DbType="VarChar(15)")]
		public string First_name
		{
			get
			{
				return this._First_name;
			}
			set
			{
				if ((this._First_name != value))
				{
					this.OnFirst_nameChanging(value);
					this.SendPropertyChanging();
					this._First_name = value;
					this.SendPropertyChanged("First_name");
					this.OnFirst_nameChanged();
				}
			}
		}
		
		[Column(Storage="_Last_name", DbType="VarChar(20)")]
		public string Last_name
		{
			get
			{
				return this._Last_name;
			}
			set
			{
				if ((this._Last_name != value))
				{
					this.OnLast_nameChanging(value);
					this.SendPropertyChanging();
					this._Last_name = value;
					this.SendPropertyChanged("Last_name");
					this.OnLast_nameChanged();
				}
			}
		}
		
		[Column(Storage="_UserId", DbType="VarChar(7) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[Column(Storage="_CaseMgrId", DbType="VarChar(4)")]
		public string CaseMgrId
		{
			get
			{
				return this._CaseMgrId;
			}
			set
			{
				if ((this._CaseMgrId != value))
				{
					this.OnCaseMgrIdChanging(value);
					this.SendPropertyChanging();
					this._CaseMgrId = value;
					this.SendPropertyChanged("CaseMgrId");
					this.OnCaseMgrIdChanged();
				}
			}
		}
		
		[Column(Storage="_UserRole", DbType="VarChar(30)")]
		public string UserRole
		{
			get
			{
				return this._UserRole;
			}
			set
			{
				if ((this._UserRole != value))
				{
					this.OnUserRoleChanging(value);
					this.SendPropertyChanging();
					this._UserRole = value;
					this.SendPropertyChanged("UserRole");
					this.OnUserRoleChanged();
				}
			}
		}
		
		[Column(Storage="_UserTeam", DbType="VarChar(20)")]
		public string UserTeam
		{
			get
			{
				return this._UserTeam;
			}
			set
			{
				if ((this._UserTeam != value))
				{
					this.OnUserTeamChanging(value);
					this.SendPropertyChanging();
					this._UserTeam = value;
					this.SendPropertyChanged("UserTeam");
					this.OnUserTeamChanged();
				}
			}
		}
		
		[Column(Storage="_Location", DbType="VarChar(15)")]
		public string Location
		{
			get
			{
				return this._Location;
			}
			set
			{
				if ((this._Location != value))
				{
					this.OnLocationChanging(value);
					this.SendPropertyChanging();
					this._Location = value;
					this.SendPropertyChanged("Location");
					this.OnLocationChanged();
				}
			}
		}
		
		[Column(Storage="_PIWDVersion", DbType="VarChar(15)")]
		public string PIWDVersion
		{
			get
			{
				return this._PIWDVersion;
			}
			set
			{
				if ((this._PIWDVersion != value))
				{
					this.OnPIWDVersionChanging(value);
					this.SendPropertyChanging();
					this._PIWDVersion = value;
					this.SendPropertyChanged("PIWDVersion");
					this.OnPIWDVersionChanged();
				}
			}
		}
		
		[Column(Storage="_LastLogin", DbType="VarChar(26)")]
		public string LastLogin
		{
			get
			{
				return this._LastLogin;
			}
			set
			{
				if ((this._LastLogin != value))
				{
					this.OnLastLoginChanging(value);
					this.SendPropertyChanging();
					this._LastLogin = value;
					this.SendPropertyChanged("LastLogin");
					this.OnLastLoginChanged();
				}
			}
		}
		
		[Column(Storage="_LastModified_User", DbType="VarChar(25)")]
		public string LastModified_User
		{
			get
			{
				return this._LastModified_User;
			}
			set
			{
				if ((this._LastModified_User != value))
				{
					this.OnLastModified_UserChanging(value);
					this.SendPropertyChanging();
					this._LastModified_User = value;
					this.SendPropertyChanged("LastModified_User");
					this.OnLastModified_UserChanged();
				}
			}
		}
		
		[Column(Storage="_LastModified_Time", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastModified_Time
		{
			get
			{
				return this._LastModified_Time;
			}
			set
			{
				if ((this._LastModified_Time != value))
				{
					this.OnLastModified_TimeChanging(value);
					this.SendPropertyChanging();
					this._LastModified_Time = value;
					this.SendPropertyChanged("LastModified_Time");
					this.OnLastModified_TimeChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	public partial class usp_AdminGetUserInfoResult
	{
		
		private string _PruKeyValue;
		
		public usp_AdminGetUserInfoResult()
		{
		}
		
		[Column(Storage="_PruKeyValue", DbType="VarChar(255)")]
		public string PruKeyValue
		{
			get
			{
				return this._PruKeyValue;
			}
			set
			{
				if ((this._PruKeyValue != value))
				{
					this._PruKeyValue = value;
				}
			}
		}
	}
	
	public partial class usp_GetAllAppInfoResult
	{
		
		private string _PruKeyName;
		
		private string _PruKeyValue;
		
		public usp_GetAllAppInfoResult()
		{
		}
		
		[Column(Storage="_PruKeyName", DbType="VarChar(255)")]
		public string PruKeyName
		{
			get
			{
				return this._PruKeyName;
			}
			set
			{
				if ((this._PruKeyName != value))
				{
					this._PruKeyName = value;
				}
			}
		}
		
		[Column(Storage="_PruKeyValue", DbType="VarChar(255)")]
		public string PruKeyValue
		{
			get
			{
				return this._PruKeyValue;
			}
			set
			{
				if ((this._PruKeyValue != value))
				{
					this._PruKeyValue = value;
				}
			}
		}
	}
	
	public partial class usp_GetPersonInfoResult
	{
		
		private string _PruKeyValue;
		
		public usp_GetPersonInfoResult()
		{
		}
		
		[Column(Storage="_PruKeyValue", DbType="VarChar(255)")]
		public string PruKeyValue
		{
			get
			{
				return this._PruKeyValue;
			}
			set
			{
				if ((this._PruKeyValue != value))
				{
					this._PruKeyValue = value;
				}
			}
		}
	}
}
#pragma warning restore 1591