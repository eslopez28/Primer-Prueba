<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultas
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
        Me.dataGridCon = New System.Windows.Forms.TabControl()
        Me.CuerposCeleste = New System.Windows.Forms.TabPage()
        Me.DataGridSatelite = New System.Windows.Forms.DataGridView()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.DataGridPlanetas = New System.Windows.Forms.DataGridView()
        Me.rbtPlanetas = New System.Windows.Forms.RadioButton()
        Me.rbtEstrella = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridEstrella = New System.Windows.Forms.DataGridView()
        Me.Estrellas = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridMision = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Programas = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridProgramas = New System.Windows.Forms.DataGridView()
        Me.btnVolver1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dataGridCon.SuspendLayout()
        Me.CuerposCeleste.SuspendLayout()
        CType(Me.DataGridSatelite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridPlanetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridEstrella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Estrellas.SuspendLayout()
        CType(Me.DataGridMision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Programas.SuspendLayout()
        CType(Me.DataGridProgramas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridCon
        '
        Me.dataGridCon.Controls.Add(Me.CuerposCeleste)
        Me.dataGridCon.Controls.Add(Me.Estrellas)
        Me.dataGridCon.Controls.Add(Me.Programas)
        Me.dataGridCon.Location = New System.Drawing.Point(51, 29)
        Me.dataGridCon.Name = "dataGridCon"
        Me.dataGridCon.SelectedIndex = 0
        Me.dataGridCon.Size = New System.Drawing.Size(900, 369)
        Me.dataGridCon.TabIndex = 1
        '
        'CuerposCeleste
        '
        Me.CuerposCeleste.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.CuerposCeleste.Controls.Add(Me.DataGridSatelite)
        Me.CuerposCeleste.Controls.Add(Me.RadioButton1)
        Me.CuerposCeleste.Controls.Add(Me.DataGridPlanetas)
        Me.CuerposCeleste.Controls.Add(Me.rbtPlanetas)
        Me.CuerposCeleste.Controls.Add(Me.rbtEstrella)
        Me.CuerposCeleste.Controls.Add(Me.Label3)
        Me.CuerposCeleste.Controls.Add(Me.DataGridEstrella)
        Me.CuerposCeleste.Location = New System.Drawing.Point(4, 30)
        Me.CuerposCeleste.Name = "CuerposCeleste"
        Me.CuerposCeleste.Padding = New System.Windows.Forms.Padding(3)
        Me.CuerposCeleste.Size = New System.Drawing.Size(892, 335)
        Me.CuerposCeleste.TabIndex = 0
        Me.CuerposCeleste.Text = "Cuerpo Celestes"
        '
        'DataGridSatelite
        '
        Me.DataGridSatelite.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DataGridSatelite.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridSatelite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSatelite.Location = New System.Drawing.Point(48, 78)
        Me.DataGridSatelite.Name = "DataGridSatelite"
        Me.DataGridSatelite.Size = New System.Drawing.Size(820, 210)
        Me.DataGridSatelite.TabIndex = 10
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(767, 26)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(79, 25)
        Me.RadioButton1.TabIndex = 9
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Satelite"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'DataGridPlanetas
        '
        Me.DataGridPlanetas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DataGridPlanetas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridPlanetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPlanetas.Location = New System.Drawing.Point(48, 78)
        Me.DataGridPlanetas.Name = "DataGridPlanetas"
        Me.DataGridPlanetas.Size = New System.Drawing.Size(798, 201)
        Me.DataGridPlanetas.TabIndex = 8
        Me.DataGridPlanetas.Visible = False
        '
        'rbtPlanetas
        '
        Me.rbtPlanetas.AutoSize = True
        Me.rbtPlanetas.Location = New System.Drawing.Point(658, 27)
        Me.rbtPlanetas.Name = "rbtPlanetas"
        Me.rbtPlanetas.Size = New System.Drawing.Size(86, 25)
        Me.rbtPlanetas.TabIndex = 7
        Me.rbtPlanetas.TabStop = True
        Me.rbtPlanetas.Text = "Planetas"
        Me.rbtPlanetas.UseVisualStyleBackColor = True
        '
        'rbtEstrella
        '
        Me.rbtEstrella.AutoSize = True
        Me.rbtEstrella.Location = New System.Drawing.Point(500, 26)
        Me.rbtEstrella.Name = "rbtEstrella"
        Me.rbtEstrella.Size = New System.Drawing.Size(78, 25)
        Me.rbtEstrella.TabIndex = 6
        Me.rbtEstrella.TabStop = True
        Me.rbtEstrella.Text = "Estrella"
        Me.rbtEstrella.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Lista cuerpos celestes"
        '
        'DataGridEstrella
        '
        Me.DataGridEstrella.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DataGridEstrella.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridEstrella.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridEstrella.Location = New System.Drawing.Point(6, 78)
        Me.DataGridEstrella.Name = "DataGridEstrella"
        Me.DataGridEstrella.Size = New System.Drawing.Size(880, 228)
        Me.DataGridEstrella.TabIndex = 4
        Me.DataGridEstrella.Visible = False
        '
        'Estrellas
        '
        Me.Estrellas.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Estrellas.Controls.Add(Me.Button1)
        Me.Estrellas.Controls.Add(Me.DataGridMision)
        Me.Estrellas.Controls.Add(Me.Label4)
        Me.Estrellas.Controls.Add(Me.DataGridView2)
        Me.Estrellas.Location = New System.Drawing.Point(4, 30)
        Me.Estrellas.Name = "Estrellas"
        Me.Estrellas.Padding = New System.Windows.Forms.Padding(3)
        Me.Estrellas.Size = New System.Drawing.Size(892, 335)
        Me.Estrellas.TabIndex = 1
        Me.Estrellas.Text = "Misiones"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(682, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridMision
        '
        Me.DataGridMision.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DataGridMision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMision.Location = New System.Drawing.Point(28, 67)
        Me.DataGridMision.Name = "DataGridMision"
        Me.DataGridMision.Size = New System.Drawing.Size(815, 190)
        Me.DataGridMision.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Lista de misiones"
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(48, 67)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(684, 150)
        Me.DataGridView2.TabIndex = 0
        '
        'Programas
        '
        Me.Programas.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Programas.Controls.Add(Me.Button2)
        Me.Programas.Controls.Add(Me.Label2)
        Me.Programas.Controls.Add(Me.DataGridProgramas)
        Me.Programas.Location = New System.Drawing.Point(4, 30)
        Me.Programas.Name = "Programas"
        Me.Programas.Padding = New System.Windows.Forms.Padding(3)
        Me.Programas.Size = New System.Drawing.Size(892, 335)
        Me.Programas.TabIndex = 2
        Me.Programas.Text = "Programas Espaciales"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(689, 295)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 34)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Consultar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Lista de programas"
        '
        'DataGridProgramas
        '
        Me.DataGridProgramas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DataGridProgramas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridProgramas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridProgramas.GridColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DataGridProgramas.Location = New System.Drawing.Point(163, 64)
        Me.DataGridProgramas.Name = "DataGridProgramas"
        Me.DataGridProgramas.Size = New System.Drawing.Size(582, 154)
        Me.DataGridProgramas.TabIndex = 0
        '
        'btnVolver1
        '
        Me.btnVolver1.Location = New System.Drawing.Point(438, 570)
        Me.btnVolver1.Name = "btnVolver1"
        Me.btnVolver1.Size = New System.Drawing.Size(101, 31)
        Me.btnVolver1.TabIndex = 6
        Me.btnVolver1.Text = "Volver"
        Me.btnVolver1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(33, 605)
        Me.Panel2.TabIndex = 30
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(963, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(33, 605)
        Me.Panel1.TabIndex = 31
        '
        'Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 629)
        Me.Controls.Add(Me.btnVolver1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dataGridCon)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Consultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas"
        Me.dataGridCon.ResumeLayout(False)
        Me.CuerposCeleste.ResumeLayout(False)
        Me.CuerposCeleste.PerformLayout()
        CType(Me.DataGridSatelite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridPlanetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridEstrella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Estrellas.ResumeLayout(False)
        Me.Estrellas.PerformLayout()
        CType(Me.DataGridMision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Programas.ResumeLayout(False)
        Me.Programas.PerformLayout()
        CType(Me.DataGridProgramas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dataGridCon As System.Windows.Forms.TabControl
    Friend WithEvents CuerposCeleste As System.Windows.Forms.TabPage
    Friend WithEvents Estrellas As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Programas As System.Windows.Forms.TabPage
    Friend WithEvents DataGridProgramas As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridEstrella As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btnVolver1 As System.Windows.Forms.Button
    Friend WithEvents rbtPlanetas As System.Windows.Forms.RadioButton
    Friend WithEvents rbtEstrella As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridPlanetas As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridMision As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridSatelite As System.Windows.Forms.DataGridView
End Class
