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

    <Persistent("Setting")>
    Partial Public Class SettingModel
        Inherits XPLiteObject
        Dim fId As Short
        <Key()>
        <Persistent("id")>
        Public Property Id() As Short
            Get
                Return fId
            End Get
            Set(ByVal value As Short)
                SetPropertyValue(Of Short)("Id", fId, value)
            End Set
        End Property
        Dim fTarifPpn As Decimal
        <Persistent("tarif_ppn")>
        Public Property TarifPpn() As Decimal
            Get
                Return fTarifPpn
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("TarifPpn", fTarifPpn, value)
            End Set
        End Property
    End Class

End Namespace