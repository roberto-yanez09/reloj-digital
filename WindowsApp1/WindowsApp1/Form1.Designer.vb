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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.minutos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.horas = New System.Windows.Forms.Label()
        Me.Dia = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.picturebox = New System.Windows.Forms.PictureBox()
        Me.config = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.config.SuspendLayout()
        Me.SuspendLayout()
        '
        'minutos
        '
        Me.minutos.AutoSize = True
        Me.minutos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.minutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutos.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.minutos.Location = New System.Drawing.Point(168, 285)
        Me.minutos.Name = "minutos"
        Me.minutos.Size = New System.Drawing.Size(80, 55)
        Me.minutos.TabIndex = 0
        Me.minutos.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(125, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = ":"
        '
        'horas
        '
        Me.horas.AutoSize = True
        Me.horas.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horas.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.horas.Location = New System.Drawing.Point(39, 285)
        Me.horas.Name = "horas"
        Me.horas.Size = New System.Drawing.Size(80, 55)
        Me.horas.TabIndex = 2
        Me.horas.Text = "00"
        '
        'Dia
        '
        Me.Dia.AutoSize = True
        Me.Dia.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dia.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dia.Location = New System.Drawing.Point(43, 350)
        Me.Dia.Name = "Dia"
        Me.Dia.Size = New System.Drawing.Size(76, 25)
        Me.Dia.TabIndex = 3
        Me.Dia.Text = "Lunes"
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.fecha.Location = New System.Drawing.Point(43, 375)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(242, 25)
        Me.fecha.TabIndex = 4
        Me.fecha.Text = "09 der marzo de 2026"
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 605)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'picturebox
        '
        Me.picturebox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.picturebox.ErrorImage = CType(resources.GetObject("picturebox.ErrorImage"), System.Drawing.Image)
        Me.picturebox.Image = CType(resources.GetObject("picturebox.Image"), System.Drawing.Image)
        Me.picturebox.Location = New System.Drawing.Point(223, 217)
        Me.picturebox.Name = "picturebox"
        Me.picturebox.Size = New System.Drawing.Size(45, 36)
        Me.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picturebox.TabIndex = 6
        Me.picturebox.TabStop = False
        '
        'config
        '
        Me.config.Controls.Add(Me.Button1)
        Me.config.Controls.Add(Me.Label2)
        Me.config.Location = New System.Drawing.Point(49, 259)
        Me.config.Name = "config"
        Me.config.Size = New System.Drawing.Size(236, 204)
        Me.config.TabIndex = 7
        Me.config.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Configuración"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 597)
        Me.Controls.Add(Me.config)
        Me.Controls.Add(Me.picturebox)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Dia)
        Me.Controls.Add(Me.horas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.minutos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.config.ResumeLayout(False)
        Me.config.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents minutos As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents horas As Label
    Friend WithEvents Dia As Label
    Friend WithEvents fecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents picturebox As PictureBox
    Friend WithEvents config As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
