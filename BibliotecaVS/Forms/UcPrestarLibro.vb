Imports System.Windows.Forms.Design.AxImporter

Public Class UcPrestarLibro
    Private _libros As New Queue(Of Libro)
    Private _miembros As New Queue(Of Miembro)

    Public Sub New(libros As Queue(Of Libro), miembros As Queue(Of Miembro))
        InitializeComponent()

        _libros = libros
        _miembros = miembros

        For Each libro As Libro In _libros
            cbLibros.Items.Add(libro.Titulo)
        Next

        For Each miembro As Miembro In _miembros
            cbUsuarios.Items.Add(miembro.Nombre)
        Next
    End Sub

    Private Sub btnPrestar_Click(sender As Object, e As EventArgs) Handles btnPrestar.Click
        Dim sqlManager As New SqlManager

        If Not cbLibros.SelectedIndex Then
            If Not cbUsuarios.SelectedIndex Then
                If Not cbTiempoPrestamo.SelectedIndex Then
                    sqlManager.SavePrestamo(GetLibroId(), GetMiembroId(), GetDias())

                    cbLibros.SelectedIndex = -1
                    cbUsuarios.SelectedIndex = -1
                    cbTiempoPrestamo.SelectedIndex = -1

                    MessageBox.Show("Se ha creado un nuevo prestamo")
                Else
                    MessageBox.Show("No se ha seleccionado un tiempo de prestamo")
                End If
            Else
                MessageBox.Show("No se ha seleccionado un miembro")
            End If
        Else
            MessageBox.Show("No se ha seleccionado un libro")
        End If
    End Sub

    Private Function GetLibroId() As Integer
        Return _libros.Where(Function(libro) libro.Titulo = cbLibros.Text).FirstOrDefault().IdLibro
    End Function

    Private Function GetMiembroId() As Integer
        Return _miembros.Where(Function(libro) libro.Nombre = cbUsuarios.Text).FirstOrDefault().IdMiembro
    End Function

    Private Function GetDias() As Integer
        Select Case cbTiempoPrestamo.SelectedIndex
            Case 0
                Return 1
            Case 1
                Return 5
            Case 2
                Return 7
            Case 3
                Return 30
            Case Else
                Console.WriteLine("Opción no reconocida")
        End Select
    End Function
End Class
