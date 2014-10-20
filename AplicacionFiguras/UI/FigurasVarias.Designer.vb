<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FigurasVarias
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCrearFigura = New System.Windows.Forms.Button()
        Me.txtFigura = New System.Windows.Forms.TextBox()
        Me.rbtnTriangulo = New System.Windows.Forms.RadioButton()
        Me.rbtnRectangulo = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnCrearFigura
        '
        Me.btnCrearFigura.Location = New System.Drawing.Point(73, 60)
        Me.btnCrearFigura.Name = "btnCrearFigura"
        Me.btnCrearFigura.Size = New System.Drawing.Size(75, 23)
        Me.btnCrearFigura.TabIndex = 0
        Me.btnCrearFigura.Text = "Crear Figura"
        Me.btnCrearFigura.UseVisualStyleBackColor = True
        '
        'txtFigura
        '
        Me.txtFigura.Location = New System.Drawing.Point(215, 148)
        Me.txtFigura.Name = "txtFigura"
        Me.txtFigura.Size = New System.Drawing.Size(100, 20)
        Me.txtFigura.TabIndex = 1
        '
        'rbtnTriangulo
        '
        Me.rbtnTriangulo.AutoSize = True
        Me.rbtnTriangulo.Location = New System.Drawing.Point(215, 60)
        Me.rbtnTriangulo.Name = "rbtnTriangulo"
        Me.rbtnTriangulo.Size = New System.Drawing.Size(69, 17)
        Me.rbtnTriangulo.TabIndex = 2
        Me.rbtnTriangulo.TabStop = True
        Me.rbtnTriangulo.Text = "Triangulo"
        Me.rbtnTriangulo.UseVisualStyleBackColor = True
        '
        'rbtnRectangulo
        '
        Me.rbtnRectangulo.AutoSize = True
        Me.rbtnRectangulo.Location = New System.Drawing.Point(215, 84)
        Me.rbtnRectangulo.Name = "rbtnRectangulo"
        Me.rbtnRectangulo.Size = New System.Drawing.Size(80, 17)
        Me.rbtnRectangulo.TabIndex = 3
        Me.rbtnRectangulo.TabStop = True
        Me.rbtnRectangulo.Text = "Rectangulo"
        Me.rbtnRectangulo.UseVisualStyleBackColor = True
        '
        'FigurasVarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 355)
        Me.Controls.Add(Me.rbtnRectangulo)
        Me.Controls.Add(Me.rbtnTriangulo)
        Me.Controls.Add(Me.txtFigura)
        Me.Controls.Add(Me.btnCrearFigura)
        Me.Name = "FigurasVarias"
        Me.Text = "FigUras"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCrearFigura As System.Windows.Forms.Button
    Friend WithEvents txtFigura As System.Windows.Forms.TextBox
    Friend WithEvents rbtnTriangulo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnRectangulo As System.Windows.Forms.RadioButton

End Class
