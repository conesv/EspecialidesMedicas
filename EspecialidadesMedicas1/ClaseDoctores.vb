Public Class ClaseDoctores
    Private idDoctor As Integer
    Private usuario As String
    Private horario As Integer
    Private especialidad As String
    Private nombre As String
    Private paterno As String
    Private materno As String
    Private celular As Integer

    Public Sub New(ByVal idDoctor As Integer,
                   ByVal txt_usuario As String,
                   ByVal horario As Integer,
                   ByVal txt_especialidad As String,
                   ByVal txt_nombre As String,
                   ByVal txt_paterno As String,
                   ByVal txt_materno As String,
                   ByVal txt_celular As Integer)

        Me.idDoctor = idDoctor
        usuario = txt_usuario
        Me.horario = horario
        especialidad = txt_especialidad
        nombre = txt_nombre
        paterno = txt_paterno
        materno = txt_materno
        celular = txt_celular

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

    Public Property getSetEspecialidad() As String
        Get
            Return especialidad
        End Get
        Set(ByVal Values As String)
            especialidad = Values
        End Set
    End Property

    Public Property getSetNombre() As Byte
        Get
            Return nombre
        End Get
        Set(ByVal Values As Byte)
            nombre = Values
        End Set
    End Property

    Public Property getSetPaterno() As Byte
        Get
            Return paterno
        End Get
        Set(ByVal Values As Byte)
            paterno = Values
        End Set
    End Property

    Public Property getSetMaterno() As Byte
        Get
            Return materno
        End Get
        Set(ByVal Values As Byte)
            materno = Values
        End Set
    End Property

    Public Property getSetCelular() As Byte
        Get
            Return celular
        End Get
        Set(ByVal Values As Byte)
            celular = Values
        End Set
    End Property

    'metodo para insertar un usuario al momento de agregarlo
    Public Sub insertarDoctor()
        ' Dim strSql As String
        'Dim xconexion As New ConexionBD

        'verificamos que los campos no esten vacios
        If True Then

            Dim query As New Oracle.ManagedDataAccess.Client.OracleCommand("insert into doctores values(" & idDoctor & ", '" &
                                                  usuario & "'," &
                                                  horario & ", '" &
                                                  especialidad & "', '" &
                                                  nombre & "', '" &
                                                  paterno & "','" &
                                                  materno & "'," &
                                                  celular & ")", Conexion)
            query.ExecuteNonQuery()

            ' xconexion.objetoCommand(strSql)
            MsgBox("El doctor se ha guardado correctamente", Title:="Ingreso realizado.")
        Else
            MsgBox("¡Faltan campos por llenar!", MsgBoxStyle.Critical, "Error.")
        End If
    End Sub

    Public Function buscaDoctor() As Boolean
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim da As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select id_doctor from doctores where   
                                                                       nombre = '" & nombre & "' AND
                                                                       paterno = '" & paterno & "' AND
                                                                       materno = '" & materno & "'", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
