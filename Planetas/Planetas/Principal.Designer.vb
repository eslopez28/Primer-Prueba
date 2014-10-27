<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.linkMisiones = New System.Windows.Forms.LinkLabel()
        Me.linkPrograma = New System.Windows.Forms.LinkLabel()
        Me.cuerpo_celeste = New System.Windows.Forms.LinkLabel()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(963, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(33, 605)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(33, 605)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel3.Controls.Add(Me.LinkLabel1)
        Me.Panel3.Controls.Add(Me.linkMisiones)
        Me.Panel3.Controls.Add(Me.linkPrograma)
        Me.Panel3.Controls.Add(Me.cuerpo_celeste)
        Me.Panel3.Location = New System.Drawing.Point(352, 192)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(5, 3, 3, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(293, 350)
        Me.Panel3.TabIndex = 2
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.DisabledLinkColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(110, 258)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(78, 21)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Consultas"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkMisiones
        '
        Me.linkMisiones.ActiveLinkColor = System.Drawing.Color.Black
        Me.linkMisiones.AutoSize = True
        Me.linkMisiones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkMisiones.DisabledLinkColor = System.Drawing.Color.Transparent
        Me.linkMisiones.ForeColor = System.Drawing.SystemColors.ControlText
        Me.linkMisiones.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkMisiones.LinkColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.linkMisiones.Location = New System.Drawing.Point(110, 196)
        Me.linkMisiones.Name = "linkMisiones"
        Me.linkMisiones.Size = New System.Drawing.Size(72, 21)
        Me.linkMisiones.TabIndex = 5
        Me.linkMisiones.TabStop = True
        Me.linkMisiones.Text = "Misiones"
        Me.linkMisiones.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkPrograma
        '
        Me.linkPrograma.ActiveLinkColor = System.Drawing.Color.Black
        Me.linkPrograma.AutoSize = True
        Me.linkPrograma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkPrograma.DisabledLinkColor = System.Drawing.Color.Transparent
        Me.linkPrograma.ForeColor = System.Drawing.SystemColors.ControlText
        Me.linkPrograma.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkPrograma.LinkColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.linkPrograma.Location = New System.Drawing.Point(67, 117)
        Me.linkPrograma.Name = "linkPrograma"
        Me.linkPrograma.Size = New System.Drawing.Size(160, 21)
        Me.linkPrograma.TabIndex = 4
        Me.linkPrograma.TabStop = True
        Me.linkPrograma.Text = "Programas espaciales"
        Me.linkPrograma.VisitedLinkColor = System.Drawing.Color.Black
        '
        'cuerpo_celeste
        '
        Me.cuerpo_celeste.ActiveLinkColor = System.Drawing.Color.Black
        Me.cuerpo_celeste.AutoSize = True
        Me.cuerpo_celeste.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cuerpo_celeste.DisabledLinkColor = System.Drawing.Color.Transparent
        Me.cuerpo_celeste.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.cuerpo_celeste.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.cuerpo_celeste.LinkColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.cuerpo_celeste.Location = New System.Drawing.Point(79, 23)
        Me.cuerpo_celeste.Name = "cuerpo_celeste"
        Me.cuerpo_celeste.Size = New System.Drawing.Size(126, 21)
        Me.cuerpo_celeste.TabIndex = 3
        Me.cuerpo_celeste.TabStop = True
        Me.cuerpo_celeste.Text = "Cuerpos celestes"
        Me.cuerpo_celeste.VisitedLinkColor = System.Drawing.Color.Black
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 629)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cuerpo_celeste As System.Windows.Forms.LinkLabel
    Friend WithEvents linkMisiones As System.Windows.Forms.LinkLabel
    Friend WithEvents linkPrograma As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
