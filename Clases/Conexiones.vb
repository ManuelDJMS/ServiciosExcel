﻿Imports System.Data.SqlClient
Module Conexiones

    Public conexion2019 As SqlConnection              ''Base de datos METASINF-2019
    Public comando2019 As SqlCommand
    Public lector2019 As SqlDataReader
    Sub MetodoMetasInf2019()
        Try
            conexion2019 = New SqlConnection("Data Source=IRONMAN;Initial Catalog=METASINF-2020; User Id=sa; Password=Met99011578a;Integrated Security=False")
            conexion2019.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos" + ex.ToString)
        End Try
    End Sub
End Module
