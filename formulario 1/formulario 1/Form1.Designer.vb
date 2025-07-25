<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        lblformulario = New Label()
        lblnombre = New Label()
        Lblapellido = New Label()
        lbltelefono = New Label()
        lblcorreo = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        txtfemenino = New RadioButton()
        txtmasculino = New RadioButton()
        txtprefieronodecirlo = New RadioButton()
        lblgenero = New Label()
        lblvehiculo = New Label()
        RadioButton1 = New RadioButton()
        btnnuevo = New Button()
        ToolTip1 = New ToolTip(components)
        CheckBox1 = New CheckBox()
        btncarro = New CheckBox()
        btnmoto = New CheckBox()
        btnbus = New CheckBox()
        btnotro = New CheckBox()
        btnguardar = New Button()
        CheckBox2 = New CheckBox()
        btnactualizar = New Button()
        CheckBox3 = New CheckBox()
        btneliminar = New Button()
        CheckBox4 = New CheckBox()
        btnsalir = New Button()
        CheckBox5 = New CheckBox()
        SuspendLayout()
        ' 
        ' lblformulario
        ' 
        lblformulario.AutoSize = True
        lblformulario.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblformulario.Location = New Point(269, 18)
        lblformulario.Name = "lblformulario"
        lblformulario.Size = New Size(298, 38)
        lblformulario.TabIndex = 0
        lblformulario.Text = "formulario ejercicio 1"
        ' 
        ' lblnombre
        ' 
        lblnombre.AutoSize = True
        lblnombre.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblnombre.Location = New Point(79, 79)
        lblnombre.Name = "lblnombre"
        lblnombre.Size = New Size(108, 31)
        lblnombre.TabIndex = 0
        lblnombre.Text = "Nombre:"
        ' 
        ' Lblapellido
        ' 
        Lblapellido.AutoSize = True
        Lblapellido.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblapellido.Location = New Point(79, 126)
        Lblapellido.Name = "Lblapellido"
        Lblapellido.Size = New Size(111, 31)
        Lblapellido.TabIndex = 0
        Lblapellido.Text = "Apellido:"
        ' 
        ' lbltelefono
        ' 
        lbltelefono.AutoSize = True
        lbltelefono.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbltelefono.Location = New Point(79, 178)
        lbltelefono.Name = "lbltelefono"
        lbltelefono.Size = New Size(113, 31)
        lbltelefono.TabIndex = 0
        lbltelefono.Text = "Telefono:"
        ' 
        ' lblcorreo
        ' 
        lblcorreo.AutoSize = True
        lblcorreo.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblcorreo.Location = New Point(79, 227)
        lblcorreo.Name = "lblcorreo"
        lblcorreo.Size = New Size(89, 31)
        lblcorreo.TabIndex = 0
        lblcorreo.Text = "correo:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(193, 83)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(519, 27)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(193, 126)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(519, 27)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(193, 178)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(519, 27)
        TextBox3.TabIndex = 1
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(193, 233)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(519, 27)
        TextBox4.TabIndex = 1
        ' 
        ' txtfemenino
        ' 
        txtfemenino.AutoSize = True
        txtfemenino.Location = New Point(193, 295)
        txtfemenino.Name = "txtfemenino"
        txtfemenino.Size = New Size(93, 24)
        txtfemenino.TabIndex = 2
        txtfemenino.TabStop = True
        txtfemenino.Text = "femenino"
        txtfemenino.UseVisualStyleBackColor = True
        ' 
        ' txtmasculino
        ' 
        txtmasculino.AutoSize = True
        txtmasculino.Location = New Point(311, 295)
        txtmasculino.Name = "txtmasculino"
        txtmasculino.Size = New Size(97, 24)
        txtmasculino.TabIndex = 2
        txtmasculino.TabStop = True
        txtmasculino.Text = "masculino"
        txtmasculino.UseVisualStyleBackColor = True
        ' 
        ' txtprefieronodecirlo
        ' 
        txtprefieronodecirlo.AutoSize = True
        txtprefieronodecirlo.Location = New Point(431, 295)
        txtprefieronodecirlo.Name = "txtprefieronodecirlo"
        txtprefieronodecirlo.Size = New Size(154, 24)
        txtprefieronodecirlo.TabIndex = 2
        txtprefieronodecirlo.TabStop = True
        txtprefieronodecirlo.Text = "prefiero no decirlo"
        txtprefieronodecirlo.UseVisualStyleBackColor = True
        ' 
        ' lblgenero
        ' 
        lblgenero.AutoSize = True
        lblgenero.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblgenero.Location = New Point(79, 288)
        lblgenero.Name = "lblgenero"
        lblgenero.Size = New Size(97, 31)
        lblgenero.TabIndex = 3
        lblgenero.Text = "Genero:"
        ' 
        ' lblvehiculo
        ' 
        lblvehiculo.AutoSize = True
        lblvehiculo.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblvehiculo.Location = New Point(74, 330)
        lblvehiculo.Name = "lblvehiculo"
        lblvehiculo.Size = New Size(113, 31)
        lblvehiculo.TabIndex = 4
        lblvehiculo.Text = "Vehiculo:"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(0, 0)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(121, 24)
        RadioButton1.TabIndex = 5
        RadioButton1.TabStop = True
        RadioButton1.Text = "RadioButton1"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' btnnuevo
        ' 
        btnnuevo.Location = New Point(74, 398)
        btnnuevo.Name = "btnnuevo"
        btnnuevo.Size = New Size(94, 29)
        btnnuevo.TabIndex = 6
        btnnuevo.Text = "NUEVO"
        btnnuevo.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(0, 0)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(103, 24)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "CheckBox1"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' btncarro
        ' 
        btncarro.AutoSize = True
        btncarro.Location = New Point(193, 338)
        btncarro.Name = "btncarro"
        btncarro.Size = New Size(65, 24)
        btncarro.TabIndex = 8
        btncarro.Text = "carro"
        btncarro.UseVisualStyleBackColor = True
        ' 
        ' btnmoto
        ' 
        btnmoto.AutoSize = True
        btnmoto.Location = New Point(311, 338)
        btnmoto.Name = "btnmoto"
        btnmoto.Size = New Size(67, 24)
        btnmoto.TabIndex = 8
        btnmoto.Text = "moto"
        btnmoto.UseVisualStyleBackColor = True
        ' 
        ' btnbus
        ' 
        btnbus.AutoSize = True
        btnbus.Location = New Point(431, 338)
        btnbus.Name = "btnbus"
        btnbus.Size = New Size(54, 24)
        btnbus.TabIndex = 8
        btnbus.Text = "bus"
        btnbus.UseVisualStyleBackColor = True
        ' 
        ' btnotro
        ' 
        btnotro.AutoSize = True
        btnotro.Location = New Point(550, 338)
        btnotro.Name = "btnotro"
        btnotro.Size = New Size(59, 24)
        btnotro.TabIndex = 8
        btnotro.Text = "otro"
        btnotro.UseVisualStyleBackColor = True
        ' 
        ' btnguardar
        ' 
        btnguardar.Location = New Point(211, 398)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(94, 29)
        btnguardar.TabIndex = 6
        btnguardar.Text = "GUARDAR"
        btnguardar.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(311, 338)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(65, 24)
        CheckBox2.TabIndex = 8
        CheckBox2.Text = "carro"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' btnactualizar
        ' 
        btnactualizar.Location = New Point(337, 398)
        btnactualizar.Name = "btnactualizar"
        btnactualizar.Size = New Size(107, 29)
        btnactualizar.TabIndex = 6
        btnactualizar.Text = "ACTUALIZAR"
        btnactualizar.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(435, 338)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(65, 24)
        CheckBox3.TabIndex = 8
        CheckBox3.Text = "carro"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' btneliminar
        ' 
        btneliminar.Location = New Point(473, 398)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(94, 29)
        btneliminar.TabIndex = 6
        btneliminar.Text = "ELIMINAR"
        btneliminar.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(535, 338)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(65, 24)
        CheckBox4.TabIndex = 8
        CheckBox4.Text = "carro"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' btnsalir
        ' 
        btnsalir.Location = New Point(618, 398)
        btnsalir.Name = "btnsalir"
        btnsalir.Size = New Size(94, 29)
        btnsalir.TabIndex = 6
        btnsalir.Text = "SALIR"
        btnsalir.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(635, 338)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(65, 24)
        CheckBox5.TabIndex = 8
        CheckBox5.Text = "carro"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnotro)
        Controls.Add(btnbus)
        Controls.Add(btnmoto)
        Controls.Add(CheckBox5)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(btncarro)
        Controls.Add(btnsalir)
        Controls.Add(btneliminar)
        Controls.Add(btnactualizar)
        Controls.Add(btnguardar)
        Controls.Add(CheckBox1)
        Controls.Add(btnnuevo)
        Controls.Add(RadioButton1)
        Controls.Add(lblvehiculo)
        Controls.Add(lblgenero)
        Controls.Add(txtprefieronodecirlo)
        Controls.Add(txtmasculino)
        Controls.Add(txtfemenino)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(lblcorreo)
        Controls.Add(lbltelefono)
        Controls.Add(Lblapellido)
        Controls.Add(lblnombre)
        Controls.Add(lblformulario)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblformulario As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents Lblapellido As Label
    Friend WithEvents lbltelefono As Label
    Friend WithEvents lblcorreo As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents txtfemenino As RadioButton
    Friend WithEvents txtmasculino As RadioButton
    Friend WithEvents txtprefieronodecirlo As RadioButton
    Friend WithEvents lblgenero As Label
    Friend WithEvents lblvehiculo As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents btnnuevo As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btncarro As CheckBox
    Friend WithEvents btnmoto As CheckBox
    Friend WithEvents btnbus As CheckBox
    Friend WithEvents btnotro As CheckBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents btnactualizar As Button
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents btneliminar As Button
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents CheckBox5 As CheckBox

End Class
