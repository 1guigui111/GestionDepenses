﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Depenses")]
public partial class DepenseBDDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Définitions de méthodes d'extensibilité
  partial void OnCreated();
  partial void InsertT_Connexion(T_Connexion instance);
  partial void UpdateT_Connexion(T_Connexion instance);
  partial void DeleteT_Connexion(T_Connexion instance);
  partial void InsertT_FactureGaz(T_FactureGaz instance);
  partial void UpdateT_FactureGaz(T_FactureGaz instance);
  partial void DeleteT_FactureGaz(T_FactureGaz instance);
  #endregion
	
	public DepenseBDDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DepensesConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DepenseBDDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DepenseBDDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DepenseBDDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DepenseBDDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<T_Connexion> T_Connexion
	{
		get
		{
			return this.GetTable<T_Connexion>();
		}
	}
	
	public System.Data.Linq.Table<T_FactureGaz> T_FactureGaz
	{
		get
		{
			return this.GetTable<T_FactureGaz>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.T_Connexion")]
public partial class T_Connexion : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _idCo;
	
	private string _username;
	
	private string _pwd;
	
	private EntitySet<T_FactureGaz> _T_FactureGaz;
	
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidCoChanging(int value);
    partial void OnidCoChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpwdChanging(string value);
    partial void OnpwdChanged();
    #endregion
	
	public T_Connexion()
	{
		this._T_FactureGaz = new EntitySet<T_FactureGaz>(new Action<T_FactureGaz>(this.attach_T_FactureGaz), new Action<T_FactureGaz>(this.detach_T_FactureGaz));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int idCo
	{
		get
		{
			return this._idCo;
		}
		set
		{
			if ((this._idCo != value))
			{
				this.OnidCoChanging(value);
				this.SendPropertyChanging();
				this._idCo = value;
				this.SendPropertyChanged("idCo");
				this.OnidCoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(30)")]
	public string username
	{
		get
		{
			return this._username;
		}
		set
		{
			if ((this._username != value))
			{
				this.OnusernameChanging(value);
				this.SendPropertyChanging();
				this._username = value;
				this.SendPropertyChanged("username");
				this.OnusernameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pwd", DbType="VarChar(30)")]
	public string pwd
	{
		get
		{
			return this._pwd;
		}
		set
		{
			if ((this._pwd != value))
			{
				this.OnpwdChanging(value);
				this.SendPropertyChanging();
				this._pwd = value;
				this.SendPropertyChanged("pwd");
				this.OnpwdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="T_Connexion_T_FactureGaz", Storage="_T_FactureGaz", ThisKey="idCo", OtherKey="idCo")]
	public EntitySet<T_FactureGaz> T_FactureGaz
	{
		get
		{
			return this._T_FactureGaz;
		}
		set
		{
			this._T_FactureGaz.Assign(value);
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
	
	private void attach_T_FactureGaz(T_FactureGaz entity)
	{
		this.SendPropertyChanging();
		entity.T_Connexion = this;
	}
	
	private void detach_T_FactureGaz(T_FactureGaz entity)
	{
		this.SendPropertyChanging();
		entity.T_Connexion = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.T_FactureGaz")]
public partial class T_FactureGaz : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _idFac;
	
	private System.Nullable<decimal> _nbKilo;
	
	private System.Nullable<float> _cout;
	
	private System.Nullable<System.DateTime> _ddate;
	
	private int _idCo;
	
	private EntityRef<T_Connexion> _T_Connexion;
	
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidFacChanging(int value);
    partial void OnidFacChanged();
    partial void OnnbKiloChanging(System.Nullable<decimal> value);
    partial void OnnbKiloChanged();
    partial void OncoutChanging(System.Nullable<float> value);
    partial void OncoutChanged();
    partial void OnddateChanging(System.Nullable<System.DateTime> value);
    partial void OnddateChanged();
    partial void OnidCoChanging(int value);
    partial void OnidCoChanged();
    #endregion
	
	public T_FactureGaz()
	{
		this._T_Connexion = default(EntityRef<T_Connexion>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idFac", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int idFac
	{
		get
		{
			return this._idFac;
		}
		set
		{
			if ((this._idFac != value))
			{
				this.OnidFacChanging(value);
				this.SendPropertyChanging();
				this._idFac = value;
				this.SendPropertyChanged("idFac");
				this.OnidFacChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nbKilo", DbType="SmallMoney")]
	public System.Nullable<decimal> nbKilo
	{
		get
		{
			return this._nbKilo;
		}
		set
		{
			if ((this._nbKilo != value))
			{
				this.OnnbKiloChanging(value);
				this.SendPropertyChanging();
				this._nbKilo = value;
				this.SendPropertyChanged("nbKilo");
				this.OnnbKiloChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cout", DbType="Real")]
	public System.Nullable<float> cout
	{
		get
		{
			return this._cout;
		}
		set
		{
			if ((this._cout != value))
			{
				this.OncoutChanging(value);
				this.SendPropertyChanging();
				this._cout = value;
				this.SendPropertyChanged("cout");
				this.OncoutChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ddate", DbType="Date")]
	public System.Nullable<System.DateTime> ddate
	{
		get
		{
			return this._ddate;
		}
		set
		{
			if ((this._ddate != value))
			{
				this.OnddateChanging(value);
				this.SendPropertyChanging();
				this._ddate = value;
				this.SendPropertyChanged("ddate");
				this.OnddateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCo", DbType="Int NOT NULL")]
	public int idCo
	{
		get
		{
			return this._idCo;
		}
		set
		{
			if ((this._idCo != value))
			{
				if (this._T_Connexion.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnidCoChanging(value);
				this.SendPropertyChanging();
				this._idCo = value;
				this.SendPropertyChanged("idCo");
				this.OnidCoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="T_Connexion_T_FactureGaz", Storage="_T_Connexion", ThisKey="idCo", OtherKey="idCo", IsForeignKey=true)]
	public T_Connexion T_Connexion
	{
		get
		{
			return this._T_Connexion.Entity;
		}
		set
		{
			T_Connexion previousValue = this._T_Connexion.Entity;
			if (((previousValue != value) 
						|| (this._T_Connexion.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._T_Connexion.Entity = null;
					previousValue.T_FactureGaz.Remove(this);
				}
				this._T_Connexion.Entity = value;
				if ((value != null))
				{
					value.T_FactureGaz.Add(this);
					this._idCo = value.idCo;
				}
				else
				{
					this._idCo = default(int);
				}
				this.SendPropertyChanged("T_Connexion");
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
#pragma warning restore 1591
