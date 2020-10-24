Imports Oracle.ManagedDataAccess.Client
Module Globales
    Public Conexion As OracleConnection
    'Hola
    'Qiubo
    'Como estas
    'login
    'hola
    Public Sub AbrirConexion()
        Conexion = New OracleConnection
        Conexion.ConnectionString = "User Id=system;Password=loshuevos123;Data Source=localhost:1521/XE; "
        Conexion.Open()
    End Sub
End Module
