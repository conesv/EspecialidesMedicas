Imports Oracle.ManagedDataAccess.Client
Module Globales
    Public Conexion As OracleConnection
    Public Sub AbrirConexion()
        Conexion = New OracleConnection
        Try
            Conexion.ConnectionString = "User Id=system;Password=tecsoftware;Data Source=localhost:1521/EX; "
            Conexion.Open()

        Catch ex As Exception
            Conexion.ConnectionString = "User Id=system;Password=tecsoftware;Data Source=localhost:1521/orcl.168.1.71; "
            Conexion.Open()

        End Try
    End Sub
End Module
