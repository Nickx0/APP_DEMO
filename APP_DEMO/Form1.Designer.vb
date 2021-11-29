<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formulario))
        Me.labelname = New System.Windows.Forms.Label()
        Me.btnMensaje = New System.Windows.Forms.Button()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelname
        '
        Me.labelname.AutoSize = True
        Me.labelname.BackColor = System.Drawing.Color.Transparent
        Me.labelname.Font = New System.Drawing.Font("Segoe UI Emoji", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelname.Location = New System.Drawing.Point(62, 128)
        Me.labelname.Name = "labelname"
        Me.labelname.Size = New System.Drawing.Size(201, 28)
        Me.labelname.TabIndex = 1
        Me.labelname.Text = "INGRESE NOMBRE"
        '
        'btnMensaje
        '
        Me.btnMensaje.Font = New System.Drawing.Font("Segoe UI Emoji", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMensaje.Location = New System.Drawing.Point(68, 260)
        Me.btnMensaje.Name = "btnMensaje"
        Me.btnMensaje.Size = New System.Drawing.Size(141, 31)
        Me.btnMensaje.TabIndex = 2
        Me.btnMensaje.Text = "Mensaje"
        Me.btnMensaje.UseVisualStyleBackColor = True
        '
        'PictureBox
        '
        Me.PictureBox.Location = New System.Drawing.Point(511, 93)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(211, 263)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 3
        Me.PictureBox.TabStop = False
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(68, 197)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(354, 23)
        Me.txtnombre.TabIndex = 4
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Emoji", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSalir.Location = New System.Drawing.Point(281, 260)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(141, 31)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Formulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.btnMensaje)
        Me.Controls.Add(Me.labelname)
        Me.Name = "Formulario"
        Me.Text = "Aplicaciones de Windows"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelname As Label
    Friend WithEvents btnMensaje As Button
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents btnSalir As Button
End Class
