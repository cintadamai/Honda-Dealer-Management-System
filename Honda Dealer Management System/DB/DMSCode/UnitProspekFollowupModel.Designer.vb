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

    <Persistent("unit_prospek_followup")>
    Partial Public Class UnitProspekFollowupModel
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
        Dim fProspek As UnitProspekModel
        <Persistent("prospek")>
        <Association("UnitProspekFollowupModelReferencesUnitProspekModel")>
        Public Property Prospek() As UnitProspekModel
            Get
                Return fProspek
            End Get
            Set(ByVal value As UnitProspekModel)
                SetPropertyValue(Of UnitProspekModel)("Prospek", fProspek, value)
            End Set
        End Property
        Dim fTanggalFollowup As DateTime
        <Persistent("tanggal_followup")>
        Public Property TanggalFollowup() As DateTime
            Get
                Return fTanggalFollowup
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("TanggalFollowup", fTanggalFollowup, value)
            End Set
        End Property
        Dim fStatusInformasi As String
        <Size(SizeAttribute.Unlimited)>
        <Persistent("status_informasi")>
        Public Property StatusInformasi() As String
            Get
                Return fStatusInformasi
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("StatusInformasi", fStatusInformasi, value)
            End Set
        End Property
        Dim fNextFollowup As DateTime
        <Persistent("next_followup")>
        Public Property NextFollowup() As DateTime
            Get
                Return fNextFollowup
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("NextFollowup", fNextFollowup, value)
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
        Dim fJenisKunjungan As String
        <Size(SizeAttribute.Unlimited)>
        <Persistent("jenis_kunjungan")>
        Public Property JenisKunjungan() As String
            Get
                Return fJenisKunjungan
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("JenisKunjungan", fJenisKunjungan, value)
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
    End Class

End Namespace
