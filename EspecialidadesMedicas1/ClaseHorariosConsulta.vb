Public Class ClaseHorariosConsulta
    Private idHorario As Integer
    Private entrada As Integer
    Private salida As Integer
    Private inicioDescanso As Integer
    Private finDescanso As Integer

    Public Sub New(ByVal idHorario As Integer,
                   ByVal txt_entrada As Integer,
                   ByVal txt_salida As Integer,
                   ByVal txt_inicio_descanso As Integer,
                   ByVal txt_fin_descanso As Integer)

        Me.idHorario = idHorario
        entrada = txt_entrada
        salida = txt_salida
        inicioDescanso = txt_inicio_descanso
        finDescanso = txt_fin_descanso

    End Sub

    Public Sub New()

    End Sub

    Public Property getSetHorario() As String
        Get
            Return idHorario
        End Get
        Set(ByVal Value As String)
            idHorario = Value
        End Set
    End Property

    Public Property getSetEntrada() As String
        Get
            Return entrada
        End Get
        Set(ByVal Values As String)
            entrada = Values
        End Set
    End Property

    Public Property getSetSalida() As Byte
        Get
            Return salida
        End Get
        Set(ByVal Values As Byte)
            salida = Values
        End Set
    End Property

    Public Property getSetInicioDescanso() As Byte
        Get
            Return inicioDescanso
        End Get
        Set(ByVal Values As Byte)
            inicioDescanso = Values
        End Set
    End Property

    Public Property getSetFinDescanso() As Byte
        Get
            Return finDescanso
        End Get
        Set(ByVal Values As Byte)
            finDescanso = Values
        End Set
    End Property

    'metodo para insertar un usuario al momento de agregarlo
    Public Sub insertarHorario()

        'verificamos que los campos no esten vacios
        If True Then

            Dim query As New Oracle.ManagedDataAccess.Client.OracleCommand("insert into horario_de_consulta values(" & finDescanso & "," &
                                                  entrada & "," &
                                                  salida & "," &
                                                  inicioDescanso & "," &
                                                  finDescanso & ")", Conexion)
            query.ExecuteNonQuery()

        Else
            MsgBox("¡Faltan campos por llenar!", MsgBoxStyle.Critical, "Error.")
        End If
    End Sub
End Class
