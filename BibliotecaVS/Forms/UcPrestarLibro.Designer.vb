<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcPrestarLibro
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        cbLibros = New ComboBox()
        Libro = New Label()
        btnPrestar = New Button()
        Label1 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel3 = New Panel()
        Label2 = New Label()
        cbTiempoPrestamo = New ComboBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label3 = New Label()
        cbUsuarios = New ComboBox()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' cbLibros
        ' 
        cbLibros.FormattingEnabled = True
        cbLibros.Location = New Point(0, 18)
        cbLibros.Name = "cbLibros"
        cbLibros.Size = New Size(121, 23)
        cbLibros.TabIndex = 0
        ' 
        ' Libro
        ' 
        Libro.AutoSize = True
        Libro.Location = New Point(0, 0)
        Libro.Name = "Libro"
        Libro.Size = New Size(37, 15)
        Libro.TabIndex = 1
        Libro.Text = "Libro:"
        ' 
        ' btnPrestar
        ' 
        btnPrestar.Anchor = AnchorStyles.None
        btnPrestar.Location = New Point(243, 30)
        btnPrestar.Name = "btnPrestar"
        btnPrestar.Size = New Size(121, 34)
        btnPrestar.TabIndex = 5
        btnPrestar.Text = "Prestar"
        btnPrestar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(476, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 3
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(btnPrestar, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Bottom
        TableLayoutPanel2.Location = New Point(0, 348)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(607, 94)
        TableLayoutPanel2.TabIndex = 7
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(Panel3, 2, 0)
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel2, 1, 0)
        TableLayoutPanel1.Location = New Point(3, 126)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(601, 100)
        TableLayoutPanel1.TabIndex = 8
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.None
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(cbTiempoPrestamo)
        Panel3.Location = New Point(439, 28)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(123, 44)
        Panel3.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 15)
        Label2.TabIndex = 1
        Label2.Text = "Tiempo de prestamo:"
        ' 
        ' cbTiempoPrestamo
        ' 
        cbTiempoPrestamo.FormattingEnabled = True
        cbTiempoPrestamo.Items.AddRange(New Object() {"1 dia", "5 dias", "1 semana", "1 mes"})
        cbTiempoPrestamo.Location = New Point(0, 18)
        cbTiempoPrestamo.Name = "cbTiempoPrestamo"
        cbTiempoPrestamo.Size = New Size(121, 23)
        cbTiempoPrestamo.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(Libro)
        Panel1.Controls.Add(cbLibros)
        Panel1.Location = New Point(38, 28)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(123, 44)
        Panel1.TabIndex = 9
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.None
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(cbUsuarios)
        Panel2.Location = New Point(238, 28)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(123, 44)
        Panel2.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 15)
        Label3.TabIndex = 1
        Label3.Text = "Miembro:"
        ' 
        ' cbUsuarios
        ' 
        cbUsuarios.FormattingEnabled = True
        cbUsuarios.Location = New Point(0, 18)
        cbUsuarios.Name = "cbUsuarios"
        cbUsuarios.Size = New Size(121, 23)
        cbUsuarios.TabIndex = 0
        ' 
        ' UcPrestarLibro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        Controls.Add(TableLayoutPanel1)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(Label1)
        Name = "UcPrestarLibro"
        Size = New Size(607, 442)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbLibros As ComboBox
    Friend WithEvents Libro As Label
    Friend WithEvents btnPrestar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cbTiempoPrestamo As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents cbUsuarios As ComboBox
End Class
