Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Win32
Imports System.Text
Imports System.Configuration
Imports System.Data.OleDb
Public Class FrmInicio
    Dim RutaArchivo As String
    Dim consulta, cadena As String
    Dim longitud As Double
    Public variable As String
    'ARRASTRAR EL FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub GunaImageButton1_Click(sender As Object, e As EventArgs) Handles GunaImageButton1.Click
        Try
            Dim ofd As OpenFileDialog = New OpenFileDialog
            ofd.DefaultExt = "txt"
            ofd.FileName = "defaultname"
            ofd.InitialDirectory = "c:\"
            ofd.Filter = "All files|*.*|Text files|*.txt"
            ofd.Title = "Select file"
            If ofd.ShowDialog() <> DialogResult.Cancel Then
                RutaArchivo = ofd.FileName
                LbRuta.Text = RutaArchivo
            End If
        Catch ex As Exception
            MsgBox("No se pudo leer el archivo.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            Dim Aplicacion
            Dim Libro As Excel.Workbook
            Dim Hoja As Excel.Worksheet

            Aplicacion = New Excel.Application
            Libro = Aplicacion.Workbooks.Open(RutaArchivo)
            Hoja = Libro.Worksheets("Importados")


            For i = 1 To 96
                DataGridView2.Rows.Add(Libro.Sheets("Importados").Cells(i + 4, 1).Value)
            Next i

            Libro.Close()
            Aplicacion.Quit()
            releaseObject(Aplicacion)
            releaseObject(Libro)
            releaseObject(Hoja)

            Dim conteo As Integer
            For i = 0 To DataGridView2.Rows.Count - 2
                If DataGridView2.Item(0, i).Value = "" Then
                    cadena = cadena
                Else
                    conteo = conteo + 1
                    cadena = cadena & DataGridView2.Item(0, i).Value & ","
                End If
            Next i
            comando2019 = conexion2019.CreateCommand()
            cadena = cadena.Substring(0, Len(cadena) - 1)


            cadena = "select " + cadena + " from [INFORMES-SERVICIOS] where MAGNITUD='" & TxtMagnitud.Text & "' and INFORME='" & TxtInforme.Text & "'"


            comando2019.CommandText = cadena
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            Dim renglon As Integer = 0
            For i = 0 To DataGridView2.Rows.Count - 2

                If Not DataGridView2.Item(0, i).Value = "" Then
                    If renglon <= conteo Then
                        DataGridView2.Item(1, i).Value = lector2019(renglon)
                        renglon = renglon + 1
                    End If
                End If
            Next i

            Aplicacion = New Excel.Application
            Libro = Aplicacion.Workbooks.Open(RutaArchivo)
            Hoja = Libro.Worksheets("Importados")
            For i = 0 To DataGridView2.Rows.Count - 2
                Hoja.Cells(i + 5, 2) = DataGridView2.Item(1, i).Value
            Next i
            Libro.Close()
            Aplicacion.Quit()
            releaseObject(Aplicacion)
            releaseObject(Libro)
            releaseObject(Hoja)

            MsgBox("Datos cargados correctamente.", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("Ocurrio un error de captura de datos", MsgBoxStyle.Critical)
            Me.Dispose()
        End Try
    End Sub

    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click
        Try
            Dim Aplicacion As New Excel.Application
            Dim Libro As Excel.Workbook
            Dim Hoja As Excel.Worksheet
            Aplicacion = New Excel.Application
            Libro = Aplicacion.Workbooks.Open(RutaArchivo)
            Hoja = Libro.Worksheets("Importados")

            ''se escribe en excel, el nombre de las columnas de SQL---------------
            For i = 1 To DataGridView1.Rows.Count - 2
                Hoja.Cells(i + 4, 8) = "[" & DataGridView1.Item(0, i).Value & "]"
            Next i
            ''--------------------------------------------------------------------

            Libro.Close()
            Aplicacion.Quit()
            'releaseObject(Aplicacion)
            'releaseObject(Libro)
            'releaseObject(Hoja)
            MsgBox("Columnas Actualizadas", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("No se pudo leer el archivo.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub FrmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LeerArchivo()
            MetodoMetasInf2019()
            Dim R As String
            R = "SELECT TOP 1 * FROM [INFORMES-SERVICIOS]"
            Dim dAdap As New SqlDataAdapter(R, conexion2019)
            Dim ds As New DataSet
            dAdap.Fill(ds)
            For Each dc As DataColumn In ds.Tables(0).Columns
                DataGridView1.Rows.Add(dc.ColumnName)
            Next
        Catch ex As Exception
            MsgBox("Error de lectura de datos.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Sub LeerArchivo()
        Dim leer As New StreamReader("\\10.10.10.7\Public-2\ServiciosExcel\Actualizaciones\Version\version.txt")
        Try
            'Se abre el txt para ver la version
            While leer.Peek <> -1
                Dim linea As String = leer.ReadLine()
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                variable = (linea)
            End While
            leer.Close()
            If Not variable = lbVersion.Text Then 'Verifica si la version es igual a la del txt
                MsgBox("Existe una nueva actualizacion", MsgBoxStyle.Exclamation, "Servicios a Excel")
                Dim OpenFileDialog As New OpenFileDialog
                Process.Start("\\10.10.10.7\Public-2\ServiciosExcel\Actualizaciones\Ultima_Version\ServiciosExcel.msp")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
        End Try
    End Sub
End Class
