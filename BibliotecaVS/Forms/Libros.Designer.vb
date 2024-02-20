<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcLibros
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
        pnlBooks = New FlowLayoutPanel()
        SuspendLayout()
        ' 
        ' pnlBooks
        ' 
        pnlBooks.BackColor = Color.Gainsboro
        pnlBooks.Dock = DockStyle.Fill
        pnlBooks.Location = New Point(0, 0)
        pnlBooks.Name = "pnlBooks"
        pnlBooks.Padding = New Padding(20)
        pnlBooks.Size = New Size(623, 442)
        pnlBooks.TabIndex = 0
        ' 
        ' UcLibros
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(pnlBooks)
        Name = "UcLibros"
        Size = New Size(623, 442)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBooks As FlowLayoutPanel
End Class
