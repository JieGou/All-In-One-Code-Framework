﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="EmailValidationDB")>  _
Partial Public Class EmailAddressValidationDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InserttblEmailValidation(instance As tblEmailValidation)
    End Sub
  Partial Private Sub UpdatetblEmailValidation(instance As tblEmailValidation)
    End Sub
  Partial Private Sub DeletetblEmailValidation(instance As tblEmailValidation)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("EmailValidationDBConnectionString").ConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property tblEmailValidations() As System.Data.Linq.Table(Of tblEmailValidation)
		Get
			Return Me.GetTable(Of tblEmailValidation)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tblEmailValidation")>  _
Partial Public Class tblEmailValidation
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _id As Integer
	
	Private _EmailAddress As String
	
	Private _IsValidated As Boolean
	
	Private _IsSendCheckEmail As Boolean
	
	Private _ValidatingStartTime As Date
	
	Private _ValidateKey As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnidChanging(value As Integer)
    End Sub
    Partial Private Sub OnidChanged()
    End Sub
    Partial Private Sub OnEmailAddressChanging(value As String)
    End Sub
    Partial Private Sub OnEmailAddressChanged()
    End Sub
    Partial Private Sub OnIsValidatedChanging(value As Boolean)
    End Sub
    Partial Private Sub OnIsValidatedChanged()
    End Sub
    Partial Private Sub OnIsSendCheckEmailChanging(value As Boolean)
    End Sub
    Partial Private Sub OnIsSendCheckEmailChanged()
    End Sub
    Partial Private Sub OnValidatingStartTimeChanging(value As Date)
    End Sub
    Partial Private Sub OnValidatingStartTimeChanged()
    End Sub
    Partial Private Sub OnValidateKeyChanging(value As String)
    End Sub
    Partial Private Sub OnValidateKeyChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property id() As Integer
		Get
			Return Me._id
		End Get
		Set
			If ((Me._id = value)  _
						= false) Then
				Me.OnidChanging(value)
				Me.SendPropertyChanging
				Me._id = value
				Me.SendPropertyChanged("id")
				Me.OnidChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EmailAddress", DbType:="NVarChar(100) NOT NULL", CanBeNull:=false)>  _
	Public Property EmailAddress() As String
		Get
			Return Me._EmailAddress
		End Get
		Set
			If (String.Equals(Me._EmailAddress, value) = false) Then
				Me.OnEmailAddressChanging(value)
				Me.SendPropertyChanging
				Me._EmailAddress = value
				Me.SendPropertyChanged("EmailAddress")
				Me.OnEmailAddressChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IsValidated", DbType:="Bit NOT NULL")>  _
	Public Property IsValidated() As Boolean
		Get
			Return Me._IsValidated
		End Get
		Set
			If ((Me._IsValidated = value)  _
						= false) Then
				Me.OnIsValidatedChanging(value)
				Me.SendPropertyChanging
				Me._IsValidated = value
				Me.SendPropertyChanged("IsValidated")
				Me.OnIsValidatedChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IsSendCheckEmail", DbType:="Bit NOT NULL")>  _
	Public Property IsSendCheckEmail() As Boolean
		Get
			Return Me._IsSendCheckEmail
		End Get
		Set
			If ((Me._IsSendCheckEmail = value)  _
						= false) Then
				Me.OnIsSendCheckEmailChanging(value)
				Me.SendPropertyChanging
				Me._IsSendCheckEmail = value
				Me.SendPropertyChanged("IsSendCheckEmail")
				Me.OnIsSendCheckEmailChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ValidatingStartTime", DbType:="DateTime NOT NULL")>  _
	Public Property ValidatingStartTime() As Date
		Get
			Return Me._ValidatingStartTime
		End Get
		Set
			If ((Me._ValidatingStartTime = value)  _
						= false) Then
				Me.OnValidatingStartTimeChanging(value)
				Me.SendPropertyChanging
				Me._ValidatingStartTime = value
				Me.SendPropertyChanged("ValidatingStartTime")
				Me.OnValidatingStartTimeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ValidateKey", DbType:="NVarChar(128) NOT NULL", CanBeNull:=false)>  _
	Public Property ValidateKey() As String
		Get
			Return Me._ValidateKey
		End Get
		Set
			If (String.Equals(Me._ValidateKey, value) = false) Then
				Me.OnValidateKeyChanging(value)
				Me.SendPropertyChanging
				Me._ValidateKey = value
				Me.SendPropertyChanged("ValidateKey")
				Me.OnValidateKeyChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
