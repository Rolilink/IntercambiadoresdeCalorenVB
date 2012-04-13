<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.transforma = New System.Windows.Forms.Button()
        Me.interpola = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'transforma
        '
        Me.transforma.BackColor = System.Drawing.Color.Transparent
        Me.transforma.BackgroundImage = Global.Termodinámica.My.Resources.Resources.st_06
        Me.transforma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.transforma.FlatAppearance.BorderSize = 0
        Me.transforma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.transforma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.transforma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.transforma.Location = New System.Drawing.Point(181, 131)
        Me.transforma.Name = "transforma"
        Me.transforma.Size = New System.Drawing.Size(145, 33)
        Me.transforma.TabIndex = 1
        Me.transforma.UseVisualStyleBackColor = False
        '
        'interpola
        '
        Me.interpola.BackColor = System.Drawing.Color.Transparent
        Me.interpola.BackgroundImage = Global.Termodinámica.My.Resources.Resources.st_03
        Me.interpola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.interpola.FlatAppearance.BorderSize = 0
        Me.interpola.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.interpola.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.interpola.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.interpola.ForeColor = System.Drawing.Color.Transparent
        Me.interpola.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.interpola.Location = New System.Drawing.Point(181, 92)
        Me.interpola.Margin = New System.Windows.Forms.Padding(0)
        Me.interpola.Name = "interpola"
        Me.interpola.Size = New System.Drawing.Size(143, 34)
        Me.interpola.TabIndex = 0
        Me.interpola.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.interpola.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Termodinámica.My.Resources.Resources.st_08
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(182, 167)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.Termodinámica.My.Resources.Resources.st_10
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(181, 207)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 33)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Termodinámica.My.Resources.Resources.Titulo
        Me.PictureBox1.Location = New System.Drawing.Point(117, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(275, 50)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Termodinámica.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(493, 299)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.transforma)
        Me.Controls.Add(Me.interpola)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "main"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Módulo 1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents transforma As System.Windows.Forms.Button
    Friend WithEvents interpola As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
