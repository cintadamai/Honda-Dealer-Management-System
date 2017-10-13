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

    <Persistent("unit_purchase")>
    Partial Public Class UnitPurchaseModel
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
        Dim fSupplier As UnitSupplierModel
        <Persistent("supplier")>
        <Association("UnitPurchaseModelReferencesUnitSupplierModel")>
        Public Property Supplier() As UnitSupplierModel
            Get
                Return fSupplier
            End Get
            Set(ByVal value As UnitSupplierModel)
                SetPropertyValue(Of UnitSupplierModel)("Supplier", fSupplier, value)
            End Set
        End Property
        Dim fTanggalPembelian As DateTime
        <Persistent("tanggal_pembelian")>
        Public Property TanggalPembelian() As DateTime
            Get
                Return fTanggalPembelian
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("TanggalPembelian", fTanggalPembelian, value)
            End Set
        End Property
        Dim fNoInvoice As String
        <Size(SizeAttribute.Unlimited)>
        <Persistent("no_invoice")>
        Public Property NoInvoice() As String
            Get
                Return fNoInvoice
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("NoInvoice", fNoInvoice, value)
            End Set
        End Property
        Dim fNoFaktur As String
        <Size(SizeAttribute.Unlimited)>
        <Persistent("no_faktur")>
        Public Property NoFaktur() As String
            Get
                Return fNoFaktur
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("NoFaktur", fNoFaktur, value)
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
        Dim fIsppn As Boolean
        <Persistent("isPPN")>
        Public Property Isppn() As Boolean
            Get
                Return fIsppn
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("Isppn", fIsppn, value)
            End Set
        End Property
        Dim fNilai As Decimal
        <Persistent("nilai")>
        Public Property Nilai() As Decimal
            Get
                Return fNilai
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("Nilai", fNilai, value)
            End Set
        End Property
        Dim fPotongan As Decimal
        <Persistent("potongan")>
        Public Property Potongan() As Decimal
            Get
                Return fPotongan
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("Potongan", fPotongan, value)
            End Set
        End Property
        Dim fDpp As Decimal
        <Persistent("dpp")>
        Public Property Dpp() As Decimal
            Get
                Return fDpp
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("Dpp", fDpp, value)
            End Set
        End Property
        Dim fPpn As Decimal
        <Persistent("ppn")>
        Public Property Ppn() As Decimal
            Get
                Return fPpn
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("Ppn", fPpn, value)
            End Set
        End Property
        Dim fTotal As Decimal
        <Persistent("total")>
        Public Property Total() As Decimal
            Get
                Return fTotal
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("Total", fTotal, value)
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
        <Association("UnitPurchaseDetailModelReferencesUnitPurchaseModel")>
        Public ReadOnly Property UnitPurchaseDetails() As XPCollection(Of UnitPurchaseDetailModel)
            Get
                Return GetCollection(Of UnitPurchaseDetailModel)("UnitPurchaseDetails")
            End Get
        End Property
    End Class

End Namespace
