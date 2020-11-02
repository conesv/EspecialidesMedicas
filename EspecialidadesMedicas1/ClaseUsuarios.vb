Public Class ClaseUsuarios
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

    'metodo para insertar un usuario al momento de agregarlo
    Public Sub insertarUsuario()

        ' verificamos que los campos no esten vacios
        If True Then

            Dim query As New Oracle.ManagedDataAccess.Client.OracleCommand("insert into usuarios values('" & usuario & "', '" & clave & "'," & idTipo & ")", Conexion)
            query.ExecuteNonQuery()

            MsgBox("El usuario se ha guardado correctamente", Title:="Ingreso realizado.")
            
        Else
            MsgBox("¡Faltan campos por llenar!", MsgBoxStyle.Critical, "Error.")
            Return
        End If
    End Sub

    Public Function buscaUsuario() As Boolean
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente

        Dim da As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select usuario from usuarios where usuario = '" & usuario & "'", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

        'buscaUsuario = False
        ' xDT = xCnx.objetoDataAdapter(strSQL)

        '  If xDT.Rows.Count >= 1 Then
        'buscaUsuario = True
        ' End If

    End Function
End Class
