<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgramaEspacial
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
        Me.txtNombreProg = New System.Windows.Forms.TextBox()
        Me.cmbMesInc = New System.Windows.Forms.ComboBox()
        Me.cmbMesFin = New System.Windows.Forms.ComboBox()
        Me.txtAlcance = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.cmbAnnoFin = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbAnnoInc = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNombreProg
        '
        Me.txtNombreProg.Location = New System.Drawing.Point(322, 83)
        Me.txtNombreProg.Name = "txtNombreProg"
        Me.txtNombreProg.Size = New System.Drawing.Size(130, 29)
        Me.txtNombreProg.TabIndex = 0
        '
        'cmbMesInc
        '
        Me.cmbMesInc.FormattingEnabled = True
        Me.cmbMesInc.Location = New System.Drawing.Point(322, 177)
        Me.cmbMesInc.Name = "cmbMesInc"
        Me.cmbMesInc.Size = New System.Drawing.Size(130, 29)
        Me.cmbMesInc.TabIndex = 1
        '
        'cmbMesFin
        '
        Me.cmbMesFin.FormattingEnabled = True
        Me.cmbMesFin.Location = New System.Drawing.Point(322, 274)
        Me.cmbMesFin.Name = "cmbMesFin"
        Me.cmbMesFin.Size = New System.Drawing.Size(130, 29)
        Me.cmbMesFin.TabIndex = 3
        '
        'txtAlcance
        '
        Me.txtAlcance.Location = New System.Drawing.Point(322, 368)
        Me.txtAlcance.Name = "txtAlcance"
        Me.txtAlcance.Size = New System.Drawing.Size(425, 76)
        Me.txtAlcance.TabIndex = 5
        Me.txtAlcance.Text = ""
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(33, 605)
        Me.Panel2.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(963, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(33, 605)
        Me.Panel1.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(137, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 21)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Nombre del programa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 21)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Mes de inicio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(614, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 21)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Año de inicio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(137, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 21)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Mes de fin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(137, 381)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 21)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Alcance"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(759, 555)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(105, 32)
        Me.btnRegistrar.TabIndex = 35
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'cmbAnnoFin
        '
        Me.cmbAnnoFin.FormattingEnabled = True
        Me.cmbAnnoFin.Location = New System.Drawing.Point(782, 277)
        Me.cmbAnnoFin.Name = "cmbAnnoFin"
        Me.cmbAnnoFin.Size = New System.Drawing.Size(130, 29)
        Me.cmbAnnoFin.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(614, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 21)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Año de fin"
        '
        'cmbAnnoInc
        '
        Me.cmbAnnoInc.FormattingEnabled = True
        Me.cmbAnnoInc.Location = New System.Drawing.Point(782, 182)
        Me.cmbAnnoInc.Name = "cmbAnnoInc"
        Me.cmbAnnoInc.Size = New System.Drawing.Size(130, 29)
        Me.cmbAnnoInc.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(137, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 21)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Fecha Inicio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(137, 235)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 21)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Fecha finalización"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(163, 555)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 32)
        Me.btnVolver.TabIndex = 38
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'ProgramaEspacial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 629)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtAlcance)
        Me.Controls.Add(Me.cmbAnnoFin)
        Me.Controls.Add(Me.cmbMesFin)
        Me.Controls.Add(Me.cmbAnnoInc)
        Me.Controls.Add(Me.cmbMesInc)
        Me.Controls.Add(Me.txtNombreProg)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ProgramaEspacial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProgramaEspacial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombreProg As System.Windows.Forms.TextBox
    Friend WithEvents cmbMesInc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMesFin As System.Windows.Forms.ComboBox
    Friend WithEvents txtAlcance As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents cmbAnnoFin As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbAnnoInc As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
