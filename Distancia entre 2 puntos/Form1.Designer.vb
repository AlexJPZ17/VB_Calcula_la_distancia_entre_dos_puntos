<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button_Calcular = New System.Windows.Forms.Button()
        Me.Button_Limpiar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox_Y2 = New System.Windows.Forms.TextBox()
        Me.TextBox_Y1 = New System.Windows.Forms.TextBox()
        Me.TextBox_X1 = New System.Windows.Forms.TextBox()
        Me.TextBox_X2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_Distancia = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Calcular
        '
        Me.Button_Calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.163636!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Calcular.Location = New System.Drawing.Point(66, 365)
        Me.Button_Calcular.Name = "Button_Calcular"
        Me.Button_Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Button_Calcular.TabIndex = 0
        Me.Button_Calcular.Text = "Calcular"
        Me.Button_Calcular.UseVisualStyleBackColor = True
        '
        'Button_Limpiar
        '
        Me.Button_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.163636!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Limpiar.Location = New System.Drawing.Point(200, 365)
        Me.Button_Limpiar.Name = "Button_Limpiar"
        Me.Button_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Limpiar.TabIndex = 1
        Me.Button_Limpiar.Text = "Limpiar"
        Me.Button_Limpiar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(77, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(286, 227)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'TextBox_Y2
        '
        Me.TextBox_Y2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.163636!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Y2.Location = New System.Drawing.Point(12, 70)
        Me.TextBox_Y2.Name = "TextBox_Y2"
        Me.TextBox_Y2.Size = New System.Drawing.Size(59, 23)
        Me.TextBox_Y2.TabIndex = 3
        '
        'TextBox_Y1
        '
        Me.TextBox_Y1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.163636!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Y1.Location = New System.Drawing.Point(12, 195)
        Me.TextBox_Y1.Name = "TextBox_Y1"
        Me.TextBox_Y1.Size = New System.Drawing.Size(59, 23)
        Me.TextBox_Y1.TabIndex = 4
        '
        'TextBox_X1
        '
        Me.TextBox_X1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.163636!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_X1.Location = New System.Drawing.Point(110, 266)
        Me.TextBox_X1.Name = "TextBox_X1"
        Me.TextBox_X1.Size = New System.Drawing.Size(59, 23)
        Me.TextBox_X1.TabIndex = 5
        '
        'TextBox_X2
        '
        Me.TextBox_X2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.163636!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_X2.Location = New System.Drawing.Point(240, 266)
        Me.TextBox_X2.Name = "TextBox_X2"
        Me.TextBox_X2.Size = New System.Drawing.Size(59, 23)
        Me.TextBox_X2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.163636!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Distancia:"
        '
        'Label_Distancia
        '
        Me.Label_Distancia.AutoSize = True
        Me.Label_Distancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.163636!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Distancia.Location = New System.Drawing.Point(153, 316)
        Me.Label_Distancia.Name = "Label_Distancia"
        Me.Label_Distancia.Size = New System.Drawing.Size(17, 17)
        Me.Label_Distancia.TabIndex = 8
        Me.Label_Distancia.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(375, 400)
        Me.Controls.Add(Me.Label_Distancia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_X2)
        Me.Controls.Add(Me.TextBox_X1)
        Me.Controls.Add(Me.TextBox_Y1)
        Me.Controls.Add(Me.TextBox_Y2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button_Limpiar)
        Me.Controls.Add(Me.Button_Calcular)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Distancia entre 2 puntos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Calcular As System.Windows.Forms.Button
    Friend WithEvents Button_Limpiar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox_Y2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Y1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_X1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_X2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label_Distancia As System.Windows.Forms.Label

End Class
