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

    <Persistent("unit_transfer")>
    Partial Public Class UnitTransferModel
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
        Dim fTanggalTransfer As DateTime
        <Persistent("tanggal_transfer")>
        Public Property TanggalTransfer() As DateTime
            Get
                Return fTanggalTransfer
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("TanggalTransfer", fTanggalTransfer, value)
            End Set
        End Property
        Dim fGudangAsal As UnitGudangModel
        <Persistent("gudang_asal")>
        <Association("UnitTransferModelReferencesUnitGudangModel")>
        Public Property GudangAsal() As UnitGudangModel
            Get
                Return fGudangAsal
            End Get
            Set(ByVal value As UnitGudangModel)
                SetPropertyValue(Of UnitGudangModel)("GudangAsal", fGudangAsal, value)
            End Set
        End Property
        Dim fGudangTujuan As UnitGudangModel
        <Persistent("gudang_tujuan")>
        <Association("UnitTransferModelReferencesUnitGudangModel1")>
        Public Property GudangTujuan() As UnitGudangModel
            Get
                Return fGudangTujuan
            End Get
            Set(ByVal value As UnitGudangModel)
                SetPropertyValue(Of UnitGudangModel)("GudangTujuan", fGudangTujuan, value)
            End Set
        End Property
        Dim fUnitStock As UnitStockModel
        <Persistent("unit_stock")>
        <Association("UnitTransferModelReferencesUnitStockModel")>
        Public Property UnitStock() As UnitStockModel
            Get
                Return fUnitStock
            End Get
            Set(ByVal value As UnitStockModel)
                SetPropertyValue(Of UnitStockModel)("UnitStock", fUnitStock, value)
            End Set
        End Property
        Dim fKeterangan As String
        <Size(SizeAttribute.Unlimited)>
        <Persistent("keterangan")>
        Public Property Keterangan() As String
            Get
                Return fKeterangan
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Keterangan", fKeterangan, value)
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
        Dim fNoBukti As String
        <Size(SizeAttribute.Unlimited)>
        <Persistent("no_bukti")>
        Public Property NoBukti() As String
            Get
                Return fNoBukti
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("NoBukti", fNoBukti, value)
            End Set
        End Property
    End Class

End Namespace
