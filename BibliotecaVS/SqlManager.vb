Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class SqlManager
    Private ReadOnly connectionString As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BibliotecaVB;Data Source=DESKTOP-MK7S9DR"

    Public Function GetAllBooks() As Queue(Of Libro)
        Dim command As New SqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "ObtenerLibros",
            .Connection = GetConection()
        }

        Dim adapter As New SqlDataAdapter(command)
        Dim dataSet As New DataSet()
        Dim libros As New Queue(Of Libro)

        Try
            adapter.Fill(dataSet, "Libros")

            ' Recorrer los datos obtenidos y crear objetos Libro
            For Each row As DataRow In dataSet.Tables("Libros").Rows
                Dim libro As New Libro With {
                    .IdLibro = Convert.ToInt32(row("IdLibro")),
                    .Titulo = Convert.ToString(row("Titulo")),
                    .Autor = Convert.ToString(row("Autor")),
                    .Genero = Convert.ToString(row("Genero")),
                    .AñoPublicacion = Convert.ToInt32(row("AñoPublicacion")),
                    .CantidadDisponible = Convert.ToInt32(row("CantidadDisponible"))
                }

                ' Agregar el objeto Libro a la lista
                libros.Enqueue(libro)
            Next
        Catch ex As Exception
            Dim errorMesage = ex.Message
        Finally
            command.Connection.Close()
        End Try

        Return libros
    End Function

    Public Function GetAllMembers() As Queue(Of Miembro)
        Dim command As New SqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "ObtenerMiembros",
            .Connection = GetConection()
        }

        Dim adapter As New SqlDataAdapter(command)
        Dim dataSet As New DataSet()
        Dim miembros As New Queue(Of Miembro)

        Try
            adapter.Fill(dataSet, "Miembros")

            ' Recorrer los datos obtenidos y crear objetos Libro
            For Each row As DataRow In dataSet.Tables("Miembros").Rows
                Dim miembro As New Miembro With {
                    .IdMiembro = Convert.ToInt32(row("IdMiembro")),
                    .Nombre = Convert.ToString(row("Nombre")),
                    .Direccion = Convert.ToString(row("Direccion")),
                    .CorreoElectronico = Convert.ToString(row("CorreoElectronico"))
                }

                miembros.Enqueue(miembro)
            Next
        Catch ex As Exception
            Dim errorMesage = ex.Message
        Finally
            command.Connection.Close()
        End Try

        Return miembros
    End Function

    Public Sub SavePrestamo(libro As Integer, miembro As Integer, diasPrestamo As Integer)
        Dim command As New SqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = "RegistrarPrestamo",
            .Connection = GetConection()
        }

        ' Agregar los parámetros al comando
        command.Parameters.AddWithValue("@IdLibro", libro) ' Reemplaza 1 con el ID del libro que deseas prestar
        command.Parameters.AddWithValue("@IdMiembro", miembro) ' Reemplaza 1 con el ID del miembro que realiza el préstamo
        command.Parameters.AddWithValue("@FechaPrestamo", DateTime.Now)
        command.Parameters.AddWithValue("@FechaDevolucionEstimada", DateTime.Now.AddDays(diasPrestamo)) ' Por ejemplo, 14 días después de la fecha actual

        command.ExecuteNonQuery()

        'Try
        '    ' Ejecutar el comando

        'Catch ex As Exception

        'Finally
        '    command.Connection.Close()
        'End Try
    End Sub

    Private Function GetConection() As SqlConnection
        Dim connection As New SqlConnection(connectionString)
        connection.Open()

        Return connection
    End Function

End Class
