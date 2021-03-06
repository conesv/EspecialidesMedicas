﻿Public Class ClaseUsuarios
    Private usuario As String
    Private clave As String
    Private idTipo As Integer

    Public Sub New(ByVal txt_usuario As String,
                   ByVal txt_clave As String,
                   ByVal idTipo As Integer)
        usuario = txt_usuario
        clave = txt_clave
        Me.idTipo = idTipo
    End Sub

    Public Sub New()
    End Sub

    Public Property getSetUsuario() As String
        Get
            Return usuario
        End Get
        Set(ByVal Value As String)
            usuario = Value
        End Set
    End Property

    Public Property getSetClave() As String
        Get
            Return clave
        End Get
        Set(ByVal Values As String)
            clave = Values
        End Set
    End Property

    Public Property getSetTipo() As Byte
        Get
            Return idTipo
        End Get
        Set(ByVal Values As Byte)
            idTipo = Values
        End Set
    End Property


    Public Sub insertarUsuario()
        'metodo para insertar un usuario 
        Dim wrapper As New Simple3Des("a")
        Dim cipherText As String = wrapper.EncryptData(clave)
        Dim query As New Oracle.ManagedDataAccess.Client.OracleCommand("insert into usuarios values('" & usuario & "', '" & cipherText & "'," & idTipo & ")", Conexion)
        query.ExecuteNonQuery()
    End Sub

    Public Function buscaUsuario() As Boolean
        ' Método para buscar a un usuario en particular, para saber
        ' si ya existe o no
        Dim da As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select usuario from usuarios where usuario = '" & usuario & "'", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
