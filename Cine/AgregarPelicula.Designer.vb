<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarPelicula
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
        Me.txtTituloDIst = New System.Windows.Forms.TextBox()
        Me.txtTituloOrig = New System.Windows.Forms.TextBox()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.txtIdioma = New System.Windows.Forms.TextBox()
        Me.txtSubt = New System.Windows.Forms.ComboBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.txtProduccion = New System.Windows.Forms.TextBox()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.txtHoras = New System.Windows.Forms.NumericUpDown()
        Me.txtMin = New System.Windows.Forms.NumericUpDown()
        Me.txtClasificacion = New System.Windows.Forms.TextBox()
        Me.txtEstreno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.btnAgregarPelicula = New System.Windows.Forms.Button()
        Me.lstPeli = New System.Windows.Forms.ListBox()
        CType(Me.txtHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTituloDIst
        '
        Me.txtTituloDIst.Location = New System.Drawing.Point(12, 47)
        Me.txtTituloDIst.Name = "txtTituloDIst"
        Me.txtTituloDIst.Size = New System.Drawing.Size(155, 20)
        Me.txtTituloDIst.TabIndex = 0
        '
        'txtTituloOrig
        '
        Me.txtTituloOrig.Location = New System.Drawing.Point(12, 103)
        Me.txtTituloOrig.Name = "txtTituloOrig"
        Me.txtTituloOrig.Size = New System.Drawing.Size(155, 20)
        Me.txtTituloOrig.TabIndex = 1
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(12, 162)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(155, 20)
        Me.txtGenero.TabIndex = 2
        '
        'txtIdioma
        '
        Me.txtIdioma.Location = New System.Drawing.Point(12, 219)
        Me.txtIdioma.Name = "txtIdioma"
        Me.txtIdioma.Size = New System.Drawing.Size(155, 20)
        Me.txtIdioma.TabIndex = 3
        '
        'txtSubt
        '
        Me.txtSubt.FormattingEnabled = True
        Me.txtSubt.Location = New System.Drawing.Point(12, 278)
        Me.txtSubt.Name = "txtSubt"
        Me.txtSubt.Size = New System.Drawing.Size(155, 21)
        Me.txtSubt.TabIndex = 4
        '
        'txtOrigen
        '
        Me.txtOrigen.Location = New System.Drawing.Point(210, 47)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(155, 20)
        Me.txtOrigen.TabIndex = 5
        '
        'txtProduccion
        '
        Me.txtProduccion.Location = New System.Drawing.Point(210, 103)
        Me.txtProduccion.Name = "txtProduccion"
        Me.txtProduccion.Size = New System.Drawing.Size(155, 20)
        Me.txtProduccion.TabIndex = 6
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(210, 162)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(155, 20)
        Me.txtUrl.TabIndex = 7
        '
        'txtHoras
        '
        Me.txtHoras.Location = New System.Drawing.Point(210, 219)
        Me.txtHoras.Name = "txtHoras"
        Me.txtHoras.Size = New System.Drawing.Size(49, 20)
        Me.txtHoras.TabIndex = 8
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(210, 278)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(49, 20)
        Me.txtMin.TabIndex = 9
        '
        'txtClasificacion
        '
        Me.txtClasificacion.Location = New System.Drawing.Point(399, 47)
        Me.txtClasificacion.Name = "txtClasificacion"
        Me.txtClasificacion.Size = New System.Drawing.Size(155, 20)
        Me.txtClasificacion.TabIndex = 10
        '
        'txtEstreno
        '
        Me.txtEstreno.Location = New System.Drawing.Point(399, 103)
        Me.txtEstreno.Name = "txtEstreno"
        Me.txtEstreno.Size = New System.Drawing.Size(155, 20)
        Me.txtEstreno.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Titulo De Distribucion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Titulo Original"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Genero"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Idioma"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Subtitulado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(217, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Origen"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(217, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Produccion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(217, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Url"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(217, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Horas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(217, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Minutos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(407, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Clasificacion"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(407, 87)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(43, 13)
        Me.label14.TabIndex = 23
        Me.label14.Text = "Estreno"
        '
        'btnAgregarPelicula
        '
        Me.btnAgregarPelicula.Location = New System.Drawing.Point(410, 158)
        Me.btnAgregarPelicula.Name = "btnAgregarPelicula"
        Me.btnAgregarPelicula.Size = New System.Drawing.Size(119, 23)
        Me.btnAgregarPelicula.TabIndex = 24
        Me.btnAgregarPelicula.Text = "Agregar Pelicula"
        Me.btnAgregarPelicula.UseVisualStyleBackColor = True
        '
        'lstPeli
        '
        Me.lstPeli.FormattingEnabled = True
        Me.lstPeli.Location = New System.Drawing.Point(399, 204)
        Me.lstPeli.Name = "lstPeli"
        Me.lstPeli.Size = New System.Drawing.Size(155, 95)
        Me.lstPeli.TabIndex = 25
        '
        'AgregarPelicula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 353)
        Me.Controls.Add(Me.lstPeli)
        Me.Controls.Add(Me.btnAgregarPelicula)
        Me.Controls.Add(Me.label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEstreno)
        Me.Controls.Add(Me.txtClasificacion)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.txtHoras)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.txtProduccion)
        Me.Controls.Add(Me.txtOrigen)
        Me.Controls.Add(Me.txtSubt)
        Me.Controls.Add(Me.txtIdioma)
        Me.Controls.Add(Me.txtGenero)
        Me.Controls.Add(Me.txtTituloOrig)
        Me.Controls.Add(Me.txtTituloDIst)
        Me.Name = "AgregarPelicula"
        Me.Text = "Peliculas"
        CType(Me.txtHoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTituloDIst As System.Windows.Forms.TextBox
    Friend WithEvents txtTituloOrig As System.Windows.Forms.TextBox
    Friend WithEvents txtGenero As System.Windows.Forms.TextBox
    Friend WithEvents txtIdioma As System.Windows.Forms.TextBox
    Friend WithEvents txtSubt As System.Windows.Forms.ComboBox
    Friend WithEvents txtOrigen As System.Windows.Forms.TextBox
    Friend WithEvents txtProduccion As System.Windows.Forms.TextBox
    Friend WithEvents txtUrl As System.Windows.Forms.TextBox
    Friend WithEvents txtHoras As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtClasificacion As System.Windows.Forms.TextBox
    Friend WithEvents txtEstreno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents label14 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarPelicula As System.Windows.Forms.Button
    Friend WithEvents lstPeli As System.Windows.Forms.ListBox
End Class
