Public Class UcLibros
    Private _libros As New Queue(Of Libro)
    Private _BooksPanel As New FlowLayoutPanel

    Public Sub New(libros As Queue(Of Libro))
        InitializeComponent()

        _libros = libros

        _BooksPanel.Dock = DockStyle.Fill
        Controls.Add(_BooksPanel)

        LoadBooks()
    End Sub

    Private Sub LoadBooks()
        For Each libro As Libro In _libros
            CreateBook(libro.Titulo)
        Next
    End Sub

    Private Sub CreateBook(ByVal name As String)
        Dim container As New FlowLayoutPanel With {
            .Padding = New Padding(10),
            .Margin = New Padding(0, 0, 20, 20),
            .Width = 160,
            .Height = 180,
            .BackColor = Color.DarkGray
        }

        Dim img As New Panel With {
            .Width = 140,
            .Margin = New Padding(0),
            .Height = 140,
            .BackColor = Color.Snow
        }

        Dim labelContainer As New TableLayoutPanel With {
            .Width = 140,
            .Height = 20,
            .Margin = New Padding(0)
        }

        Dim label As New Label With {
            .Text = name,
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleCenter
        }

        labelContainer.Controls.Add(label)
        container.Controls.Add(img)
        container.Controls.Add(labelContainer)

        pnlBooks.Controls.Add(container)
    End Sub
End Class
