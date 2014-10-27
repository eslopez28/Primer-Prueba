<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MisionEspacial
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNombreM = New System.Windows.Forms.TextBox()
        Me.txtTripulantes = New System.Windows.Forms.TextBox()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.txtDatosI = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.txtNave = New System.Windows.Forms.TextBox()
        Me.cmbCuerpoC = New System.Windows.Forms.ComboBox()
        Me.dtpFechaLanzamiento = New System.Windows.Forms.DateTimePicker()
        Me.btnInsignia = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(33, 605)
        Me.Panel2.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(963, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(33, 605)
        Me.Panel1.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 21)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Nombre de la misión"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 21)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Tripulantes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(131, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 21)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Fecha lanzamiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(131, 317)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 21)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Duración en tiempo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(131, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 21)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Datos de interes"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(131, 426)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 21)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Resultado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(131, 479)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 21)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Insignia"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(131, 525)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 21)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Nave"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(131, 578)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(167, 21)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Cuerpo celeste destino"
        '
        'txtNombreM
        '
        Me.txtNombreM.Location = New System.Drawing.Point(346, 83)
        Me.txtNombreM.Name = "txtNombreM"
        Me.txtNombreM.Size = New System.Drawing.Size(139, 29)
        Me.txtNombreM.TabIndex = 45
        '
        'txtTripulantes
        '
        Me.txtTripulantes.Location = New System.Drawing.Point(346, 142)
        Me.txtTripulantes.Name = "txtTripulantes"
        Me.txtTripulantes.Size = New System.Drawing.Size(139, 29)
        Me.txtTripulantes.TabIndex = 46
        '
        'txtDuracion
        '
        Me.txtDuracion.Location = New System.Drawing.Point(346, 309)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(139, 29)
        Me.txtDuracion.TabIndex = 47
        '
        'txtDatosI
        '
        Me.txtDatosI.Location = New System.Drawing.Point(346, 360)
        Me.txtDatosI.Name = "txtDatosI"
        Me.txtDatosI.Size = New System.Drawing.Size(139, 29)
        Me.txtDatosI.TabIndex = 48
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(346, 418)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(139, 29)
        Me.txtResultado.TabIndex = 49
        '
        'txtNave
        '
        Me.txtNave.Location = New System.Drawing.Point(346, 517)
        Me.txtNave.Name = "txtNave"
        Me.txtNave.Size = New System.Drawing.Size(139, 29)
        Me.txtNave.TabIndex = 50
        '
        'cmbCuerpoC
        '
        Me.cmbCuerpoC.FormattingEnabled = True
        Me.cmbCuerpoC.Location = New System.Drawing.Point(346, 570)
        Me.cmbCuerpoC.Name = "cmbCuerpoC"
        Me.cmbCuerpoC.Size = New System.Drawing.Size(139, 29)
        Me.cmbCuerpoC.TabIndex = 51
        '
        'dtpFechaLanzamiento
        '
        Me.dtpFechaLanzamiento.Location = New System.Drawing.Point(346, 222)
        Me.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento"
        Me.dtpFechaLanzamiento.Size = New System.Drawing.Size(278, 29)
        Me.dtpFechaLanzamiento.TabIndex = 52
        '
        'btnInsignia
        '
        Me.btnInsignia.Location = New System.Drawing.Point(346, 470)
        Me.btnInsignia.Name = "btnInsignia"
        Me.btnInsignia.Size = New System.Drawing.Size(139, 30)
        Me.btnInsignia.TabIndex = 53
        Me.btnInsignia.Text = "Agregar insignia"
        Me.btnInsignia.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(613, 340)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(305, 160)
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(586, 570)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 29)
        Me.btnVolver.TabIndex = 55
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(831, 569)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 28)
        Me.btnRegistrar.TabIndex = 56
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'MisionEspacial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 629)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnInsignia)
        Me.Controls.Add(Me.dtpFechaLanzamiento)
        Me.Controls.Add(Me.cmbCuerpoC)
        Me.Controls.Add(Me.txtNave)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtDatosI)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.txtTripulantes)
        Me.Controls.Add(Me.txtNombreM)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MisionEspacial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MisionEspacial"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNombreM As System.Windows.Forms.TextBox
    Friend WithEvents txtTripulantes As System.Windows.Forms.TextBox
    Friend WithEvents txtDuracion As System.Windows.Forms.TextBox
    Friend WithEvents txtDatosI As System.Windows.Forms.TextBox
    Friend WithEvents txtResultado As System.Windows.Forms.TextBox
    Friend WithEvents txtNave As System.Windows.Forms.TextBox
    Friend WithEvents cmbCuerpoC As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFechaLanzamiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnInsignia As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
End Class
