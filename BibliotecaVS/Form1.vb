Imports System.Windows.Forms.VisualStyles

Public Class Form1
    Dim sqlManager As New SqlManager
    Private _libros, _miembros
    Dim LibrosLoaded As Boolean = False


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _libros = sqlManager.GetAllBooks()
        _miembros = sqlManager.GetAllMembers()
    End Sub

    Private Sub btnLibros_Click(sender As Object, e As EventArgs) Handles btnLibros.Click
        pnlUserControls.Controls.Clear()

        'If Not LibrosLoaded Then
        '    _libros = sqlManager.GetAllBooks()
        '    Dim control As New UcLibros()
        '    pnlUserControls.Controls.Add(control)
        '    LibrosLoaded = True
        'Else
        '    Dim control As New UcLibros()
        '    pnlUserControls.Controls.Add(control)
        'End If

        Dim control As New UcLibros(_libros)
        pnlUserControls.Controls.Add(control)

        lblTitle.Text = "Libros"
    End Sub

    Private Sub btnPrestarLibro_Click(sender As Object, e As EventArgs) Handles btnPrestarLibro.Click
        pnlUserControls.Controls.Clear()

        Dim control As New UcPrestarLibro(_libros, _miembros)
        pnlUserControls.Controls.Add(control)

        lblTitle.Text = "Prestar libro"
    End Sub

    Private Sub btnAgregarLibro_Click(sender As Object, e As EventArgs) Handles btnAgregarLibro.Click
        pnlUserControls.Controls.Clear()

        lblTitle.Text = "Agregar libro"
    End Sub

    Private Sub btnCrearUsuario_Click(sender As Object, e As EventArgs) Handles btnCrearUsuario.Click
        pnlUserControls.Controls.Clear()

        lblTitle.Text = "Crear usuario"
    End Sub
End Class
