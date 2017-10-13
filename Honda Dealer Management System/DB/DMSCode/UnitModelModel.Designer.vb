﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Namespace HDMS

    <Persistent("unit_model")>
    Partial Public Class UnitModelModel
        Inherits XPLiteObject
        Dim fId As Long
        <Key(True)>
        <Persistent("id")>
        Public Property Id() As Long
            Get
                Return fId
            End Get
            Set(ByVal value As Long)
                SetPropertyValue(Of Long)("Id", fId, value)
            End Set
        End Property
        Dim fModel As String
        <Size(SizeAttribute.Unlimited)>
        <Persistent("model")>
        Public Property Model() As String
            Get
                Return fModel
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Model", fModel, value)
            End Set
        End Property
        Dim fTipe As String
        <Size(255)>
        <Persistent("tipe")>
        Public Property Tipe() As String
            Get
                Return fTipe
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Tipe", fTipe, value)
            End Set
        End Property
        Dim fVariant1 As String
        <Size(SizeAttribute.Unlimited)>
        <Persistent("variant")>
        Public Property Variant1() As String
            Get
                Return fVariant1
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Variant1", fVariant1, value)
            End Set
        End Property
        Dim fCreatedBy As Long
        <Persistent("created_by")>
        Public Property CreatedBy() As Long
            Get
                Return fCreatedBy
            End Get
            Set(ByVal value As Long)
                SetPropertyValue(Of Long)("CreatedBy", fCreatedBy, value)
            End Set
        End Property
        Dim fCreatedAt As DateTime
        <Persistent("created_at")>
        Public Property CreatedAt() As DateTime
            Get
                Return fCreatedAt
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("CreatedAt", fCreatedAt, value)
            End Set
        End Property
        Dim fUpdatedBy As Long
        <Persistent("updated_by")>
        Public Property UpdatedBy() As Long
            Get
                Return fUpdatedBy
            End Get
            Set(ByVal value As Long)
                SetPropertyValue(Of Long)("UpdatedBy", fUpdatedBy, value)
            End Set
        End Property
        Dim fUpdatedAt As DateTime
        <Persistent("updated_at")>
        Public Property UpdatedAt() As DateTime
            Get
                Return fUpdatedAt
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("UpdatedAt", fUpdatedAt, value)
            End Set
        End Property
        <Association("UnitProspekModelReferencesUnitModelModel")>
        Public ReadOnly Property UnitProspeks() As XPCollection(Of UnitProspekModel)
            Get
                Return GetCollection(Of UnitProspekModel)("UnitProspeks")
            End Get
        End Property
        <Association("UnitPurchaseDetailModelReferencesUnitModelModel")>
        Public ReadOnly Property UnitPurchaseDetails() As XPCollection(Of UnitPurchaseDetailModel)
            Get
                Return GetCollection(Of UnitPurchaseDetailModel)("UnitPurchaseDetails")
            End Get
        End Property
        <Association("UnitSpkModelReferencesUnitModelModel")>
        Public ReadOnly Property UnitSpks() As XPCollection(Of UnitSpkModel)
            Get
                Return GetCollection(Of UnitSpkModel)("UnitSpks")
            End Get
        End Property
        <Association("UnitStockModelReferencesUnitModelModel")>
        Public ReadOnly Property UnitStocks() As XPCollection(Of UnitStockModel)
            Get
                Return GetCollection(Of UnitStockModel)("UnitStocks")
            End Get
        End Property
    End Class

End Namespace
