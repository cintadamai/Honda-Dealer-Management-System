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

    <Persistent("branch")>
    Partial Public Class BranchModel
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
        Dim fNamaBranch As String
        <Size(SizeAttribute.Unlimited)>
        <Persistent("nama_branch")>
        Public Property NamaBranch() As String
            Get
                Return fNamaBranch
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("NamaBranch", fNamaBranch, value)
            End Set
        End Property
        Dim fAlamat As String
        <Size(SizeAttribute.Unlimited)>
        <Persistent("alamat")>
        Public Property Alamat() As String
            Get
                Return fAlamat
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Alamat", fAlamat, value)
            End Set
        End Property
        Dim fKotakabupaten As String
        <Size(SizeAttribute.Unlimited)>
        <Persistent("kotaKabupaten")>
        Public Property Kotakabupaten() As String
            Get
                Return fKotakabupaten
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Kotakabupaten", fKotakabupaten, value)
            End Set
        End Property
        Dim fNoTelepon As String
        <Size(SizeAttribute.Unlimited)>
        <Persistent("no_telepon")>
        Public Property NoTelepon() As String
            Get
                Return fNoTelepon
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("NoTelepon", fNoTelepon, value)
            End Set
        End Property
        Dim fNoFax As String
        <Size(SizeAttribute.Unlimited)>
        <Persistent("no_fax")>
        Public Property NoFax() As String
            Get
                Return fNoFax
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("NoFax", fNoFax, value)
            End Set
        End Property
        Dim fEmail As String
        <Size(SizeAttribute.Unlimited)>
        <Persistent("email")>
        Public Property Email() As String
            Get
                Return fEmail
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Email", fEmail, value)
            End Set
        End Property
        Dim fIsactive As Boolean
        <Persistent("isActive")>
        Public Property Isactive() As Boolean
            Get
                Return fIsactive
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("Isactive", fIsactive, value)
            End Set
        End Property
        Dim fTanggalAktif As DateTime
        <Persistent("tanggal_aktif")>
        Public Property TanggalAktif() As DateTime
            Get
                Return fTanggalAktif
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("TanggalAktif", fTanggalAktif, value)
            End Set
        End Property
        Dim fNpwp As String
        <Size(SizeAttribute.Unlimited)>
        <Persistent("npwp")>
        Public Property Npwp() As String
            Get
                Return fNpwp
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Npwp", fNpwp, value)
            End Set
        End Property
        <Association("KaryawanModelReferencesBranchModel")>
        Public ReadOnly Property Karyawans() As XPCollection(Of KaryawanModel)
            Get
                Return GetCollection(Of KaryawanModel)("Karyawans")
            End Get
        End Property
        <Association("UnitSpkModelReferencesBranchModel")>
        Public ReadOnly Property UnitSpks() As XPCollection(Of UnitSpkModel)
            Get
                Return GetCollection(Of UnitSpkModel)("UnitSpks")
            End Get
        End Property
    End Class

End Namespace
