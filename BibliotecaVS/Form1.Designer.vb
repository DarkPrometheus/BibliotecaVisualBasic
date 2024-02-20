<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        lblTitle = New Label()
        btnLibros = New Button()
        btnPrestarLibro = New Button()
        btnAgregarLibro = New Button()
        btnCrearUsuario = New Button()
        Panel1 = New Panel()
        Panel3 = New Panel()
        pnlUserControls = New Panel()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(lblTitle)
        FlowLayoutPanel1.Controls.Add(btnLibros)
        FlowLayoutPanel1.Controls.Add(btnPrestarLibro)
        FlowLayoutPanel1.Controls.Add(btnAgregarLibro)
        FlowLayoutPanel1.Controls.Add(btnCrearUsuario)
        FlowLayoutPanel1.Dock = DockStyle.Left
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(177, 513)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = SystemColors.ActiveBorder
        lblTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblTitle.Location = New Point(0, 0)
        lblTitle.Margin = New Padding(0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(177, 51)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Gestion de libros"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnLibros
        ' 
        btnLibros.Location = New Point(3, 54)
        btnLibros.Name = "btnLibros"
        btnLibros.Size = New Size(167, 47)
        btnLibros.TabIndex = 1
        btnLibros.Text = "Libros"
        btnLibros.UseVisualStyleBackColor = True
        ' 
        ' btnPrestarLibro
        ' 
        btnPrestarLibro.Location = New Point(3, 107)
        btnPrestarLibro.Name = "btnPrestarLibro"
        btnPrestarLibro.Size = New Size(167, 47)
        btnPrestarLibro.TabIndex = 2
        btnPrestarLibro.Text = "Prestar libro"
        btnPrestarLibro.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarLibro
        ' 
        btnAgregarLibro.Location = New Point(3, 160)
        btnAgregarLibro.Name = "btnAgregarLibro"
        btnAgregarLibro.Size = New Size(167, 47)
        btnAgregarLibro.TabIndex = 3
        btnAgregarLibro.Text = "Agregar libro"
        btnAgregarLibro.UseVisualStyleBackColor = True
        ' 
        ' btnCrearUsuario
        ' 
        btnCrearUsuario.Location = New Point(3, 213)
        btnCrearUsuario.Name = "btnCrearUsuario"
        btnCrearUsuario.Size = New Size(167, 47)
        btnCrearUsuario.TabIndex = 4
        btnCrearUsuario.Text = "Usuarios"
        btnCrearUsuario.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(177, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(623, 51)
        Panel1.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Gainsboro
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(177, 493)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(623, 20)
        Panel3.TabIndex = 3
        ' 
        ' pnlUserControls
        ' 
        pnlUserControls.BackColor = Color.Gainsboro
        pnlUserControls.Dock = DockStyle.Fill
        pnlUserControls.Location = New Point(177, 51)
        pnlUserControls.Name = "pnlUserControls"
        pnlUserControls.Size = New Size(623, 442)
        pnlUserControls.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 513)
        Controls.Add(pnlUserControls)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(FlowLayoutPanel1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnLibros As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPrestarLibro As Button
    Friend WithEvents btnAgregarLibro As Button
    Friend WithEvents btnCrearUsuario As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pnlUserControls As Panel
End Class
